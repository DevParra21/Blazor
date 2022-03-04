using API.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [Route("api/[controller]")]

    public class AlumnoController : ControllerBase
    {
        private readonly IRepositoryAlumno _repositoryAlumno;

        public AlumnoController(IRepositoryAlumno repositoryAlumno)
        {
            this._repositoryAlumno = repositoryAlumno;
        }

        [HttpGet]
        public async Task<ActionResult> GetAlumnos()
        {
            try
            {
                return Ok(await _repositoryAlumno.GetAlumnos());
            }
            catch(Exception)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "There's an error obtaining the information.");
            }
        }
    }
}
