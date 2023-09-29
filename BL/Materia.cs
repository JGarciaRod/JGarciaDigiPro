using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BL
{
    public class Materia
    {
        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    var rowAfected = context.GetAllMaterias().ToList();

                    if (rowAfected != null)
                    {
                        result.Objects = new List<object>();

                        foreach (var registro in rowAfected)
                        {
                            ML.Materia materia = new ML.Materia();
                            materia.IdMateria = registro.IdMateria;
                            materia.Nombre = registro.Nombre;
                            materia.costo = Convert.ToDecimal(registro.costo);

                            result.Objects.Add(materia);
                        }
                        result.Correct = true;
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

        public static ML.Result GetById(int idMateria)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    var rowAffected = context.GetByIdMateria(idMateria).SingleOrDefault();

                    result.Objects = new List<object>();

                    if (rowAffected != null)
                    {
                        ML.Materia materia = new ML.Materia();

                        materia.IdMateria = rowAffected.IdMateria;
                        materia.Nombre = rowAffected.Nombre;
                        materia.costo = rowAffected.costo.Value;

                        result.Object = materia;

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

        public static ML.Result Add(ML.Materia materia) 
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    int rowAfected = context.AddMateria(
                        materia.Nombre,
                        materia.costo
                        );

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
            catch(Exception e)
            {
                result.Correct = false;
                result.ErrorMessage = e.Message;
                result.Ex = e;
            }
            return result;
        }

        public static ML.Result Update(ML.Materia materia)
        {
            ML.Result result = new ML.Result();

            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    int rowAfected = context.UpdateMateria(
                        materia.IdMateria,
                        materia.Nombre,
                        materia.costo
                        );

                    if (rowAfected > 0)
                    {
                        result.Correct= true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Error al actualizar";
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

        public static ML.Result Dell(int id)
        {
            ML.Result result = new ML.Result();
            try
            {
                using (DL.ControlEscolarEntities context = new DL.ControlEscolarEntities())
                {
                    int rowAffected = context.DellMateria(id);

                    if(rowAffected > 0)
                    {
                        result.Correct= true;
                    }
                    else
                    {
                        result.Correct = false;
                        result.ErrorMessage = "Ocurrio un error al eliminar";
                    }
                }
            }
            catch (Exception E)
            {
                result.Correct = false;
                result.ErrorMessage = E.Message;
                result.Ex = E;
            }
            return result;
        }

    }
}
