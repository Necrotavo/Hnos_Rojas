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
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n Este módulo es el encargado de todo lo relacionado con las ventas que se realizan a todos los consumidores, lo primero que se nota en este modulo es un panel blanco el cual cuenta con tickets, cuando se ingresa un codigo de un producto y se preciona la tecla ENTER el producto el cual tenga ese código aparecera en el panel de tickets con su información, al finalizar todo lo relacionado con la venta de productos se cobra al cliente y se le entrega una factura la cual contiene información de los productos que compró y el total de la compra";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\n Este módulo puede ser accedido presionando el botón de ventas o también presionando la tecla F1, dentro del módulo también existen accesos rápidos, el F12 es el encargado de cobrar al cliente el monto de los productos que va a adquirir";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n Este módulo posee ventanas, cuando se va a cobrar existen 2 opciones, de CONTADO y CRÉDITO, cada opción genera una ventana diferente, en CONTADO en la ventana se puede poner el nombre del cliente, alguna nota si se desea y la cantidad con la cual pagó, en CRÉDITO se tiene que seleccionar el cliente al cual desea sumarle al crédito la cantidad de los productos que va a adquirir";
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
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }
    }
}
