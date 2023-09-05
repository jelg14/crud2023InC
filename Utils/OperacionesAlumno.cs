using CRUD2023.Clases;
using CRUD2023.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUD2023.Utils
{
    public class OperacionesAlumno : IAlumno
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void DeleteAlumno(int id)
        {
            throw new NotImplementedException();
        }

        public List<Alumno> GetAllAlumnos()
        {
            throw new NotImplementedException();
        }

        public Alumno GetAlumno(int id)
        {
            throw new NotImplementedException();
        }

        public int GetIdAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public int GetIdAlumno(string Nombre)
        {
            throw new NotImplementedException();
        }

        public void SaveAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public void UpdateAlumno(Alumno alumno, bool forze = false)
        {
            throw new NotImplementedException();
        }
    }

    public class Test : ITest
    {
        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string LastName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
