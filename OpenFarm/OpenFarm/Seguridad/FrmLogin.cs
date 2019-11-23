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
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        public FrmLogin()
        {


 InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
