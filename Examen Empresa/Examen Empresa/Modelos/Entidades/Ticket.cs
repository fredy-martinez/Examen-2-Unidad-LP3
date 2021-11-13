using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examen_Empresa.Modelos.Entidades
{
    public class Ticket
    {
        public int Id { get; set; }
        public string NombreCliente { get; set; }
        public string Estado { get; set; }
        public DateTime FechaInicio { get; set; }
        public string Soporte { get; set; }
    }
}
