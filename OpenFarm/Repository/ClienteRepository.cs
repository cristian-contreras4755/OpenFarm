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
   public class ClienteRepository
    {

        public ClassResult Cliente_Crea(ClienteModel ClienteModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_TDI", ClienteModel.Cd_TDI, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@NDoc", ClienteModel.NDoc, dbType: DbType.String, direction: ParameterDirection.Input, size: 15);
                    Parameters.Add("@TipoCliente", ClienteModel.TipoCliente, dbType: DbType.Boolean, direction: ParameterDirection.Input);
                    Parameters.Add("@RSocial", ClienteModel.RSocial, dbType: DbType.String, direction: ParameterDirection.Input, size: 150);
                    Parameters.Add("@NComercial", ClienteModel.NComercial, dbType: DbType.String, direction: ParameterDirection.Input, size: 150);
                    Parameters.Add("@ApPat", ClienteModel.ApPat, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@ApMat", ClienteModel.ApMat, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Nom", ClienteModel.Nom, dbType: DbType.String, direction: ParameterDirection.Input, size: 70);
                    Parameters.Add("@Direc", ClienteModel.Direc, dbType: DbType.String, direction: ParameterDirection.Input, size: 200);
                    Parameters.Add("@Telf", ClienteModel.Telf, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Correo", ClienteModel.Correo, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@IdUsuCrea", ClienteModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_cliente_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Cliente_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Cliente_Crea()";
                return cr;
            }
        }

        public ClassResult Cliente_Elim(ClienteModel ClienteModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Clt", ClienteModel.Cd_Clt, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_cliente_Elim", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Cliente_Elim()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Cliente_Elim()";
                return cr;
            }
        }

        public ClassResult Cliente_Mdf(ClienteModel ClienteModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Clt", ClienteModel.Cd_Clt, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@Cd_TDI", ClienteModel.Cd_TDI, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@TipoCliente", ClienteModel.TipoCliente, dbType: DbType.Boolean, direction: ParameterDirection.Input);
                    Parameters.Add("@NDoc", ClienteModel.NDoc, dbType: DbType.String, direction: ParameterDirection.Input, size: 15);
                    Parameters.Add("@RSocial", ClienteModel.RSocial, dbType: DbType.String, direction: ParameterDirection.Input, size: 150);
                    Parameters.Add("@NComercial", ClienteModel.NComercial, dbType: DbType.String, direction: ParameterDirection.Input, size: 150);
                    Parameters.Add("@ApPat", ClienteModel.ApPat, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@ApMat", ClienteModel.ApMat, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Nom", ClienteModel.Nom, dbType: DbType.String, direction: ParameterDirection.Input, size: 70);
                    Parameters.Add("@Direc", ClienteModel.Direc, dbType: DbType.String, direction: ParameterDirection.Input, size: 200);
                    Parameters.Add("@Telf", ClienteModel.Telf, dbType: DbType.String, direction: ParameterDirection.Input, size: 20);
                    Parameters.Add("@Correo", ClienteModel.Correo, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@IdUsuCrea", ClienteModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_Cliente_Mdf", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Cliente_Mdf()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Cliente_Mdf()";
                return cr;
            }
        }

        public ClassResult Cliente_ConsUn(ClienteModel ClienteModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Clientes");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    connection.Open();

                    SqlCommand SqlCmd = new SqlCommand();

                    SqlParameter ParCd_Clt = new SqlParameter();
                    ParCd_Clt.ParameterName = "@Cd_Clt";
                    ParCd_Clt.SqlDbType = SqlDbType.VarChar;
                    ParCd_Clt.Value = ClienteModel.Cd_Clt;
                    ParCd_Clt.Size = 10;
                    SqlCmd.Parameters.Add(ParCd_Clt);

                    SqlParameter Parmsg = new SqlParameter();
                    Parmsg.ParameterName = "@msj";
                    Parmsg.SqlDbType = SqlDbType.VarChar;
                    Parmsg.Size = 100;
                    Parmsg.Direction = ParameterDirection.Output;
                    SqlCmd.Parameters.Add(Parmsg);


                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_cliente_consUn";
                    SqlCmd.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter SqlDat = new SqlDataAdapter(SqlCmd);

                    SqlCmd.ExecuteNonQuery();
                    connection.Close();
                    string PCmsj = SqlCmd.Parameters["@msj"].Value.ToString();


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
                        cr.LugarError = "Cliente_ConsUn()";
                        return cr;
                    }
                }
            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Cliente_ConsUn()";
                return cr;
            }
        }

        public ClassResult Cliente_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("cliente");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_cliente_cons";
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
                cr.LugarError = "Cliente_Cons()";
                return cr;
            }
        }

        public DataTable FiltrarCliente(ClienteModel ClienteModel)
        {
            DataTable DtResultado = new DataTable("cliente");
            Conexion _conexion = new Conexion();
            try
            {
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_cliente_filter";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParTextoaBuscar = new SqlParameter();
                    ParTextoaBuscar.ParameterName = "@textobuscar";
                    ParTextoaBuscar.SqlDbType = SqlDbType.VarChar;
                    ParTextoaBuscar.Size = 50;
                    ParTextoaBuscar.Value = ClienteModel.TextoBuscar;
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

        public ClassResult TipoDocIdn_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("TipoDocIdn_Cons");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_TipoDocIdn_cons";
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
                cr.LugarError = "TipoDocIdn_Cons()";
                return cr;
            }
        }

    }
}
