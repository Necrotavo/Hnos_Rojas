using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;
using DO;

namespace Hnos_Rojas
{
    public partial class PlantillaConfig : Form
    {
        DO_PlantillaFactura plantillaFactura;
        BL_Factura factLogica;

        public PlantillaConfig()
        {
            InitializeComponent();
            factLogica = new BL_Factura();
            fillPlantilla();
            rellenarTextos();
        }


        private void fillPlantilla()
        {
            plantillaFactura = factLogica.obtenerPlantillaFactura();
        }

        private void rellenarTextos()
        {
            txtCed.Text = plantillaFactura.cedula;
            txtDir.Text = plantillaFactura.direccion;
            txtNombre.Text = plantillaFactura.nombreEmpresa;
            txtTelef.Text = plantillaFactura.numeroTelefono;
        }

        private void actualizarPlantilla()
        {
            plantillaFactura.cedula = txtCed.Text;
            plantillaFactura.direccion = txtDir.Text;
            plantillaFactura.nombreEmpresa = txtNombre.Text;
            plantillaFactura.numeroTelefono = txtTelef.Text;
        }
        private void btnUsuariosConf_Click(object sender, EventArgs e)
        {
            actualizarPlantilla();
            factLogica.actualizarPlantillaFactura(plantillaFactura);

        }
    }
}
