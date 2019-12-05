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
    public partial class MensajeConfirmacion : Form
    {
        IConfirmacion padre;
        public bool estado;
        public MensajeConfirmacion(string mensaje, IConfirmacion formaPadre)
        {
            InitializeComponent();
            padre = formaPadre;
            lbMensajeConfirmacion.Text = mensaje;
        }

        private void btnSi_Click(object sender, EventArgs e)
        {
            padre.positivo();
            this.Dispose();
        }

        private void btnNo_Click(object sender, EventArgs e)
        {
            padre.negativo();
            this.Dispose();
        }
    }
}
