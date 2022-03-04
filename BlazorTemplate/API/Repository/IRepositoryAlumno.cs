using ModeloClasesAlumnos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Repository
{
    public interface IRepositoryAlumno
    {
        Task<bool> AddAlumno(Alumno alumno);

        Task<IEnumerable<Alumno>> GetAlumnos();

        Task<Alumno> GetAlumno(int id);

        Task<bool> UpdateAlumno(Alumno alumno);

        Task<bool> DeleteAlumno(int id);
    }
}
