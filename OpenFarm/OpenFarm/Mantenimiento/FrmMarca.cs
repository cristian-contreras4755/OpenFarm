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
    public partial class FrmMarca : MaterialSkin.Controls.MaterialForm
    {
        public FrmMarca()
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

        int Id_Mca = 0;


        private void FrmMarca_Load(object sender, EventArgs e)
        {
            incializarControles();
            Listar();
        }



      
        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            MarcaBusiness ctr = new MarcaBusiness();
            MarcaModel model = new MarcaModel();
            model.Nombre = txt_Marca.Text;
            model.Descrip = txt_Descripcion.Text;
            model.NCorto = txt_NCorto.Text;

            if (!Validar())
            {
                return;
            }



            if (Id_Mca == 0)
            {
                ClassResult cr = ctr.Marca_Crea(model);
                if (cr.HuboError)
                {
                    MessageBox.Show("error: " + cr.ErrorMsj);
                }
                else
                {
                    //  MessageBox.Show("Marca Registrada.");
                    incializarControles();
                    Listar();
                }

            }
            else if (Id_Mca != 0)
            {
                model.Id_Mca = Id_Mca;
                ClassResult cr = ctr.Marca_Mdf(model);
                if (cr.HuboError)
                {

                    MessageBox.Show("error: " + cr.ErrorMsj);

                }
                else
                {
                    /// MessageBox.Show("Marca Editada.");
                    incializarControles();
                    Listar();

                }
            }
            else
            {
                MessageBox.Show("No se ha especificado el proceso cierre la ventana y  vuelva a abrir.");
            }

        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarMarca();

        }





        public bool Validar()
        {

            if (txt_Marca.Text == "")
            {
                MessageBox.Show("Ingrese Marca");
                return false;
            }

            if (txt_NCorto.Text == "")
            {
                MessageBox.Show("Ingrese Nombre corto de la marca  (5 carateres)");
                return false;
            }


            return true;
        }

        public void Listar()
        {

            ClassResult cr = new ClassResult();
            MarcaBusiness ctr = new MarcaBusiness();
            cr = ctr.Marca_Cons();
            DataTable data = cr.Dt1;
            Dtg_Marca.DataSource = data;
            OcultarColumnas();
        }



        public void BuscarMarca()
        {
            MarcaBusiness ctr = new MarcaBusiness();
            MarcaModel model = new MarcaModel();
            model.Nombre = txt_buscar.Text;
            Dtg_Marca.DataSource = ctr.BuscarMarca(model);
            OcultarColumnas();
        }

        public void incializarControles()
        {
            txt_Marca.Text = "";
            txt_Descripcion.Text = "";
            txt_NCorto.Text = "";
            btn_cancelar.Visible = false;
            Id_Mca = 0;
        }



        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarMarca();
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            incializarControles();
        }

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                    MarcaBusiness ctr = new MarcaBusiness();
                    MarcaModel model = new MarcaModel();
                    model.Id_Mca = Convert.ToInt32( Dtg_Marca.CurrentRow.Cells["Id_Mca"].Value.ToString());

                    ClassResult cr = ctr.Marca_ConsUn(model);
                    if (cr.Dt1.Rows.Count > 0)
                    {
                        DataRow row = cr.Dt1.Rows[0];
                        txt_Marca.Text = row["Nombre"].ToString();
                        txt_Descripcion.Text = row["Descrip"].ToString();
                        txt_NCorto.Text = row["NCorto"].ToString();
                        Id_Mca = Convert.ToInt32(row["Id_Mca"].ToString());

                        btn_cancelar.Visible = true;
                    }

            }
            catch (Exception ex)
            {

                MessageBox.Show("error :" + ex.Message +"-" +ex.StackTrace.ToString());
            }

        }


        public void OcultarColumnas()
        {
            //this.Dtg_Marca.Columns["Id_Mca"].Visible = false;
        }


        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Seguro que desea Eliminar la Marca?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                MarcaBusiness ctr = new MarcaBusiness();
                MarcaModel model = new MarcaModel();

                int id = Convert.ToInt32(Dtg_Marca.CurrentRow.Cells["Id_Mca"].Value.ToString());
                model.Id_Mca = id;
                ClassResult cr = ctr.Marca_Elim(model);
                if (cr.HuboError)
                {
                    MessageBox.Show("error :"+ cr.ErrorMsj);
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

        private void ContextMenucrud_Opening(object sender, CancelEventArgs e)
        {
            if (Dtg_Marca.Rows.Count == 1)
            {
                editarToolStripMenuItem.Visible = false;
                eliminarToolStripMenuItem.Visible = false;
            }
            else
            {
                editarToolStripMenuItem.Visible = true;
                eliminarToolStripMenuItem.Visible = true;
            }
        }
    }
}
