using MyDiet.DAL;
using MyDiet.Entity;
using System;
using System.Collections.Generic;
using System.Data;
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

        public DataTable ObterDietaDoDia()
        {
            return dietaDoDiaDAL.ObterDietaDoDia();
        }

        public void CadastrarDieta(DateTable dietaDoDia)
        {
            dietaDoDiaDAL.CadastrarDietaDoDia(dietaDoDia);
        }

        public void EditarDieta(DateTable dietaDoDia)
        {
            dietaDoDiaDAL.EditarDietaDoDia(dietaDoDia);
        }
    }
}
