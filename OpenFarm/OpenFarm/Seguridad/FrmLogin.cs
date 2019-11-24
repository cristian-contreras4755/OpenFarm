using Bussines;
using Common;
using Common.Help;
using Common.Seguridad;
using Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OpenFarm.Seguridad
{
    public partial class FrmLogin : MaterialSkin.Controls.MaterialForm
    {
        public FrmLogin()
        {


            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void Btn_salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_login_Click(object sender, EventArgs e)
        {

            try
            {

                if (String.IsNullOrEmpty(txt_usuario.Text) || String.IsNullOrEmpty(txt_contrasena.Text))
                {
                    MessageBox.Show("Por favor ingrese usuario y contraseña.", "Error al inicias session", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                }

                UsuarioBusiness ctr = new UsuarioBusiness();
                UsuarioModel model = new UsuarioModel();
                model.Usuario = txt_usuario.Text;
                model.Password = txt_contrasena.Text;

                ClassResult cr = ctr.Usuario_Login(model);
                if (cr.HuboError)
                {
                    MessageBox.Show(cr.ErrorMsj, "Error al inicias session", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    Limpiar();
                    return;
                }
                else
                {


                    if (cr.Dt1.Rows.Count > 0)
                    {
                        DataRow row = cr.Dt1.Rows[0];
                        Session.Id_Usuario = Convert.ToInt32(row["Id_Usuario"].ToString());
                        Session.Id_Rol = Convert.ToInt32(row["Id_Rol"].ToString());
                        Session.Rol = row["Rol"].ToString();
                        Principal fmr = new Principal();
                        fmr.Show();
                        this.Hide();

                    }
                    else
                    {
                        MessageBox.Show(cr.ErrorMsj, "Error al obtener datos de session, comunicate con tu proveedor de software.", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);

                        Limpiar();
                        return;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message, "Error Fatal al inicial session", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                Limpiar();
            }



        }


        public void Limpiar() {
            txt_usuario.Text = "";
            txt_contrasena.Text = "";

        }

    }
}
