using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploPatronRepositorio.Entidades
{
    public class Cuentas
    {
        [Key]
        int CuentaId { get; set; }
        string Descripcion { get; set; }
    }
}
