using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAO;
using DO;

namespace BL
{
    public class BL_Cliente
    {
        private DO_Cliente cliente;

        public BL_Cliente(DO_Cliente _cliente)
        {
            this.cliente = _cliente;
        }

        public BL_Cliente()
        {
            cliente = new DO_Cliente();
        }

        public List<DO_Cliente> obtenerListaClientes() {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.obtenerListaClientes();
        }

        public DO_Cliente buscarCliente(String nombre) {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.buscarCliente(nombre);
        }

        public bool modificarEstadoCliente(int idCliente, String estado)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.modificarEstadoCliente(idCliente, estado);
        }

        public bool registrarClienteCrediticio(DO_Cliente cliente) {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.registrarClienteCrediticio(cliente);
        }
    }
}
