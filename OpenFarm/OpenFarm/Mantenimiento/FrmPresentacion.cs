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
    public partial class FrmPresentacion : MaterialSkin.Controls.MaterialForm
    {
        public FrmPresentacion()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }


        int Id_Presentacion = 0;



        private void FrmPresentacion_Load(object sender, EventArgs e)
        {

        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            PresentacionBusiness ctr = new PresentacionBusiness();
            PresentacionModel model = new PresentacionModel();
            model.Nombre = txt_nombre.Text;
            model.Ncorto = txt_NCortoPresentacion.Text;

            if (!Validar())
            {
                return;
            }



            if (Id_Presentacion == 0)
            {
                ClassResult cr = ctr.Presentacion_Crea(model);
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
            else if (Id_Presentacion != 0)
            {
                model.Id_Presentacion = Id_Presentacion;
                ClassResult cr = ctr.Presentacion_Mdf(model);
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

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            incializarControles();
        }


        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarPresentacion();

        }




        public bool Validar()
        {

            if (txt_nombre.Text == "")
            {
                MessageBox.Show("Ingrese Nombre presentación");
                return false;
            }

            if (txt_NCortoPresentacion.Text == "")
            {
                MessageBox.Show("Ingrese Nombre corto de la Presentacion  (5 carateres)");
                return false;
            }

            return true;
        }

        public void Listar()
        {
            ClassResult cr = new ClassResult();
            PresentacionBusiness ctr = new PresentacionBusiness();
            cr = ctr.Presentacion_Cons();
            DataTable data = cr.Dt1;
            Dtg_Presentacion.DataSource = data;
          //OcultarColumnas();
        }



        public void BuscarPresentacion()
        {
            PresentacionBusiness ctr = new PresentacionBusiness();
            PresentacionModel model = new PresentacionModel();
            model.Nombre = txt_buscar.Text;
            Dtg_Presentacion.DataSource = ctr.BuscarPresentacion(model);
            OcultarColumnas();
        }


        public void incializarControles()
        {
            txt_nombre.Text = "";
            txt_NCortoPresentacion.Text = "";
            btn_cancelar.Visible = false;
            Id_Presentacion = 0;
        }




        public void OcultarColumnas()
        {
            //this.Dtg_Marca.Columns["Id_Presentacion"].Visible = false;
        }

        private void Txt_nombre_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPresentacion();
        }

        private void ContextMenucrud_Opening(object sender, CancelEventArgs e)
        {
            if (Dtg_Presentacion.Rows.Count == 1)
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

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {


            DialogResult result = MessageBox.Show("Seguro que desea Eliminar la Presentacion?", "Salir", MessageBoxButtons.YesNoCancel);

            if (result == DialogResult.Yes)
            {
                PresentacionBusiness ctr = new PresentacionBusiness();
                PresentacionModel model = new PresentacionModel();

                int id = Convert.ToInt32(Dtg_Presentacion.CurrentRow.Cells["Id_Presentacion"].Value.ToString());
                model.Id_Presentacion = id;
                ClassResult cr = ctr.Presentacion_Elim(model);
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

        private void EditarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                PresentacionBusiness ctr = new PresentacionBusiness();
                PresentacionModel model = new PresentacionModel();
                model.Id_Presentacion = Convert.ToInt32(Dtg_Presentacion.CurrentRow.Cells["Id_Presentacion"].Value.ToString());

                ClassResult cr = ctr.Presentacion_ConsUn(model);
                if (cr.Dt1.Rows.Count > 0)
                {
                    DataRow row = cr.Dt1.Rows[0];
                    txt_nombre.Text = row["Nombre"].ToString();
                    txt_NCortoPresentacion.Text = row["NCorto"].ToString();
                    Id_Presentacion = Convert.ToInt32(row["Id_Presentacion"].ToString());

                    btn_cancelar.Visible = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("error :" + ex.Message + "-" + ex.StackTrace.ToString());
            }
        }
    }
}
