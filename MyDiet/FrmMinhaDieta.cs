using MyDiet.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyDiet
{
    public partial class FrmMinhaDieta : Form
    {
        public FrmMinhaDieta()
        {
            InitializeComponent();
        }

        private void btnInserirDietaDia_Click(object sender, EventArgs e)
        {
            this.Hide();
            frmInseriDietaDia frmInseriDietaDia = new frmInseriDietaDia();
            frmInseriDietaDia.ShowDialog();
            this.Show();
            CarregarGrid();
        }

        private void btnCadastrarAlimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroAlimento frmCadastroAlimento = new FrmCadastroAlimento();
            frmCadastroAlimento.ShowDialog();
            this.Show();
            CarregarGrid();
        }

        private void FrmMinhaDieta_Load(object sender, EventArgs e)
        {
            CarregarGrid();
        }

        private void btnEditarAlimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmEditarAlimento frmEditarAlimento = new FrmEditarAlimento();
            frmEditarAlimento.ShowDialog();
            this.Show();
            CarregarGrid();
        }

        private void btnHistorico_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmHistoricoDieta frmHistoricoDieta = new FrmHistoricoDieta();
            frmHistoricoDieta.ShowDialog();
            this.Show();
            CarregarGrid();
        }
        private void CarregarGrid()
        {
            DietaDoDiaBLL dietaDoDiaBLL = new DietaDoDiaBLL();
            DataTable dt = dietaDoDiaBLL.ObterDietaDoDia();
            decimal proteinaTotal = 0;
            decimal caloriaTotal = 0;

            foreach (DataRow row in dt.Rows)
            {
                if (!row.IsNull("GramasAlimento"))
                {
                    var gramasAlimento = Convert.ToDecimal(row["GramasAlimento"]);

                    if (!row.IsNull("ProteinaPorGrama"))
                    {
                        var proteinaValor = Convert.ToDecimal(row["ProteinaPorGrama"]);
                        proteinaTotal += (gramasAlimento * proteinaValor);
                    }

                    if (!row.IsNull("CaloriaPorGrama"))
                    {
                        var caloriaValor = Convert.ToDecimal(row["CaloriaPorGrama"]);
                        caloriaTotal += (gramasAlimento * caloriaValor);

                    }
                }
            }

            dataGridView1.DataSource = dt;
            lblValorCaloricoTotal.Text = caloriaTotal.ToString("N2");
            lblValorProteicoTotal.Text = proteinaTotal.ToString("N2");
        }
    }
}
