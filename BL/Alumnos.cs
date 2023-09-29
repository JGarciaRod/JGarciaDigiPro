using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Alumnos
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "[dbo].[GetAllAlumnos]";

                    SqlCommand cmd = new SqlCommand(query, context);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);

                    DataTable tableAlumnos = new DataTable();

                    adapter.Fill(tableAlumnos);

                    if (tableAlumnos.Rows.Count > 0)
                    {
                        result.Objects = new List<object>();

                        foreach (DataRow row in tableAlumnos.Rows)
                        {
                            ML.Alumnos alumnos = new ML.Alumnos();

                            alumnos.IdAlumno = int.Parse(row[0].ToString());
                            alumnos.Nombre = row[1].ToString();
                            alumnos.ApellidoPaterno = row[2].ToString();
                            alumnos.ApellidoMaterno = row[3].ToString();

                            result.Objects.Add(alumnos);
                        }
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }

                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
                result.Ex = e;
            }
            return result;
        }

        public static ML.Result GetById(int IdAlumno)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "GetByIdAlumnos";

                    SqlCommand cmd = new SqlCommand(query, context);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] parm = new SqlParameter[1];

                    parm[0] = new SqlParameter("@IdAlumno", SqlDbType.Int);
                    parm[0].Value = IdAlumno;

                    cmd.Parameters.AddRange(parm);
                    cmd.Connection.Open();

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable tableAlumno = new DataTable();

                    adapter.Fill(tableAlumno);

                    if (tableAlumno.Rows.Count > 0)
                    {
                        DataRow row = tableAlumno.Rows[0];

                        ML.Alumnos alumnos = new ML.Alumnos();
                        alumnos.Nombre = row[1].ToString();
                        alumnos.ApellidoPaterno = row[2].ToString();
                        alumnos.ApellidoMaterno = row[3].ToString();

                        result.Object = alumnos;

                        result.Correct = true;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
                result.Ex = e;
            }
            return result;
        }

        public static ML.Result Add(ML.Alumnos alumno)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    var query = "AddAlumno";

                    SqlCommand cmd = new SqlCommand(query, context);
                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[3];

                    collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[0].Value = alumno.Nombre;

                    collection[1] = new SqlParameter("@ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = alumno.ApellidoPaterno;

                    collection[2] = new SqlParameter("ApellidoMaterno", SqlDbType.VarChar);
                    collection[2].Value = alumno.ApellidoMaterno;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
                result.Ex = e;
            }
            return result;
        }

        public static ML.Result Update(ML.Alumnos alumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "UpdateAlumno";

                    SqlCommand cmd = new SqlCommand();

                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Connection = context;
                    cmd.CommandText = query;

                    SqlParameter[] collection = new SqlParameter[4];

                    collection[0] = new SqlParameter("@Nombre", SqlDbType.VarChar);
                    collection[0].Value = alumno.Nombre;
                    collection[1] = new SqlParameter("ApellidoPaterno", SqlDbType.VarChar);
                    collection[1].Value = alumno.ApellidoPaterno;
                    collection[2] = new SqlParameter("@ApellidoMaterno",SqlDbType.VarChar);
                    collection[2].Value = alumno.ApellidoMaterno;

                    collection[3] = new SqlParameter("@IdAlumno", SqlDbType.Int);
                    collection[3].Value = alumno.IdAlumno;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch (Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
                result.Ex = e;
            }
            return result;
        }

        public static ML.Result Dell(int IdAlumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (SqlConnection context = new SqlConnection(DL.Conexion.GetConnectionString()))
                {
                    string query = "DellAlumno";

                    SqlCommand cmd = new SqlCommand(query, context);

                    cmd.CommandType = CommandType.StoredProcedure;

                    SqlParameter[] collection = new SqlParameter[1];

                    collection[0] = new SqlParameter("@IdAlumno", SqlDbType.Int);
                    collection[0].Value = IdAlumno;

                    cmd.Parameters.AddRange(collection);
                    cmd.Connection.Open();

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch(Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
                result.Ex = e;
            }
            return result;
        }

       
    }
}
