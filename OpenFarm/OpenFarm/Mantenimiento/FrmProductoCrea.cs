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
    public partial class FrmProductoCrea :  MaterialSkin.Controls.MaterialForm
    {
        public FrmProductoCrea()
        {
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        string  Cd_Prod="";
        int Id_Categoria = 0;
        int Id_Mca = 0;
       int Id_Presentacion= 0;


        Byte[] Imagen;

        public FrmProductoCrea(ProductoModel productoModel) {
            Cd_Prod = productoModel.Cd_Prod;
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
            llernarDatos( productoModel);
        }


        private void FrmProductoCrea_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty( Cd_Prod))
            {
            }
        }

        private void Btn_buscar_img_Click(object sender, EventArgs e)
        {
            try
            {
                bool selecciono;
                string archivo;
                OFD_imagen.Title = "Seleccionar Foto";
                OFD_imagen.Filter = "Todas las imagenes (*.*)|*.*| Imagenes gif (*.gif)|*.gif| Imagenes jpg (*.jpg)|*.jpg";

                if (OFD_imagen.ShowDialog() == DialogResult.OK)
                {
                    archivo = OFD_imagen.FileName;
                    selecciono = true;
                }
                else return;

                if (selecciono)
                {
                    //editado = true;
                    FileStream fsFoto = new FileStream(archivo, FileMode.Open);
                    FileInfo fiFoto = new FileInfo(archivo);
                    long temp = fiFoto.Length;
                    int len = int.Parse(temp + "");
                    byte[] pic = new byte[len];
                    fsFoto.Read(pic, 0, len);
                    fsFoto.Close();
                    pic_producto.Image = Image.FromFile(archivo);
                    Imagen = pic;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }



        public bool Validar()
        {

            if (txt_nom1.Text == "")
            {
                MessageBox.Show("Ingrese nombre producto");
                return false;
            }

            if (nud_stockmin.Value == 0)
            {
                MessageBox.Show("Ingrese stock Minimo");
                return false;
            }

            if (nud_stockmax.Value == 0)
            {
                MessageBox.Show("Ingrese stock Maximo");
                return false;
            }





            if (txt_categoria.Text == "" || Id_Categoria==0)
            {
                MessageBox.Show("Seleccione categoria");
                return false;
            }

            if (txt_presentacion.Text == ""  ||Id_Presentacion == 0)
            {
                MessageBox.Show("Seleccione categoria");
                return false;
            }

            if (txt_marca.Text == ""|| Id_Mca == 0)
            {
                MessageBox.Show("Seleccione Marca");
                return false;
            }


            return true;
        }

        public void incializarControles()
        {
            txt_nom1.Text = "";
            txt_nom2.Text = "";
            txt_nomcorto.Text = "";
            txt_Descripcion.Text = "";
             Id_Categoria = 0;
             Id_Mca = 0;
             Id_Presentacion = 0;
            txt_categoria.Text = "";
            txt_presentacion.Text = "";
            txt_marca.Text = "";
            nud_stockmin.Value = 0;
            nud_stockmax.Value = 0;
            btn_cancelar.Visible = false;
            Cd_Prod = "";
        }



        public void llernarDatos(ProductoModel productoModel) {

            try
            {

                ProductoBusiness ctr = new ProductoBusiness();
                ProductoModel model = new ProductoModel();
                model.Cd_Prod = productoModel.Cd_Prod;

                ClassResult cr = ctr.Producto_ConsUn(model);
                if (cr.Dt1.Rows.Count > 0)
                {
                    DataRow row = cr.Dt1.Rows[0];
                    txt_nom1.Text = row["Nombre1"].ToString();
                    txt_nom2.Text = row["Nombre2"].ToString();
                    txt_nomcorto.Text = row["NCorto"].ToString();
                    txt_Descripcion.Text = row["Descrip"].ToString();

                    txt_categoria.Text = row["Categoria"].ToString();
                    txt_marca.Text = row["Marca"].ToString();
                    txt_presentacion.Text = row["Presentacion"].ToString();

                    Id_Categoria = Convert.ToInt32(row["Id_Categoria"].ToString());  
                    Id_Mca = Convert.ToInt32(row["Id_Mca"].ToString());
                    Id_Presentacion = Convert.ToInt32(row["Id_Presentacion"].ToString());

                    nud_stockmin.Value = Convert.ToInt32(row["StockMin"].ToString());
                    nud_stockmax.Value = Convert.ToInt32(row["StockMax"].ToString());

                    if (!(row["Img"]==DBNull.Value))
                    {
                        Byte[] data = new Byte[0];
                        data = (Byte[])(row["Img"]);
                        Imagen = data;
                        MemoryStream mem = new MemoryStream(data);
                        pic_producto.Image = Image.FromStream(mem);
                    }
                    
                    Cd_Prod = productoModel.Cd_Prod;           
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message + "-" + ex.StackTrace.ToString());
                this.Dispose();
            }
        }




        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {


                if (!Validar())
                {
                    return;
                }

                ProductoBusiness ctr = new ProductoBusiness();
                ProductoModel model = new ProductoModel();
                model.Nombre1 = txt_nom1.Text;
                model.Nombre2 = txt_nom2.Text;
                model.NCorto = txt_nomcorto.Text;
                model.Descrip = txt_Descripcion.Text;
                model.Id_Categoria = Id_Categoria;
                model.Id_Presentacion = Id_Presentacion;
                model.Id_Mca = Id_Mca;
                model.StockMin = Convert.ToInt32(nud_stockmin.Value);
                model.StockMax = Convert.ToInt32(nud_stockmax.Value);

                if (Imagen==null)
                {
                    model.Img = null;
                }
                else
                {
                    model.Img = Imagen;
                }

                if (Cd_Prod == "")
                {
                    ClassResult cr = ctr.Producto_Crea(model);
                    if (cr.HuboError)
                    {
                        MessageBox.Show("error: " + cr.ErrorMsj);
                    }
                    else
                    {
                        incializarControles();
                        this.Dispose();
                    }

                }
                else if (Cd_Prod != "")
                {
                    model.Cd_Prod = Cd_Prod;
                    ClassResult cr = ctr.Producto_Mdf(model);
                    if (cr.HuboError)
                    {

                        MessageBox.Show("error: " + cr.ErrorMsj);

                    }
                    else
                    {
                        incializarControles();
                        this.Dispose();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error  al getionar el registro o  actualizacion de producto : " + ex.Message);
            }
        }


     









        private void Cb_categoria_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void Cb_categoria_KeyUp(object sender, KeyEventArgs e)
        {
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cb_marca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Cb_categoria_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Cb_presentacion_KeyPress(object sender, KeyPressEventArgs e)
        {

        }






        private void Btn_buscarMarca_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDialogMarca())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txt_marca.Text = form.MarcaModel.Nombre;
                    Id_Mca = form.MarcaModel.Id_Mca;
                }
            }
        }

        private void Btn_buscarCategoria_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDialogCategoria())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txt_categoria.Text = form.CategoriaModel.Nombre;
                    Id_Categoria = form.CategoriaModel.Id_Categoria;
                }
            }
        }

        private void Btn_buscarPresentacion_Click(object sender, EventArgs e)
        {

            using (var form = new FrmDialogPresentacion())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txt_presentacion.Text = form.PresentacionModel.Nombre;
                    Id_Presentacion = form.PresentacionModel.Id_Presentacion;
                }
            }

        }
    }
}
