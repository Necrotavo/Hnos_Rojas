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
    public partial class DetallesEstadoCuenta : Form
    {
        private DO_Cliente cliente;
        public DetallesEstadoCuenta(DO_Cliente _cliente)
        {
            InitializeComponent();
            cliente = _cliente;
            obtenerCredito();
        }

        public void obtenerCredito() {
            BL_Credito blCredito = new BL_Credito();
            cliente.credito = blCredito.ObtenerCredito(cliente.id);

            DataTable tablaFacturas = new DataTable();
            tablaFacturas.Columns.Add("Cod. Factura");
            tablaFacturas.Columns.Add("Fecha");
            tablaFacturas.Columns.Add("Usuario");
            tablaFacturas.Columns.Add("Cliente");
            tablaFacturas.Columns.Add("Estado");
            tablaFacturas.Columns.Add("Monto");
            tablaFacturas.Columns.Add("Saldo");

            foreach (DO_Factura doFactura in cliente.credito.listaFactura) {
                tablaFacturas.Rows.Add(doFactura.codigoFactura, doFactura.fecha, doFactura.usuario,
                    cliente.nombre + " " + cliente.primerApellido + " " + cliente.segundoApellido,
                    doFactura.estado, doFactura.totalFactura, doFactura.saldo);
            }

            grdFacturas.DataSource = tablaFacturas;

            grdFacturas.Columns[0].Width = 100;    //codigo
            grdFacturas.Columns[1].Width = 150;    //Fecha
            grdFacturas.Columns[2].Width = 70;    //Usuario
            grdFacturas.Columns[3].Width = 200;    //Cliente
            grdFacturas.Columns[4].Width = 70;    //Estado
            grdFacturas.Columns[5].Width = 70;    //Saldo
            grdFacturas.Columns[5].Width = 70;    //Monto
        }
    }
}
