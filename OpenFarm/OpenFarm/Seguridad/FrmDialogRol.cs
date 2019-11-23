using Bussines;
using Common;
using Common.Help;
using Model;
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
    public partial class FrmDialogRol : MaterialSkin.Controls.MaterialForm
    {
        public FrmDialogRol()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        public RolModel rolModel { get; set; }

        private void FrmDialogRol_Load(object sender, EventArgs e)
        {
            ListarProducto();
        }

        public void ListarProducto()
        {
            ClassResult cr = new ClassResult();
            UsuarioBusiness ctr = new UsuarioBusiness();
            cr = ctr.Rol_Cons();
            DataTable data = cr.Dt1;
            DRG_Rol.DataSource = data;
        }


        private void DRG_Rol_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            RolModel model = new RolModel();
            model.Id_Rol = Convert.ToInt32(DRG_Rol.CurrentRow.Cells["Id_Rol"].Value.ToString());
            model.Nombre = DRG_Rol.CurrentRow.Cells["Nombre"].Value.ToString();

            this.rolModel = model;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
