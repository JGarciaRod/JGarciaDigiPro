using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class AlumnoMateria
    {
        public static ML.Result GetMateriasAsignadas(int IdAlumno)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    ML.AlumnoMateria alumno = new ML.AlumnoMateria();
                    alumno.Alumno = new ML.Alumnos();
                    alumno.Alumno.IdAlumno = IdAlumno;

                    var rowAffected = context.GetMateriasAlumno(alumno.Alumno.IdAlumno);

                    if(rowAffected != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var item in rowAffected)
                        {
                            ML.AlumnoMateria Materia = new ML.AlumnoMateria();
                            Materia.Materia = new ML.Materia();

                            Materia.Materia.IdMateria = item.IdMateria;
                            Materia.Materia.Nombre = item.Nombre;
                            Materia.Materia.costo = Convert.ToDecimal(item.costo);

                            result.Objects.Add(Materia);
                        }
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

        public static ML.Result GetMateriasNoAsignadas(int IdAlumno)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    ML.AlumnoMateria alumno = new ML.AlumnoMateria();
                    alumno.Alumno = new ML.Alumnos();
                    alumno.Alumno.IdAlumno = IdAlumno;

                    var rowAffected = context.GetMateriasNoAsignadas(IdAlumno);

                    if (rowAffected != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var registro in rowAffected)
                        {
                            ML.AlumnoMateria Materia = new ML.AlumnoMateria();
                            Materia.Materia = new ML.Materia();

                            Materia.Materia.IdMateria = registro.IdMateria;
                            Materia.Materia.Nombre = registro.Nombre;
                            Materia.Materia.costo = Convert.ToDecimal(registro.costo);

                            result.Objects.Add(Materia);
                        }
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

        public static ML.Result AddMateria(int idAlumo, int idMateria)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    int rowAfected = context.AddAlumoMateria(idAlumo, idMateria);

                    if(rowAfected > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al incertar";
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

        public static ML.Result DellMateria(int idAlumno,int idMateria)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    int rowAffect = context.DellAlumoMateria(idAlumno, idMateria);

                    if (rowAffect > 0)
                    {
                        result.Correct = true;
                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch(Exception ex)
            {
                result.Correct = false;
                result.ErrorMessage = ex.Message;
                result.Ex = ex;
            }
            return result;

        }

    }
}
