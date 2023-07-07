using MyDiet.Entity;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDiet.DAL
{
    public class AlimentoDAL : BaseDAL
    {
        public AlimentoDAL()
        {
            
        }

        public int CadastrarAlimento(Alimento alimento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"INSERT INTO TB_Alimento
                                (NomeAlimento,CaloriaPorGrama,ProteinaPorGrama)
                                VALUES
                                ('{0}',{1},{2})",
                                alimento.NomeAlimento, alimento.CaloriaPorGrama.ToString("N2", CultureInfo.InvariantCulture), alimento.ProteinaPorGrama.ToString("N2", CultureInfo.InvariantCulture));


            return ExecuteScalar(sb);
        }

        public bool EditarAlimento(Alimento alimento)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"UPDATE TB_Alimento
                           SET NomeAlimento='{0}', CaloriaPorGrama={1}, ProteinaPorGrama={2}
                            WHERE Id={3}",alimento.NomeAlimento, alimento.CaloriaPorGrama, alimento.ProteinaPorGrama, alimento.Id);


            return ExecuteNonQuery(sb);
        }
    }
}
