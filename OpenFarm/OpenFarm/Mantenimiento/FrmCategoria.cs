using Bussines;
using Common;
using MetroFramework.Forms;
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
    public partial class FrmCategoria : MaterialSkin.Controls.MaterialForm
    {
        public FrmCategoria()
        {
            InitializeComponent();
            var skinmanager = MaterialSkin.MaterialSkinManager.Instance;
            skinmanager.AddFormToManage(this);
            skinmanager.Theme = MaterialSkin.MaterialSkinManager.Themes.LIGHT;
            skinmanager.ColorScheme = new MaterialSkin.ColorScheme(
                   MaterialSkin.Primary.Brown400,
                   MaterialSkin.Primary.Brown400,
                MaterialSkin.Primary.Brown400,
                 MaterialSkin.Accent.Blue200,
                  MaterialSkin.TextShade.BLACK


                );

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {

            ClassResult cr = new ClassResult();
            CategoriaBusiness ctr = new CategoriaBusiness();
            cr = ctr.Categoria_Cons();

            DataTable data = cr.Dt1;
            GCCategoria.DataSource= data;

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


            ClassResult cr = ctr.Categoria_CreaMdf(model);
            if (cr.HuboError)
            {

                MessageBox.Show("error");

            }
            else
            {
                MessageBox.Show("registrado");
            }




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


    }
}
