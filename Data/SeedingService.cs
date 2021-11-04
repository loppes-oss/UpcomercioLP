using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ComercioLP.Models;

namespace ComercioLP.Data
{
    public class SeedingService
    {
        private ComercioLPContext _context;
        public SeedingService(ComercioLPContext context)
        {
            _context = context;
        }
        public void seed()
        {
            if(_context.Departament.Any() || 
                _context.Vendedor.Any() || 
                _context.VendasRecord.Any())
            {
                return; //o Db ja foi populado!
            }
            Departament d1 = new Departament(1, "computador");
            Departament d2 = new Departament(2, "books");

            Vendedor v1 = new Vendedor(1, "lopes" , "lopesalves@gaiml.com", new DateTime(1994/08/29),1000 ,d1);

            VendasRecord vr = new VendasRecord(1, new DateTime(2018 / 05 / 01), 2000.0, Models.enums.VendStatus.faturado, v1);

            _context.Departament.AddRange(d1, d2);
            _context.Vendedor.AddRange(v1);
            _context.VendasRecord.AddRange(vr);

          


        }
    }
}
