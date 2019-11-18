using Bussines;
using Common;
using Common.Help;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFarm.Mantenimiento
{
    public partial class FrmProducto : MaterialSkin.Controls.MaterialForm
    {
        public FrmProducto()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);

        }

        private void FrmProducto_Load(object sender, EventArgs e)
        {
            Listar();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

        }




        private void Btn_buscar_img_Click(object sender, EventArgs e)
        {

        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            FrmProductoCrea fmr = new FrmProductoCrea();
            fmr.ShowDialog();
         
        }





        public void Listar()
        {

            ClassResult cr = new ClassResult();
            ProductoBusiness ctr = new ProductoBusiness();
            cr = ctr.Producto_Cons();
            DataTable data = cr.Dt1;
            DRG_Producto.DataSource = data;
            OcultarColumnas();
        }

        public void OcultarColumnas()
        {
        //    this.DRG_Producto.Columns["Id_Categoria"].Visible = false;
        }



        public void FiltrarCategoria()
        {
            ProductoBusiness ctr = new ProductoBusiness();
            ProductoModel model = new ProductoModel();
            model.TextoBuscar = txt_buscar.Text;
            DRG_Producto.DataSource = ctr.BuscarProducto(model);
            OcultarColumnas();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {

        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarCategoria();
        }

        private void DRG_Producto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string cd_prod = DRG_Producto.CurrentRow.Cells["codigo"].Value.ToString();
            if (String.IsNullOrEmpty(cd_prod))
            {
                return;
            }

            ProductoModel productoModel = new ProductoModel();
            productoModel.Cd_Prod = cd_prod;
            FrmProductoCrea fmr = new FrmProductoCrea(productoModel);
            fmr.ShowDialog();
        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
