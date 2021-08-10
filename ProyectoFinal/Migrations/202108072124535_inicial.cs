namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Autor",
                c => new
                    {
                        AutorId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 100, unicode: false),
                        Nacionalidad = c.String(nullable: false, maxLength: 100, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.AutorId);
            
            CreateTable(
                "dbo.Devolucion",
                c => new
                    {
                        DevolucionId = c.Int(nullable: false, identity: true),
                        PrestamoId = c.Int(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.DevolucionId)
                .ForeignKey("dbo.Prestamo", t => t.PrestamoId, cascadeDelete: true)
                .Index(t => t.PrestamoId);
            
            CreateTable(
                "dbo.Prestamo",
                c => new
                    {
                        PrestamoId = c.Int(nullable: false, identity: true),
                        EstudianteId = c.Int(nullable: false),
                        LibroId = c.Int(nullable: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.PrestamoId)
                .ForeignKey("dbo.Estudiante", t => t.EstudianteId, cascadeDelete: true)
                .ForeignKey("dbo.Libro", t => t.LibroId, cascadeDelete: true)
                .Index(t => t.EstudianteId)
                .Index(t => t.LibroId);
            
            CreateTable(
                "dbo.Estudiante",
                c => new
                    {
                        EstudianteId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 100, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 100, unicode: false),
                        Telefono = c.String(nullable: false, maxLength: 100, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EstudianteId);
            
            CreateTable(
                "dbo.Libro",
                c => new
                    {
                        LibroId = c.Int(nullable: false, identity: true),
                        AutorId = c.Int(nullable: false),
                        EditorialId = c.Int(nullable: false),
                        Nombre = c.String(nullable: false, maxLength: 200, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.LibroId)
                .ForeignKey("dbo.Autor", t => t.AutorId, cascadeDelete: true)
                .ForeignKey("dbo.Editorial", t => t.EditorialId, cascadeDelete: true)
                .Index(t => t.AutorId)
                .Index(t => t.EditorialId);
            
            CreateTable(
                "dbo.Editorial",
                c => new
                    {
                        EditorialId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Direccion = c.String(nullable: false, maxLength: 500, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.EditorialId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Devolucion", "PrestamoId", "dbo.Prestamo");
            DropForeignKey("dbo.Prestamo", "LibroId", "dbo.Libro");
            DropForeignKey("dbo.Libro", "EditorialId", "dbo.Editorial");
            DropForeignKey("dbo.Libro", "AutorId", "dbo.Autor");
            DropForeignKey("dbo.Prestamo", "EstudianteId", "dbo.Estudiante");
            DropIndex("dbo.Libro", new[] { "EditorialId" });
            DropIndex("dbo.Libro", new[] { "AutorId" });
            DropIndex("dbo.Prestamo", new[] { "LibroId" });
            DropIndex("dbo.Prestamo", new[] { "EstudianteId" });
            DropIndex("dbo.Devolucion", new[] { "PrestamoId" });
            DropTable("dbo.Editorial");
            DropTable("dbo.Libro");
            DropTable("dbo.Estudiante");
            DropTable("dbo.Prestamo");
            DropTable("dbo.Devolucion");
            DropTable("dbo.Autor");
        }
    }
}
