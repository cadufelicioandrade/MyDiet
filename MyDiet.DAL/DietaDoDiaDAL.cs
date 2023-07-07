using MyDiet.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiet.DAL
{
    public class DietaDoDiaDAL : BaseDAL
    {
        public DietaDoDiaDAL()
        {
            
        }

        public int CadastrarDietaDoDia(DietaDoDia dietaDoDia)
        {
            //Fazer o trigger para calcular ProteinasTotais e CaloriasTotas
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"INSERT INTO TB_DietaDoDia (AlimentoId,GramasAlimento)
                              VALUES ({0}, {1})",dietaDoDia.AlimentoId, dietaDoDia.GramasAlimento);


            return ExecuteScalar(sb);
        }

        public bool EditarDietaDoDia(DietaDoDia dietaDoDia)
        {
            //Fazer o trigger para recalcular ProteinasTotais e CaloriasTotas
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"UPDATE TB_DietaDoDia
                              SET AlimentoId={0},GramasAlimento={1}
                              WHERE Id={3}",dietaDoDia.AlimentoId, dietaDoDia.GramasAlimento,dietaDoDia.Id);


            return ExecuteNonQuery(sb);
        }
    }
}
