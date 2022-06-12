using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoResidencia.Models
{
    public class Usuario
    {
        public int idUsuario { get; set; }
        public string nombre { get; set; }
        public string apellidoPaterno { get; set; }
        public string apellidoMaterno { get; set; }
        public int edad { get; set; }
        public string correo { get; set; }
        public string password { get; set; }
    }
}