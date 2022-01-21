using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulacion.Entidades
{
	public class Aprobacion
	{
	
		public int IDAprobacion { get; set; }
		public Tesis Tesis { get; set; }
		public int IDTesis { get; set; }
		public Examen Examen { get; set; }
		public int IDExamen { get; set; }


	}
}
