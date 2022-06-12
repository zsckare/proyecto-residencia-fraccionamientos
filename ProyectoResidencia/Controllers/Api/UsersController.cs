using DbConnector.Core;
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
    public class UsersController : ApiController
    {
        // GET: api/Users

        DbConnector<SqlConnection> _dbConnector = new DbConnector<SqlConnection>("Server=52.156.153.12;Initial Catalog=Smartzone;Persist Security Info=True;User ID=sa;Password=D@d2021;");

        public IHttpActionResult Get()
        {

            var res = _dbConnector.ReadToList(
                onInit: (cmd) =>
                {
                    cmd.CommandText = "exec list_user"; // manda llamar proceso almacenado
                }

                ).Execute();
            return Ok(res);
        }

        // GET: api/Users/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Users
        public IHttpActionResult Post([FromBody]Usuario user)
        {
            var res = _dbConnector.NonQuery("exec insert_user @nombre, @apellidoPaterno,@apellidoMaterno,@edad,@correo,@password", new { user.nombre,user.apellidoPaterno,user.apellidoMaterno,user.edad,user.correo,user.password }).Execute();

            return Ok(res);
        }

        // PUT: api/Users/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Users/5
        public IHttpActionResult Delete(int id)
        {
            var res = _dbConnector.NonQuery("exec delete_user @id", new { id}).Execute();

            return Ok(res);
        }
    }
}
