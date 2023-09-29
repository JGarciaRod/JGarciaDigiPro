using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PL.Controllers
{
    public class MateriaController : Controller
    {
        // GET: Materia
        [HttpGet]
        public ActionResult GetAll()
        {
            ML.Materia materia = new ML.Materia();
            materia.Materias = new List<object>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"Materia");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ML.Result resultMateria = BL.Materia.GetAll();

                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultItem in readTask.Result.Objects)
                    {
                        ML.Materia resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Materia>(resultItem.ToString());
                        materia.Materias.Add(resultItemList);
                    }
                }
            }

            return View(materia);
        }

        [HttpPost]
        public ActionResult GetAll(ML.Materia materia)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var responseTask = client.GetAsync($"Materia");
                responseTask.Wait();

                var result = responseTask.Result;

                if (result.IsSuccessStatusCode)
                {
                    ML.Result resultMateria = BL.Materia.GetAll();

                    var readTask = result.Content.ReadAsAsync<ML.Result>();
                    readTask.Wait();

                    foreach (var resultItem in readTask.Result.Objects)
                    {
                        ML.Materia resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Materia>(resultItem.ToString());
                        materia.Materias.Add(resultItemList);
                    }
                }
            }

            return View(materia);
        }

        [HttpGet]
        public ActionResult Add(int? IdMateria)
        {
            ML.Materia materia = new ML.Materia();
            materia.IdMateria = IdMateria.Value;

            if (materia.IdMateria != 0) //update
            {
                using (var client = new HttpClient())
                {
                    client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);
                    var responseTask = client.GetAsync("Materia/Getby?IdMateria=" + IdMateria);
                    responseTask.Wait();

                    var resultServicio = responseTask.Result;
                    if (resultServicio.IsSuccessStatusCode)
                    {

                        var readTask = resultServicio.Content.ReadAsAsync<ML.Result>();
                        readTask.Wait();

                        ML.Materia resultItemList = Newtonsoft.Json.JsonConvert.DeserializeObject<ML.Materia>(readTask.Result.Object.ToString());
                        materia = resultItemList;

                    }
                }
            }
            else
            {

            }

            return View(materia);
        }

        [HttpPost]
        public ActionResult Add(ML.Materia materia)
        {
            materia.Materias = new List<object>();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                if (materia.IdMateria == 0) //add
                {
                    var postTask = client.PostAsJsonAsync<ML.Materia>("Materia", materia);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = "Se ha insertado correctamente";
                    }
                    else
                    {
                        ViewBag.Error = result.ToString();
                    }
                }
                else //update
                {
                    var postTask = client.PutAsJsonAsync<ML.Materia>("Materia?IdMateria=" + materia.IdMateria, materia);
                    postTask.Wait();

                    var result = postTask.Result;
                    if (result.IsSuccessStatusCode)
                    {
                        ViewBag.Mensaje = "Se Actualizo la materia";
                    }
                    else
                    {
                        ViewBag.Error = result.ToString();
                    }
                }
            }

            return PartialView("Modal");
        }


        public ActionResult Dell(int IdMateria)
        {
            ML.Materia materia = new ML.Materia();
            materia.IdMateria = IdMateria;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(ConfigurationManager.AppSettings["WebApi"]);

                var postTask = client.DeleteAsync("Materia?IdMateria=" + materia.IdMateria);
                postTask.Wait();

                var result = postTask.Result;
                if (result.IsSuccessStatusCode)
                {
                    ViewBag.Mensaje = "Se elimino la materia";
                }
                else
                {
                    ViewBag.Error = result.ToString();
                }
            }

            return PartialView("Modal");
        }


    }
}