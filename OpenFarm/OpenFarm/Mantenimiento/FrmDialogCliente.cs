﻿using Common.Help;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFarm.Mantenimiento
{
    public partial class FrmDialogCliente : MaterialSkin.Controls.MaterialForm
    {
        public FrmDialogCliente()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);

        }

        private void FrmDialogCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
