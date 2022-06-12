﻿using DbConnector.Core;
using ProyectoResidencia.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ProyectoResidencia.Controllers.Api
{
    public class SocialAreasController : ApiController
    {
        // GET: api/Users

        DbConnector<SqlConnection> _dbConnector = new DbConnector<SqlConnection>("Server=52.156.153.12;Initial Catalog=Smartzone;Persist Security Info=True;User ID=sa;Password=D@d2021;");

        public IHttpActionResult Get()
        {

            var res = _dbConnector.ReadToList(
                onInit: (cmd) =>
                {
                    cmd.CommandText = "exec list_area"; // manda llamar proceso almacenado
                }

                ).Execute();
            return Ok(res);
        }

        // GET: api/SocialAreas/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/SocialAreas
        public IHttpActionResult Post([FromBody] area user)
        {
            var res = _dbConnector.NonQuery("exec insert_area @clave, @nombre ,@tipo", new { user.clave, user.nombre, user.tipo}).Execute();

            return Ok(res);
        }

        // PUT: api/SocialAreas/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/SocialAreas/5
        public IHttpActionResult Delete(int id)
        {
            var res = _dbConnector.NonQuery("exec delete_area @id", new { id }).Execute();

            return Ok(res);
        }
    }
}