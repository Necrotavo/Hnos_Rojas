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
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\n Este módulo puede ser accedido presionando el botón de ventas o también presionando la tecla F1, dentro del módulo también existen accesos rápidos, el F12 es el encargado de cobrar al cliente el monto de los productos que va a adquirir";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n Este módulo posee ventanas, cuando se va a cobrar existen 2 opciones, de CONTADO y CRÉDITO, cada opción genera una ventana diferente, en CONTADO en la ventana se puede poner el nombre del cliente, alguna nota si se desea y la cantidad con la cual pagó, en CRÉDITO se tiene que seleccionar el cliente al cual desea sumarle al crédito la cantidad de los productos que va a adquirir";
        }

        private void btnAyudaClientes_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnAyudaProductos_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnAyudaProveedores_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n escritura";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\n escritura";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n escritura";
        }

        private void btnAyudaConfiguracion_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n Este módulo se encarga de brindar la capacidad de configurar la plantilla" +
            "de la factura que se va a imprimir al hacer clic en el botón \"PLANILLA FACTURAS\", del mismo modo al hacer clic en el botón " + 
            "\"USUARIOS\" se podrá configurar los usuarios del sistema, también cuanta con la opción de ayuda la cual provee" +
            "a los usuarios del sistema una descripción de los módulos de la aplicación";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\n Este módulo no tiene accesos rápidos";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n Este módulo no tiene ventanas emergentes";
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
