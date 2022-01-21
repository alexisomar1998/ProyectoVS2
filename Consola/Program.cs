using System;
using System.Collections.Generic;
using Titulacion.Entidades;

namespace Consola
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Curso Curso1 = new Curso()
			{
				carrera = "Analisis Sistema",
				jornada = "Matutina",


			};
			//Estudiante
			Estudiante EsOrozco = new Estudiante()
			{
				nombre = "Samantha Orozco",
				dni = "1727310004",
				telefono = "09656654",
				Cursos = new List<Curso>() { Curso1 }
			};

			List < Estudiante > LisEstudiantes = new() { EsOrozco };
			
		}
	}
}
