using Bussines;
using Common;
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

namespace OpenFarm.Mantenimiento
{
    public partial class Categoria : MaterialSkin.Controls.MaterialForm
    {
        public Categoria()
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

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            Listar();
        }


 



        public void incializarControles() {
             txt_Nombre.Text="";
             txt_Descripcion.Text = "";
        }


        public bool Validar() {

            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Ingrese categoria");
                return false;
            }
            return true;
        }

        public void Listar() {

            ClassResult cr = new ClassResult();
            CategoriaBusiness ctr = new CategoriaBusiness();
            cr = ctr.Categoria_Cons();
            DataTable data = cr.Dt1;
            DRG_Categoria.DataSource = data;
        }



        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            CategoriaBusiness ctr = new CategoriaBusiness();
            CategoriaModel model = new CategoriaModel();
            model.Nombre = txt_buscar.Text;
            DRG_Categoria.DataSource = ctr.BuscarCategoria(model);
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            CategoriaBusiness ctr = new CategoriaBusiness();
            CategoriaModel model = new CategoriaModel();

            model.Nombre = txt_Nombre.Text;
            model.Descripcion = txt_Descripcion.Text;

            if (!Validar())
            {
                return;
            }


            ClassResult cr = ctr.Categoria_Crea(model);
            if (cr.HuboError)
            {

                MessageBox.Show("error");
            }
            else
            {
                MessageBox.Show("registrado");
                Listar();
            }
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


    }
}
