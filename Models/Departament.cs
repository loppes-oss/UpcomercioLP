﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ComercioLP.Models
{
    public class Departament
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Vendedor> Vendedors { get; set; } = new List<Vendedor>();

        public Departament()
        {
        }

        public Departament(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }
        public void AddVendedor(Vendedor vendedor)
        {
            Vendedors.Add(vendedor);
        }
        public double TotalVendas(DateTime inicial , DateTime final)
        {
            return Vendedors.Sum(Vendedor => Vendedor.TotalVendas(inicial, final));
        }
    }
}
