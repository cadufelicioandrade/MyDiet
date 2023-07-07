using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiet.Entity
{
    public class Alimento
    {
        public Alimento()
        {
                
        }

        public int Id { get; set; }
        public string NomeAlimento { get; set; }
        public decimal CaloriaPorGrama { get; set; }
        public decimal ProteinaPorGrama { get; set; }

    }
}
