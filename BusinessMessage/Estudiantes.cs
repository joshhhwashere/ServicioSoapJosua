using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioSoapJosua.BusinessMessage
{
    public class Estudiantes
    {
        public List<Estudiante> estudiantes {  get; set; }
        public bool ActionResult { get; set; }

        public string Error { get; set; }

        public string Message { get; set; }
    }
}