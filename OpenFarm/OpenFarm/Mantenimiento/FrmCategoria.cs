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

namespace OpenFarm.Mantenimiento
{
    public partial class Categoria : MaterialSkin.Controls.MaterialForm
    {
        public Categoria()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);

        }

        int Id_Categoria=0;

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            incializarControles();
            Listar();
        }



        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarCategoria();
        }

        public void FiltrarCategoria()
        {
            CategoriaBusiness ctr = new CategoriaBusiness();
            CategoriaModel model = new CategoriaModel();
            model.Nombre = txt_buscar.Text;
            DRG_Categoria.DataSource = ctr.BuscarCategoria(model);
            OcultarColumnas();
        }

        public void OcultarColumnas() {
            this.DRG_Categoria.Columns["Id_Categoria"].Visible = false;
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


            if (Id_Categoria==0)
            {
                    ClassResult cr = ctr.Categoria_Crea(model);
                    if (cr.HuboError)
                    {
                        MessageBox.Show("error: " + cr.ErrorMsj);
                    }
                    else
                    {
                      //  MessageBox.Show("Categoria Registrada.");
                    incializarControles();
                    Listar();
                    }

            }
            else if (Id_Categoria != 0)
            {
                model.Id_Categoria = Id_Categoria;
                ClassResult cr = ctr.Categoria_Mdf(model);
                if (cr.HuboError)
                {

                    MessageBox.Show("error: " + cr.ErrorMsj);
                
                }
                else
                {
                   /// MessageBox.Show("Categoria Editada.");
                    incializarControles();
                    Listar();
                 
                }
            }
            else
            {
                MessageBox.Show("No se ha especificado el proceso cierre la ventana y  vuelva a abrir.");
            }
        }



        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CategoriaBusiness ctr = new CategoriaBusiness();
            CategoriaModel model = new CategoriaModel();
            model.Id_Categoria =  (int)DRG_Categoria.Rows[(int)DRG_Categoria.CurrentRow.Index].Cells[0].Value;



            ClassResult cr = ctr.Categoria_ConsUn(model);
            if (cr.Dt1.Rows.Count>0)
            {
                DataRow row = cr.Dt1.Rows[0];
                txt_Nombre.Text = row["Nombre"].ToString();
                txt_Descripcion.Text = row["Descripcion"].ToString();
                Id_Categoria =Convert.ToInt32 (row["Id_Categoria"].ToString());

                btn_cancelar.Visible = true;
            }
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Seguro que desea Eliminar la Categoria?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                CategoriaBusiness ctr = new CategoriaBusiness();
                CategoriaModel model = new CategoriaModel();

                int id = Convert.ToInt32(DRG_Categoria.CurrentRow.Cells["Id_Categoria"].Value.ToString());  
                model.Id_Categoria = id;
                ClassResult cr = ctr.Categoria_Elim(model);
                if (cr.HuboError)
                {
                    MessageBox.Show("error :" + cr.ErrorMsj);
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






        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            incializarControles();
        }



        public void incializarControles()
        {
            txt_Nombre.Text = "";
            txt_Descripcion.Text = "";
            btn_cancelar.Visible = false;
            Id_Categoria = 0;
        }

        private void ContextMenucrud_Opening(object sender, CancelEventArgs e)
        {
            if (DRG_Categoria.Rows.Count == 1)
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

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            FiltrarCategoria();
        }

        public bool Validar()
        {

            if (txt_Nombre.Text == "")
            {
                MessageBox.Show("Ingrese categoria");
                return false;
            }
            return true;
        }

        public void Listar()
        {

            ClassResult cr = new ClassResult();
            CategoriaBusiness ctr = new CategoriaBusiness();
            cr = ctr.Categoria_Cons();
            DataTable data = cr.Dt1;
            DRG_Categoria.DataSource = data;
            OcultarColumnas();
        }



    }
}
