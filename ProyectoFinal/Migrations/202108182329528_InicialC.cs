namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InicialC : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Devolucion", "FechaDevolucion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Autor", "FechaActualizacion", c => c.DateTime());
            AlterColumn("dbo.Devolucion", "FechaActualizacion", c => c.DateTime());
            AlterColumn("dbo.Prestamo", "FechaActualizacion", c => c.DateTime());
            AlterColumn("dbo.Estudiante", "FechaActualizacion", c => c.DateTime());
            AlterColumn("dbo.Libro", "FechaActualizacion", c => c.DateTime());
            AlterColumn("dbo.Editorial", "FechaActualizacion", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Editorial", "FechaActualizacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Libro", "FechaActualizacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Estudiante", "FechaActualizacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Prestamo", "FechaActualizacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Devolucion", "FechaActualizacion", c => c.DateTime(nullable: false));
            AlterColumn("dbo.Autor", "FechaActualizacion", c => c.DateTime(nullable: false));
            DropColumn("dbo.Devolucion", "FechaDevolucion");
        }
    }
}
