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
    public partial class MensajeExito : Form
    {
        public MensajeExito(String mensaje)
        {
            InitializeComponent();
            lbMensajeExito.Text = mensaje;
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
