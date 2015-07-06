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
    public partial class frmcabiarcontrasena : Form
    {
        private basedato.mysqlbasedato db;
        public frmcabiarcontrasena(basedato.mysqlbasedato cn,String nomusuario)
        {
            InitializeComponent();
            db = cn;
            this.txtuser.Text = nomusuario;
        }

        private void btnaceptar_Click(object sender, EventArgs e)
        {
            Infragistics.Win.Misc.Validation val;
            db.ejecutar("select if(usupassword=md5('" + this.txtanterior.Text + "'),'1','0') from ste_usuario where usuuser='" + this.txtuser.Text + "'");
            if (db.getvalor().ToString() == "0") {
                uv.GetValidationSettings(this.txtanterior).Condition = new Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, this.txtuser.Text + db.getvalor());
            }else{
                uv.GetValidationSettings(this.txtanterior).Condition = new Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, this.txtanterior.Text);
            }
            uv.GetValidationSettings(this.txtpass2).Condition = new Infragistics.Win.OperatorCondition(Infragistics.Win.ConditionOperator.Match, this.txtpass1.Text);
            val = uv.Validate(true, false);
            if (val.IsValid) {
                MySqlCommand cm = new MySqlCommand();
                db.begin_transaction();
                cm.Parameters.Add("@user", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = this.txtuser.Text;
                cm.Parameters.Add("@pass", MySql.Data.MySqlClient.MySqlDbType.VarChar).Value = this.txtpass1.Text;
                cm.CommandText = "update ste_usuario set usupassword=md5(@pass) where usuuser=@user";
                db.ejecutar(cm);
                db.commit_transaction();
                MessageBox.Show("El cambio de contraseña fue efectuado con éxito","Información",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}