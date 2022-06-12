using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoResidencia.Models
{
    public class Lote
    {

        public int idlote { get; set; }
        public string nombre { get; set; }
        public int n_lote { get; set; }
        public string fecha { get; set; }
        public string direccion { get; set; }
        public string colindancia { get; set; }
        public string metros { get; set; }
        public string mensualidad { get; set; }
        public string estado { get; set; }
    }
}