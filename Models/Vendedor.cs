using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComercioLP.Models
{
    public class Vendedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public DateTime DtNasc { get; set; }
        public double BaseSalario { get; set; }
        public Departament Departament { get; set; }
    }
}
