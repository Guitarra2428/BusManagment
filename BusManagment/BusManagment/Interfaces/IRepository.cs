using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagment.Interfaces
{
    public interface IRepository<T> where T : class
    {
        List<T> TraerTodo();

        T ObtenerPorId(int id);

        void Agregar(T entidad);

        void Actualizar(T entidad);

        void Eliminar(int id);

        void GuardarCambios();

    }
}
