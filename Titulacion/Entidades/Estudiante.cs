using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulacion.Entidades
{
	public class Estudiante
	{
		public int IdEstudiante { get; set; }
		public string nombre { get; set; }
		public string dni { get; set; }
		public string telefono { get; set; }
		public List<Curso> Cursos { get; set; }

	}
}
