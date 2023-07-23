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
    public partial class FrmCadastroAlimento : Form
    {
        public FrmCadastroAlimento()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtProteinaPorGrama.Text) && !String.IsNullOrEmpty(txtCaloriaPorGrama.Text))
            {
                Alimento alimento = new Alimento();
                alimento.NomeAlimento = txtNomeAlimento.Text;
                alimento.CaloriaPorGrama = Convert.ToDecimal(txtCaloriaPorGrama.Text);
                alimento.ProteinaPorGrama = Convert.ToDecimal(txtProteinaPorGrama.Text);

                AlimentoBLL alimentoBLL = new AlimentoBLL();
                alimentoBLL.CadastrarAlimento(alimento);
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos os campos devem ser preenchidos!");
            }

        }

        private void btnVoltarCadastro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
