using MyDiet.DAL;
using MyDiet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiet.BLL
{
    public class AlimentoBLL
    {
        private AlimentoDAL alimentoDAL;

        public AlimentoBLL()
        {
            alimentoDAL = new AlimentoDAL();
        }

        public void CadastrarAlimento(Alimento alimento)
        {
            alimentoDAL.CadastrarAlimento(alimento);
        }

        public void EditarAlimento(Alimento alimento)
        {
            alimentoDAL.EditarAlimento(alimento);
        }
    }
}
