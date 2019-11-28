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
            txtAyuda.Text = "ÉSTE MODULO PUEDE SER INVOCADO PRESIONADO LA TELCA F1, ES EL ENCARGADO DE TODO LO RELACIONADO CON LAS VENTAS, EXISTEN ATAJOS CON BOTONES LOS CUALES AL PRESIONARLOS INVOCAN FUNCIONALIDADES, EXISTE LA PESTAÑA LLAMADA TICKETS LA CUAL ES LA ENCARGADA DE TENER TODOS LOS PRODUCTOS QUE SE VAN REGISTRANDO CON LA TECLA F12 O PRESIONADO EL BOTÓN COBRAR Y POSTERIORMENTE EN UNA VENTANA QUE EMERGE SE INGRESAN LOS DATOS PERTINENTES PARA LUEGO GENERAR UNA FACTURA, DENTRO DE ESTE MÓDULO TAMBIÉN SE PUEDE COBRAR PERO A CRÉDITO Y EMERGE UNA VENTANA DONDE SE INGRESAN LOS DATOS PERTINENTES, SE CUENTA CON UNA FUNCIONALIDAD DE REIMPRIMIR FACTURA LO CUAL IMPRIME LA ULTIMA FACTURA QUE SE IMPRIMIÓ";
        }

        private void btnAyudaClientes_Click(object sender, EventArgs e)
        {
            txtAyuda.Text = "TEXTO AYUDA CLIENTES";
        }

        private void btnAyudaProductos_Click(object sender, EventArgs e)
        {
            txtAyuda.Text = "TEXTO AYUDA PRODUCTOS";
        }

        private void btnAyudaProveedores_Click(object sender, EventArgs e)
        {
            txtAyuda.Text = "TEXTO AYUDA PROVEEDORES";
        }

        private void btnAyudaConfiguracion_Click(object sender, EventArgs e)
        {
            txtAyuda.Text = "TEXTO AYUDA CONFIGURACIÓN";
        }

        private void btnReportes_Click(object sender, EventArgs e)
        {
            txtAyuda.Text = "TEXTO AYUDA REPORTES";
        }
    }
}
