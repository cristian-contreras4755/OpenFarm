using Common.Help;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFarm.Seguridad
{
    public partial class FrmPermisos :   MaterialSkin.Controls.MaterialForm
    {
        public FrmPermisos()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);

        }

        private void FrmPermisos_Load(object sender, EventArgs e)
        {

        }
    }
}
