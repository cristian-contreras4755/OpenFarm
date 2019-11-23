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
    public partial class FrmDialogCategoria :  MaterialSkin.Controls.MaterialForm
    {
        public FrmDialogCategoria()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        public CategoriaModel CategoriaModel { get; set; }

        private void FrmDialogCategoria_Load(object sender, EventArgs e)
        {
            ListarCategoria();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        public void ListarCategoria()
        {
            ClassResult cr = new ClassResult();
            CategoriaBusiness ctr = new CategoriaBusiness();
            cr = ctr.Categoria_Cons();
            DataTable data = cr.Dt1;
            Dtg_Categoria.DataSource = data;
        }


        public void FiltrarCategoria()
        {
            CategoriaBusiness ctr = new CategoriaBusiness();
            CategoriaModel model = new CategoriaModel();
            model.Nombre = txt_buscar.Text;
            Dtg_Categoria.DataSource = ctr.BuscarCategoria(model);
           // OcultarColumnas();
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarCategoria();
        }

        private void Dtg_Categoria_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CategoriaModel model = new CategoriaModel();
            model.Id_Categoria = Convert.ToInt32(Dtg_Categoria.CurrentRow.Cells["Id_Categoria"].Value.ToString());
            model.Nombre = Dtg_Categoria.CurrentRow.Cells["Nombre"].Value.ToString();
            this.CategoriaModel= model;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
