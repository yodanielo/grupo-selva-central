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
    public partial class Imprimir : Form
    {
        private mysqlbasedato cn = new mysqlbasedato("localhost", "sthefanydb", "root", "");
        public Imprimir(CrystalDecisions.CrystalReports.Engine.ReportClass r)
        {
            InitializeComponent();
            this.crystalReportViewer1.ReportSource = r;
        }
    }
}