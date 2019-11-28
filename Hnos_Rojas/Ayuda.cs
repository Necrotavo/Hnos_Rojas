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
    public partial class Ayuda : Form
    {
        public Ayuda()
        {
            InitializeComponent();
        }

        private void btnAyudaVentas_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnAyudaClientes_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnAyudaProductos_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnAyudaProveedores_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnAyudaConfiguracion_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n" +
                "Este módulo muestra la información contable útil en los reportes de contado y crédito." +
                "\r\n" +
                "Aquí el usuario puede seleccionar dos fechas, depués hacer clic en el boton  \"FILTRAR\" y" +
                " el sistema mostrará los datos contables desde la primer fecha seleccionada hasta la" +
                "segunda, en caso de necesitar un reporte diario se debe seleccionar la misma fecha en ambos calendarios." +
                "\r\nEs posible imprimir estos reportes, en la impresora por defecto del sistema, mediante le boton \"IMPRIMIR\"" +
                "";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n" +
                "Para acceder este modulo oprima la tecla F6";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n" +
                "Este modulo no tiene ventanas emergentes";
        }
    }
}
