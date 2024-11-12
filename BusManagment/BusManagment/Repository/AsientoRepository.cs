using BusManagment.Entities;
using BusManagment.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusManagment.Repository
{
    public class AsientoRepository : IRepository<Asiento>, IAsientoRepository
    {
        public void Actualizar(Asiento entidad)
        {
            throw new NotImplementedException();
        }

        public void Agregar(Asiento entidad)
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

        public Asiento ObtenerPorId(int id)
        {
            throw new NotImplementedException();
        }

        public List<Asiento> TraerTodo()
        {
            throw new NotImplementedException();
        }
    }
}
