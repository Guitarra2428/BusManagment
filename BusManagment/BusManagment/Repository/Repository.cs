using BusManagment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagment.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
       
        public void Actualizar(T entidad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(T entidad)
        {
            throw new NotImplementedException();
        }

        public void Eliminar(int id)
        {
            throw new NotImplementedException();
        }

        public void GuardarCambios()
        {
            throw new NotImplementedException();
        }

        public T ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<T> TraerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
