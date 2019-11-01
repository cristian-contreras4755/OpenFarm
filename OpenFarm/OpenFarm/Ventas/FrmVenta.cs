using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFarm.Ventas
{
    public partial class FrmVenta :   MaterialSkin.Controls.MaterialForm
    {
        public FrmVenta()
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

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }

        private void Btn_imprimir_Click(object sender, EventArgs e)
        {
           


        }

        private void ImprimirTicket(object sender, PrintPageEventArgs e)
        {
            //ancho  85 caracteres
            // 39 CARACTERES EN MAYUSCULA


            //(X)ANCHO DE CAJAS DE TEXTO = 330;   320


            //(y)ANCHO DE CAJAS DE TEXTO = 25-30;





            List<Detalles> lista = new List<Detalles>();

            Detalles det = new Detalles { cantidad = 3000, DsctUnit = 52000, PrecioUnit = 60.00, Total = 150.00, Producto = "papa" };
            Detalles det1 = new Detalles { cantidad = 50, DsctUnit = 52000, PrecioUnit = 60.00, Total = 150.00, Producto = "camote" };
            lista.Add(det);
            lista.Add(det1);

            int X = 10;
            int Y = 15;


            Font aFont = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
            Font font = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
            Font FuenteCabDet = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);


            Rectangle rect = new Rectangle(X, Y, 300, 30);
            var formato = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            e.Graphics.DrawString("ACEROS  AREQUIPA SOCIENDAD ANONIMA CERRADA", font, Brushes.Black, rect, formato);
            Y = Y + 15;


            var formato_isquierda = new StringFormat() { Alignment = StringAlignment.Near, LineAlignment = StringAlignment.Center };

            Rectangle Rec_derecho = new Rectangle(X, Y, 300, 30);
            e.Graphics.DrawString("RUC : 201504544154", font, Brushes.Black, Rec_derecho, formato);
            Y = Y + 15;

            Rectangle Rec_Direccion = new Rectangle(X, Y, 300, 30);
            e.Graphics.DrawString("DIRECCION : ate vitarte sadsad", font, Brushes.Black, Rec_Direccion, formato);
            Y = Y + 15;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("BOLETA ELECTRONICA", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("B001-00778158", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("Fecha  :27-09-2019     Hora:17:50:16", font, Brushes.Black, X, Y);
            Y = Y + 15;

            Rectangle Rec_Cajero = new Rectangle(X, Y, 300, 30);
            e.Graphics.DrawString("Cajero  :", font, Brushes.Black, Rec_Cajero, formato_isquierda);
            Y = Y + 15;

            Rectangle Rec_Cliente = new Rectangle(X, Y, 300, 30);
            e.Graphics.DrawString("Cliente  : Cristian Angel Quicaño contreras Fuentes perez figueroa", font, Brushes.Black, Rec_Cliente, formato_isquierda);
            Y = Y + 15;

            Rectangle Rec_nroDocCli = new Rectangle(X, Y, 300, 30);
            e.Graphics.DrawString("Nro Doc  : 00000001", font, Brushes.Black, Rec_nroDocCli, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;

            Rectangle Rec_CabDet = new Rectangle(X, Y, 300, 30);

            e.Graphics.DrawString("CANT        PRECIO      DSCTO        TOTAL    DESCRIPCION", FuenteCabDet, Brushes.Black, Rec_CabDet, formato_isquierda);
            Y = Y + 15;

            Rectangle Rec_CabDet_line = new Rectangle(X, Y, 330, 30);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, Rec_CabDet_line, formato_isquierda);
            Y = Y + 15;
            foreach (var item in lista)
            {

                Rectangle rectDet = new Rectangle(X, Y, 300, 30);
                var formatoDet = new StringFormat() { Alignment = StringAlignment.Near };
                int cant = item.cantidad.ToString().Length;



                Rectangle rectCantidadDet = new Rectangle(X, Y, 70, 30);
                Rectangle rectPrecioDet = new Rectangle(X+30, Y, 70, 30);
              //  Rectangle rectDesctoDet = new Rectangle(X+20, Y, 70, 30);
               // Rectangle rectTotalDet = new Rectangle(X+20, Y, 70, 30);
               // Rectangle rectDescripcionDet = new Rectangle(X+20, Y, 70, 30);

                //     e.Graphics.DrawString("  "+item.cantidad + "             " + item.PrecioUnit + "             " + item.DsctUnit + "             " + item.Total + "             " + item.Producto, font, Brushes.Black, rectDet, formato_isquierda);


                e.Graphics.DrawString(""+ item.cantidad , font, Brushes.Black, rectCantidadDet, formato_isquierda);
                e.Graphics.DrawString("" + item.PrecioUnit, font, Brushes.Black, rectPrecioDet, formato_isquierda);
              //  e.Graphics.DrawString("" + item.DsctUnit, font, Brushes.Black, rectDesctoDet, formato_isquierda);
               // e.Graphics.DrawString("" + item.Total, font, Brushes.Black, rectTotalDet, formato_isquierda);
               // e.Graphics.DrawString("" + item.Producto, font, Brushes.Black, rectDescripcionDet, formato_isquierda);

                Y = Y + 15;
            }
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          OP. GRABADAS                                      100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          OP. GRATUITAS                                      100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          OP. EXONERADAS                                  100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          OP. INAFECTAS                                      100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          TOTAL DCTO                                          100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          IGV                                                       100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          IMP BOLSA                                             100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          TOTAL DCTO                                           100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("                          TOTAL A PAGAR                                       100.000", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("PAGO CASH          S/           50.50", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("CAMBIO               S/           50.50", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("Son :  giglglglglhglrfpd6ñlzxryluccry", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("gracias por comprar en tienda bla bla", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("reprensentacion de bolete bal bla bal", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);


            //string prueba = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA";

            //MessageBox.Show("" + prueba.Length);


            //e.Graphics.DrawString("mi primer ticker,", font, Brushes.Black, new Rectangle(0, 10, 120, 20));
            //e.Graphics.DrawString("mi primer ticker,", font, Brushes.Black, new Rectangle(0, 10, 120, 20));
            //e.Graphics.DrawString("mi primer ticker,", font, Brushes.Black, new Rectangle(0, 10, 120, 20));
            //e.Graphics.DrawString("mi primer ticker,", font, Brushes.Black, new Rectangle(0, 10, 120, 20));
        }

        private void Btn_print_Click(object sender, EventArgs e)
        {
            printDocumentTicket = new PrintDocument();
            PrinterSettings prints = new PrinterSettings();
            printDocumentTicket.PrinterSettings = prints;
            printDocumentTicket.PrintPage += ImprimirTicket;



            printPreviewDialogTicket.Document = printDocumentTicket;
            printPreviewDialogTicket.ShowDialog();


            //printDialogticket.Document = printDocumentTicket;

            //if (printDialogticket.ShowDialog() == DialogResult.OK)
            //{
            //    printDocumentTicket.Print();
            //}

        }

        private void Btn_cliente_Click(object sender, EventArgs e)
        {

        }
    }





    public class Detalles {

        public int cantidad { get; set; }
        public  string Producto { get; set; }
        public double PrecioUnit { get; set; }
        public double DsctUnit { get; set; }
        public double Total { get; set; }
    }

   


     
}
