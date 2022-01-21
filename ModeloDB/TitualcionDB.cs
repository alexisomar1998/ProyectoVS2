using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Titulacion.Entidades;

namespace ModeloDB
{
	public  class TitualcionDB:DbContext

	{
		public DbSet<Curso> Cursos { get; set; }
		public DbSet<Estudiante> Estudies { get; set; }
		public DbSet<Examen> Examenes { get; set; }
		public DbSet<CalificacionExamen> NotaExamen { get; set; }
		public DbSet<MatriculaGrado> MatriculaGrados { get; set; }
		public DbSet<Tesis> tesiss { get; set; }
		public DbSet<Tutor> Tutores { get; set; }
		public DbSet<Aprobacion> Aprobaciones { get; set; }
		public DbSet<Calificaciones> Calificacioness { get; set; }
		public DbSet<CalificacionTesis> NotaTesis { get; set; }
		public DbSet<Requisito> Requisitos { get; set; }


		//Configuracion de la conexion

		protected override void OnConfiguring(DbContextOptionsBuilder options)
		{
			options.UseSqlServer("Server=;Initial Catalog=DBGraduacion;truted_connection=true;");
			
		}
		//Configuracion del modelo de clases
		protected override void OnModelCreating(ModelBuilder model)
		{
			//Matricula
			//estudiante
			model.Entity<MatriculaGrado>()
			.HasOne(MatriculaGrados => MatriculaGrados.Estudiante)
			.WithMany(Estudies=>Estudies.MatriculaGrados)
			.HasForeignKey(MatriculaGrados = MatriculaGrados.IDEstudiante);
			//curso
			model.Entity<MatriculaGrado>()
			.HasOne(MatriculaGrados => MatriculaGrados.Curos)
			.WithMany(estudies => estudies.MatriculaGrados)
			.HasForeignKey(MatriculaGrado = MatriculaGrado.IDCurso);
			//clave Primaria para dos claves foraneas
			model.Entity<MatriculaGrado>()
				.HasKey(MatriculaGrado => new
				{
					MatriculaGrado,
					IDEstudiante,
					MatriculaGrado.IDCurtso,
				});
			//Calificaciones
			//tesis
			model.Entity<Calificaciones>()
				.HasOne(Calificacioness=>Calificacioness.IDCalifiTesi)
				.WithOne(tesiss=>tesiss.Calificacion)
		}
	}
}
