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
        }

        private void btnCadastrarAlimento_Click(object sender, EventArgs e)
        {
            this.Hide();
            FrmCadastroAlimento frmCadastroAlimento = new FrmCadastroAlimento();
            frmCadastroAlimento.ShowDialog();
            this.Show();
        }
    }
}
