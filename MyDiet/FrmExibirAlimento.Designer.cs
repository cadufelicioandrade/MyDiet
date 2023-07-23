namespace MyDiet
{
    partial class FrmExibirAlimento
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
            dataGridView1 = new DataGridView();
            btnBuscaAlimento = new Button();
            txtBuscaAlimento = new TextBox();
            btnLimpar = new Button();
            btnVoltar = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 26);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(437, 150);
            dataGridView1.TabIndex = 0;
            // 
            // btnBuscaAlimento
            // 
            btnBuscaAlimento.Location = new Point(324, 217);
            btnBuscaAlimento.Name = "btnBuscaAlimento";
            btnBuscaAlimento.Size = new Size(125, 23);
            btnBuscaAlimento.TabIndex = 1;
            btnBuscaAlimento.Text = "Buscar";
            btnBuscaAlimento.UseVisualStyleBackColor = true;
            // 
            // txtBuscaAlimento
            // 
            txtBuscaAlimento.Location = new Point(12, 182);
            txtBuscaAlimento.Name = "txtBuscaAlimento";
            txtBuscaAlimento.Size = new Size(437, 23);
            txtBuscaAlimento.TabIndex = 2;
            // 
            // btnLimpar
            // 
            btnLimpar.Location = new Point(168, 217);
            btnLimpar.Name = "btnLimpar";
            btnLimpar.Size = new Size(125, 23);
            btnLimpar.TabIndex = 3;
            btnLimpar.Text = "Limpar";
            btnLimpar.UseVisualStyleBackColor = true;
            // 
            // btnVoltar
            // 
            btnVoltar.Location = new Point(12, 217);
            btnVoltar.Name = "btnVoltar";
            btnVoltar.Size = new Size(125, 23);
            btnVoltar.TabIndex = 4;
            btnVoltar.Text = "Voltar";
            btnVoltar.UseVisualStyleBackColor = true;
            // 
            // FrmExibirAlimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(461, 249);
            Controls.Add(btnVoltar);
            Controls.Add(btnLimpar);
            Controls.Add(txtBuscaAlimento);
            Controls.Add(btnBuscaAlimento);
            Controls.Add(dataGridView1);
            Name = "FrmExibirAlimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Dados Alimento";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private Button btnBuscaAlimento;
        private TextBox txtBuscaAlimento;
        private Button btnLimpar;
        private Button btnVoltar;
    }
}