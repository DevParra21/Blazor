using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ModeloClasesAlumnos;

namespace BlazorTemplate.Pages
{
    public class ListaAlumnosBase: ComponentBase
    {
        public IEnumerable<Alumno> Alumnos { get; set; }

        protected override Task OnInitializedAsync()
        {
            CargarAlumnos();
            return base.OnInitializedAsync();
        }

        private void CargarAlumnos()
        {
            Precio precio = new Precio();
            precio.Id = 1;
            precio.Coste = 99.99;
            precio.FechaInicio = DateTime.Now;
            precio.FechaFin = DateTime.Now.AddDays(5);

            Curso curso = new Curso();
            curso.Id = 1;
            curso.NombreCurso = "Curso Blazor";
            curso.ListaPrecio = new List<Precio>();
            curso.ListaPrecio.Add(precio);

            Alumno alumno = new Alumno()
            {
                Id = 1,
                Nombre = "Pato",
                Email = "edparra@outlook.com",
                Foto = "img/foto.jpg",
                FechaAlta = DateTime.Now,
                FechaBaja = null,
                ListaCursos = new List<Curso>()
            };
            alumno.ListaCursos.Add(curso);

            Alumno alumno2 = new Alumno()
            {
                Id = 2,
                Nombre = "Eddy",
                Email = "eddy@outlook.com",
                Foto = "img/foto2.jpg",
                FechaAlta = DateTime.Now.AddDays(-5),
                FechaBaja = null,
                ListaCursos = new List<Curso>()
            };
            alumno2.ListaCursos.Add(curso);

            Alumno alumno3 = new Alumno()
            {
                Id = 3,
                Nombre = "Laura",
                Email = "laura@outlook.com",
                Foto = "img/foto3.jpg",
                FechaAlta = DateTime.Now.AddDays(-14),
                FechaBaja = null,
                ListaCursos = new List<Curso>()
            };
            alumno3.ListaCursos.Add(curso);

            Alumnos = new List<Alumno> { alumno, alumno2, alumno3 };
        }

    }
}
