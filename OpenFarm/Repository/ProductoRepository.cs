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
    public  class ProductoRepository
    {

        public ClassResult Producto_Crea(ProductoModel ProductoModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();            
                    Parameters.Add("@Nombre1", ProductoModel.Nombre1, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@Nombre2", ProductoModel.Nombre2, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);               
                    Parameters.Add("@Id_Categoria", ProductoModel.Id_Categoria, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Id_Presentacion", ProductoModel.Id_Presentacion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Id_Mca", ProductoModel.Id_Mca, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@NCorto", ProductoModel.NCorto, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@Descrip", ProductoModel.Descrip, dbType: DbType.String, direction: ParameterDirection.Input, size: 200);
                    // Parameters.Add("@CodBarras", ProductoModel.CodBarras, dbType: DbType.Binary, direction: ParameterDirection.Input);
                    Parameters.Add("@Img", ProductoModel.Img, dbType: DbType.Binary, direction: ParameterDirection.Input);
                    Parameters.Add("@StockMin", ProductoModel.StockMin, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@StockMax", ProductoModel.StockMax, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@IdUsuCrea", ProductoModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_producto_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Producto_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Producto_Crea()";
                return cr;
            }
        }

        public ClassResult Producto_Elim(ProductoModel ProductoModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Prod", ProductoModel.Cd_Prod, dbType: DbType.String, direction: ParameterDirection.Input, size: 7);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_producto_Elim", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Producto_Elim()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Producto_Elim()";
                return cr;
            }
        }

        public ClassResult Producto_Mdf(ProductoModel ProductoModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Prod", ProductoModel.Cd_Prod, dbType: DbType.String, direction: ParameterDirection.Input, size: 7);
                    Parameters.Add("@Id_Presentacion", ProductoModel.Id_Presentacion, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Nombre1", ProductoModel.Nombre1, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@Nombre2", ProductoModel.Nombre2, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@Id_Categoria", ProductoModel.Id_Categoria, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Id_Mca", ProductoModel.Id_Mca, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@NCorto", ProductoModel.NCorto, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@Descrip", ProductoModel.Descrip, dbType: DbType.String, direction: ParameterDirection.Input, size: 200);
                    // Parameters.Add("@CodBarras", ProductoModel.CodBarras, dbType: DbType.Binary, direction: ParameterDirection.Input);
                    Parameters.Add("@Img", ProductoModel.Img, dbType: DbType.Binary, direction: ParameterDirection.Input);
                    Parameters.Add("@StockMin", ProductoModel.StockMin, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@StockMax", ProductoModel.StockMax, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@IdUsuCrea", ProductoModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_producto_Mdf", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Producto_Mdf()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Producto_Mdf()";
                return cr;
            }
        }

        public ClassResult Producto_ConsUn(ProductoModel ProductoModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Productos");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    connection.Open();

                    SqlCommand SqlCmd = new SqlCommand();

                    SqlParameter ParCd_Prod = new SqlParameter();
                    ParCd_Prod.ParameterName = "@Cd_Prod";
                    ParCd_Prod.SqlDbType = SqlDbType.VarChar;
                    ParCd_Prod.Value = ProductoModel.Cd_Prod;
                    ParCd_Prod.Size = 7;
                    SqlCmd.Parameters.Add(ParCd_Prod);

                    SqlParameter Parmsg = new SqlParameter();
                    Parmsg.ParameterName = "@msj";
                    Parmsg.SqlDbType = SqlDbType.VarChar;
                    Parmsg.Size = 100;
                    Parmsg.Direction = ParameterDirection.Output;
                    SqlCmd.Parameters.Add(Parmsg);


                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_producto_consUn";
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
                        cr.LugarError = "Producto_ConsUn()";
                        return cr;
                    }
                }
            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Producto_ConsUn()";
                return cr;
            }
        }

        public ClassResult Producto_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Producto");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_producto_cons";
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
                cr.LugarError = "Producto_Cons()";
                return cr;
            }
        }

        public DataTable FiltrarProducto(ProductoModel ProductoModel)
        {
            DataTable DtResultado = new DataTable("cat");
            Conexion _conexion = new Conexion();
            try
            {
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_producto_filter";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParTextoaBuscar = new SqlParameter();
                    ParTextoaBuscar.ParameterName = "@textobuscar";
                    ParTextoaBuscar.SqlDbType = SqlDbType.VarChar;
                    ParTextoaBuscar.Size = 50;
                    ParTextoaBuscar.Value = ProductoModel.TextoBuscar;
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
