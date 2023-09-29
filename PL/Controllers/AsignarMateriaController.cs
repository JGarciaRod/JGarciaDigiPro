using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI.WebControls;

namespace PL.Controllers
{
    public class AsignarMateriaController : Controller
    {
        // GET: AsignarMateria
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Alumnos alumnos = new ML.Alumnos();
            ML.Result result = BL.Alumnos.GetAll();

            if (result.Correct)
            {
                alumnos.TAlumnos = result.Objects.ToList();
            }
            else
            {
                ViewBag.Message = result.ErrorMessage;
            }
            return View(alumnos);
        }
        [HttpGet]
        public ActionResult GetMateriasAsignadas(int IdAlumno)
        {
            ML.AlumnoMateria alumnoMateria = new ML.AlumnoMateria();
            alumnoMateria.Materia = new ML.Materia();
            alumnoMateria.Alumno = new ML.Alumnos();

            ML.Result result = BL.AlumnoMateria.GetMateriasAsignadas(IdAlumno);

            if (result.Correct)
            {
                alumnoMateria.Materia.Materias = result.Objects.ToList();
                alumnoMateria.Alumno.IdAlumno = IdAlumno;
            }

            return View(alumnoMateria);
        }
        [HttpGet]
        public ActionResult GetMateriaNoAsignada(int IdAlumno)
        {
            ML.AlumnoMateria materia = new ML.AlumnoMateria();
            materia.Materia = new ML.Materia();
            materia.Alumno = new ML.Alumnos();

            ML.Result result = BL.AlumnoMateria.GetMateriasNoAsignadas(IdAlumno);

            if (result.Correct)
            {
                materia.Materia.Materias = result.Objects.ToList();
                materia.Alumno.IdAlumno = IdAlumno;
            }
            return View(materia);
        }

        [HttpPost]
        public ActionResult Add(ML.Alumnos alumno, int[] IdMaterias, int? IdAlumno)
        {

            foreach (var item in IdMaterias)
            {
                BL.AlumnoMateria.AddMateria(alumno.IdAlumno, item);
            }


            return PartialView("Modal");
        }


        public ActionResult Dell(int IdAlumno, int IdMateria)
        {
            ML.Result result = BL.AlumnoMateria.DellMateria(IdAlumno, IdMateria);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino correctamente";
            }
            else
            {
                ViewBag.Error = result.ErrorMessage;
            }

            return PartialView("Modal");
        }
    }
}