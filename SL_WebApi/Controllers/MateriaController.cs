﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace SL_WebApi.Controllers
{
    [RoutePrefix("api/Materia")]
    public class MateriaController : ApiController
    {
        [Route("")]
        [HttpPost]
        public IHttpActionResult Add(ML.Materia materia)
        {
            ML.Result result =BL.Materia.Add(materia);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK,result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest,result);
            }
        }

        [Route("{IdMateria?}")]
        [HttpDelete]
        public IHttpActionResult Delete(int IdMateria)
        {
            ML.Result result = BL.Materia.Dell(IdMateria);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK,result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest,result);
            }
        }

        [Route("{IdMateria?}")]
        [HttpPut]
        public IHttpActionResult Update(int IdMateria, [FromBody] ML.Materia materia)
        {
            materia.IdMateria = IdMateria;
            ML.Result result = BL.Materia.Update(materia);
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest,result);
            }
        }

        [Route("")]
        [HttpGet]
        public IHttpActionResult GetAll()
        {
            ML.Result result = BL.Materia.GetAll();
            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }
        }

        [Route("Getby/{IdMateria?}")]
        [HttpGet]
        public IHttpActionResult GetById(int IdMateria) 
        {
            ML.Result result = BL.Materia.GetById(IdMateria);

            if (result.Correct)
            {
                return Content(HttpStatusCode.OK, result);
            }
            else
            {
                return Content(HttpStatusCode.BadRequest, result);
            }


        }

    }
}
