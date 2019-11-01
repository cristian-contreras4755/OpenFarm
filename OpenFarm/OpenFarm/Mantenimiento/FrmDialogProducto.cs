using Bussines;
using Common;
using Common.Help;
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


        enum ModuloCons
        {
            FrmVentas, FrmIngreso
        }
        public FrmDialogProducto()
        {
            InitializeComponent();
            HelpTeme  teme= new HelpTeme();
            teme.InicializarTema(this);
        }



        public FrmDialogProducto(ModuloCons.FrmIngreso,)
        {
            InitializeComponent();
            
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
            OcultarColumnas();
        }



        public void OcultarColumnas()
        {
            //    this.DRG_Producto.Columns["Id_Categoria"].Visible = false;
        }

    }
}
