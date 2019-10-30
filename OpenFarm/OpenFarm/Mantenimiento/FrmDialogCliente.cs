﻿using System;
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
            var skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(
                   MaterialSkin.Primary.LightBlue500,
                  MaterialSkin.Primary.LightBlue700,
                 MaterialSkin.Primary.Amber600,
                 MaterialSkin.Accent.Blue200,
                MaterialSkin.TextShade.WHITE
                );

        }

        private void FrmDialogCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
