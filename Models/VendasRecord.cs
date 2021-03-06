using ComercioLP.Models.enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComercioLP.Models
{
    public class VendasRecord
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public double Quantidade { get; set; }
        public VendStatus Status { get; set; }
        public Vendedor vendedor { get; set; }
        public VendasRecord()
        {
        }

        public VendasRecord(int id, DateTime data, double quantidade, VendStatus status, Vendedor vendedor)
        {
            Id = id;
            Data = data;
            Quantidade = quantidade;
            Status = status;
            this.vendedor = vendedor;
        }
    }
}
