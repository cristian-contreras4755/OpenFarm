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
   public class InventarioRepository
    {

        public ClassResult Inventario_Crea(InventarioModel inventarioModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Ejer", inventarioModel.Ejer, dbType: DbType.String, direction: ParameterDirection.Input, size: 4);
                    Parameters.Add("@Cd_Prod", inventarioModel.Cd_Prod, dbType: DbType.String, direction: ParameterDirection.Input, size: 7);
                    Parameters.Add("@Cd_TD", inventarioModel.Cd_TD, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Cd_TM", inventarioModel.Cd_TM, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Cd_Clt", inventarioModel.Cd_Clt, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@Cd_Vta", inventarioModel.Cd_Vta, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@Cd_TO", inventarioModel.Cd_TO, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Cd_UM", inventarioModel.Cd_UM, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Cd_Prov", inventarioModel.Cd_Prov, dbType: DbType.String, direction: ParameterDirection.Input, size: 7);
                    Parameters.Add("@FecMov", inventarioModel.FecMov, dbType: DbType.DateTime, direction: ParameterDirection.Input);
                    Parameters.Add("@Cd_Mda", inventarioModel.Cd_Mda, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@NroSre", inventarioModel.NroSre, dbType: DbType.String, direction: ParameterDirection.Input, size: 4);
                    Parameters.Add("@NroDoc", inventarioModel.NroDoc, dbType: DbType.String, direction: ParameterDirection.Input, size: 15);
                    Parameters.Add("@Item", inventarioModel.Item, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@CosUnt", inventarioModel.CosUnt, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 15, scale: 7);
                    Parameters.Add("@Total", inventarioModel.Total, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 15, scale: 7);
                    Parameters.Add("@IdUsuCrea", inventarioModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_inv_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
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
        public ClassResult Inventario_Anula(InventarioModel inventarioModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Inv", inventarioModel.Cd_Mov, dbType: DbType.String, direction: ParameterDirection.Input, size: 12);
                    Parameters.Add("@Cd_Mov", inventarioModel.Cd_Mov, dbType: DbType.String, direction: ParameterDirection.Input, size: 12);
                    Parameters.Add("@IdUsuModf", inventarioModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
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
