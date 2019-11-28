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
    public partial class HorarioProveedores : Form
    {
        public HorarioProveedores()
        {
            InitializeComponent();
        }

        public void llenarGrid() {
            BL_Proveedor blProveedor = new BL_Proveedor();
            List<DO_ProveedorParaHorario> elementosHorario = blProveedor.dividirHorario();

            DataTable dtHorario = new DataTable();
            dtHorario.Columns.Add("Lunes");
            dtHorario.Columns.Add("Martes");
            dtHorario.Columns.Add("Miercoles");
            dtHorario.Columns.Add("Jueves");
            dtHorario.Columns.Add("Viernes");
            dtHorario.Columns.Add("Sabado");
            dtHorario.Columns.Add("Domingo");

            foreach (DO_ProveedorParaHorario doProvHorario in elementosHorario) {
                //DataRow fila = new DataRow();
                int i = 0;
                foreach (String diaHora in doProvHorario.listaDiaYhora) {
                    if ((i % 2) == 0)
                    { //Es par, es un dia

                    }
                    else { //Es impar, es una hora)

                    }
                }
            }
        }
    }
}
