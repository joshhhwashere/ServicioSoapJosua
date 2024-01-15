using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using ServicioSoapJosua.BusinessAction;
using ServicioSoapJosua.BusinessMessage;

namespace ServicioSoapJosua
{
    /// <summary>
    /// Descripción breve de Lista
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Lista : System.Web.Services.WebService
    {
        [WebMethod]
        public Estudiantes GetAllEstudiantes()
        {
            return EstudiantesManage.GetAllEstudiantes();
        }

        [WebMethod]
        public Estudiantes GetEstudianteById(int id)
        {
            return EstudiantesManage.GetEstudianteById(id);
        }

        [WebMethod]
        public Estudiantes AddEstudiante(string nombres)
        {
            return EstudiantesManage.AddEstudiante(nombres);
        }

        [WebMethod]
        public Estudiantes UpdateEstudiante(int id, string nombres)
        {
            return EstudiantesManage.UpdateEstudiante(id, nombres);
        }

        [WebMethod]
        public Estudiantes DeleteEstudiante(int id)
        {
            return EstudiantesManage.DeleteEstudiante(id);
        }

        [WebMethod]
        public string HelloWorld()
        {
            return "Hola a todos";
        }
    }
}