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
            llenarGrid();
        }

        public void llenarGrid() {
            BL_Proveedor blProveedor = new BL_Proveedor();
            List<DO_ProveedorParaHorario> elementosHorario = blProveedor.dividirHorario();

            DataTable dtHorario = construirDataTable();

            foreach (DO_ProveedorParaHorario doProvHorario in elementosHorario) {
                int i = 0;

                int[] indicesHoraYdia = new int[2];

                foreach (String diaHora in doProvHorario.listaDiaYhora) {
                    if ((i % 2) == 0)
                    { //Es par, es un dia
                        indicesHoraYdia[1] = obtenerIndiceDia(diaHora);
                    }
                    else { //Es impar, es una hora)
                        indicesHoraYdia[0] = obtenerIndiceHora(diaHora);
                    }
                    i++;
                }

                dtHorario.Rows[indicesHoraYdia[0]][indicesHoraYdia[1]] = (String)(dtHorario.Rows[indicesHoraYdia[0]][indicesHoraYdia[1]])
                    +doProvHorario.nombre;
            }

            grdAsociados.DataSource = dtHorario;
        }

        public DataTable construirDataTable() {
            DataTable dtHor = new DataTable();
            dtHor.Columns.Add("Hora");
            dtHor.Columns.Add("Lunes");
            dtHor.Columns.Add("Martes");
            dtHor.Columns.Add("Miercoles");
            dtHor.Columns.Add("Jueves");
            dtHor.Columns.Add("Viernes");
            dtHor.Columns.Add("Sabado");
            dtHor.Columns.Add("Domingo");

            dtHor.Rows.Add("8-00AM - 9:00AM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("9-00AM - 10:00AM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("10-00AM - 11:00AM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("11-00AM - 12:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("12-00PM - 1:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("1-00PM - 2:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("2-00PM - 3:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("3-00PM - 4:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("4-00PM - 5:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("5-00PM - 6:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("6-00PM - 7:00PM", "", "", "", "", "", "", "");
            dtHor.Rows.Add("7-00PM - 8:00PM", "", "", "", "", "", "", "");

            return dtHor;
        }

        public int obtenerIndiceHora(String hora) {
            if (hora == "8:00AM")
            {
                return 0;
            }
            else if (hora == "9:00AM")
            {
                return 1;
            }
            else if (hora == "10:00AM")
            {
                return 2;
            }
            else if (hora == "11:00AM")
            {
                return 3;
            }
            else if (hora == "12:00AM")
            {
                return 4;
            }
            else if (hora == "1:00PM")
            {
                return 5;
            }
            else if (hora == "2:00PM")
            {
                return 6;
            }
            else if (hora == "3:00PM")
            {
                return 7;
            }
            else if (hora == "4:00PM")
            {
                return 8;
            }
            else if (hora == "5:00PM")
            {
                return 9;
            }
            else if (hora == "6:00PM")
            {
                return 10;
            }
            else if (hora == "7:00PM")
            {
                return 11;
            }
            else {
                return -1;
            }
        }

        public int obtenerIndiceDia(String dia)
        {
            if (dia == "9:00AM")
            {
                return 1;
            }
            else if (dia == "10:00AM")
            {
                return 2;
            }
            else if (dia == "11:00AM")
            {
                return 3;
            }
            else if (dia == "12:00AM")
            {
                return 4;
            }
            else if (dia == "1:00PM")
            {
                return 5;
            }
            else if (dia == "2:00PM")
            {
                return 6;
            }
            else if (dia == "3:00PM")
            {
                return 7;
            }
            else
            {
                return -1;
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
