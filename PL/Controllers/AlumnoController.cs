using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel.Description;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class AlumnoController : Controller
    {
        // GET: Alumno
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Alumnos alumnos = new ML.Alumnos();

            ServiceReference1.AlumnoOperationClient AlumnoWCF = new ServiceReference1.AlumnoOperationClient();
            var result = AlumnoWCF.GetAll();
            //ML.Result result = BL.Alumnos.GetAll();

            if (result.Correct)
            {
                alumnos.TAlumnos = result.Objects.ToList();
            }
            else
            {
                ViewBag.Message = result.ErrorMassage;
            }
            return View(alumnos);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Alumnos alumno)
        {
            //ML.Result result = BL.Alumnos.GetAll();
            ServiceReference1.AlumnoOperationClient AlumnoWCf =  new ServiceReference1.AlumnoOperationClient();
            var result = AlumnoWCf.GetAll();

            alumno = new ML.Alumnos();
            alumno.TAlumnos = result.Objects.ToList();
            return View(alumno);
        }

        [HttpGet]
        public ActionResult Add(int? IdAlumno)
        {
            ML.Alumnos alumnos = new ML.Alumnos();
            alumnos.IdAlumno = IdAlumno.Value;
            
            if (IdAlumno != 0) //update
            {
                //ML.Result result = BL.Alumnos.GetById(IdAlumno.Value);
                ServiceReference1.AlumnoOperationClient AlumnoWCF = new ServiceReference1.AlumnoOperationClient();
                var result = AlumnoWCF.GetById(alumnos);

                if (result.Correct)
                {
                    alumnos = (ML.Alumnos)result.Object;
                }
            }
            else //add
            {

            }
            return View(alumnos);
        }

        [HttpPost]
        public ActionResult Add(ML.Alumnos alumnos) 
        {
            alumnos.TAlumnos = new List<object>();
            if (alumnos.IdAlumno == 0 ) //add
            {
                //ML.Result result = BL.Alumnos.Add(alumnos);
                ServiceReference1.AlumnoOperationClient AlumnoWCF = new ServiceReference1.AlumnoOperationClient();
                var result = AlumnoWCF.Add(alumnos);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se incerto correctamente";
                }
                else
                {
                    ViewBag.Error = result.ErrorMassage;
                }
            }
            else //update
            {
                //ML.Result result = BL.Alumnos.Update(alumnos);
                ServiceReference1.AlumnoOperationClient AlumnoWCf = new ServiceReference1.AlumnoOperationClient();
                var result = AlumnoWCf.Update(alumnos);

                if (result.Correct)
                {
                    ViewBag.Mensaje = "Se actualizo correctamente";
                }
                else
                {
                    ViewBag.Error = result.ErrorMassage;
                }
            }

            return PartialView("Modal");
        }

        public ActionResult Dell(int IdAlumno)
        {
            ML.Alumnos alumnos = new ML.Alumnos();
            alumnos.IdAlumno = IdAlumno;

            //ML.Result result =  BL.Alumnos.Dell(IdAlumno);
            ServiceReference1.AlumnoOperationClient AlumnoWCF = new ServiceReference1.AlumnoOperationClient();
            var result = AlumnoWCF.Delete(alumnos);

            if (result.Correct)
            {
                ViewBag.Mensaje = "Se elimino correctamente";
            }
            else
            {
                ViewBag.Error = result.ErrorMassage;
            }

            return PartialView("Modal");
        }
    }
}