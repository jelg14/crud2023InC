using CRUD2023.Clases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD2023.Interfaces
{
    internal interface IAlumno : ITest
    {
        //Template-> Plantilla -> Machote -> Esquema
        //NO tiene funcionalidad , solo declaracion de metodos.
        //Camel Case

        public int GetIdAlumno(Alumno alumno);
        public int GetIdAlumno(String Nombre);
        public Alumno GetAlumno(int id);
        public List<Alumno> GetAllAlumnos();
        public void SaveAlumno(Alumno alumno);
        public void DeleteAlumno(int id);
        public void UpdateAlumno(Alumno alumno, bool forze= false);

    }

    interface ITest
    {
        public string Name { get; set; }
        public string LastName { get; set; }
    }
}
