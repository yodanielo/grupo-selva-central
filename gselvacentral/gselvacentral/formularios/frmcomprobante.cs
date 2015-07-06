using basedato;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.Shared;

namespace gselvacentral.formularios
{
    public partial class frmcomprobante : Form
    {
        public int midcliente;
        public String idenvio;
        private mysqlbasedato db;
        private estado_formulario estgrid = estado_formulario.insertando;
        public frmcomprobante(int idcliente, String nomremitente, String rucremitente, mysqlbasedato cn)
        {
            //éste formulario es solo para nuevos comprobantes...si me pide pa modificar soy hombre muerto :-S
            db = cn;
            InitializeComponent();
            txtnomremitente.Text = nomremitente;
            txtrucremitente.Text = rucremitente;
            midcliente = idcliente;
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgvdetalle_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int ri = e.RowIndex;
            grdcodigo.Text = dgvdetalle.Rows[ri].Cells["dencodigo"].Value.ToString();
            grdcantidad.Text = dgvdetalle.Rows[ri].Cells["dencantidad"].Value.ToString();
            grddescripcion.Text = dgvdetalle.Rows[ri].Cells["dendescripcion"].Value.ToString();
            grdumedida.Text = dgvdetalle.Rows[ri].Cells["umedida"].Value.ToString();
            grdpunitario.Text = dgvdetalle.Rows[ri].Cells["denpreciounitario"].Value.ToString();
            estgrid = estado_formulario.actualizando;
        }

        private void btnguardar_Click(object sender, EventArgs e)
        {
            String sqlcriterio = "update incremento set valor=valor+1 where criterio='comprobante'";
            String sqlcriterioprin = "select valor+1 from incremento where criterio='comprobante'";
            db.ejecutar(sqlcriterioprin);
            this.idenvio = db.getvalor().ToString();

            Infragistics.Win.Misc.Validation val;
            val = uv.Validate(true, false);
            if (val.IsValid == true && dgvdetalle.Rows.Count > 0)
            {
                switch (this.cmbtipcomprobante.SelectedIndex)
                {
                    case 0:
                        db.ejecutar("select valor+1 from incremento where criterio='boleta'");
                        sqlcriterio = "update incremento set valor=valor+1 where criterio='comprobante'";
                        break;
                    case 1:
                        db.ejecutar("select valor+1 from incremento where criterio='factura'");
                        sqlcriterio = "update incremento set valor=valor+1 where criterio='comprobante'";
                        break;
                    case 2:
                        db.ejecutar("select valor+1 from incremento where criterio='orden'");
                        sqlcriterio = "update incremento set valor=valor+1 where criterio='comprobante'";
                        break;
                }
                //cojo el id del comprobante sea boleta o factura
                String tc = db.getvalor().ToString();
                //cojo el numero de serie, ya no importa :-/
                db.ejecutar("select idserie,sernumero from ste_serie where sertipo=" + cmbtipcomprobante.SelectedIndex + " and " + tc + " between servalmin and servalmax");
                DataTable ts = db.gettabla();
                if (ts.Rows.Count > 0 || 1==1)
                {
                    //inicio la transaccion
                    db.begin_transaction();
                    MySqlCommand cm = new MySqlCommand();
                    cm.Parameters.Add("@idenvio", MySqlDbType.Int16).Value = this.idenvio;
                    cm.Parameters.Add("@idcliente", MySqlDbType.Int64).Value = midcliente;
                    cm.Parameters.Add("@dir_origen", MySqlDbType.VarChar).Value = txtdirremitente.Text;
                    cm.Parameters.Add("@dir_destino", MySqlDbType.VarChar).Value = txtdirdestinatario.Text;
                    cm.Parameters.Add("@destinatario", MySqlDbType.VarChar).Value = txtnomdestinatario.Text;
                    cm.Parameters.Add("@idserie", MySqlDbType.Int16).Value = 1;
                    cm.Parameters.Add("@numcomprobante", MySqlDbType.Int64).Value = 1;
                    cm.Parameters.Add("@tipcomprobante", MySqlDbType.Int16).Value = cmbtipcomprobante.SelectedIndex;
                    cm.Parameters.Add("@rucdestinatario", MySqlDbType.VarChar).Value = this.txtrucdestinatario.Text;
                    cm.Parameters.Add("@idunidad", MySqlDbType.Int16).Value = this.cbunidad.SelectedValue;
                    cm.Parameters.Add("@gremision", MySqlDbType.VarChar).Value = this.txtremision.Text;
                    cm.CommandText = "insert into ste_envio values(null,@idcliente,curdate(),@dir_origen,@dir_destino,@destinatario,@rucdestinatario,@idserie,@numcomprobante,@tipcomprobante,@idunidad,@gremision)";
                    //inserti la cabecera
                    db.ejecutar(cm);
                    //incremento el indice segun el tipo de comprobante
                    //db.ejecutar("select max(idenvio) from ste_envio");
                    //this.idenvio = db.getvalor().ToString();
                    //incremento el indice del comprobante en general
                    db.ejecutar(sqlcriterio);
                    //inserto el detalle
                    foreach (DataGridViewRow r in dgvdetalle.Rows)
                    {
                        MySqlCommand cm1 = new MySqlCommand();
                        cm1.Parameters.Add("@idenvio", MySqlDbType.Int16).Value = idenvio;
                        cm1.Parameters.Add("@codigo", MySqlDbType.VarChar).Value = r.Cells["dencodigo"].Value;
                        cm1.Parameters.Add("@cantidad", MySqlDbType.VarChar).Value = r.Cells["dencantidad"].Value;
                        cm1.Parameters.Add("@descripcion", MySqlDbType.VarChar).Value = r.Cells["dendescripcion"].Value;
                        cm1.Parameters.Add("@peso", MySqlDbType.VarChar).Value = r.Cells["peso"].Value;
                        cm1.Parameters.Add("@umedida", MySqlDbType.VarChar).Value = r.Cells["umedida"].Value;
                        cm1.Parameters.Add("@punitario", MySqlDbType.VarChar).Value = r.Cells["denpreciounitario"].Value;
                        cm1.Parameters.Add("@tipo", MySqlDbType.Int16).Value = cmbtipcomprobante.SelectedIndex;
                        cm1.Parameters.Add("@resta", MySqlDbType.Int16).Value = r.Cells["dencantidad"].Value;
                        cm1.CommandText = "insert into ste_detalleenvio values(null,@idenvio,@codigo,@descripcion,@cantidad,@punitario,@tipo,@resta,@umedida,@peso)";
                        db.ejecutar(cm1);
                    }
                    db.commit_transaction();
                    hacer_report(this.idenvio);
                    this.Close();
                }
                
            }
    

        }
        public void hacer_report(String idcomprobante)
        {
            ParameterDiscreteValue parametro=new ParameterDiscreteValue();
            ParameterFields paramlist = new ParameterFields();

            DataSet ds = new DataSet("comprobante");
            db.ejecutar("select envnumcomprobante,envfecha_registro,if(clitipo=0,(select concat(natnombres,' ',natapellidos) from ste_clinatural where idclinatural=idcliente),(select jurrazonsocial from ste_clijuridico where idste_clijuridico=idcliente)) as nomcliente, cliruc, envdestinatario, envrucdestinatario, envdireccion_destino,envdireccion_origen,'" + this.txtrucremitente.Text + "' as rucremitente, ste_envio.gremision from ste_envio inner join ste_cliente on ste_envio.envidcliente=ste_cliente.idcliente where idenvio=" + idcomprobante);
            ds.Tables.Add(db.gettabla());
            db.ejecutar("select * from ste_detalleenvio where denidenvio=" + idcomprobante);
            ds.Tables.Add(db.gettabla());
            db.ejecutar("select * from ste_camionero inner join ste_unidad on ste_unidad.uniidcamionero=ste_camionero.idcamionero where ste_unidad.idunidad=" + this.cbunidad.SelectedIndex);
            ds.Tables.Add(db.gettabla());
            ds.WriteXmlSchema("./comprobante.xml");
            CrystalDecisions.CrystalReports.Engine.ReportClass rpt;
            switch (cmbtipcomprobante.SelectedIndex)
            {
                case 0://boleta
                    rpt = new reportes.boletadeventa();
                    break;
                case 1://factura
                    rpt = new reportes.factura();
                    double subt=0;
                    foreach (DataRow r in ds.Tables[1].Rows) {
                        subt +=Double.Parse(r["dencantidad"].ToString()) * Double.Parse(r["denpreciounitario"].ToString());
                        //subt += ((Double)r["dencantidad"]) * ((Double)r["denpreciounitario"]);
                    }
                    parametro.Value = aletras(subt.ToString(),true);
                    paramlist.Add("enletras", ParameterValueKind.StringParameter, DiscreteOrRangeKind.DiscreteValue).CurrentValues.Add(parametro);
                    break;
                default://orden de despacho
                    rpt = new reportes.ordendedespacho();
                    break;
            }
            rpt.SetDataSource(ds);
            //FACTURA
            formularios.Imprimir frmr = new formularios.Imprimir(rpt);
            frmr.crystalReportViewer1.ParameterFieldInfo = paramlist;
            frmr.ShowDialog(this);
            //GUIA DE REMISION
            if (cmbtipcomprobante.SelectedIndex==1)
            {
                rpt = new reportes.guiaderemision();
                rpt.SetDataSource(ds);
                frmr = new formularios.Imprimir(rpt);
                //frmr.crystalReportViewer1.ParameterFieldInfo = paramlist;
                frmr.ShowDialog(this);
            }
        }
        //actualizar
        private void button5_Click(object sender, EventArgs e)
        {
            Infragistics.Win.Misc.Validation val;
            val = uv2.Validate(true, false);
            if (val.IsValid == true)
            {
                if (estgrid == estado_formulario.insertando)
                {
                    dgvdetalle.Rows.Add(this.grdcodigo.Text, this.grddescripcion.Text, this.grdcantidad.Text, this.grdpeso.Text, this.grdumedida.Text,this.grdpunitario.Text, (Double.Parse(this.grdpunitario.Text) * Double.Parse(this.grdcantidad.Text)));
                    grdcantidad.Text = "";
                    grdcodigo.Text = "";
                    grddescripcion.Text = "";
                    grdumedida.Text = "";
                    grdpunitario.Text = "";
                    grdpeso.Text = "";
                    estgrid = estado_formulario.insertando;
                }
                else
                {
                    if (dgvdetalle.SelectedRows.Count > 0)
                    {
                        dgvdetalle.SelectedRows[0].Cells["dencodigo"].Value = grdcodigo.Text;
                        dgvdetalle.SelectedRows[0].Cells["dencantidad"].Value = grdcantidad.Text;
                        dgvdetalle.SelectedRows[0].Cells["dendescripcion"].Value = grddescripcion.Text;
                        dgvdetalle.SelectedRows[0].Cells["peso"].Value = grdpeso.Text;
                        dgvdetalle.SelectedRows[0].Cells["umedida"].Value = grdumedida.Text;
                        dgvdetalle.SelectedRows[0].Cells["denpreciounitario"].Value = grdumedida.Text;
                        dgvdetalle.SelectedRows[0].Cells["denimporte"].Value = Double.Parse(this.grdumedida.Text) * Double.Parse(this.grdcantidad.Text);
                        grdcantidad.Text = "";
                        grdcodigo.Text = "";
                        grddescripcion.Text = "";
                        grdumedida.Text = "";
                        estgrid = estado_formulario.insertando;
                    }
                }
            }
        }

        private void frmcomprobante_Load(object sender, EventArgs e)
        {
            DataTable dt;
            db.ejecutar("select idunidad,concat(a.uniplaca,' - ',b.camnombres,' ',b.camapellidos) as unidad from ste_unidad a inner join ste_camionero b on a.uniidcamionero=b.idcamionero");
            dt = db.gettabla();
            this.cbunidad.DataSource = dt;
            this.cbunidad.DisplayMember = "unidad";
            this.cbunidad.ValueMember = "idunidad";
        }
        protected String aletras(String numero, Boolean ajuste)
        {
            //separo enteros de decimales
            String[] numsep;
            String ent = "";
            String dec = "";
            String conv = "";
            Boolean correccion = false;
            if (numero.Length == 1)
                correccion = true;
            numsep = numero.Split(new char[] { '.' });
            ent = numsep[0];
            if (numsep.Length > 1)
                dec = numsep[1];
            else
                dec = "00";
            //doy formato a decimales
            dec = dec + "0";
            dec = dec.Substring(0, 2);
            do
            {
                Int64 evaluar;
                if (Int64.Parse(ent) >= 0 && Int64.Parse(ent) <= 15)
                {
                    evaluar = Int64.Parse(ent);
                    ent = "";
                }
                else
                {
                    evaluar = Int64.Parse(ent.Substring(0, 1)) * Int64.Parse((Math.Pow(10, ent.Length - 1)).ToString());
                    try
                    {
                        ent = ent.Substring(1);
                    }
                    catch (Exception ex)
                    {
                        ent = "";
                    }
                }
                switch (evaluar)
                {
                    case 1:
                        conv += " y uno";
                        break;
                    case 2:
                        conv += " y dos";
                        break;
                    case 3:
                        conv += " y tres";
                        break;
                    case 4:
                        conv += " y cuatro";
                        break;
                    case 5:
                        conv += " y cinco";
                        break;
                    case 6:
                        conv += " y seis";
                        break;
                    case 7:
                        conv += " y siete";
                        break;
                    case 8:
                        conv += " y ocho";
                        break;
                    case 9:
                        conv += " y nueve";
                        break;
                    case 10:
                        conv += " diez";
                        break;
                    case 11:
                        conv += " once";
                        break;
                    case 12:
                        conv += " doce";
                        break;
                    case 13:
                        conv += " trece";
                        break;
                    case 14:
                        conv += " catorce";
                        break;
                    case 15:
                        conv += " quince";
                        break;
                    case 20:
                        conv += " veinte";
                        break;
                    case 30:
                        conv += " treinta";
                        break;
                    case 40:
                        conv += " cuarenta";
                        break;
                    case 50:
                        conv += " cincuenta";
                        break;
                    case 60:
                        conv += " sesenta";
                        break;
                    case 70:
                        conv += " setenta";
                        break;
                    case 80:
                        conv += " ochenta";
                        break;
                    case 90:
                        conv += " noventa";
                        break;
                    case 100:
                        if (ent == "00")
                            conv += " cien";
                        else
                            conv += " ciento";
                        break;
                    case 200:
                        conv += " docientos";
                        break;
                    case 300:
                        conv += " trescientos";
                        break;
                    case 400:
                        conv += " cuatrocientos";
                        break;
                    case 500:
                        conv += " quinientos";
                        break;
                    case 600:
                        conv += " seiscientos";
                        break;
                    case 700:
                        conv += " setecientos";
                        break;
                    case 800:
                        conv += " ochocientos";
                        break;
                    case 900:
                        conv += " novecientos";
                        break;
                    default:
                        if (evaluar > 1000 && evaluar <= 900000)
                        {
                            Int64 ev = evaluar / 1000;
                            conv += aletras(ev.ToString(), false) + " mil";
                        }
                        if (evaluar == 1000)
                        {
                            conv += " mil";
                        }
                        break;
                }
            }
            while (ent != "");
            if (correccion)
                conv = conv.Replace(" y ", "");
            if (ajuste)
                return conv + " y " + dec + "/100 Nuevos Soles";
            else
                return conv;
        }

    }
}