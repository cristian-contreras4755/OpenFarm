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
   public class MarcaRepository
    {

        public ClassResult Marca_Crea(MarcaModel MarcaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Nombre", MarcaModel.Nombre, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Descrip", MarcaModel.Descrip, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    Parameters.Add("@NCorto", MarcaModel.NCorto, dbType: DbType.String, direction: ParameterDirection.Input, size: 5);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 200);
                    var Result = conexion.ExecuteScalar("sp_venta_Marca_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Marca_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Marca_Crea()";
                return cr;
            }
        }

        public ClassResult Marca_Elim(MarcaModel MarcaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Id_Mca", MarcaModel.Id_Mca, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_Marca_Elim", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Marca_Elim()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Marca_CreaMdf()";
                return cr;
            }
        }


        public ClassResult Marca_Mdf(MarcaModel MarcaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Id_Mca", MarcaModel.Id_Mca, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Nombre", MarcaModel.Nombre, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Descrip", MarcaModel.Descrip, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    Parameters.Add("@NCorto", MarcaModel.NCorto, dbType: DbType.String, direction: ParameterDirection.Input, size: 5);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_Marca_Mdf", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Marca_Mdf()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Marca_Mdf()";
                return cr;
            }
        }

        public ClassResult Marca_ConsUn(MarcaModel MarcaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Marcas");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    connection.Open();

                    SqlCommand SqlCmd = new SqlCommand();

                    SqlParameter ParId_Marca = new SqlParameter();
                    ParId_Marca.ParameterName = "@Id_Mca";
                    ParId_Marca.SqlDbType = SqlDbType.Int;
                    ParId_Marca.Value = MarcaModel.Id_Mca;
                    SqlCmd.Parameters.Add(ParId_Marca);

                    SqlParameter Parmsg = new SqlParameter();
                    Parmsg.ParameterName = "@msj";
                    Parmsg.SqlDbType = SqlDbType.VarChar;
                    Parmsg.Size = 100;
                    Parmsg.Direction = ParameterDirection.Output;
                    SqlCmd.Parameters.Add(Parmsg);



                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_marca_consUn";
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
                        cr.LugarError = "Marca_ConsUn()";
                        return cr;
                    }
                }
            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Marca_ConsUn()";
                return cr;
            }
        }

        public ClassResult Marca_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Marca");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_marca_cons";
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
                cr.LugarError = "Marca_Cons()";
                return cr;
            }
        }

        public DataTable FiltrarMarca(MarcaModel MarcaModel)
        {
            DataTable DtResultado = new DataTable("cat");
            Conexion _conexion = new Conexion();
            try
            {
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_marca_filter";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParTextoaBuscar = new SqlParameter();
                    ParTextoaBuscar.ParameterName = "@Nombre";
                    ParTextoaBuscar.SqlDbType = SqlDbType.VarChar;
                    ParTextoaBuscar.Size = 50;
                    ParTextoaBuscar.Value = MarcaModel.Nombre;
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
