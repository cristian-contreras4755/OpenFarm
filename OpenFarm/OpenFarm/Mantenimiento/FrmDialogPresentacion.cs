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
    public partial class FrmDialogPresentacion : MaterialSkin.Controls.MaterialForm
    {

        public PresentacionModel PresentacionModel { get; set; }

        public FrmDialogPresentacion()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        private void FrmDialogPresentacion_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarPresentacion();
        }

        private void Txt_buscar_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarPresentacion();

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
            //OcultarColumnas();
        }



        private void Dtg_Presentacion_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            PresentacionModel model = new PresentacionModel();
            model.Id_Presentacion = Convert.ToInt32(Dtg_Presentacion.CurrentRow.Cells["Id_Presentacion"].Value.ToString());
            model.Nombre = Dtg_Presentacion.CurrentRow.Cells["Nombre"].Value.ToString();
            this.PresentacionModel = model;
            this.DialogResult = DialogResult.OK;
            this.Close();

        }
    }
}
