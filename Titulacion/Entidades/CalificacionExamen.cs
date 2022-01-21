using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulacion.Entidades
{
	public class CalificacionExamen
	{
		public int IdCaliExamen { get; set; }
		public float nota1 { get; set; }
		public float nota2 { get; set; }
		public float nota3 { get; set; }
		public float notafinal { get; set; }
		public string aprobacion { get; set; }
	}
}
