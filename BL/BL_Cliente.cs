﻿using System;
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

        public List<DO_Cliente> obtenerListaClientesHabilitados(bool clientesHabilitados, String nombre) {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.obtenerListaClientesHabilitados(clientesHabilitados, nombre);
        }

        public DO_Cliente buscarCliente(String nombre) {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.buscarCliente(nombre);
        }
        public List<DO_Cliente> buscarClientes(String datos)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.buscarClientes(datos);
        }
        public DO_Cliente buscarCliente(int idCliente)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.buscarCliente(idCliente);
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

        public bool modificarCliente(DO_Cliente cliente)
        {
            DAO_Cliente daoCliente = new DAO_Cliente();
            return daoCliente.modificarCliente(cliente);
        }

        public List<DO_Cliente> filtrarClientes(String filtro)
        {
            DAO_Cliente dao_cliente = new DAO_Cliente();
            return dao_cliente.filtrarClientes(filtro);
        }
    }
}
