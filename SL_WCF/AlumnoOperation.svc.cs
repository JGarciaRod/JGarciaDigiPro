using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace SL_WCF
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AlumnoOperation" en el código, en svc y en el archivo de configuración a la vez.
    // NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AlumnoOperation.svc o AlumnoOperation.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class AlumnoOperation : IAlumnoOperation
    {
        public Result Add(ML.Alumnos alumnos)
        {
            ML.Result result = BL.Alumnos.Add(alumnos);

            return new Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public Result Update(ML.Alumnos alumnos)
        {
            ML.Result result = BL.Alumnos.Update(alumnos);

            return new Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public Result Delete(ML.Alumnos alumnos)
        {
            ML.Result result = BL.Alumnos.Dell(alumnos.IdAlumno);

            return new Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public Result GetAll()
        {
            ML.Result result = BL.Alumnos.GetAll();

            return new Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }

        public Result GetById(ML.Alumnos alumnos)
        {
            ML.Result result = BL.Alumnos.GetById(alumnos.IdAlumno);

            return new Result
            {
                Correct = result.Correct,
                ErrorMassage = result.ErrorMessage,
                Ex = result.Ex,
                Object = result.Object,
                Objects = result.Objects,
            };
        }
    }
}
