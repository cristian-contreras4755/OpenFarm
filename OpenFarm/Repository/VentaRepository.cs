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
    public  class VentaRepository
    {

        public ClassResult VentaCab_Crea(VentaCabModel VentaCabModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();

                    Parameters.Add("@Cd_Vta", dbType: DbType.String, direction: ParameterDirection.Output, size: 10);
                    Parameters.Add("@Cd_Sr", VentaCabModel.Cd_Sr, dbType: DbType.String, direction: ParameterDirection.Input, size: 7);
                    Parameters.Add("@Cd_TD", VentaCabModel.Cd_TD, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Cd_Mda", VentaCabModel.Cd_Mda, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@Cd_Clt", VentaCabModel.Cd_Clt, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@NroSre", VentaCabModel.NroSre, dbType: DbType.String, direction: ParameterDirection.Input, size: 5);
                    Parameters.Add("@NroDoc", VentaCabModel.NroDoc, dbType: DbType.String, direction: ParameterDirection.Input, size: 15);
                    Parameters.Add("@Obs", VentaCabModel.Obs, dbType: DbType.String, direction: ParameterDirection.Input, size: 1000);
                    Parameters.Add("@Valor", VentaCabModel.Valor, dbType: DbType.Decimal, direction: ParameterDirection.Input , precision: 13, scale: 2);
                    Parameters.Add("@TotDsctoP", VentaCabModel.TotDsctoP, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 5, scale: 2);
                    Parameters.Add("@TotDsctoI", VentaCabModel.TotDsctoI, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 13, scale: 2);
                    Parameters.Add("@ValorNeto", VentaCabModel.ValorNeto, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 13, scale: 2);
                    Parameters.Add("@BaseSinDscto", VentaCabModel.BaseSinDscto, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 13, scale: 2);
                    Parameters.Add("@BIM_Neto", VentaCabModel.BIM_Neto, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 13, scale: 2);
                    Parameters.Add("@IGV", VentaCabModel.IGV, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 13, scale: 2);
                    Parameters.Add("@Total", VentaCabModel.Total, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 13, scale: 2);
                    Parameters.Add("@IdUsuCrea", VentaCabModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_VentaCab_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
                    string PCmsj = Parameters.Get<string>("@msj");
                    string PCd_Vta = Parameters.Get<string>("@Cd_Vta");
                    if (String.IsNullOrEmpty(PCmsj) && ! String.IsNullOrEmpty(PCd_Vta))
                    {
                        cr.HuboError = false;
                        return cr;
                    }
                    else
                    {
                        cr.HuboError = true;
                        cr.ErrorMsj = PCmsj;
                        cr.LugarError = "VentaCab_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "VentaCab_Crea()";
                return cr;
            }
        }
        public ClassResult Venta_Anular(VentaCabModel VentaCabModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Clt", VentaCabModel.Cd_Clt, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_Anula", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Venta_Anular()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Venta_Anular()";
                return cr;
            }
        }
        public ClassResult Venta_Impreso(VentaCabModel VentaCabModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Cd_Vta", VentaCabModel.Cd_Vta, dbType: DbType.String, direction: ParameterDirection.Input, size: 10);
                    Parameters.Add("@DE_PDF", VentaCabModel.DE_PDF, dbType: DbType.Binary, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_Impreso", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Venta_Impreso()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Venta_Anular()";
                return cr;
            }
        }
        public ClassResult VentaDet_Crea(VentaDetModel VentaDetModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();

                    Parameters.Add("@Cd_Vta", VentaDetModel.Cd_Vta, dbType: DbType.String, direction: ParameterDirection.Output, size: 10);
                    Parameters.Add("@Cd_Prod", VentaDetModel.Cd_Prod, dbType: DbType.String, direction: ParameterDirection.Input, size: 7);
                    Parameters.Add("@Cant", VentaDetModel.Cant, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Cd_UM", VentaDetModel.Cd_UM, dbType: DbType.String, direction: ParameterDirection.Input, size: 2);
                    Parameters.Add("@PU", VentaDetModel.PU, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 16, scale: 7);
                    Parameters.Add("@Valor", VentaDetModel.Valor, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 16, scale: 7);
                    Parameters.Add("@DsctoP", VentaDetModel.DsctoP, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 5, scale: 2);
                    Parameters.Add("@DsctoI", VentaDetModel.DsctoI, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 16, scale: 7);

                    Parameters.Add("@IMP", VentaDetModel.IMP, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 16, scale: 7);
                    Parameters.Add("@IGV", VentaDetModel.IGV, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 16, scale: 7);
                    Parameters.Add("@Total", VentaDetModel.Total, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 16, scale: 7);
                    Parameters.Add("@TotalNeto", VentaDetModel.TotalNeto, dbType: DbType.Decimal, direction: ParameterDirection.Input, precision: 16, scale: 7);

                    Parameters.Add("@Obs", VentaDetModel.Obs, dbType: DbType.String, direction: ParameterDirection.Input, size: 1000);
                    Parameters.Add("@IdUsuCrea", VentaDetModel.IdUsuCrea, dbType: DbType.Int32, direction: ParameterDirection.Input);

                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_VentaCab_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
                    string PCmsj = Parameters.Get<string>("@msj");
                    string PCd_Vta = Parameters.Get<string>("@Cd_Vta");
                    if (String.IsNullOrEmpty(PCmsj) && !String.IsNullOrEmpty(PCd_Vta))
                    {
                        cr.HuboError = false;
                        return cr;
                    }
                    else
                    {
                        cr.HuboError = true;
                        cr.ErrorMsj = PCmsj;
                        cr.LugarError = "VentaCab_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "VentaCab_Crea()";
                return cr;
            }
        }
        public ClassResult TipoDoc_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("TipoDoc");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_TipoDoc_cons";
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
                cr.LugarError = "TipoDoc()";
                return cr;
            }
        }

    }
}
