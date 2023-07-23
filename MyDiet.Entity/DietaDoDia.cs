using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiet.Entity
{
    public class DateTable
    {
        public DateTable()
        {
            
        }

        public int Id { get; set; }
        public double GramasAlimento { get; set; }
        public double CaloriasTotais { get; set; }
        public double ProteinasTotais { get; set; }
        public int AlimentoId { get; set; }
        public int UsuarioId { get; set; }

    }
}
