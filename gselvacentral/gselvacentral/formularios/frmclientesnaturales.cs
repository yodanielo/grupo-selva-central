using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using basedato;
using MySql.Data.MySqlClient;

namespace gselvacentral.formularios
{
    public partial class frmclientesnaturales : gselvacentral.padre
    {
        private mysqlbasedato db;
        private DataTable dtmaestro;
        private int id;
        public frmclientesnaturales(mysqlbasedato cn)
        {
            InitializeComponent();
            this.db = cn;
            this.carga_datos();
            this.estform = estado_formulario.insertando;
        }
        public void carga_datos()
        {
            String sql = "select idclinatural,natnombres,natapellidos,natdni,cliruc from ste_cliente inner join ste_clinatural on ste_clinatural.idclinatural=ste_cliente.idcliente";
            this.db.ejecutar(sql);
            dtmaestro = db.gettabla();
            grilla.DataSource = null;
            grilla.DataSource = dtmaestro;
            grilla.DisplayLayout.Bands[0].Columns[0].Hidden = true;
            grilla.DisplayLayout.Bands[0].Columns["natnombres"].Header.Caption = "Nombres";
            grilla.DisplayLayout.Bands[0].Columns["natapellidos"].Header.Caption = "Apellidos";
            grilla.DisplayLayout.Bands[0].Columns["natdni"].Header.Caption = "DNI";
            grilla.DisplayLayout.Bands[0].Columns["cliruc"].Header.Caption = "RUC";
            foreach (Infragistics.Win.UltraWinGrid.UltraGridColumn cc in grilla.DisplayLayout.Bands[0].Columns)
            {
                cc.CellActivation = Infragistics.Win.UltraWinGrid.Activation.NoEdit;
            }
        }
        private void seleccionar(Int32 r)
        {
            DataRow dr = this.dtmaestro.Select("idclinatural=" + r.ToString())[0];
            this.txtnombres.Text = dr["natnombres"].ToString();
            this.txtapellidos.Text = dr["natapellidos"].ToString();
            this.txtdni.Text = dr["natdni"].ToString();
            this.txtruc.Text = dr["cliruc"].ToString();
            this.estform = estado_formulario.actualizando;
            this.id = r;
        }

        private void grilla_AfterSelectChange(object sender, Infragistics.Win.UltraWinGrid.AfterSelectChangeEventArgs e)
        {
            if (grilla.Selected.Cells.Count > 0)
            {
                int c = grilla.Selected.Cells.Count - 1;
                String r = grilla.Selected.Cells[c].Row.Cells["idclinatural"].Text;
                this.seleccionar(int.Parse(r));
            }
        }

        private void btnnuevo_Click(object sender, EventArgs e)
        {
            this.estform = estado_formulario.insertando;
            this.txtapellidos.Text = "";
            this.txtdni.Text = "";
            this.txtnombres.Text = "";
            this.txtruc.Text = "";
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            int c = grilla.Selected.Cells.Count - 1;
            String r = grilla.Selected.Cells[c].Row.Cells["idclinatural"].Text;
            seleccionar(int.Parse(r));
        }

        public int guardar_registro()
        {
            Infragistics.Win.Misc.Validation val;
            val = uv.Validate(true, false);
            if (val.IsValid == true)
            {
                //insertar en clientes
                MySqlCommand cb1 = new MySqlCommand();
                cb1.Parameters.Add("@clitipo", MySqlDbType.Int16).Value = 0; //'0=>natural
                cb1.Parameters.Add("@cliruc", MySqlDbType.VarChar).Value = this.txtruc.Text;
                cb1.Parameters.Add("@natnombres", MySqlDbType.VarChar).Value = this.txtnombres.Text;
                cb1.Parameters.Add("@natapellidos", MySqlDbType.VarChar).Value = this.txtapellidos.Text;
                cb1.Parameters.Add("@natdni", MySqlDbType.VarChar).Value = this.txtdni.Text;

                String lid;
                if (estform == estado_formulario.insertando)
                {
                    cb1.CommandText = "insert into ste_cliente values(null,@clitipo,@cliruc)";
                    db.ejecutar("update incremento set valor=valor+1 where criterio='cliente'");
                    db.ejecutar("select valor+1 from incremento where criterio='cliente'");
                    lid = db.getvalor().ToString();
                    db.ejecutar(cb1);
                    cb1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lid;
                    cb1.CommandText = "insert into ste_clinatural values(@id,@natnombres,@natapellidos,@natdni)";
                    db.ejecutar(cb1);
                }
                else
                {
                    cb1.CommandText = "update ste_cliente set cliruc=@cliruc where idcliente=" + id.ToString();
                    db.ejecutar(cb1);
                    lid = id.ToString();
                    cb1.Parameters.Add("@id", MySqlDbType.VarChar).Value = lid;
                    cb1.CommandText = "update ste_clinatural set natnombres=@natnombres,natapellidos=@natapellidos, natdni=@natdni where idclinatural=" + id;
                    db.ejecutar(cb1);
                }
                
                btnnuevo_Click(null, null);
                carga_datos();
                return int.Parse(lid);
            }
            else
            {
                return 0;
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            this.guardar_registro();
        }

        private void btncomprobante_Click(object sender, EventArgs e)
        {
            //para crear un nuevo comprobante
            String remitente = this.txtnombres.Text + " " + this.txtapellidos.Text;
            String ruc = txtruc.Text;
            int lid = guardar_registro();
            if (lid != 0)
            {
                frmcomprobante a = new frmcomprobante(lid, remitente, ruc, this.db);
                a.ShowDialog();
            }
        }
        private void filtrar_changed(object sender, EventArgs e)
        {
            this.filtrar(((TextBox)sender).Tag.ToString(), ((TextBox)sender).Text);
        }

    }
}

