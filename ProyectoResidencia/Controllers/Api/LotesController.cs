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
    public class LotesController : ApiController
    {
        // GET: api/Lotes
        DbConnector<SqlConnection> _dbConnector = new DbConnector<SqlConnection>("Server=52.156.153.12;Initial Catalog=Smartzone;Persist Security Info=True;User ID=sa;Password=D@d2021;");

        public IHttpActionResult Get()
        {

            var res = _dbConnector.ReadToList(
                onInit: (cmd) =>
                {
                    cmd.CommandText = "exec list_lote"; // manda llamar proceso almacenado
                }

                ).Execute();
            return Ok(res);
        }

        // GET: api/Lotes/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Lotes
        public IHttpActionResult Post([FromBody] Lote user)
        {
            var res = _dbConnector.NonQuery("exec insert_lote @nombre, @n_lote,@fecha,@direccion,@colindancia,@metros,@mensualidad,@estado", new { user.nombre, user.n_lote, user.fecha, user.direccion, user.colindancia, user.metros, user.mensualidad, user.estado }).Execute();

            return Ok(res);
        }

        // PUT: api/Lotes/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Lotes/5
        public IHttpActionResult Delete(int id)
        {
            var res = _dbConnector.NonQuery("exec delete_lote @id", new { id }).Execute();

            return Ok(res);
        }
    }
}
