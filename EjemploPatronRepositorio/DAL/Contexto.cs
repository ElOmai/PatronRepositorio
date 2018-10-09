using EjemploPatronRepositorio.Entidades;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronRepositorio.DAL
{
    public class Contexto : DbContext
    {
        public DbSet<Cuentas> Cuentas { get; set; }
        public Contexto() : base("ConStr")
        { }
    }
}
