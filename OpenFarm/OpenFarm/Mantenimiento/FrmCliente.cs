using Bussines;
using Common;
using Common.Help;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFarm.Mantenimiento
{
    public partial class FrmCliente : MaterialSkin.Controls.MaterialForm
    {
        public FrmCliente()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        CookieContainer myCookie;
        string Cd_Clt = "";


        private void FrmCliente_Load(object sender, EventArgs e)
        {
            Listar();
            ListarTipoDoc();
            IncializarControles();
        }



        public void CargarCfgCookingPorDefecto()
        {
            try
            {
                myCookie = null;
                myCookie = new CookieContainer();

                ServicePointManager.Expect100Continue = true;
                ServicePointManager.SecurityProtocol = SecurityProtocolType.Ssl3;
            }
            catch (Exception)
            {

                throw;
            }
        }



        private void Btn_buscar_cliente_sunat_Click(object sender, EventArgs e)
        {


            ObtenerImgCaptchaSNT();
        }


        public Bitmap ObtenerImgCaptchaSNT()
        {
            try
            {
                ServicePointManager.ServerCertificateValidationCallback = new RemoteCertificateValidationCallback(ValidarCertificado);
                HttpWebRequest myWebRequest = (HttpWebRequest)WebRequest.Create("http://e-consultaruc.sunat.gob.pe/cl-ti-itmrconsruc/captcha?accion=image");
                myWebRequest.CookieContainer = myCookie;
                myWebRequest.Proxy = null;
                myWebRequest.Credentials = CredentialCache.DefaultCredentials;
                HttpWebResponse myWebResponse = (HttpWebResponse)myWebRequest.GetResponse();
                Stream myImgStream = myWebResponse.GetResponseStream();
                Bitmap Img = new Bitmap(myImgStream);
                myImgStream.Flush();
                myImgStream.Close();
                return Img;
            }
            catch (Exception)
            {
                throw;
            }
        }

        private bool ValidarCertificado(object sender, System.Security.Cryptography.X509Certificates.X509Certificate certificate, System.Security.Cryptography.X509Certificates.X509Chain chain, SslPolicyErrors sslPolicyErrors)
        {
            return true;
        }


        public void DescargaImgCaptchaSN(string rutaImg)
        {
            try
            {
                Bitmap bmpImgCaptchaSNT;
                Bitmap pImgCaptcha = ObtenerImgCaptchaSNT();
                bmpImgCaptchaSNT = pImgCaptcha;
                bmpImgCaptchaSNT.Save(rutaImg, ImageFormat.Jpeg);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }



        private void ConvertirATextDeImgCaptchaSNT()
        {
            /* CREADO 28/02/2017 - POR : GGONZ */
            try
            {
                string rutaProyecto = Environment.CurrentDirectory.Replace("Ejecutable v3", "Complementos");
                string rutaTexto = rutaProyecto + "\\Tesseract-OCR\\imgSNTCaptchar.txt";
                string rutaImagen = rutaProyecto + "\\Tesseract-OCR\\imgSNTCaptchar.jpg";
                string rutaEjecutable = @"" + rutaProyecto + "\\Tesseract-OCR\\tesseract.exe";
                //NO BORRAR -->  //string cadenaArgumento = "\"D:\\Proyecto ERP\\IDSI ERP\\Complementos\\Tesseract-OCR\\imgSNTCaptchar.jpg\" \"D:\\Proyecto ERP\\IDSI ERP\\Complementos\\Tesseract-OCR\\imgSNTCaptchar\" -psm 7";  //-->FUNCIONA
                string cadenaArgumento = "\"" + rutaImagen + "\" \"" + rutaImagen.Replace(".jpg", "") + "\" -psm 7";
                //string cadenaArgumento =  "
                DescargaImgCaptchaSN(rutaImagen);
                //File.Delete("D:\\Tesseract-OCR\\imgSNTCaptchar.txt");
                File.Delete(rutaTexto);
                Process proc = new Process();
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.StartInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
                //proc.StartInfo.FileName = @"D:\Proyecto ERP\IDSI ERP\Complementos\Tesseract-OCR\tesseract.exe";
                proc.StartInfo.FileName = rutaEjecutable;
                //proc.StartInfo.Arguments = "\"D:\\Proyecto ERP\\IDSI ERP\\Complementos\\Tesseract-OCR\\imgSNTCaptchar.jpg\" \"D:\\Proyecto ERP\\IDSI ERP\\Complementos\\Tesseract-OCR\\imgSNTCaptchar\" -psm 7"; //--> FUNCIONA
                proc.StartInfo.Arguments = cadenaArgumento;
                proc.StartInfo.RedirectStandardError = false;
                proc.StartInfo.RedirectStandardOutput = false;
                proc.StartInfo.UseShellExecute = false;
                proc.StartInfo.CreateNoWindow = true;
                proc.Start();
                Thread.Sleep(150);
            }
            catch (Exception ex)
            {
                //HelpPV.MsjShow("Conexión con la SUNAT demoró, vuelta intentarlo", ex.Message, true, EstiloMsj.Alerta);
                // throw;
            }

        }



        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            ClienteBusiness ctr = new ClienteBusiness();
            ClienteModel model = new ClienteModel();
            model.Cd_TDI = cb_Cd_TDI.SelectedValue.ToString();
            model.NDoc = txt_NDoc.Text;
            model.RSocial = txt_RSocial.Text;
            model.NComercial = txt_NComercial.Text;
            model.ApMat = txt_ApMat.Text;
            model.ApPat = txt_ApPat.Text;
            model.Nom = txt_Nom.Text;
            model.Direc = txt_direccion.Text;
            model.Telf= txt_tlf.Text;
            model.Correo = txt_correo.Text;
            model.IdUsuCrea =1;

            if (rbt_pnat.Checked== true)
            {
                model.TipoCliente = true;
            }
            else
            {
                model.TipoCliente = false;
            }

            if (!Validar())
            {
                return;
            }


            if (Cd_Clt == "")
            {
                ClassResult cr = ctr.Cliente_Crea(model);
                if (cr.HuboError)
                {
                    MessageBox.Show("error: " + cr.ErrorMsj);
                }
                else
                {
                    //  MessageBox.Show("Marca Registrada.");
                    IncializarControles();
                    Listar();
                }

            }
            else if (Cd_Clt != "")
            {
                model.Cd_Clt = Cd_Clt;
                ClassResult cr = ctr.Cliente_Mdf(model);
                if (cr.HuboError)
                {

                    MessageBox.Show("error: " + cr.ErrorMsj);
                }
                else
                {
                    /// MessageBox.Show("Marca Editada.");
                    IncializarControles();
                    Listar();

                }
            }
            else
            {
                MessageBox.Show("No se ha especificado el proceso cierre la ventana y  vuelva a abrir.");
            }


        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void Txt_buscar_KeyUp(object sender, KeyEventArgs e)
        {
            BuscarCliente();
        }




        public void Listar()
        {
            ClassResult cr = new ClassResult();
            ClienteBusiness ctr = new ClienteBusiness();
            cr = ctr.Cliente_Cons();
            DataTable data = cr.Dt1;
            DT_Cliente.DataSource = data;
            OcultarColumnas();
        }


        public void BuscarCliente()
        {
            ClienteBusiness ctr = new ClienteBusiness();
            ClienteModel model = new ClienteModel();
            model.TextoBuscar = txt_buscar.Text;
            DT_Cliente.DataSource = ctr.BuscarCliente(model);
            OcultarColumnas();
        }

        public void ListarTipoDoc()
        {
            ClassResult cr = new ClassResult();
            ClienteBusiness ctr = new ClienteBusiness();
            cr = ctr.TipoDocIdn_Cons();
            DataTable data = cr.Dt1;
            cb_Cd_TDI.DataSource = data;
            cb_Cd_TDI.ValueMember = "Cd_TDI";
            cb_Cd_TDI.DisplayMember = "Descrip";
        }

        public void IncializarControles()
        {
            cb_Cd_TDI.Text = "";
            txt_NDoc.Text = "";
            txt_RSocial.Text = "";
            txt_NComercial.Text = "";
            txt_ApPat.Text = "";
            txt_ApMat.Text = "";
            txt_Nom.Text = "";
            txt_direccion.Text = "";
            txt_tlf.Text = "";
            txt_correo.Text = "";
            btn_cancelar.Visible = false;
            Cd_Clt = "";
        }



        public void OcultarColumnas()
        {
            //this.Dtg_Marca.Columns["Id_Mca"].Visible = false;
        }



        public bool Validar()
        {

            if (cb_Cd_TDI.Text == "")
            {
                MessageBox.Show("Ingrese  tipo de documento");
                return false;
            }

            if (txt_NDoc.Text == "")
            {
                MessageBox.Show("Ingrese Nro de documento del cliente");
                return false;
            }



            if (rbt_pnat.Checked==true)
            {
                if (txt_Nom.Text == "")
                {
                    MessageBox.Show("Ingrese nombre del cliente");
                    return false;
                }

                if (txt_ApPat.Text == "")
                {
                    MessageBox.Show("Ingrese  apellido paterno del cliente");
                    return false;
                }

                if (txt_ApMat.Text == "")
                {
                    MessageBox.Show("Ingreseapellido Materno del cliente");
                    return false;
                }

            }
            else
            {
                if (txt_RSocial.Text == "")
                {
                    MessageBox.Show("Ingrese la razon social del cliente");
                    return false;
                }
            }

            return true;
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }



        private void DT_Cliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void DT_Cliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                ClienteBusiness ctr = new ClienteBusiness();
                ClienteModel model = new ClienteModel();
                model.Cd_Clt = DT_Cliente.CurrentRow.Cells["Codigo"].Value.ToString();
                ClassResult cr = ctr.Cliente_ConsUn(model);
                if (cr.Dt1.Rows.Count > 0)
                {
                    DataRow row = cr.Dt1.Rows[0];

                    bool TipoCliente = (bool)row["TipoCliente"];
                    if (TipoCliente)
                    {
                        rbt_pnat.Checked = true;
                        rbt_pjur.Checked = false;
                    }
                    else
                    {
                        rbt_pjur.Checked = true;
                        rbt_pnat.Checked = false;
                    }

                    cb_Cd_TDI.SelectedValue = row["Cd_TDI"].ToString();
                    txt_NDoc.Text = row["NDoc"].ToString();
                    txt_RSocial.Text = row["RSocial"].ToString();
                    txt_NComercial.Text = row["NComercial"].ToString();
                    txt_ApPat.Text = row["ApPat"].ToString();
                    txt_ApMat.Text = row["ApMat"].ToString();
                    txt_Nom.Text = row["Nom"].ToString();
                    txt_direccion.Text = row["Direc"].ToString();
                    txt_tlf.Text = row["Telf"].ToString();
                    txt_correo.Text = row["Correo"].ToString();
                    Cd_Clt = model.Cd_Clt;
                    btn_cancelar.Visible = true;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("error  al obtener el codigo del cliente. :" + ex.Message + "-" + ex.StackTrace.ToString());
            }
        }



        private void EliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {

                DialogResult result = MessageBox.Show("Seguro que desea Eliminar  al cliente ?", "Salir", MessageBoxButtons.YesNoCancel);

                if (result == DialogResult.Yes)
                {
                    ClienteBusiness ctr = new ClienteBusiness();
                    ClienteModel model = new ClienteModel();

                    string Cd_Clt = DT_Cliente.CurrentRow.Cells["Codigo"].Value.ToString();
                    model.Cd_Clt = Cd_Clt;
                    ClassResult cr = ctr.Cliente_Elim(model);
                    if (cr.HuboError)
                    {
                        MessageBox.Show("error :" + cr.ErrorMsj);
                    }
                    else
                    {
                        Listar();
                    }

                }
                else if (result == DialogResult.No)
                {
                    return;
                }
                else if (result == DialogResult.Cancel)
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("error  al eliminar correo:" + ex.Message + "-" + ex.StackTrace.ToString());
            }
        }
    }
}
