using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoFinal.DataModel.Interfaces
{
    public interface IGenericRepository<T>
    {
        T Create(T model);
        List<T> GetAll();
        T FindById(int Id);
        OperationResult Update(T model);
        OperationResult Delete(T model);
    }
}
