using Common.Help;
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
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {
            CrearColumas();
        }


        public void CrearColumas()
        {
            DT_DetVta.Columns.Add("Cd_Prod", "Cod. Producto");
            DT_DetVta.Columns.Add("Desc", "Descripcion");
            DT_DetVta.Columns.Add("Cant", "Cantidad");
            DT_DetVta.Columns.Add("Cant", "Unid. Med.");
            DT_DetVta.Columns.Add("PrecioVta", "Precio");
            DT_DetVta.Columns.Add("Dscto", "Dscto.");
            DT_DetVta.Columns.Add("Immporte", "Importe");
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

            Detalles det = new Detalles { cantidad = 6, DsctUnit = 520, PrecioUnit = 60.00, Total = 150.00, Producto = "Crema de almejas estilo Nueva Inglaterra peru argetina " };
            Detalles det1 = new Detalles { cantidad = 2, DsctUnit = 5200, PrecioUnit = 60.00, Total = 150.00, Producto = "Cerveza tibetana Barley" };
            Detalles det2 = new Detalles { cantidad = 2, DsctUnit = 5200, PrecioUnit = 60.00, Total = 150.00, Producto = "Crema de almejas estilo Nueva Inglaterra" };
            Detalles det3 = new Detalles { cantidad = 2, DsctUnit = 5200, PrecioUnit = 60.00, Total = 150.00, Producto = "Especias Cajun del chef Anton" };
            Detalles det4 = new Detalles { cantidad = 2, DsctUnit = 5200, PrecioUnit = 60.00, Total = 150.00, Producto = "Mermelada de grosellas de la abuela" };
            Detalles det5 = new Detalles { cantidad = 2, DsctUnit = 5200, PrecioUnit = 60.00, Total = 150.00, Producto = "Peras secas orgánicas del tío Bob" };
            Detalles det6 = new Detalles { cantidad = 2, DsctUnit = 5200, PrecioUnit = 60.00, Total = 150.00, Producto = "Salsa de arándanos Northwoods" };
           lista.Add(det);
            lista.Add(det1);
            lista.Add(det2);
            lista.Add(det3);
            lista.Add(det4);
            lista.Add(det5);
            lista.Add(det6);

            int X = 10;
            int Y = 15;




            Font aFont = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
            Font font = new Font("Arial", 8, FontStyle.Bold, GraphicsUnit.Point);
            Font FuenteCabDet = new Font("Arial", 7, FontStyle.Bold, GraphicsUnit.Point);


            Rectangle rect = new Rectangle(X, Y, 300, 30);
            var formato = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };

            e.Graphics.DrawString("ACEROS  AREQUIPA SOCIENDAD ANONIMA CERRADA", font, Brushes.Black, rect, formato);
            Y = Y + 15;


            var formato_isquierda = new StringFormat() { Alignment = StringAlignment.Near };
            var formato_isderecha = new StringFormat() { Alignment = StringAlignment.Far };

            var alineacion_centro = new StringFormat() { Alignment = StringAlignment.Center, LineAlignment = StringAlignment.Center };
            var alineacion_prueba = new StringFormat() { Alignment = StringAlignment.Near };

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

            string NomVndr = "Cajero: juan perez del solar";
            Rectangle Rec_Cajero = new Rectangle(X, Y, 320, 30);
            // e.Graphics.DrawString("Cajero  :", font, Brushes.Black, Rec_Cajero, formato_isquierda);
            e.Graphics.DrawString(NomVndr, font, Brushes.Black, Rec_Cajero, alineacion_prueba);
            if (NomVndr.Length > 38)
            {
                Y = Y + 15;
            }

            Y = Y + 15;

            string NomCli = "Cliente  : Cristian Angel Quicaño contreras  sdfdsf        sdfsdf sdfsd sdfsd sdfsdf ";
            Rectangle Rec_Cliente = new Rectangle(X, Y, 320, 30);
              e.Graphics.DrawString(NomCli, font, Brushes.Black, Rec_Cliente, alineacion_prueba);
            if (NomCli.Length>38)
            {
                Y = Y + 15;
            }
          //  e.Graphics.DrawString("AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA", font, Brushes.Black, Rec_Cliente, alineacion_prueba);
            Y = Y + 15;

            Rectangle Rec_nroDocCli = new Rectangle(X, Y, 300, 30);
            e.Graphics.DrawString("Nro Doc  : 00000001", font, Brushes.Black, Rec_nroDocCli, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 10;

            Rectangle Rec_CabDet = new Rectangle(X, Y, 300, 30);

            e.Graphics.DrawString("PROD                                               CANT.   PRECIO   IMPORTE", FuenteCabDet, Brushes.Black, Rec_CabDet, formato_isquierda);
            Y = Y + 15;

            Rectangle Rec_CabDet_line = new Rectangle(X, Y, 330, 30);
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, Rec_CabDet_line, formato_isquierda);
            Y = Y + 15;
            foreach (var item in lista)
            {

                int lengProd = item.Producto.Length;
                decimal nroLinea = lengProd / 23;
                int reciduo = lengProd % 23;

            


              //  int altura = 0;

                //validacion de detalle si  el detalle tiene  es mayor a 21 caracteres por linea
                for (int i = 0; i <= nroLinea; i++)
                {
                   // altura = altura + 30;
                    if (!(lista.IndexOf(item)==0))
                    {
                        Y = Y + 19;
                     
                    } 
                }


                Rectangle rectDescripcionDet = new Rectangle(X, Y, 155, 160);
                Rectangle rectCantidadDet = new Rectangle(X +150, Y, 70, 160);
                Rectangle rectPrecioDet = new Rectangle(X+190, Y, 70, 160);
             //   Rectangle rectDesctoDet = new Rectangle(X+200, Y, 70, 30);
                Rectangle rectTotalDet = new Rectangle(X+250, Y, 70, 160);


                e.Graphics.DrawString(""+ nroLinea+"-" + lengProd + item.Producto, font, Brushes.Black, rectDescripcionDet, formato_isquierda);
                e.Graphics.DrawString(""+ item.cantidad , font, Brushes.Black, rectCantidadDet, formato_isquierda);
                e.Graphics.DrawString("" + item.PrecioUnit, font, Brushes.Black, rectPrecioDet, formato_isquierda);
             //   e.Graphics.DrawString("" + item.DsctUnit, font, Brushes.Black, rectDesctoDet, formato_isquierda);
                e.Graphics.DrawString("" + item.Total, font, Brushes.Black, rectTotalDet, formato_isquierda);
              
 
            }
            Y = Y + 15;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;



            //55
            double OP_grabada = 100.000;

            
            e.Graphics.DrawString("OP. GRABADAS", font, Brushes.Black, X+80, Y);
            Rectangle Rec_OpGrabada = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+OP_grabada, font, Brushes.Black, Rec_OpGrabada, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("OP. GRATUITAS", font, Brushes.Black, X + 80, Y);
            Rectangle Rec_OpGrattuita = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+ OP_grabada, font, Brushes.Black, Rec_OpGrattuita, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("OP. EXONERADAS", font, Brushes.Black, X + 80, Y);
            Rectangle Rec_OpExonorada = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+ OP_grabada, font, Brushes.Black, Rec_OpExonorada, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("OP. INAFECTAS", font, Brushes.Black, X + 80, Y);
            Rectangle Rec_OpInafecta = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+ OP_grabada, font, Brushes.Black, Rec_OpInafecta, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("TOTAL DCTO", font, Brushes.Black, X + 80, Y);
            Rectangle Rec_Dscto = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+ OP_grabada, font, Brushes.Black, Rec_Dscto, formato_isquierda);
            Y = Y + 15;


            e.Graphics.DrawString("IGV", font, Brushes.Black, X + 80, Y);
            Rectangle Rec_Igv = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+ OP_grabada, font, Brushes.Black, Rec_Igv, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("IMP BOLSA", font, Brushes.Black, X + 80, Y);
            Rectangle Rec_ImpBolsa = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+ OP_grabada, font, Brushes.Black, Rec_ImpBolsa, formato_isquierda);
            Y = Y + 15;

            e.Graphics.DrawString("TOTAL A PAGAR", font, Brushes.Black, X + 80, Y);
            Rectangle Rec_Total = new Rectangle(X + 240, Y, 300, 30);
            e.Graphics.DrawString(""+ OP_grabada, font, Brushes.Black, Rec_Total, formato_isquierda);
            Y = Y + 15;




            e.Graphics.DrawString("PAGO CASH          S/           50.50", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("CAMBIO               S/           50.50", font, Brushes.Black, X, Y);
            Y = Y + 15;
            e.Graphics.DrawString("Son :  giglglglglhglrfpd6ñlzxryluccry", font, Brushes.Black, X, Y);
            Y = Y + 20;



            Rectangle Rec_QR = new Rectangle(X+80, Y, 80, 80);
            Bitmap  image1 =(Bitmap) Image.FromFile("D:\\qr.jpg", true);
            Point point = new Point(X,Y);
            e.Graphics.DrawImage(image1, Rec_QR);

            Y = Y + 80;
            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;

            Rectangle Rec_MsjAgradecimiento= new Rectangle(X, Y, 300, 30);
            e.Graphics.DrawString("gracias por comprar en  en  NOMBRE COMERCIAL", font, Brushes.Black, Rec_MsjAgradecimiento, alineacion_centro);
            Y = Y + 15;

            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);
            Y = Y + 15;

            Rectangle Rec_MsjRutaDesc = new Rectangle(X  ,Y, 300, 30);
            e.Graphics.DrawString("REPRESENTACION DE LA BOLETA ELECTRONICA PODRA SER CONSULTADA EN  WWW.IDSI.PE/DOCS", font, Brushes.Black, Rec_MsjRutaDesc, alineacion_centro);
            Y = Y + 20;

            e.Graphics.DrawString("-------------------------------------------------------------------------------------", font, Brushes.Black, X, Y);


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



        public string AjustarTotalesText(string Titulo, double Monto) {
      
                if (Monto==null || Monto.ToString().Length==0)
                {
                    Monto = 00.0;
                }


                int totalCaracLine = 50;
                int totalseparacion = totalCaracLine - (Titulo.Length + Monto.ToString().Length);
                return (Titulo.PadRight(totalseparacion, ' ') + Monto.ToString());
      
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
