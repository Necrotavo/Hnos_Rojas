using BL;
using DO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hnos_Rojas
{
    public partial class Reportes : Form
    {
        public Reportes()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            DateTime fechaReporte = new DateTime(calReporte.SelectionStart.Year, calReporte.SelectionStart.Month,
                calReporte.SelectionStart.Day, 0, 0, 0);
            lbFechaReporte.Text = fechaReporte.GetDateTimeFormats()[0];


        }
    }
}
