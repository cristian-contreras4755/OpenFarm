using Bussines;
using Common;
using Common.Help;
using Model;
using OpenFarm.Inventario;
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
    public partial class FrmDialogProducto : MaterialSkin.Controls.MaterialForm
    {


        ModuloCons moduloconsulta;

        public ProductoModel ProductoModel { get; set; }

        public enum ModuloCons
        {
            FrmVentas, FrmIngreso
        }


        public FrmDialogProducto()
        {
            InitializeComponent();
            HelpTeme  teme= new HelpTeme();
            teme.InicializarTema(this);
        }



        public FrmDialogProducto(ModuloCons m)
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
            moduloconsulta =m ;
        }






        private void FrmDialogProducto_Load(object sender, EventArgs e)
        {
            ListarProducto();
        }


        public void ListarProducto()
        {

            ClassResult cr = new ClassResult();
            ProductoBusiness ctr = new ProductoBusiness();
            cr = ctr.Producto_Cons();
            DataTable data = cr.Dt1;
            DRG_Producto.DataSource = data;
        }



        public void OcultarColumnas()
        {
            //    this.DRG_Producto.Columns["Id_Categoria"].Visible = false;
        }

        private void DRG_Producto_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DRG_Producto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            ProductoModel model = new ProductoModel();

            model.Cd_Prod = DRG_Producto.CurrentRow.Cells["Codigo"].Value.ToString();
            model.Nombre1 = DRG_Producto.CurrentRow.Cells["NombrePrin"].Value.ToString();

            switch (moduloconsulta)
            {
                case ModuloCons.FrmVentas:

                    break;
                case ModuloCons.FrmIngreso:
                    this.ProductoModel = model;
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                   // this.Dispose();
                    break;
                default:
                    break;
            }




        }






    }
}
