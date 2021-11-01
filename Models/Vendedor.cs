using System;
using System.Collections;
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
        public ICollection<VendasRecord> Vend { get; set; } = new List<VendasRecord>();
        public Vendedor()
        {
        }

        public Vendedor(int id, string nome, string email, DateTime dtNasc, double baseSalario, Departament departament)
        {
            Id = id;
            Nome = nome;
            Email = email;
            DtNasc = dtNasc;
            BaseSalario = baseSalario;
            Departament = departament;
        }
        public void AddVendedor(VendasRecord sr)
        {
            Vend.Add(sr);
        }
        public void Removevendedor(VendasRecord sr)
        {
            Vend.Remove(sr);
        }
        public double TotalVendas(DateTime inicial, DateTime final)
        {
            return Vend.Where(sr => sr.Data >= inicial && sr.Data <= final).Sum(sr => sr.Quantidade);
        }
    }
}
