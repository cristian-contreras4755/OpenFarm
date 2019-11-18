using Bussines;
using Common;
using Common.Help;
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
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

       

        private int IdUsuCrea = 1;
        private string Cd_Prod = "";
        List <IngresoDetModel> ingresoDetModel = new List<IngresoDetModel>();
        IngresoModel ingresoModel = new IngresoModel();


        private void FrmIngreso_Load(object sender, EventArgs e)
        {
            CrearColumas();
            ListarTipoDoc();
            dt_FV.MinDate = DateTime.Now;
            dt_FP.MaxDate = DateTime.Now;
        }

 
        public void CrearColumas() {
            DT_IngresoDet.Columns.Add("Cd_Prod", "Cod. Producto");
            DT_IngresoDet.Columns.Add("Desc", "Descripcion");
            DT_IngresoDet.Columns.Add("Cant", "Cantidad");
            DT_IngresoDet.Columns.Add("PrecioCom", "P. Compra");
            DT_IngresoDet.Columns.Add("PrecioVta", "P. Vta");
            DT_IngresoDet.Columns.Add("Fecha_produccion", "F. Prod.");
            DT_IngresoDet.Columns.Add("Fecha_vencimiento", "F. Vcto");
            DT_IngresoDet.Columns.Add("Total", "Total");
        }


        private void Btn_buscarCliente_Click(object sender, EventArgs e)
        {

            using (var form = new FrmDialogProducto(FrmDialogProducto.ModuloCons.FrmIngreso))
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                  txt_producto.Text = form.ProductoModel.Nombre1;
                  Cd_Prod = form.ProductoModel.Cd_Prod;

                }
            }


      
        }

        public void ListarTipoDoc()
        {
            ClassResult cr = new ClassResult();
            VentaBusiness ctr = new VentaBusiness();
            cr = ctr.TipoDoc_Cons();
            DataTable data = cr.Dt1;
            cb_Cd_TD.DataSource = data;
            cb_Cd_TD.ValueMember = "Cd_TD";
            cb_Cd_TD.DisplayMember = "Descrip";
        }





        public void SetData(  ProductoModel productoModel) {
            txt_producto.Text = productoModel.Nombre1.ToString();
        }

        private void Btn_guardar_Click(object sender, EventArgs e)
        {

            try
            {

                if (!ValidarRegistro())
                {
                    return;
                }

                IngresoBusiness ctr = new IngresoBusiness();
                ClassResult cr = ctr.Ingreso_Crea(ingresoModel, ingresoDetModel);
                if (cr.HuboError)
                {
                    MessageBox.Show("Error al registrar el  ingreso" , cr.ErrorMsj, MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Ingreso registrado correctamente", cr.ErrorMsj, MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("error  al registrar ingreo vuelva realizar el registro: " + ex.Message, ex.StackTrace.ToString(),MessageBoxButtons.OKCancel,MessageBoxIcon.Error) ;
            }
            //MessageBox.Show(Cd_Prod);
        }





        private void Btn_Agregaritem_Click(object sender, EventArgs e)
        {

            if (!ValidarRegistroItem())
            {
                //MessageBox.Show("Verfique que todos los campos esten registrados , caso contrario vulvalos a registra nuevamente");
                return ;
            }
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(DT_IngresoDet);
            fila.Cells[0].Value = Cd_Prod;
            fila.Cells[1].Value = txt_producto.Text;
            fila.Cells[2].Value = npd_cantidad.Text;
            fila.Cells[3].Value = txt_precioCom.Text;
            fila.Cells[4].Value = txt_precioVta.Text;
            fila.Cells[5].Value = dt_FP.Text;
            fila.Cells[6].Value = dt_FV.Text;
            fila.Cells[7].Value = Calcular();
            DT_IngresoDet.Rows.Add(fila);


     DT_IngresoDet.Columns["Cant"].DefaultCellStyle
    .Alignment = DataGridViewContentAlignment.MiddleRight;

            DT_IngresoDet.Columns["Total"].DefaultCellStyle
    .Alignment = DataGridViewContentAlignment.MiddleRight;

            DT_IngresoDet.Columns["PrecioCom"].DefaultCellStyle
.Alignment = DataGridViewContentAlignment.MiddleRight;

            DT_IngresoDet.Columns["PrecioVta"].DefaultCellStyle
.Alignment = DataGridViewContentAlignment.MiddleRight;

            CalcularTotal();
          
        }




        private void DT_IngresoDet_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            if (e.KeyChar  == (char)Keys.Delete)
            {
                DT_IngresoDet.Rows.Remove(DT_IngresoDet.CurrentRow);
        
                e.Handled = true;
              
            }
        }



        private void Txt_precioCom_KeyPress(object sender, KeyPressEventArgs e)
        {




            decimal pre=0;
           var  res = decimal.TryParse(txt_precioCom.Text, out pre);
            if (res)
            {
                helpValidacion helpValidacion = new helpValidacion();
                helpValidacion.ValidarDecimal(e);
            }
            else
            {
                txt_precioCom.Text = "";
            }
        }


        public bool ValidarRegistro()
        {

            if (String.IsNullOrEmpty(cb_Cd_TD.Text))
            {
                MessageBox.Show("Seleccione el  tipo de documento de ingreso");
                return false;
            }

            if (String.IsNullOrEmpty(txt_proveedor.Text))
            {
                MessageBox.Show("Ingrese provedor de referencia  de ingreso");
                return false;
            }


            if (DT_IngresoDet.Rows.Count<1)
            {
                MessageBox.Show("Registre productos a ingresar");
                return false;
            }
            return true;
        }
        public bool ValidarRegistroItem()
        {

            if (String.IsNullOrEmpty(txt_producto.Text) || String.IsNullOrEmpty(Cd_Prod))
            {
                MessageBox.Show("Seleccione un producto, no ha seleccionado  nigun producto");
                return false;
            }

            if (String.IsNullOrEmpty(dt_FP.Text))
            {
                MessageBox.Show("Ingrese  fecha de produccion del producto.");
                return false;
            }

            if (String.IsNullOrEmpty(dt_FV.Text))
            {
                MessageBox.Show("Ingrese  fecha de vencimiento del producto.");
                return false;
            }


            if (String.IsNullOrEmpty(npd_cantidad.Text))
            {
                MessageBox.Show("Ingrese  cantidad ");
                return false;
            }

            if (String.IsNullOrEmpty(txt_precioCom.Text))
            {
                MessageBox.Show("Ingrese  precio compra del producto. ");
                return false;
            }

            if (String.IsNullOrEmpty(txt_precioVta.Text))
            {
                MessageBox.Show("Ingrese  precio venta del producto. ");
                return false;
            }
            return true;
        }



        public decimal Calcular() {
          return Convert.ToDecimal(npd_cantidad.Text) * Convert.ToDecimal(txt_precioCom.Text);
        }



        public void CalcularTotal()     {
            try
            {
                        decimal subtotal = 0;
                        foreach (DataGridViewRow row in DT_IngresoDet.Rows)
                        {
                    subtotal += Convert.ToDecimal( row.Cells["Total"].Value);
                        }

                        lbl_subtotal.Text =Math.Round(subtotal, 2).ToString();


                       decimal Impuesto= subtotal * (100/18);
                       lblimpuesto.Text = Math.Round(Impuesto, 2).ToString();

                           decimal total = Impuesto + subtotal;
                        lbl_total.Text = Math.Round(total, 2).ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Error,  no se pudo calcular");
            }

           
        }

        private void Txt_precioVta_KeyPress(object sender, KeyPressEventArgs e)
        {

            helpValidacion helpValidacion = new helpValidacion();
            helpValidacion.ValidarDecimal(e);

        }



        public void pasarModelo() {

            foreach (DataGridViewRow row in DT_IngresoDet.Rows)
            {
                IngresoDetModel ingdetm = new IngresoDetModel
                {
                    Cd_Prod = row.Cells["Cd_Prod"].Value.ToString(),
                    Cant =Convert.ToInt32( row.Cells["Cant"].Value.ToString()),
                    PrecioCom = Convert.ToDecimal(row.Cells["PrecioCom"].Value),
                    PrecioVta = Convert.ToDecimal(row.Cells["PrecioVta"].Value),
                    Fecha_produccion = Convert.ToDateTime(row.Cells["Fecha_produccion"].Value),
                    Fecha_vencimiento = Convert.ToDateTime(row.Cells["Fecha_vencimiento"].Value),
                    Total = Convert.ToInt32(row.Cells["Total"].Value)
                };
                ingresoDetModel.Add(ingdetm);
            }

        }



        public void InicializarControlDetalle() {
            txt_producto.Text=String.Empty;
            npd_cantidad.Text ="1";
            txt_precioCom.Text = String.Empty;
            txt_precioVta.Text = String.Empty;
            txt_producto.Text = String.Empty;
            dt_FP.Value =DateTime.Now;
            dt_FV.Value = DateTime.Now;
            Cd_Prod = String.Empty;
        }

        public void InicializarControlCab()
        {
            txt_proveedor.Text = String.Empty;
            txt_serie.Text = String.Empty;
            txt_nroDoc.Text = String.Empty;
           ingresoDetModel = new List<IngresoDetModel>();
           ingresoModel = new IngresoModel();
           DT_IngresoDet.DataSource=""; 
        }




    }
}
