using Common;
using Dapper;
using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UsuarioRepository
    {

        public ClassResult Usuario_Crea(UsuarioModel usuarioModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();

                    Parameters.Add("@Id_Rol", usuarioModel.Id_Rol, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@NDoc", usuarioModel.NDoc, dbType: DbType.String, direction: ParameterDirection.Input, size: 15);
                    Parameters.Add("@ApPat", usuarioModel.ApPat, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@ApMat", usuarioModel.ApMat, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Nom", usuarioModel.Nom, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Direc", usuarioModel.Direc, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@Telf1", usuarioModel.Telf1, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Telf2", usuarioModel.Telf2, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Correo", usuarioModel.Correo, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Cargo", usuarioModel.Cargo, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@IdUsuCrea", usuarioModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@usuario", usuarioModel.Usuario, dbType: DbType.String, direction: ParameterDirection.Input, size:50);
                    Parameters.Add("@Password", usuarioModel.Password, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 200);
                    var Result = conexion.ExecuteScalar("sp_seg_usuario_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
                    string PCmsj = Parameters.Get<string>("@msj");
                    if (String.IsNullOrEmpty(PCmsj))
                    {
                        cr.HuboError = false;
                        return cr;
                    }
                    else
                    {
                        cr.HuboError = true;
                        cr.ErrorMsj = PCmsj;
                        cr.LugarError = "Usuario_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Usuario_CreaMdf()";
                return cr;
            }
        }

        public ClassResult Usuario_Elim(UsuarioModel usuarioModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Id_Usuario", usuarioModel.Id_Usuario, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_seg_usuario_Elim", param: Parameters, commandType: CommandType.StoredProcedure);
                    string PCmsj = Parameters.Get<string>("@msj");
                    if (String.IsNullOrEmpty(PCmsj))
                    {
                        cr.HuboError = false;
                        return cr;
                    }
                    else
                    {
                        cr.HuboError = true;
                        cr.ErrorMsj = PCmsj;
                        cr.LugarError = "Usuario_Elim()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Usuario_CreaMdf()";
                return cr;
            }
        }

        public ClassResult Usuario_Mdf(UsuarioModel usuarioModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Id_Usuario", usuarioModel.Id_Usuario, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Id_Rol", usuarioModel.Id_Rol, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@NDoc", usuarioModel.NDoc, dbType: DbType.String, direction: ParameterDirection.Input, size: 15);
                    Parameters.Add("@ApPat", usuarioModel.ApPat, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@ApMat", usuarioModel.ApMat, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Nom", usuarioModel.Nom, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Direc", usuarioModel.Direc, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@Telf1", usuarioModel.Telf1, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Telf2", usuarioModel.Telf2, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Correo", usuarioModel.Correo, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Cargo", usuarioModel.Cargo, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@IdUsuCrea", usuarioModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@usuario", usuarioModel.Usuario, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Password", usuarioModel.Password, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 200);

                    var Result = conexion.ExecuteScalar("sp_seg_usuario_Mdf", param: Parameters, commandType: CommandType.StoredProcedure);
                    string PCmsj = Parameters.Get<string>("@msj");
                    if (String.IsNullOrEmpty(PCmsj))
                    {
                        cr.HuboError = false;
                        return cr;
                    }
                    else
                    {
                        cr.HuboError = true;
                        cr.ErrorMsj = PCmsj;
                        cr.LugarError = "Usuario_CreaMdf()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Usuario_CreaMdf()";
                return cr;
            }
        }

        public ClassResult Usuario_ConsUn(UsuarioModel usuarioModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Usuarios");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    connection.Open();

                    SqlCommand SqlCmd = new SqlCommand();

                    SqlParameter ParId_Usuario = new SqlParameter();
                    ParId_Usuario.ParameterName = "@Id_Usuario";
                    ParId_Usuario.SqlDbType = SqlDbType.Int;
                    ParId_Usuario.Value = usuarioModel.Id_Usuario;
                    SqlCmd.Parameters.Add(ParId_Usuario);

                    SqlParameter Parmsg = new SqlParameter();
                    Parmsg.ParameterName = "@msj";
                    Parmsg.SqlDbType = SqlDbType.VarChar;
                    Parmsg.Size = 100;
                    Parmsg.Direction= ParameterDirection.Output;
                    SqlCmd.Parameters.Add(Parmsg);



                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_seg_usuario_consUn";
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);

                    SqlCmd.ExecuteNonQuery();
                    connection.Close();
                    string PCmsj =SqlCmd.Parameters["@msj"].Value.ToString();


                    if (String.IsNullOrEmpty(PCmsj))
                    {
                        SqlDat.Fill(DtResultado);
                        cr.HuboError = false;
                        cr.Dt1 = DtResultado;
                        return cr;
                    }
                    else
                    {
                        cr.HuboError = true;
                        cr.ErrorMsj = PCmsj;
                        cr.LugarError = "Usuario_ConsUn()";
                        return cr;
                    }
                }
            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Usuario_ConsUn()";
                return cr;
            }
        }

        public ClassResult Usuario_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Usuario");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_seg_usuario_cons";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                    SqlDat.Fill(DtResultado);
                    cr.HuboError = false;
                    cr.Dt1 = DtResultado;
                    return cr;
                }
            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Usuario_Cons()";
                return cr;
            }
        }
        public ClassResult Rol_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Rol");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_seg_rol_cons";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                    SqlDat.Fill(DtResultado);
                    cr.HuboError = false;
                    cr.Dt1 = DtResultado;
                    return cr;
                }
            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "sp_seg_rol_cons()";
                return cr;
            }
        }
        public DataTable FiltrarUsuario(UsuarioModel usuarioModel)
        {
            DataTable DtResultado = new DataTable("cat");
            Conexion _conexion = new Conexion();
            try
            {
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_seg_usuario_filter";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParTextoaBuscar = new SqlParameter();
                    ParTextoaBuscar.ParameterName = "@Nombre";
                    ParTextoaBuscar.SqlDbType = SqlDbType.VarChar;
                    ParTextoaBuscar.Size = 50;
                    ParTextoaBuscar.Value = usuarioModel.Nom;
                    SqlCmd.Parameters.Add(ParTextoaBuscar);
                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);
                    SqlDat.Fill(DtResultado);

                }
            }
            catch (Exception ex)
            {
                DtResultado = null;
            }
            return DtResultado;
        }

    }
}
