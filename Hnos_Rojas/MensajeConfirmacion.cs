﻿using System;
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
        public MensajeConfirmacion(String mensaje)
        {
            InitializeComponent();
            lbMensajeConfirmacion.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
