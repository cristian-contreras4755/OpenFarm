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
   public class IngresoRepository
    {

        public ClassResult IngresoCab_Crea(IngresoModel ingresoModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {

                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Ing", dbType: DbType.String, direction: ParameterDirection.Output, size: 12);
                    Parameters.Add("@Cd_TD", ingresoModel.Cd_TD, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@NroDoc", ingresoModel.NroDoc, dbType: DbType.String, direction: ParameterDirection.Input, size: 15);
                    Parameters.Add("@NroSre", ingresoModel.NroSre, dbType: DbType.String, direction: ParameterDirection.Input, size: 4);
                    Parameters.Add("@Cd_Mda", ingresoModel.Cd_Mda, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Proveedor", ingresoModel.FecMov, dbType: DbType.String, direction: ParameterDirection.Input, size: 100);
                    Parameters.Add("@BIM_Neto", ingresoModel.BIM_Neto, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 13, scale: 2);
                    Parameters.Add("@Igv", ingresoModel.Igv, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 15, scale: 7);
                    Parameters.Add("@Total", ingresoModel.Total, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 15, scale: 7);
                    Parameters.Add("@IdUsuCrea", ingresoModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_inv_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
                    string PCmsj = Parameters.Get<string>("@msj");
                    string PCd_Ing = Parameters.Get<string>("@Cd_Ing");
                    if (String.IsNullOrEmpty(PCmsj) && String.IsNullOrEmpty(PCd_Ing))
                    {
                        cr.HuboError = false;
                        return cr;
                    }
                    else
                    {
                        cr.HuboError = true;
                        cr.ErrorMsj = PCmsj;
                        cr.LugarError = "Inventario_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Inventario_Crea()";
                return cr;
            }
        }
        public ClassResult IngresoDet_Crea(IngresoDetModel ingresoDetModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {

                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Ing", ingresoDetModel.Cd_Ing, dbType: DbType.String, direction: ParameterDirection.Input, size: 12);
                    Parameters.Add("@Cd_Prod", ingresoDetModel.Cd_Prod, dbType: DbType.String, direction: ParameterDirection.Input, size: 7);
                    Parameters.Add("@Cd_UM", ingresoDetModel.Cd_UM, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Cant", ingresoDetModel.Cant, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@PrecioVta", ingresoDetModel.PrecioVta, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 15, scale: 7);
                    Parameters.Add("@PrecioCom", ingresoDetModel.PrecioCom, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 15, scale: 7);
                    Parameters.Add("@Stock_inicial", ingresoDetModel.Stock_inicial, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Stock_Actual", ingresoDetModel.Stock_Actual, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Fecha_produccion", ingresoDetModel.Fecha_produccion, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    Parameters.Add("@Fecha_vencimiento", ingresoDetModel.Fecha_vencimiento, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    Parameters.Add("@Total", ingresoDetModel.Total, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 15, scale: 7);
                    Parameters.Add("@IdUsuCrea", ingresoDetModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_IngresoDet_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Inventario_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Inventario_Crea()";
                return cr;
            }
        }
        public ClassResult Ingreso_Anula(IngresoModel ingresoModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                  //  Parameters.Add("@Cd_Inv", ingresoModel.Cd_Mov, dbType: DbType.String, direction: ParameterDirection.Input, size: 12);
                   // Parameters.Add("@Cd_Mov", ingresoModel.Cd_Mov, dbType: DbType.String, direction: ParameterDirection.Input, size: 12);
                    Parameters.Add("@IdUsuModf", ingresoModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);

                    var Result = conexion.ExecuteScalar("sp_venta_inv_Anula", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Inventario_Anula()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Inventario_Anula()";
                return cr;
            }
        }
    }
}
