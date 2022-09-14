using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CapaAccesoDatos
{
    public class Cls_Parametros
    {
        public string nombre { get; set; }
        public object valor { get; set; }
        public SqlDbType tipoDato { get; set; }
        public Int32 tamaño { get; set; }
        public ParameterDirection direccionparametro { get; set; }

        public Cls_Parametros(String objNombre, Object objValor)
        {
            nombre = objNombre;
            valor = objValor;
            direccionparametro = ParameterDirection.Input;
        }

        public Cls_Parametros(String objNombre, SqlDbType objTipoDato, Int32 objTamaño)
        {
            nombre = objNombre;
            tipoDato = objTipoDato;
            tamaño = objTamaño;
            direccionparametro = ParameterDirection.Output;
        }

    }


    public class Acceso_datos
    {
        SqlConnection conexion;
        SqlCommand cmd;
        SqlDataReader lectorDatos = null;
        SqlDataAdapter da;
        DataTable dt;

        public string abrirBd()
        {
            string resultado = "";
            try
            {
                conexion = new SqlConnection("Data Source=PC-GAMER-MEJIA\\SQLEXPRESS;Initial Catalog =[DBFACTURAS]; Integrated Security = True");
                conexion.Open();
            }
            catch (Exception ex)
            {
                resultado = "falló la conexion" + ex;
            }
            return resultado;
        }

        public string cerrarBd()
        {
            string resultado = "";
            try
            {
                conexion.Close();
            }
            catch (Exception ex)
            {
                resultado = "falló cerrar la conexion" + ex;
            }

            return resultado;
        }

        public string Ejecutar_procedimiento(string procedimiento, List<Cls_Parametros> lst)
        {
            string salida = "";
            try
            {
                int retornado;

                abrirBd();
                SqlCommand comando = new SqlCommand(procedimiento, conexion);
                comando.CommandType = CommandType.StoredProcedure;

                if (lst != null)
                {
                    for (int i = 0; i < lst.Count; i++)
                    {
                        if (lst[i].direccionparametro == ParameterDirection.Input)
                        {
                            comando.Parameters.AddWithValue(lst[i].nombre, lst[i].valor);
                        }
                        if (lst[i].direccionparametro == ParameterDirection.Output)
                        {
                            comando.Parameters.Add(lst[i].nombre, lst[i].tipoDato, lst[i].tamaño).Direction = ParameterDirection.Output;
                        }
                    }
                }
                retornado = comando.ExecuteNonQuery();
                cerrarBd();

                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }
            }
            catch (Exception ex)
            {
                salida = "Falló operación: " + ex;
            }

            return salida;
        }

        public string EjecutarComando(string sentencia)
        {
            string salida = "";
            try
            {
                int retornado;
                abrirBd();
                cmd = new SqlCommand(sentencia, conexion);
                retornado = cmd.ExecuteNonQuery();
                cerrarBd();
                if (retornado > 0)
                {
                    salida = "Los datos fueron actualizados";
                }
                else
                {
                    salida = "Los datos no fueron actualizados";
                }

            }
            catch (Exception ex)
            {
                salida = "Falló la operación:" + ex;
            }

            return salida;
        }

        public DataTable EjecutarConsulta(string cmd)
        {
            try
            {
                abrirBd();
                da = new SqlDataAdapter(cmd, conexion);
                dt = new DataTable();
                da.Fill(dt);
                cerrarBd();
                return dt;
            }
            catch (Exception)
            {
                return null;
            }
        }


    }
}
