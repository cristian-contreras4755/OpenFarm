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
    public partial class FrmUsuario : MaterialSkin.Controls.MaterialForm
    {
        public FrmUsuario()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        private void FrmUsuario_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmUsuarioCrea fmr = new FrmUsuarioCrea();
            fmr.ShowDialog();
            Listar();
        }

        private void DRG_usuario_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int Id_Usuario =Convert.ToInt32( DRG_usuario.CurrentRow.Cells["Id_Usuario"].Value.ToString());
            if (Id_Usuario==null)
            {
                return;
            }


            UsuarioModel productoModel = new UsuarioModel();
            productoModel.Id_Usuario = Id_Usuario;
            FrmUsuarioCrea fmr = new FrmUsuarioCrea(productoModel);
            fmr.ShowDialog();

            Listar();
        }

        public void Listar()
        {

            ClassResult cr = new ClassResult();
            UsuarioBusiness ctr = new UsuarioBusiness();
            cr = ctr.Usuario_Cons();
            DataTable data = cr.Dt1;
            DRG_usuario.DataSource = data;
            OcultarColumnas();
        }

        public void OcultarColumnas()
        {
            //    this.DRG_Usuario.Columns["Id_Categoria"].Visible = false;
        }



        public void FiltrarCategoria()
        {
            UsuarioBusiness ctr = new UsuarioBusiness();
            UsuarioModel model = new UsuarioModel();
            model.Nom = txt_buscar.Text;
            DRG_usuario.DataSource = ctr.BuscarUsuario(model);
            OcultarColumnas();
        }



        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarCategoria();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            FiltrarCategoria();
        }



        private void Btn_Editar_Click(object sender, EventArgs e)
        {
            if (DRG_usuario.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro.","validacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            if (String.IsNullOrEmpty(DRG_usuario.CurrentRow.Cells["Id_Usuario"].Value.ToString()))
            {
                MessageBox.Show("Debe asegurarse de seleccionar un registro.", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int Id_Usuario = Convert.ToInt32(DRG_usuario.CurrentRow.Cells["Id_Usuario"].Value.ToString());
            if (Id_Usuario == null)
            {
                return;
            }


            UsuarioModel productoModel = new UsuarioModel();
            productoModel.Id_Usuario = Id_Usuario;
            FrmUsuarioCrea fmr = new FrmUsuarioCrea(productoModel);
            fmr.ShowDialog();

            Listar();
        }



        private void Btn_eliminar_Click(object sender, EventArgs e)
        {
            if (DRG_usuario.CurrentRow == null)
            {
                MessageBox.Show("Debe seleccionar un registro.", "validacion", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }

            if (String.IsNullOrEmpty(DRG_usuario.CurrentRow.Cells["Id_Usuario"].Value.ToString()))
            {
                MessageBox.Show("Debe seleccionar un registro.", "", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                return;
            }



            DialogResult result = MessageBox.Show("Seguro que desea Eliminar al Usuario?", "Eliminacion de usuario", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                UsuarioBusiness ctr = new UsuarioBusiness();
                UsuarioModel model = new UsuarioModel();


                int id = Convert.ToInt32(DRG_usuario.CurrentRow.Cells["Id_Usuario"].Value.ToString());
                model.Id_Usuario = id;
                ClassResult cr = ctr.Usuario_Elim(model);
                if (cr.HuboError)
                {
                    MessageBox.Show("Debe seleccionar un registro.", cr.ErrorMsj, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    Listar();
                }

            }
            else if (result == DialogResult.No)
            {
                return;
            }
            else if (result == DialogResult.Cancel)
            {
                return;
            }


        }


        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
