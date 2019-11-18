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
        Byte[] Imagen;

        public FrmProductoCrea(ProductoModel productoModel) {
            Cd_Prod = productoModel.Cd_Prod;
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);

            ListarCategoria();
            ListarMarca();
            llernarDatos( productoModel);
        }


        private void FrmProductoCrea_Load(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty( Cd_Prod))
            {
                ListarCategoria();
                ListarMarca();
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

            if (cb_categoria.Text == "")
            {
                MessageBox.Show("Seleccione categoria");
                return false;
            }

            if (cb_marca.Text == "")
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
            cb_categoria.Text = "";
            cb_marca.Text = "";
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
                    cb_categoria.SelectedValue = row["Id_Categoria"].ToString();
                    cb_marca.SelectedValue = row["Id_Mca"].ToString();
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
                model.Id_Categoria = Convert.ToInt32(cb_categoria.SelectedValue);
                model.Id_Mca = Convert.ToInt32(cb_marca.SelectedValue);
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


            public void ListarCategoria()
            {

                ClassResult cr = new ClassResult();
                CategoriaBusiness ctr = new CategoriaBusiness();
                cr = ctr.Categoria_Cons();
                DataTable data = cr.Dt1;
                cb_categoria.DataSource = data;
                cb_categoria.ValueMember = "Id_Categoria";
                cb_categoria.DisplayMember = "Nombre";
            }


        public void FiltrarCategoria()
        {
            CategoriaBusiness ctr = new CategoriaBusiness();
            CategoriaModel model = new CategoriaModel();
            model.Nombre = cb_categoria.Text;
            cb_categoria.DataSource = ctr.BuscarCategoria(model);
            cb_categoria.ValueMember = "Id_Categoria";
            cb_categoria.DisplayMember = "Nombre";
        }



        public void ListarMarca()
        {

            ClassResult cr = new ClassResult();
            MarcaBusiness ctr = new MarcaBusiness();
            cr = ctr.Marca_Cons();
            DataTable data = cr.Dt1;
            cb_marca.DataSource = data;
            cb_marca.ValueMember = "Id_Mca";
            cb_marca.DisplayMember = "Nombre";
        }

        public void FiltrarMarca()
        {
            MarcaBusiness ctr = new MarcaBusiness();
            MarcaModel model = new MarcaModel();
            model.Nombre = cb_marca.Text;
            cb_marca.DataSource = ctr.BuscarMarca(model);
            cb_marca.ValueMember = "Id_Mca";
            cb_marca.DisplayMember = "Nombre";
        }


    

        private void Cb_categoria_TextChanged(object sender, EventArgs e)
        {
    
        }

        private void Cb_categoria_KeyUp(object sender, KeyEventArgs e)
        {
            FiltrarCategoria();
        }


        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Cb_marca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                FiltrarMarca();
            }
        }

        private void Cb_categoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                FiltrarCategoria();
            }
        }
    }
}
