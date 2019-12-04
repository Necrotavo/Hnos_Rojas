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
        Proveedor papa;

        public HorarioProveedores(Proveedor padre)
        {
            InitializeComponent();
            papa = padre;
            llenarGrid();
            grdAsociados.DefaultCellStyle.Font = new Font("Microsoft Sans Serif", 10);
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

                        String textoAntiguo = (String)(dtHorario.Rows[indicesHoraYdia[0]][indicesHoraYdia[1]]);
                        dtHorario.Rows[indicesHoraYdia[0]][indicesHoraYdia[1]] = textoAntiguo + " " + doProvHorario.nombre;
                    }
                    i++;
                }
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
            if (hora == "08:00AM")
            {
                return 0;
            }
            else if (hora == "09:00AM")
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
            else if (hora == "01:00PM")
            {
                return 5;
            }
            else if (hora == "02:00PM")
            {
                return 6;
            }
            else if (hora == "03:00PM")
            {
                return 7;
            }
            else if (hora == "04:00PM")
            {
                return 8;
            }
            else if (hora == "05:00PM")
            {
                return 9;
            }
            else if (hora == "06:00PM")
            {
                return 10;
            }
            else if (hora == "07:00PM")
            {
                return 11;
            }
            else {
                return -1;
            }
        }

        public int obtenerIndiceDia(String dia)
        {
            if (dia == "L")
            {
                return 1;
            }
            else if (dia == "K")
            {
                return 2;
            }
            else if (dia == "M")
            {
                return 3;
            }
            else if (dia == "J")
            {
                return 4;
            }
            else if (dia == "V")
            {
                return 5;
            }
            else if (dia == "S")
            {
                return 6;
            }
            else if (dia == "D")
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
            papa.invocarListaProveedores();
            this.Dispose();
        }

        private void grdAsociados_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            grdAsociados.Rows[e.RowIndex].Cells[e.ColumnIndex].ToolTipText = grdAsociados.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();
        }
    }
}
