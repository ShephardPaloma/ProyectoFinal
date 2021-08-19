using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using ProyectoFinal.DataModel.Entities;

namespace ProyectoFinal.DataModel.Context
{
    public class BibliotecaDbContext:DbContext
    {
        public BibliotecaDbContext()
         : base("conn")
        {
        }

        public DbSet<Autor> Autors { get; set; }
        public DbSet<Devolucion> Devolucions { get; set; }
        public DbSet<Editorial> Editorials { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Libro> Libros { get; set; }
        public DbSet<Prestamo> Prestamos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            #region Comun
            modelBuilder.Properties<string>()
                .Where(p => p.Name == "Estatus")
                .Configure(c => c.HasColumnType("varchar").HasMaxLength(2).IsRequired());

            modelBuilder.Properties<bool>()
                .Where(p => p.Name == "Borrado")
                .Configure(c => c.HasColumnType("BIT").IsRequired());

            modelBuilder.Properties<DateTime>()
                .Where(p => p.Name == "FechaRegistro")
                .Configure(c => c.HasColumnType("DateTime").IsRequired());

            modelBuilder.Properties<DateTime>()
               .Where(p => p.Name == "FechaActualizacion")
              .Configure(c => c.HasColumnType("DateTime"));
            #endregion

            #region Autor
            modelBuilder.Entity<Autor>()
                .ToTable("Autor")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Autor>()
                .Property(p => p.Id)
                .HasColumnName("AutorId");

            modelBuilder.Entity<Autor>()
                .Property(p => p.Nombre)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Autor>()
                .Property(p => p.Apellido)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Autor>()
                .Property(p => p.Nacionalidad)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();
            #endregion

            #region Devolucion
            modelBuilder.Entity<Devolucion>()
                .ToTable("Devolucion")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Devolucion>()
                .Property(p => p.Id)
                .HasColumnName("DevolucionId");

            modelBuilder.Entity<Devolucion>()
                .Property(p => p.FechaDevolucion)
                .HasColumnType("DateTime")
                .IsRequired();
            #endregion

            #region Editorial
            modelBuilder.Entity<Editorial>()
                .ToTable("Editorial")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Editorial>()
                .Property(p => p.Id)
                .HasColumnName("EditorialId");

            modelBuilder.Entity<Editorial>()
                .Property(p => p.Nombre)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Editorial>()
                .Property(p => p.Direccion)
                .HasMaxLength(500)
                .HasColumnType("varchar")
                .IsRequired();
            #endregion

            #region Estudiante
            modelBuilder.Entity<Estudiante>()
                .ToTable("Estudiante")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Estudiante>()
                .Property(p => p.Id)
                .HasColumnName("EstudianteId");

            modelBuilder.Entity<Estudiante>()
                .Property(p => p.Nombre)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Estudiante>()
                .Property(p => p.Apellido)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Estudiante>()
                .Property(p => p.Direccion)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();

            modelBuilder.Entity<Estudiante>()
                .Property(p => p.Telefono)
                .HasMaxLength(100)
                .HasColumnType("varchar")
                .IsRequired();
            #endregion

            #region Libro
            modelBuilder.Entity<Libro>()
                .ToTable("Libro")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Libro>()
                .Property(p => p.Id)
                .HasColumnName("LibroId");

            modelBuilder.Entity<Libro>()
                .Property(p => p.Nombre)
                .HasMaxLength(200)
                .HasColumnType("varchar")
                .IsRequired();

            //Preguntar si debemos colocar los FK requeridos en la BD
            #endregion

            #region Prestamo
            modelBuilder.Entity<Prestamo>()
                .ToTable("Prestamo")
                .HasKey(k => k.Id);

            modelBuilder.Entity<Prestamo>()
                .Property(p => p.Id)
                .HasColumnName("PrestamoId");
            #endregion
        }
    }
}
