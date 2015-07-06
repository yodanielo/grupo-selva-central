using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using basedato;

namespace gselvacentral
{
    public partial class FrmPrincipal : Form
    {
        public String nomusuario;
        private mysqlbasedato cn = new mysqlbasedato("localhost", "gselvacentraldb", "root", "");
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            formularios.frmlogin a = new formularios.frmlogin(cn, this);
            a.Show();
        }
        /// <summary>
        /// persona jurídica
        /// </summary>
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            formularios.frmclientesjuridicos a = new formularios.frmclientesjuridicos(cn);
            a.Show();
            a.MdiParent = this;
        }
        /// <summary>
        /// persona natural
        /// </summary>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            formularios.frmclientesnaturales a = new formularios.frmclientesnaturales(cn);
            a.Show();
            a.MdiParent = this;
        }
        /// <summary>
        /// cambiar contraseña
        /// </summary>
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            formularios.frmcabiarcontrasena a = new formularios.frmcabiarcontrasena(cn, this.nomusuario);
            a.MdiParent = this;
            a.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            formularios.AboutBox1 a = new formularios.AboutBox1();
            a.MdiParent=this;
            a.Show();
        }

    }
}