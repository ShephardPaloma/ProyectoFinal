namespace ProyectoFinal.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class prueba : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Solicitud",
                c => new
                    {
                        SolicitudId = c.Int(nullable: false, identity: true),
                        Nombre = c.String(nullable: false, maxLength: 100, unicode: false),
                        Apellido = c.String(nullable: false, maxLength: 100, unicode: false),
                        Libro = c.String(nullable: false, maxLength: 100, unicode: false),
                        Editorial = c.String(nullable: false, maxLength: 100, unicode: false),
                        Autor = c.String(nullable: false, maxLength: 100, unicode: false),
                        Borrado = c.Boolean(nullable: false),
                        Estatus = c.String(nullable: false, maxLength: 2, unicode: false),
                        FechaRegistro = c.DateTime(nullable: false),
                        FechaActualizacion = c.DateTime(),
                    })
                .PrimaryKey(t => t.SolicitudId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Solicitud");
        }
    }
}
