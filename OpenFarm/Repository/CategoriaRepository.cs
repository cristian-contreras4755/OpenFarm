﻿using Common;
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
    public class CategoriaRepository
    {

        public ClassResult Categoria_Crea(CategoriaModel categoriaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Nombre", categoriaModel.Nombre, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Descripcion", categoriaModel.Descripcion, dbType: DbType.String, direction: ParameterDirection.Input, size:250);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 200);
                    var Result = conexion.ExecuteScalar("sp_venta_categoria_Crea", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Categoria_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Categoria_CreaMdf()";
                return cr;
            }
        }

        public ClassResult Categoria_Elim(CategoriaModel categoriaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Id_Categoria", categoriaModel.Id_Categoria, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_categoria_Elim", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Categoria_Elim()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Categoria_CreaMdf()";
                return cr;
            }
        }

        public ClassResult Categoria_Mdf(CategoriaModel categoriaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                using (IDbConnection conexion = new SqlConnection(_conexion.Getconnection()))
                {
                    var Parameters = new DynamicParameters();
                    Parameters.Add("@Id_Categoria", categoriaModel.Id_Categoria, dbType: DbType.Int32, direction: ParameterDirection.Input);
                    Parameters.Add("@Nombre", categoriaModel.Nombre, dbType: DbType.String, direction: ParameterDirection.Input, size: 50);
                    Parameters.Add("@Descripcion", categoriaModel.Descripcion, dbType: DbType.String, direction: ParameterDirection.Input, size: 250);
                    Parameters.Add("@msj", dbType: DbType.String, direction: ParameterDirection.Output, size: 100);
                    var Result = conexion.ExecuteScalar("sp_venta_categoria_Mdf", param: Parameters, commandType: CommandType.StoredProcedure);
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
                        cr.LugarError = "Categoria_Crea()";
                        return cr;
                    }
                }

            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Categoria_CreaMdf()";
                return cr;
            }
        }

        public ClassResult Categoria_ConsUn(CategoriaModel categoriaModel)
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Categorias");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    connection.Open();

                    SqlCommand SqlCmd = new SqlCommand();

                    SqlParameter ParId_Categoria = new SqlParameter();
                    ParId_Categoria.ParameterName = "@Id_Categoria";
                    ParId_Categoria.SqlDbType = SqlDbType.Int;
                    ParId_Categoria.Value = categoriaModel.Id_Categoria;
                    SqlCmd.Parameters.Add(ParId_Categoria);

                    SqlParameter Parmsg = new SqlParameter();
                    Parmsg.ParameterName = "@msj";
                    Parmsg.SqlDbType = SqlDbType.VarChar;
                    Parmsg.Size = 100;
                    Parmsg.Direction= ParameterDirection.Output;
                    SqlCmd.Parameters.Add(Parmsg);



                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_categoria_consUn";
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
                        cr.LugarError = "Categoria_ConsUn()";
                        return cr;
                    }
                }
            }
            catch (Exception ex)
            {
                cr.HuboError = true;
                cr.ErrorMsj = ex.Message;
                cr.LugarError = "Categoria_ConsUn()";
                return cr;
            }
        }

        public ClassResult Categoria_Cons()
        {
            ClassResult cr = new ClassResult();
            Conexion _conexion = new Conexion();
            try
            {
                DataTable DtResultado = new DataTable("Categoria");
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {

                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_categoria_cons";
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
                cr.LugarError = "Categoria_Cons()";
                return cr;
            }
        }

        public DataTable FiltrarCategoria(CategoriaModel categoriaModel)
        {
            DataTable DtResultado = new DataTable("cat");
            Conexion _conexion = new Conexion();
            try
            {
                using (SqlConnection connection = new SqlConnection(_conexion.Getconnection()))
                {
                    SqlCommand SqlCmd = new SqlCommand();
                    SqlCmd.Connection = connection;
                    SqlCmd.CommandText = "sp_venta_categoria_filter";
                    SqlCmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter ParTextoaBuscar = new SqlParameter();
                    ParTextoaBuscar.ParameterName = "@Nombre";
                    ParTextoaBuscar.SqlDbType = SqlDbType.VarChar;
                    ParTextoaBuscar.Size = 50;
                    ParTextoaBuscar.Value = categoriaModel.Nombre;
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
