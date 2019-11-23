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
    public partial class FrmDialogMarca : MaterialSkin.Controls.MaterialForm
    {
        public FrmDialogMarca()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);

        }

        public MarcaModel MarcaModel { get; set; }


        private void FrmDialogMarca_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarMarca();
        }


        private void Dtg_Marca_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MarcaModel model = new MarcaModel();
            model.Id_Mca = Convert.ToInt32(Dtg_Marca.CurrentRow.Cells["Id_Mca"].Value.ToString());
            model.Nombre = Dtg_Marca.CurrentRow.Cells["Nombre"].Value.ToString();
            this.MarcaModel = model;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarMarca();
        }











        public void Listar()
        {

            ClassResult cr = new ClassResult();
            MarcaBusiness ctr = new MarcaBusiness();
            cr = ctr.Marca_Cons();
            DataTable data = cr.Dt1;
            Dtg_Marca.DataSource = data;
            //OcultarColumnas();
        }



        public void BuscarMarca()
        {
            MarcaBusiness ctr = new MarcaBusiness();
            MarcaModel model = new MarcaModel();
            model.Nombre = txt_buscar.Text;
            Dtg_Marca.DataSource = ctr.BuscarMarca(model);
            //OcultarColumnas();
        }
    }
}
