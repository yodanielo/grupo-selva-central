using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using basedato;

namespace administrador
{
    public partial class frmprincipal : Form
    {
        mysqlbasedato cn = new mysqlbasedato("localhost","gselvacentral","root","");
        public frmprincipal()
        {
            InitializeComponent();
        }

        private void frmprincipal_Load(object sender, EventArgs e)
        {

        }

    }
}