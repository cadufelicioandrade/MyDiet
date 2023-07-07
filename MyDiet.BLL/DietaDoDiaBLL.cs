using MyDiet.DAL;
using MyDiet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiet.BLL
{
    public class DietaDoDiaBLL
    {
        private DietaDoDiaDAL dietaDoDiaDAL;

        public DietaDoDiaBLL()
        {
            dietaDoDiaDAL = new DietaDoDiaDAL();
        }

        public void CadastrarDieta(DietaDoDia dietaDoDia)
        {
            dietaDoDiaDAL.CadastrarDietaDoDia(dietaDoDia);
        }

        public void EditarDieta(DietaDoDia dietaDoDia)
        {
            dietaDoDiaDAL.EditarDietaDoDia(dietaDoDia);
        }
    }
}
