using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulacion.Entidades
{
	public class Examen
	{
		public int IdExamen { get; set; }
		public List<Tutor> Tutores { get; set; }
		public Curso Curso { get; set; }
		public int IDCuros { get; set; }
		public MatriculaGrado MatriculaGrado { get; set;}
		public int IDMatricula { get; set; }
		public Tutor Tutor { get; set; }
		public int IDTutor { get; set; }
		public Calificaciones Calificaciones { get; set;}
		public int IDCalificaiones { get; set; }

	}
}
