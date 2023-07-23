namespace MyDiet
{
    partial class FrmMinhaDieta
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnInserirDietaDia = new Button();
            dataGridView1 = new DataGridView();
            btnEditarAlimento = new Button();
            btnCadastrarAlimento = new Button();
            btnHistorico = new Button();
            lblTotalCaloriasDia = new Label();
            lblValorCaloricoTotal = new Label();
            lblValorProteicoTotal = new Label();
            lblTotalProteinaDia = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnInserirDietaDia
            // 
            btnInserirDietaDia.Location = new Point(463, 39);
            btnInserirDietaDia.Name = "btnInserirDietaDia";
            btnInserirDietaDia.Size = new Size(123, 23);
            btnInserirDietaDia.TabIndex = 0;
            btnInserirDietaDia.Text = "Inserir Dieta Dia";
            btnInserirDietaDia.UseVisualStyleBackColor = true;
            btnInserirDietaDia.Click += btnInserirDietaDia_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(11, 39);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(444, 187);
            dataGridView1.TabIndex = 1;
            // 
            // btnEditarAlimento
            // 
            btnEditarAlimento.Location = new Point(463, 147);
            btnEditarAlimento.Name = "btnEditarAlimento";
            btnEditarAlimento.Size = new Size(123, 23);
            btnEditarAlimento.TabIndex = 2;
            btnEditarAlimento.Text = "Editar Alimento";
            btnEditarAlimento.UseVisualStyleBackColor = true;
            btnEditarAlimento.Click += btnEditarAlimento_Click;
            // 
            // btnCadastrarAlimento
            // 
            btnCadastrarAlimento.Location = new Point(463, 93);
            btnCadastrarAlimento.Name = "btnCadastrarAlimento";
            btnCadastrarAlimento.Size = new Size(123, 23);
            btnCadastrarAlimento.TabIndex = 3;
            btnCadastrarAlimento.Text = "Cadastrar Alimento";
            btnCadastrarAlimento.UseVisualStyleBackColor = true;
            btnCadastrarAlimento.Click += btnCadastrarAlimento_Click;
            // 
            // btnHistorico
            // 
            btnHistorico.Location = new Point(463, 201);
            btnHistorico.Name = "btnHistorico";
            btnHistorico.Size = new Size(123, 23);
            btnHistorico.TabIndex = 4;
            btnHistorico.Text = "Exibir Histórico";
            btnHistorico.UseVisualStyleBackColor = true;
            btnHistorico.Click += btnHistorico_Click;
            // 
            // lblTotalCaloriasDia
            // 
            lblTotalCaloriasDia.AutoSize = true;
            lblTotalCaloriasDia.Location = new Point(315, 239);
            lblTotalCaloriasDia.Name = "lblTotalCaloriasDia";
            lblTotalCaloriasDia.Size = new Size(100, 15);
            lblTotalCaloriasDia.TabIndex = 5;
            lblTotalCaloriasDia.Text = "Total Calorias Dia:";
            // 
            // lblValorCaloricoTotal
            // 
            lblValorCaloricoTotal.AutoSize = true;
            lblValorCaloricoTotal.Location = new Point(414, 239);
            lblValorCaloricoTotal.Name = "lblValorCaloricoTotal";
            lblValorCaloricoTotal.Size = new Size(37, 15);
            lblValorCaloricoTotal.TabIndex = 6;
            lblValorCaloricoTotal.Text = "00000";
            // 
            // lblValorProteicoTotal
            // 
            lblValorProteicoTotal.AutoSize = true;
            lblValorProteicoTotal.Location = new Point(274, 239);
            lblValorProteicoTotal.Name = "lblValorProteicoTotal";
            lblValorProteicoTotal.Size = new Size(37, 15);
            lblValorProteicoTotal.TabIndex = 8;
            lblValorProteicoTotal.Text = "00000";
            // 
            // lblTotalProteinaDia
            // 
            lblTotalProteinaDia.AutoSize = true;
            lblTotalProteinaDia.Location = new Point(168, 239);
            lblTotalProteinaDia.Name = "lblTotalProteinaDia";
            lblTotalProteinaDia.Size = new Size(107, 15);
            lblTotalProteinaDia.TabIndex = 7;
            lblTotalProteinaDia.Text = "Total Proteínas Dia:";
            // 
            // FrmMinhaDieta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(605, 277);
            Controls.Add(lblValorProteicoTotal);
            Controls.Add(lblTotalProteinaDia);
            Controls.Add(lblValorCaloricoTotal);
            Controls.Add(lblTotalCaloriasDia);
            Controls.Add(btnHistorico);
            Controls.Add(btnCadastrarAlimento);
            Controls.Add(btnEditarAlimento);
            Controls.Add(dataGridView1);
            Controls.Add(btnInserirDietaDia);
            Name = "FrmMinhaDieta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Minha Dieta";
            Load += FrmMinhaDieta_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInserirDietaDia;
        private DataGridView dataGridView1;
        private Button btnEditarAlimento;
        private Button btnCadastrarAlimento;
        private Button btnHistorico;
        private Label lblTotalCaloriasDia;
        private Label lblValorCaloricoTotal;
        private Label lblValorProteicoTotal;
        private Label lblTotalProteinaDia;
    }
}