namespace MyDiet
{
    partial class FrmCadastroAlimento
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
            txtNomeAlimento = new TextBox();
            lblNomeAlimento = new Label();
            lblCaloriaPorGrama = new Label();
            txtCaloriaPorGrama = new TextBox();
            btnCadastrar = new Button();
            btnCancelarCadastro = new Button();
            label1 = new Label();
            txtProteinaPorGrama = new TextBox();
            SuspendLayout();
            // 
            // txtNomeAlimento
            // 
            txtNomeAlimento.Location = new Point(12, 56);
            txtNomeAlimento.Name = "txtNomeAlimento";
            txtNomeAlimento.Size = new Size(129, 23);
            txtNomeAlimento.TabIndex = 0;
            // 
            // lblNomeAlimento
            // 
            lblNomeAlimento.AutoSize = true;
            lblNomeAlimento.Location = new Point(12, 37);
            lblNomeAlimento.Name = "lblNomeAlimento";
            lblNomeAlimento.Size = new Size(95, 15);
            lblNomeAlimento.TabIndex = 1;
            lblNomeAlimento.Text = "Nome Alimento:";
            // 
            // lblCaloriaPorGrama
            // 
            lblCaloriaPorGrama.AutoSize = true;
            lblCaloriaPorGrama.Location = new Point(170, 37);
            lblCaloriaPorGrama.Name = "lblCaloriaPorGrama";
            lblCaloriaPorGrama.Size = new Size(106, 15);
            lblCaloriaPorGrama.TabIndex = 3;
            lblCaloriaPorGrama.Text = "Caloria Por Grama:";
            // 
            // txtCaloriaPorGrama
            // 
            txtCaloriaPorGrama.Location = new Point(170, 56);
            txtCaloriaPorGrama.Name = "txtCaloriaPorGrama";
            txtCaloriaPorGrama.Size = new Size(129, 23);
            txtCaloriaPorGrama.TabIndex = 2;
            // 
            // btnCadastrar
            // 
            btnCadastrar.Location = new Point(328, 153);
            btnCadastrar.Name = "btnCadastrar";
            btnCadastrar.Size = new Size(129, 23);
            btnCadastrar.TabIndex = 4;
            btnCadastrar.Text = "Cadastrar";
            btnCadastrar.UseVisualStyleBackColor = true;
            btnCadastrar.Click += btnCadastrar_Click;
            // 
            // btnCancelarCadastro
            // 
            btnCancelarCadastro.Location = new Point(12, 153);
            btnCancelarCadastro.Name = "btnCancelarCadastro";
            btnCancelarCadastro.Size = new Size(129, 23);
            btnCancelarCadastro.TabIndex = 5;
            btnCancelarCadastro.Text = "Cancelar";
            btnCancelarCadastro.UseVisualStyleBackColor = true;
            btnCancelarCadastro.Click += btnCancelarCadastro_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(328, 37);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 17;
            label1.Text = "Proteína Por Grama:";
            // 
            // txtProteinaPorGrama
            // 
            txtProteinaPorGrama.Location = new Point(328, 56);
            txtProteinaPorGrama.Name = "txtProteinaPorGrama";
            txtProteinaPorGrama.Size = new Size(129, 23);
            txtProteinaPorGrama.TabIndex = 16;
            // 
            // FrmCadastroAlimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(473, 189);
            Controls.Add(label1);
            Controls.Add(txtProteinaPorGrama);
            Controls.Add(btnCancelarCadastro);
            Controls.Add(btnCadastrar);
            Controls.Add(lblCaloriaPorGrama);
            Controls.Add(txtCaloriaPorGrama);
            Controls.Add(lblNomeAlimento);
            Controls.Add(txtNomeAlimento);
            Name = "FrmCadastroAlimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Cadastro de Alimento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNomeAlimento;
        private Label lblNomeAlimento;
        private Label lblCaloriaPorGrama;
        private TextBox txtCaloriaPorGrama;
        private Button btnCadastrar;
        private Button btnCancelarCadastro;
        private Label label1;
        private TextBox txtProteinaPorGrama;
    }
}