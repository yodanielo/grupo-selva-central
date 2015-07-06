using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using basedato;

namespace gselvacentral.formularios
{
    public partial class frmlogin : Form
    {
        private mysqlbasedato db;
        private FrmPrincipal f;
        private Boolean correcto = false;
        private int intentos;
        public frmlogin(mysqlbasedato cn, FrmPrincipal ff)
        {
            InitializeComponent();
            db = cn;
            f = ff;
            f.Enabled = false;
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            db.ejecutar("select count(*) from ste_usuario where usuestado=1 and usutipo=1 and usuuser='" + this.txtuser.Text + "' and usupassword=md5('" + this.txtcontrasena.Text + "')");
            if (int.Parse(db.getvalor().ToString()) == 1)
            {
                correcto = true;
                this.f.nomusuario = this.txtuser.Text;
                this.Close();
            }
            else
            {
                intentos = intentos + 1;
                if (intentos < 3)
                {
                    MessageBox.Show("Usuario o contraseña erronea", "Sthefany Transportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    this.txtcontrasena.Text = "";
                    this.txtuser.Text = "";
                }
                else
                {
                    MessageBox.Show("Ah excedido el numero de intentos permitidos, el programa se cerrará", "Sthefany Transportes", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    Application.Exit();
                }
            }
        }

        private void btncancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void frmlogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (correcto != true)
                Application.Exit();
            else
                f.Enabled = true;
        }
    }
}