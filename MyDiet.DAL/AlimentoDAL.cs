using MyDiet.Entity;
using System;
using System.Collections.Generic;
using System.Data;
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

        public List<Alimento> ObterAlimento(string where = "")
        {
            List<Alimento> alimentos = new List<Alimento>();
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(@"SELECT	Id, 
		                                NomeAlimento, 
		                                CaloriaPorGrama, 
		                                ProteinaPorGrama  
	                                FROM TB_Alimento ");

            if(!String.IsNullOrEmpty(where))
                sb.AppendFormat("WHERE = {0}", where);

            DataTable dt = Consultar(sb);

            foreach (DataRow row in dt.Rows)
            {
                Alimento alimento = new Alimento();
                if (!row.IsNull("Id")) alimento.Id = Convert.ToInt32(row["Id"]);
                if (!row.IsNull("NomeAlimento")) alimento.NomeAlimento = row["NomeAlimento"].ToString();
                if (!row.IsNull("CaloriaPorGrama")) alimento.CaloriaPorGrama = Convert.ToDecimal(row["CaloriaPorGrama"]);
                if (!row.IsNull("ProteinaPorGrama")) alimento.ProteinaPorGrama = Convert.ToDecimal(row["ProteinaPorGrama"]);
                alimentos.Add(alimento);
            }

            return alimentos;
        }
    }
}
