using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace gselvacentral.formularios
{
    public partial class frmclientesjuridicos : gselvacentral.padre
    {
        private basedato.mysqlbasedato db;
        private DataTable dtmaestro;
        private int id;
        public frmclientesjuridicos(basedato.mysqlbasedato cn)
        {
            InitializeComponent();
            db = cn;
            carga_datos();
            estform = estado_formulario.insertando;
        }
        private void carga_datos()
        {
            String sql = "select idste_clijuridico,jurrazonsocial,cliruc,jurrepresentante from ste_cliente inner join ste_clijuridico on ste_clijuridico.idste_clijuridico=ste_cliente.idcliente";
            db.ejecutar(sql);
            dtmaestro = db.gettabla();
            grilla.DataSource = null;
            grilla.DataSource = dtmaestro;
            grilla.DisplayLayout.Bands[0].Columns[0].Hidden = true;
            grilla.DisplayLayout.Bands[0].Columns["jurrazonsocial"].Header.Caption = "Razon Social";
            grilla.DisplayLayout.Bands[0].Columns["cliruc"].Header.Caption = "RUC";
            grilla.DisplayLayout.Bands[0].Columns["jurrepresentante"].Header.Caption = "Representante";
            foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn cc in grilla.DisplayLayout.Bands[0].Columns)
            {
                cc.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            }
        }
        private void seleccionar(Int32 r)
        {
            DataRow dr = this.dtmaestro.Select("idste_clijuridico=" + r.ToString())[0];
            this.txtrazonsocial.Text = dr["jurrazonsocial"].ToString();
            this.txtruc.Text = dr["cliruc"].ToString();
            this.txtrepresentante.Text = dr["jurrepresentante"].ToString();
            estform = estado_formulario.actualizando;
            id = r;
        }
        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.estform = estado_formulario.insertando;
            this.txtrazonsocial.Text = "";
            this.txtruc.Text = "";
            this.txtrepresentante.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            int c = grilla.Selected.Cells.Count - 1;
            String r = grilla.Selected.Cells[c].Row.Cells["idste_clijuridico"].Text;
            seleccionar(int.Parse(r));
        }
        private int guardar_registro()
        {
            Infragistics.Win.Misc.Validation val;
            val = uv.Validate(true, false);
            if (val.IsValid == true)
            {
                //insertar en clientes
                MySqlCommand cb1 = new MySqlCommand();
                cb1.Parameters.Add("@clitipo", MySqlDbType.Int16).Value = 1; //0=>natural
                cb1.Parameters.Add("@cliruc", MySqlDbType.VarChar).Value = this.txtruc.Text;
                cb1.Parameters.Add("@razsocial", MySqlDbType.VarChar).Value = this.txtrazonsocial.Text;
                cb1.Parameters.Add("@representante", MySqlDbType.VarChar).Value = this.txtrepresentante.Text;
                db.ejecutar("select valor+1 from incremento where criterio='cliente'");
                String lid;
                if (estform == estado_formulario.insertando)
                {
                    //incremento
                    db.ejecutar("update incremento set valor=valor+1 where criterio='cliente'");
                    //inserto
                    cb1.CommandText = "insert into ste_cliente values(null,@clitipo,@cliruc)";
                    db.ejecutar(cb1);
                    //ultimo id
                    db.ejecutar("select valor from incremento where criterio = 'cliente'");
                    lid = db.getvalor().ToString();
                    //generalizacion
                    cb1.Parameters.Add("@id", MySqlDbType.Int16).Value = lid;
                    cb1.CommandText = "insert into ste_clijuridico values (@id,@representante,@razsocial)";
                    db.ejecutar(cb1);
                }
                else
                {
                    lid = id.ToString();
                    cb1.Parameters.Add("@id", MySqlDbType.Int16).Value = lid;
                    cb1.CommandText = "update ste_cliente set cliruc=@cliruc where idcliente=@id";
                    db.ejecutar(cb1);
                    cb1.CommandText = "update ste_clijuridico set jurrepresentante=@representante, jurrazonsocial=@razsocial where idste_clijuridico=@id";
                    db.ejecutar(cb1);
                }
                
                btnnuevo_Click(null, null);
                carga_datos();
                return int.Parse(lid);
            }
            else
                return 0;
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            guardar_registro();
        }

        private void btnhacercomprobante_Click(object sender, EventArgs e)
        {
            String remitente = this.txtrazonsocial.Text;
            String ruc = this.txtruc.Text;
            int lid = guardar_registro();
            if (lid != 0)
            {
                frmcomprobante a = new frmcomprobante(lid, remitente, ruc, db);
                a.ShowDialog();
            }
        }

        private void grilla_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            if (grilla.Selected.Cells.Count > 0)
            {
                int c = grilla.Selected.Cells.Count - 1;
                String r = grilla.Selected.Cells[c].Row.Cells["idste_clijuridico"].Text;
                seleccionar(int.Parse(r));
            }
        }

        private void filtrar_changed(object sender, EventArgs e)
        {
            this.filtrar(((TextBox)sender).Tag.ToString(), ((TextBox)sender).Text);
        }
    }
}

