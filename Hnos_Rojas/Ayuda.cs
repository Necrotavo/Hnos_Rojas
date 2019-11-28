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
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n" +
                "En este módulo se ingresan productos a las posibles facturas de los clientes. Se imprimen facturas y se pueden" +
                " ejecutar los multiples accesos directos del sistema\r\nPara cambiar de usuario en este módulo es necesario ingresar primero la " +
                "contraseña correspondiente y luego seleccionar el usuario";
            txtAyuda2.Text = "ACEESOS RÁPIDOS: \r\n\r\nEste módulo se puede abrir presionando la tecla F1" +
                "\r\n***CTRL + P abre la ventana de buscar producto" +
                "\r\n***F12 realiza el pago e imprime la factura" +
                "\r\n***INSERT Abre la ventana de insertar producto" +
                "\r\n***F10 Abre la ventana de pago a proveedores";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n" +
                "***Insertar producto: Permite insertar un producto al inventario sin tener que acceder al modulo de productos" +
                "\r\n***Articulo común: Permite buscar productos e ingresarlos al ticket con la posibilidad de ajustar su precio de venta" +
                "\r\n***Pagos: Permite realizar pagos a los proveedores" +
                "\r\n***Cobro: Según el tipo de cobro (Contado o crédito) muestra ventanas donde se ve el resumen de la compra y permine pagar e imprimir las facturas correspondientes";
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
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n" +
                "Este módulo muestra la información contable útil en los reportes de contado y crédito." +
                "\r\n" +
                "Aquí el usuario puede seleccionar dos fechas, depués hacer clic en el boton  \"FILTRAR\" y" +
                " el sistema mostrará los datos contables desde la primer fecha seleccionada hasta la" +
                "segunda, en caso de necesitar un reporte diario se debe seleccionar la misma fecha en ambos calendarios." +
                "\r\nEs posible imprimir estos reportes, en la impresora por defecto del sistema, mediante le boton \"IMPRIMIR\"" +
                "";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\n" +
                "Para acceder este modulo oprima la tecla F6";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n" +
                "Este modulo no tiene ventanas emergentes";
        }
    }
}
