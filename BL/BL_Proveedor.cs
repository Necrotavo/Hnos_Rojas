using DAO;
using DO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class BL_Proveedor
    {
        public bool ingresarProveedor(DO_Proveedor proveedor) {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.ingresarProveedor(proveedor);
        }

        public bool modificarProveedor(DO_Proveedor proveedor)
        {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.modificarProveedor(proveedor);
        }

        public DO_Proveedor obtenerProveedor(String nombreProveedor)
        {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.obtenerProveedor(nombreProveedor);
        }

        public bool pagarProveedor(DO_Pago pago)
        {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.pagarProveedor(pago);
        }

        public List<DO_Proveedor> obtenerListaProveedores(String filtro, bool todos) {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.obtenerListaProveedores(filtro, todos);
        }

        public bool eliminarProveedor(String nombre) {
            DAO_Proveedor daoProveedor = new DAO_Proveedor();
            return daoProveedor.EliminarProveedor(nombre);
        }

        public List<DO_ProveedorParaHorario> dividirHorario() {
            List<DO_Proveedor> listaProveedores = obtenerListaProveedores( "", false);
            List<DO_ProveedorParaHorario> elementosDelHorario = new List<DO_ProveedorParaHorario>();
            

            foreach (DO_Proveedor doProveedor in listaProveedores) {
                DO_ProveedorParaHorario doProveedorParaHorario = new DO_ProveedorParaHorario();
                doProveedorParaHorario.nombre = doProveedor.nombre;

                String[] listaDiaYhoraJuntos = doProveedor.fechaVisita.Split(',');

                foreach (String diaYhora in listaDiaYhoraJuntos) {
                    String[] listaDiaYHoraSeparados = diaYhora.Split('-');

                    doProveedorParaHorario.listaDiaYhora.Add(listaDiaYHoraSeparados[0]); //Se supone que sera una letra segun el dia
                    doProveedorParaHorario.listaDiaYhora.Add(listaDiaYHoraSeparados[1]); //Se supone que va a ser la hora del dia
                }
                elementosDelHorario.Add(doProveedorParaHorario); //Los indices pares son dias,  los impares son horas, el ultimo es el proveedor
            }

            return elementosDelHorario;
        }
    }
}
