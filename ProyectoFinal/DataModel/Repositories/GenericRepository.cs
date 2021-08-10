using ProyectoFinal.DataModel.Interfaces;
using ProyectoFinal.DataModel.Context;
using System.Data.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DataModel.Repositories
{
    public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
    {
        private BibliotecaDbContext dbContext;
        private DbSet<T> _set;

        public GenericRepository()
        {
            dbContext = new BibliotecaDbContext();
            _set = dbContext.Set<T>();
        }

        public T Create(T model)
        {
            _set.Add(model);
            model.Borrado = false;
            model.Estatus = "A";
            model.FechaRegistro = DateTime.Today;

            dbContext.SaveChanges();
            return model;
        }

        public OperationResult Delete(T model)
        {
            dbContext.Entry(model).State = EntityState.Modified;
            model.Borrado = true;
            model.Estatus = "I";
            model.FechaActualizacion = DateTime.Today;

            dbContext.SaveChanges();
            return new OperationResult() { Succes = true };
        }

        public T FindById(int Id)
        {
            return _set.Where(x => x.Borrado == false && x.Estatus == "A").FirstOrDefault(x => x.Id == Id);
        }

        public List<T> GetAll()
        {
            return _set.Where(x => x.Borrado == false && x.Estatus == "A").ToList();
        }

        public OperationResult Update(T model)
        {
            dbContext.Entry(model).State = EntityState.Modified;
            model.FechaActualizacion = DateTime.Today;
            dbContext.SaveChanges();

            return new OperationResult() { Succes = true };
        }
    }
}
