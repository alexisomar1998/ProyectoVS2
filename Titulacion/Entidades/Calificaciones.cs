using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulacion.Entidades
{
	public class Calificaciones
	{
		public CalificacionExamen  CalificacionExamen { get; set; }
		public int IDCalifiExamen { get; set; }
		public CalificacionTesis CalificacionTesis { get; set; }
		public int IDCalifiTesi { get; set;}
	}
}
