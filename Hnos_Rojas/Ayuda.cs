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
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL:";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: ";
            txtAyuda3.Text = "VENTANAS EMERGENTES: ";
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
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n En este módulo se muestra la lista con todos los clientes registrados activos." +
              "Presenta dos botones. \"Estado de Cuenta\" y \"Nuevo/Modificar\"";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\nEste módulo no tiene accesos rápidos";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n  ****Estado de Cuenta: Muestra el estado de cuenta del cliente seleccionado con sus respectivas facturas." +
                "Aquí se puede abonar a cada factura su saldo correspondiente o imprimir determinadas facturas" +
                "\r\n  ****Nuevo/Modificar: Presenta dos pestañas \"Agregar\" y \"Modificar\"" +
                "\r\n    *****Agregar: Muestra los campos para agregar un nuevo cliente."+
                "\r\n    *****Modificar: Muestra todos los clientes. Al presionar el botón \"Editar\" el sistema se redirecciona a una ventana para modificar los respectivos datos. ";
        }

        private void btnAyudaProductos_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n En este módulo se puede visualizar la lista con todos los  productos "+
                "registrados. Aquí se pueden buscar los productos por código. También presenta la opción de agregar nuevos productos o modificar existentes.";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\nEste módulo no tiene accesos rápidos";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n ***Nuevo/Modificar: Muestra una nueva ventana la cual permite modificar o agregar los productos \r\n"+
                "\r\n  ****Formulario: Muestra los campos para agregar los datos de un nuevo producto.\r\n"+
                "\r\n  ****Modificar producto: Muestra la lista de productos. Al presionar el botón Modificar el programa se redirecciona al Formulario para editar"+
                "el producto. Es posible buscar el producto por código o descripción.";
        }

        private void btnAyudaProveedores_Click(object sender, EventArgs e)
        {
            txtAyuda1.Text = "DESCRIPCIÓN GENERAL: \r\n\r\n En este módulo se pueden realizar distintas acciones relacionadas con los proveedores."+
                "Se incluye el Agregar, visualizar el horario, modificar o eliminar. Además se pueden agregar los respectivos asociados.";
            txtAyuda2.Text = "ACCESOS RÁPIDOS: \r\n\r\nEste módulo no tiene accesos rápidos";
            txtAyuda3.Text = "VENTANAS EMERGENTES: \r\n\r\n ***Ver Asociados: se pueden realizar todas las operaciones relacionadas con Asociados. Se incluye Agregar, Editar o Eliminar"+
                "\r\n\r\n ***Insertar: Se agregan los datos del proveedor, incluyendo sus días de visita."+
                "\r\n\r\n ***Horario: Muestra el calendario semanal con la visita de los Proveedores."+
                "\r\n\r\n ***Modificar: Presenta la opción de modificar los días de visita del Proveedor."+
                "\r\n\r\n ***Eliminar Proveedor: permite eliminar un respectivo Proveedor.";
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
