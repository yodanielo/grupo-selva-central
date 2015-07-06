using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace gselvacentral
{
    public partial class padre : Form
    {
        protected estado_formulario estform = new estado_formulario();
        public padre()
        {
            InitializeComponent();
        }
        protected void filtrar(String campo, String valor)
        {
            if (valor != "")
            {
                if (grilla.Rows.ColumnFilters[campo].FilterConditions.Count == 0)
                {
                    Infragistics.Win.UltraWinGrid.FilterCondition a = new Infragistics.Win.UltraWinGrid.FilterCondition();
                    a.ComparisionOperator = Infragistics.Win.UltraWinGrid.FilterComparisionOperator.Contains;
                    grilla.DisplayLayout.Bands[0].ColumnFilters[campo].FilterConditions.Add(a);
                }
                grilla.DisplayLayout.Bands[0].ColumnFilters[campo].FilterConditions[0].CompareValue = valor;
            }
            else
                grilla.DisplayLayout.Bands[0].ColumnFilters[campo].FilterConditions.Clear();
        }
    }
}