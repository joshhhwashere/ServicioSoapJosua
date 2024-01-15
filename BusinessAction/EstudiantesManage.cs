using ServicioSoapJosua.BusinessMessage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ServicioSoapJosua.BusinessAction
{
    public class EstudiantesManage
    {
        public static List<Estudiante> estudiantes = new List<Estudiante>()
        {
            new Estudiante() { Id = 1, Nombres = "Juan" },
            new Estudiante() { Id = 2, Nombres = "Maria" },
            new Estudiante() { Id = 3, Nombres = "Carlos" },
        };

        public static Estudiantes GetAllEstudiantes()
        {
            return new Estudiantes() { estudiantes = estudiantes };
        }

        public static Estudiantes GetEstudianteById(int id)
        {
            Estudiante estudiante = estudiantes.FirstOrDefault(e => e.Id == id);
            return new Estudiantes() { estudiantes = (estudiante != null) ? new List<Estudiante> { estudiante } : null };
        }

        public static Estudiantes AddEstudiante(string nombres)
        {
            Estudiante estudiante = new Estudiante() { Nombres = nombres };
            estudiante.Id = estudiantes.Count + 1;
            estudiantes.Add(estudiante);
            return new Estudiantes() { estudiantes = new List<Estudiante> { estudiante } };
        }

        public static Estudiantes UpdateEstudiante(int id, string nombres)
        {
            Estudiante existingEstudiante = estudiantes.FirstOrDefault(e => e.Id == id);
            if (existingEstudiante != null)
            {
                existingEstudiante.Nombres = nombres;
                return new Estudiantes() { estudiantes = new List<Estudiante> { existingEstudiante } };
            }
            else
            {
                return new Estudiantes() { Error = "Estudiante no encontrado" };
            }
        }

        public static Estudiantes DeleteEstudiante(int id)
        {
            Estudiante estudianteToDelete = estudiantes.FirstOrDefault(e => e.Id == id);
            if (estudianteToDelete != null)
            {
                estudiantes.Remove(estudianteToDelete);
                return new Estudiantes() { ActionResult = true, Message = "Estudiante eliminado exitosamente" };
            }
            else
            {
                return new Estudiantes() { Error = "Estudiante no encontrado" };
            }
        }
    }
}
