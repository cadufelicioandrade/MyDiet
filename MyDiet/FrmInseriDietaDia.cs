using MyDiet.BLL;
using MyDiet.Entity;
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
    public partial class frmInseriDietaDia : Form
    {
        public frmInseriDietaDia()
        {
            InitializeComponent();
        }

        private void btnCadastradaDietaDia_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtGramas.Text) && !String.IsNullOrEmpty(txtGramas.Text))
            {
                DateTable dietaDoDia = new DateTable();
                var arr = cbxAlimentos.SelectedItem.ToString().Split('-');
                dietaDoDia.AlimentoId = Convert.ToInt32(arr[0]);
                dietaDoDia.GramasAlimento = Convert.ToDouble(txtGramas.Text);
                DietaDoDiaBLL dietaDoDiaBLL = new DietaDoDiaBLL();
                dietaDoDiaBLL.CadastrarDieta(dietaDoDia);
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }


        }

        private void frmInseriDietaDia_Load(object sender, EventArgs e)
        {
            AlimentoBLL alimentoBLL = new AlimentoBLL();
            var alimentos = alimentoBLL.ObterAlimento();

            foreach (var alimento in alimentos)
                cbxAlimentos.Items.Add($"{alimento.Id}-{alimento.NomeAlimento}");
        }

        private void btnVoltarDietaDia_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
