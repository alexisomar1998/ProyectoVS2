using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulacion.Entidades
{
	public class MatriculaGrado
	{
		public int Matricula { get; set; }
		public List<Estudiante> Estudiantes { get; set; }
		public float pago { get; set; }
		public Estudiante Estudiante { get; set; }
		public int IDEstudiante { get; set; }
		public string period { get; set; }
		public Curso Curos { get; set; }
		public int IDCurso { get; set; }
		public Requisito Requisito { get; set; }
		public  int IDRequisito { get; set; }

	}
}
