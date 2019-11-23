using Common.Seguridad;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI;
using System.Windows.Forms;

namespace Common.Help
{
   public class Utiles
    {
    
        public decimal DameIGV(string fecha)
        {
            if (Convert.ToDateTime(fecha) >= Convert.ToDateTime("01/03/2011"))
                return 18.00M;
            else return 19.00M;
        }
        public decimal DameIGV(DateTime fecha)
        {
            if (fecha >= Convert.ToDateTime("01/03/2011"))
                return 18.00M;
            else return 19.00M;
        }

        #region VARIABLES
        public string direccion = "";
        public string direccText = "";
        DataColumn column;


  


        #endregion

        #region  NUMERO A LETRAS
        public static string NumeroALetras(string num)
        {
            string res, dec = "";
            Int64 entero;
            int decimales;
            double nro;

            try
            {
                nro = Math.Abs(Convert.ToDouble(num));
            }
            catch
            {
                return "";
            }

            entero = Convert.ToInt64(Math.Truncate(nro));
            decimales = Convert.ToInt32(Math.Round((nro - entero) * 100, 2));

            if (decimales >= 0 && decimales < 10)
                dec = " CON 0" + decimales.ToString() + "/100";
            else
                dec = " CON " + decimales.ToString() + "/100";

            res = Utiles.toText(Convert.ToDouble(entero)) + dec;

            return res;
        }

        private static string toText(double value)
        {
            string Num2Text = "";
            value = Math.Truncate(value);

            if (value == 0) Num2Text = "CERO";
            else if (value == 1) Num2Text = "UNO";
            else if (value == 2) Num2Text = "DOS";
            else if (value == 3) Num2Text = "TRES";
            else if (value == 4) Num2Text = "CUATRO";
            else if (value == 5) Num2Text = "CINCO";
            else if (value == 6) Num2Text = "SEIS";
            else if (value == 7) Num2Text = "SIETE";
            else if (value == 8) Num2Text = "OCHO";
            else if (value == 9) Num2Text = "NUEVE";
            else if (value == 10) Num2Text = "DIEZ";
            else if (value == 11) Num2Text = "ONCE";
            else if (value == 12) Num2Text = "DOCE";
            else if (value == 13) Num2Text = "TRECE";
            else if (value == 14) Num2Text = "CATORCE";
            else if (value == 15) Num2Text = "QUINCE";
            else if (value < 20) Num2Text = "DIECI" + toText(value - 10);
            else if (value == 20) Num2Text = "VEINTE";
            else if (value < 30) Num2Text = "VEINTI" + toText(value - 20);
            else if (value == 30) Num2Text = "TREINTA";
            else if (value == 40) Num2Text = "CUARENTA";
            else if (value == 50) Num2Text = "CINCUENTA";
            else if (value == 60) Num2Text = "SESENTA";
            else if (value == 70) Num2Text = "SETENTA";
            else if (value == 80) Num2Text = "OCHENTA";
            else if (value == 90) Num2Text = "NOVENTA";

            else if (value < 100) Num2Text = toText(Math.Truncate(value / 10) * 10) + " Y " + toText(value % 10);
            else if (value == 100) Num2Text = "CIEN";
            else if (value < 200) Num2Text = "CIENTO " + toText(value - 100);
            else if ((value == 200) || (value == 300) || (value == 400) || (value == 600) || (value == 800)) Num2Text = toText(Math.Truncate(value / 100)) + "CIENTOS";

            else if (value == 500) Num2Text = "QUINIENTOS";
            else if (value == 700) Num2Text = "SETECIENTOS";
            else if (value == 900) Num2Text = "NOVECIENTOS";
            else if (value < 1000) Num2Text = toText(Math.Truncate(value / 100) * 100) + " " + toText(value % 100);
            else if (value == 1000) Num2Text = "MIL";
            else if (value < 2000) Num2Text = "MIL " + toText(value % 1000);
            else if (value < 1000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000)) + " MIL";
                if ((value % 1000) > 0) Num2Text = Num2Text + " " + toText(value % 1000);
            }

            else if (value == 1000000) Num2Text = "UN MILLON";
            else if (value < 2000000) Num2Text = "UN MILLON " + toText(value % 1000000);
            else if (value < 1000000000000)
            {
                Num2Text = toText(Math.Truncate(value / 1000000)) + " MILLONES ";
                if ((value - Math.Truncate(value / 1000000) * 1000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000) * 1000000);
            }
            else if (value == 1000000000000) Num2Text = "UN BILLON";
            else if (value < 2000000000000) Num2Text = "UN BILLON " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            else
            {
                Num2Text = toText(Math.Truncate(value / 1000000000000)) + " BILLONES";
                if ((value - Math.Truncate(value / 1000000000000) * 1000000000000) > 0) Num2Text = Num2Text + " " + toText(value - Math.Truncate(value / 1000000000000) * 1000000000000);
            }

            return Num2Text;
        }
        #endregion

        #region VALIDAR RUC

        int[] Pesos = new int[10];
        int[] Val_X_Peso = new int[10];



        public bool VerificarRuc(string Ruc)
        {
            if (Ruc.Length != 11) return false;
            int Sum_Val_X_Peso = 0;
            char[] ArrayRuc = Ruc.ToCharArray();

            for (int i = 0; i < 10; i++)
            {
                Val_X_Peso[i] = int.Parse(ArrayRuc[i].ToString()) * DamePeso(i);
                Sum_Val_X_Peso = Sum_Val_X_Peso + Val_X_Peso[i];
            }
            if (DameResultado(Sum_Val_X_Peso, int.Parse(ArrayRuc[10].ToString()))) return true;
            else return false;
        }

        private int DamePeso(int i)
        {
            if (i >= Pesos.Length) return -1;
            Pesos[0] = 5; Pesos[1] = 4; Pesos[2] = 3; Pesos[3] = 2;
            Pesos[4] = 7; Pesos[5] = 6; Pesos[6] = 5; Pesos[7] = 4;
            Pesos[8] = 3; Pesos[9] = 2;

            return Pesos[i];
        }

        private bool DameResultado(int Suma, int Digito)
        {
            int Diferencia = 0;
            int DigitoVerif = 0;

            Diferencia = 11 - (Suma - (int.Parse((Suma / 11).ToString()) * 11));

            switch (Diferencia)
            {
                case 10: DigitoVerif = 0; break;
                case 11: DigitoVerif = 1; break;
                default: DigitoVerif = Diferencia; break;
            }

            if (DigitoVerif == Digito) return true;
            else return false;
        }

        #endregion

        #region EXPORTAR EXCEL
        public bool Exportar(DataTable dt, string nombre, string path)
        {
            if (dt.Rows.Count <= 0) return false;

            String nom_archivo = nombre;// +"_0";
            String ubi_archivo = path + "\\" + nom_archivo + ".xls";//Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), nom_archivo + ".xls");

            //BORRANDO ARCHIVO EXISTENTE
            //if(System.IO.File.Exists(ubi_archivo))
            //{   if(HelpPV.MsjShowQs("Desea reemplazar archivo") == DialogResult.OK)
            //        System.IO.File.Delete(ubi_archivo);
            //    else return false;
            //}

            //CORRELATIVO
            bool verifica = true;
            while (System.IO.File.Exists(ubi_archivo))
            {
                //for(int i=0;i<=nom_archivo.Substring(nom_archivo.Length - 1, 1)-1;i++)
                if (verifica)
                {
                    nom_archivo = nombre + "_0";
                    verifica = false;
                }
                else
                    nom_archivo = nombre + "_" + Convert.ToInt32(nom_archivo.Substring(nombre.Length + 1));

                int valor = int.Parse(nom_archivo.Substring(nom_archivo.Length - 1, 1));
                nom_archivo = nombre + "_" + (valor + 1).ToString();
                ubi_archivo = path + "\\" + nom_archivo + ".xls"; ;
            }

            System.Web.UI.WebControls.DataGrid grid = new System.Web.UI.WebControls.DataGrid();
            grid.HeaderStyle.Font.Bold = true;
            grid.CellSpacing = 10;
            grid.HeaderStyle.BackColor = System.Drawing.Color.Silver;

            /*
            DataRow dr = dt.NewRow();
            dr[0] = "RUC: " + Session.RucEmpresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresa;
            dt.Rows.InsertAt(dr, 0);
            */
            grid.DataSource = dt;
            grid.DataMember = dt.TableName;
            grid.DataBind();

            using (StreamWriter sw = new StreamWriter(ubi_archivo))
            {
                using (HtmlTextWriter hw = new HtmlTextWriter(sw))
                {
                    System.Web.UI.WebControls.Style estilo = new System.Web.UI.WebControls.Style();
                    estilo.Font.Bold = true;
                    estilo.ForeColor = Color.Blue;
                    hw.AddStyleAttribute(HtmlTextWriterStyle.FontSize, "12");
                    //estilo.Font.Size.Unit.Value = 12M;
                    hw.EnterStyle(estilo);

                    hw.WriteLine("EMPRESA: " + Session.NombreUsuario);
                    hw.WriteBreak();
                    hw.WriteLine("RUC: " + Session.RucEmpresa);
                    hw.WriteBreak();
                    hw.WriteLine("EJERCICIO: " + Session.RucEmpresa);
                    hw.WriteBreak();
                    hw.WriteLine(" ");

                    grid.RenderControl(hw);

                }
            }

            direccion = ubi_archivo;

            return true;
        }
        #endregion

        #region ENVIAR ARCHIVO TXT



        /*
        public bool ImportarFallas(string titulo, string subrayado, string detalle, string path, string nomClass)
        {   return ImportarFallas(titulo, subrayado, detalle, path, nomClass, totalErrores);
        }
        */

        public bool ImportarFallas(string titulo, string subrayado, string detalle, string path, string nomClass)
        {
            if (path.Length > 3 | detalle.Length > 0)
            {
                if (!File.Exists(path))
                {
                    StreamWriter swn = File.AppendText(path);
                    swn.WriteLine("EMPRESA : " + Session.RucEmpresa + " - " + Session.NombreUsuario);
                    swn.WriteLine("REPORTE DE ERRORES DE IMPORTACION " + nomClass.ToUpper());
                    swn.WriteLine("================================================");
                    swn.WriteLine("");
                    swn.WriteLine(titulo);
                    swn.WriteLine(subrayado);
                    swn.Close();
                }

                StreamWriter sw = File.AppendText(path);
                sw.WriteLine(detalle);
                sw.Close();
                direccText = path;

                return true;
            }
            return false;
        }
        #endregion

        #region Otros Metodos



        private bool isNroCta(string cadena)
        {
            cadena = cadena.Trim();
            char[] cadVect = cadena.ToCharArray();
            for (int i = 0; i < cadena.Length; i++)
            {
                if (!(char.IsNumber(cadVect[i]) || cadVect[i] == '.'))
                    return false;
            }
            return true;
        }
        public static string GetOSName()
        {
            OperatingSystem osInfo = Environment.OSVersion;
            string osName = "UNKNOWN";

            switch (osInfo.Platform)
            {
                case PlatformID.Win32Windows:
                    switch (osInfo.Version.Minor)
                    {
                        case 0:
                            osName = "Windows 95";
                            break;

                        case 10:
                            if (osInfo.Version.Revision.ToString() == "2222A")
                            {
                                osName = "Windows 98 Second Edition";
                            }
                            else
                            {
                                osName = "Windows 98";
                            }
                            break;

                        case 90:
                            osName = "Windows Me";
                            break;
                    }
                    break;

                case PlatformID.Win32NT:
                    switch (osInfo.Version.Major)
                    {
                        case 3:
                            osName = "Windows NT 3.51";
                            break;

                        case 4:
                            osName = "Windows NT 4.0";
                            break;

                        case 5:
                            if (osInfo.Version.Minor == 0)
                            {
                                osName = "Windows 2000";
                            }
                            else if (osInfo.Version.Minor == 1)
                            {
                                osName = "Windows XP";
                            }
                            else if (osInfo.Version.Minor == 2)
                            {
                                osName = "Windows Server 2003";
                            }
                            break;

                        case 6:
                            osName = "Windows Vista";
                            break;
                    }
                    break;
            }
            return osName;
        }

        public static void AutoSizeCol(DataGridView dgv, Form form, params int[] listColumnIndex)
        {
            foreach (int columnIndex in listColumnIndex)
            {
                Graphics g = form.CreateGraphics();
                int maxSize = 0, originalWidth = 0;
                SizeF size;
                originalWidth = dgv.Columns[columnIndex].Width;
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    size = g.MeasureString(dgv.Rows[i].Cells[columnIndex].Value.ToString(), form.Font);
                    if (size.Width > maxSize)
                        maxSize = (int)size.Width;
                }
                if (maxSize > originalWidth)
                {
                    dgv.Columns[columnIndex].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                    dgv.Columns[columnIndex].Width = maxSize;
                }
                g.Dispose();
            }
        }

        public byte[] imagenEnArregloBytes(Image imageIn)
        {
            try
            {
                MemoryStream ms = new MemoryStream();
                imageIn.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                return ms.ToArray();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message);
                return new byte[0];
            }
        }


        public static void CambConfRegional()
        {
            try
            {
                RegistryKey clave = Registry.CurrentUser.OpenSubKey(@"Control Panel\International", true);
                clave.SetValue("Locale", "0000280A");
                clave.SetValue("LocaleName", "es-PE");
                clave.SetValue("sCurrency", "S/.");
                clave.SetValue("iFirstDayOfWeek", "0");
                clave.SetValue("sLongDate", "dddd, dd' de 'MMMM' de 'yyyy");
                clave.SetValue("sLanguage", "ESR");
                clave.SetValue("sCountry", "Perú");
                clave.SetValue("sDecimal", ".");
                clave.SetValue("sGrouping", "3;0");
                clave.SetValue("sList", ",");
                clave.SetValue("s1159", "a.m");
                clave.SetValue("s2359", "p.m");
                clave.SetValue("sMonDecimalSep", ".");
                clave.SetValue("sMonGrouping", "3;0");
                clave.SetValue("sMonThousandSep", ",");
                clave.SetValue("sNativeDigits", "0123456789");
                clave.SetValue("sNegativeSign", "-");
                clave.SetValue("sShortDate", "dd/MM/yyyy");
                clave.SetValue("sShortTime", "hh:mm tt");
                clave.SetValue("sThousand", ",");
                clave.SetValue("sTime", ":");
                clave.SetValue("sTimeFormat", "hh:mm:ss tt");
                clave.SetValue("sYearMonth", "MMMM' de 'yyyy");
                clave.SetValue("iCalendarType", "1");
                clave.SetValue("iCountry", "51");
                clave.SetValue("iCurrDigits", "2");
                clave.SetValue("iCurrency", "2");
                clave.SetValue("iDate", "1");
                clave.SetValue("iDigits", "2");
                clave.SetValue("iFirstWeekOfYear", "0");
                clave.SetValue("iLZero", "1");
                clave.SetValue("iMeasure", "0");
                clave.SetValue("iNegCurr", "12");
                clave.SetValue("iNegNumber", "1");
                clave.SetValue("iPaperSize", "1");
                clave.SetValue("iCurrency", "2");
                clave.SetValue("iTime", "0");
                clave.SetValue("iTimePrefix", "0");
                clave.SetValue("iTLZeror", "1");
                clave.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace, ex.Message+ " "+ "Error al cambiar Configuracion Regional");
            }
        }
        public static DataTable RetornaTablaCabeceras(DataGridView grilla)
        {
            try
            {
                DataTable tabla = new DataTable();
                tabla.Columns.Add("DataProperty");
                tabla.Columns.Add("Header");
                tabla.Columns.Add("Data");
                foreach (DataGridViewColumn columna in grilla.Columns)
                {
                    if ((columna is DataGridViewTextBoxColumn || columna is DataGridViewCheckBoxColumn) && columna.Visible)
                    {
                        DataRow fila = tabla.NewRow();
                        fila[0] = columna.DataPropertyName;
                        fila[1] = columna.HeaderText;
                        fila[2] = columna.Name;
                        tabla.Rows.Add(fila);
                    }
                }
                return tabla;
            }
            catch
            {
                return new DataTable();
            }
        }
        public static void FormateaDataGridView(DataGridView dgv)
        {
            DataGridViewCellStyle CellAlternateStyle = new DataGridViewCellStyle();
            CellAlternateStyle.BackColor = System.Drawing.Color.Lavender;
            CellAlternateStyle.SelectionBackColor = System.Drawing.Color.Teal;
            dgv.AlternatingRowsDefaultCellStyle = CellAlternateStyle;
            dgv.BackgroundColor = System.Drawing.SystemColors.Window;
            DataGridViewCellStyle CellDefaultStyle = new DataGridViewCellStyle();
            CellDefaultStyle.SelectionBackColor = System.Drawing.Color.Teal;
            dgv.RowsDefaultCellStyle = CellDefaultStyle;
        }
        public static decimal RedondearDec(decimal num, int cant)
        {//Utilitarios.RedondearDec((dtoCDTemp.IMPTotal * (IGV_ / 100)), 2, MidpointRounding.AwayFromZero)
            try
            {
                return decimal.Round(num, cant, MidpointRounding.AwayFromZero);
            }
            catch
            {
                return 0.00M;
            }
        }
        #endregion Fin Otros Metodos

        public bool esValidaRutaCertificado(string ruta) //PV: 2019-09-07: Agregado
        {

            //Verificamos que exista ruta certificado 
            //if (!Directory.Exists(ruta))
            if (!File.Exists(ruta))
            {
              //  HelpPV.MsjShow("No se encontró certificado digital. Ver detalle", "Verificar que exista certificado en la siguiente ruta: \r\n" + ruta + "\r\n\r\nDe lo contrario cambiar ruta del certificado con su cuenta Administrador en Módulo Ventas / Configuraciones / Facturación Electrónica", true, EstiloMsj.Alerta);
                return false;
            }
            return true;
        }

        //public static string ObtenerRutaRpt(TipReporteGen tip) //PV: 2019-09-12: Agregado
        //{

        //    string ext = ".rpt"; //Extension
        //    if (tip == TipReporteGen.COM) //PV: 2019-10-09: Agregado
        //        ext = ".repx";

        //    string tipdoc = tip.ToString();
        //    string ruta = @"\ReportesCR\Personalizados\cr" + Session.RucEmpresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresaresa + tipdoc + ext; //".rpt"; 
        //    string path = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + ruta;

        //    if (!File.Exists(path.Trim()))
        //    {
        //        path = path.Replace(ruta, @"\ReportesCR\crGeneral" + tipdoc + ext);  //+".rpt");
        //    }


        //    return path;
        //}


    }


}
