using Bussines;
using Common;
using Common.Help;
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
    public partial class FrmUsuarioCrea : MaterialSkin.Controls.MaterialForm
    {
        public FrmUsuarioCrea()
        {
        InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
        }

        private int Id_Rol = 0;
        private int Id_Usuario = 0;


        public FrmUsuarioCrea(UsuarioModel usuarioModel)
        {
            Id_Usuario = usuarioModel.Id_Usuario;
            InitializeComponent();
            HelpTeme teme = new HelpTeme();
            teme.InicializarTema(this);
            llernarDatos(usuarioModel);
        }



        private void FrmUsuarioCrea_Load(object sender, EventArgs e)
        {

        }



        public bool Validar()
        {

            if (String.IsNullOrEmpty(txt_rol.Text) || Id_Rol==0)
            {
                MessageBox.Show("Seleccione Rol");
                return false;
            }

            if (String.IsNullOrEmpty(txt_ndoc.Text) || txt_ndoc.Text.Length<8)
            {
                MessageBox.Show("Ingrese  Nro. de documento del trabajador, asegurse que el nro de documento sea mayor o igual a 8 caracteres");
                return false;
            }


            if (String.IsNullOrEmpty(txt_nombre.Text) )
            {
                MessageBox.Show("Ingrese  nombre ");
                return false;
            }

            if (String.IsNullOrEmpty(txt_ap_pat.Text))
            {
                MessageBox.Show("Ingrese  apellido Paterno ");
                return false;
            }


            if (String.IsNullOrEmpty(txt_ap_mat.Text))
            {
                MessageBox.Show("Ingrese  apellido materno ");
                return false;
            }


            if (String.IsNullOrEmpty(txt_usuario.Text))
            {
                MessageBox.Show("Ingrese  Usuario a asignar ");
                return false;
            }

            if (String.IsNullOrEmpty(txt_usuario.Text))
            {
                MessageBox.Show("Ingrese  contraseña");
                return false;
            }

            return true;
        }


        public void incializarControles()
        {
            txt_ap_mat.Text = "";
            txt_ap_pat.Text = "";
            txt_cargo.Text = "";
            txt_correo.Text = "";
            Id_Rol = 0;
            Id_Usuario = 0;
            txt_dir.Text = "";
            txt_ndoc.Text = "";
            txt_nombre.Text = "";          
            txt_rol.Text = "";
            txt_tel1.Text = "";
            txt_tel2.Text = "";
            txt_usuario.Text = "";
            txt_password.Text = "";
            btn_cancelar.Visible = false;
        }



        private void Btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {

                if (!Validar())
                {
                    return;
                }

                UsuarioBusiness ctr = new UsuarioBusiness();
                UsuarioModel model = new UsuarioModel();
              //  model.Id_Usuario = Id_Usuario;
                model.Id_Rol = Id_Rol;
                model.NDoc = txt_ndoc.Text;
                model.Nom = txt_nombre.Text;
                model.ApPat = txt_ap_pat.Text;
                model.ApMat = txt_ap_mat.Text;
                model.Direc = txt_dir.Text;
                model.Telf1 = txt_tel1.Text;
                model.Telf2 = txt_tel2.Text;
                model.Correo = txt_correo.Text;
                model.Cargo = txt_cargo.Text;
                model.Usuario = txt_usuario.Text;
                model.Password = txt_password.Text;
                model.IdUsuCrea =0;


                if (Id_Usuario == 0)
                {
                    ClassResult cr = ctr.Usuario_Crea(model);
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
                else if (Id_Usuario  != 0)
                {
                    model.Id_Usuario = Id_Usuario;
                    ClassResult cr = ctr.Usuario_Mdf(model);
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
                MessageBox.Show("Error  al getionar el registro o  actualizacion de  usuarios  : " + ex.Message);
            }
        }


        public void llernarDatos(UsuarioModel usuarioModel)
        {

            try
            {

                UsuarioBusiness ctr = new UsuarioBusiness();
                UsuarioModel model = new UsuarioModel();
                model.Id_Usuario = usuarioModel.Id_Usuario;

                ClassResult cr = ctr.Usuario_ConsUn(model);
                if (cr.Dt1.Rows.Count > 0)
                {
                    DataRow row = cr.Dt1.Rows[0];
                     txt_rol.Text = row["Rol"].ToString();
                    txt_ndoc.Text = row["NDoc"].ToString();
                    txt_nombre.Text = row["Nom"].ToString();
                    txt_ap_pat.Text = row["ApPat"].ToString();
                    txt_ap_mat.Text = row["ApMat"].ToString();
                    txt_dir.Text = row["Direc"].ToString();
                    txt_tel1.Text = row["Telf1"].ToString();
                    txt_tel2.Text = row["Telf2"].ToString();
                    txt_correo.Text = row["Correo"].ToString();
                    txt_cargo.Text = row["Cargo"].ToString();
                    txt_usuario.Text = row["usuario"].ToString();
                    txt_password.Text = row["Password"].ToString();
                    Id_Rol = Convert.ToInt32(row["Id_Rol"].ToString());
                   Id_Usuario = Convert.ToInt32(row["Id_Usuario"].ToString());

    }

}
            catch (Exception ex)
            {
                MessageBox.Show("error :" + ex.Message + "-" + ex.StackTrace.ToString());
                this.Dispose();
            }
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_buscarRol_Click(object sender, EventArgs e)
        {
            using (var form = new FrmDialogRol())
            {
                var result = form.ShowDialog();
                if (result == DialogResult.OK)
                {
                    txt_rol.Text = form.rolModel.Nombre;
                    Id_Rol = form.rolModel.Id_Rol;
                }
            }
        }
    }
}
