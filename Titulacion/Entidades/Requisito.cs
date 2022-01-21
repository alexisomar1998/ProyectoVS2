using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Titulacion.Entidades
{
	public class Requisito
	{
		public int IdRequisito { get; set; }
		public int HorasVincu { get; set; }
		public int HorasPrac { get; set; }
		public string Ingles { get; set; }
		public int CreditAcadem { get; set; }
		public Estudiante Estudiante { get; set; }
		public int IDEstudiante { get; set; }
		public string Aprobacion { get; set; }
	}
}
