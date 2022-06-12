using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProyectoResidencia.Models
{
    public class mascota
    {

        public int idMascota { get; set; }
        public string raza { get; set; }
        public string especie { get; set; }
        public string color { get; set; }
        public string tamaño { get; set; }
        public string propietario { get; set; }
        public string imagen { get; set; }

    }
}