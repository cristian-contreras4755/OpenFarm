using Bussines;
using Common;
using Model;
using OpenFarm.Mantenimiento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFarm.Inventario
{
    public partial class FrmIngreso : MaterialSkin.Controls.MaterialForm
    {
        public FrmIngreso()
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

        private int IdUsuCrea = 1;
       List <IngresoDetModel> ingresoDetModel = new List<IngresoDetModel>();






        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            CrearColumas();
            ListarTipoDoc();
            dt_FV.MinDate = DateTime.Now;
            ft_FP.MinDate = DateTime.Now;
        }


        public void CrearColumas() {
            DT_IngresoDet.Columns.Add("Cd_Prod", "Cod. Producto");
            DT_IngresoDet.Columns.Add("Cant", "Cantidad");
            DT_IngresoDet.Columns.Add("CosUnt", "Cto. Unit");
            DT_IngresoDet.Columns.Add("PrecioCom", "P. Compra");
            DT_IngresoDet.Columns.Add("PrecioVta", "P. Vta");
            DT_IngresoDet.Columns.Add("Fecha_produccion", "F. Prod.");
            DT_IngresoDet.Columns.Add("Fecha_vencimiento", "F. Vcto");
            DT_IngresoDet.Columns.Add("Total", "Total");

        }


        private void Btn_buscarCliente_Click(object sender, EventArgs e)
        {
            FrmDialogProducto fmr = new FrmDialogProducto();
            fmr.ShowDialog();
        }

        public void ListarTipoDoc()
        {
            ClassResult cr = new ClassResult();
            VentaBusiness ctr = new VentaBusiness();
            cr = ctr.TipoDoc_Cons();
            DataTable data = cr.Dt1;
            cb_Cd_TDI.DataSource = data;
            cb_Cd_TDI.ValueMember = "Cd_TD";
            cb_Cd_TDI.DisplayMember = "Descrip";
        }


    }
}
