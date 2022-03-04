using API.Data;
using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;


namespace API.Repository
{
    public class RepositoryAlumno : IRepositoryAlumno
    {
        private string _cadenaConexion;

        public RepositoryAlumno(AccesoDatos cadenaConexion)
        {
            _cadenaConexion = cadenaConexion.CadenaSQL;
        }

        private SqlConnection conexion()
        {
            return new SqlConnection(_cadenaConexion);
        }
        public Task<bool> AddAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteAlumno(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Alumno> GetAlumno(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IEnumerable<Alumno>> GetAlumnos()
        {
            throw new NotImplementedException();
        }

        public Task<bool> UpdateAlumno(Alumno alumno)
        {
            throw new NotImplementedException();
        }
    }
}
