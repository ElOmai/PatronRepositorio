using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronRepositorio.BLL
{
    interface IRepository
    {
        List<T>.GetList(Expression<Func<T,bool>>expression);
        T Buscar(int Id);
        bool Guardar(T, entity);
        bool Modificar(T, entity);
    }
}
