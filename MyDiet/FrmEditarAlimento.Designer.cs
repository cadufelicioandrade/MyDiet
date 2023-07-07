namespace MyDiet
{
    partial class FrmEditarAlimento
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
            btnCancelarCadastro = new Button();
            btnBuscar = new Button();
            lblCaloriaPorGrama = new Label();
            txtCaloriaPorGrama = new TextBox();
            lblNomeAlimento = new Label();
            txtNomeAlimento = new TextBox();
            comboBox1 = new ComboBox();
            btnEditar = new Button();
            label1 = new Label();
            txtProteinaPorGrama = new TextBox();
            SuspendLayout();
            // 
            // btnCancelarCadastro
            // 
            btnCancelarCadastro.Location = new Point(29, 98);
            btnCancelarCadastro.Name = "btnCancelarCadastro";
            btnCancelarCadastro.Size = new Size(129, 23);
            btnCancelarCadastro.TabIndex = 11;
            btnCancelarCadastro.Text = "Cancelar";
            btnCancelarCadastro.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(339, 146);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(129, 23);
            btnBuscar.TabIndex = 10;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            // 
            // lblCaloriaPorGrama
            // 
            lblCaloriaPorGrama.AutoSize = true;
            lblCaloriaPorGrama.Location = new Point(184, 31);
            lblCaloriaPorGrama.Name = "lblCaloriaPorGrama";
            lblCaloriaPorGrama.Size = new Size(106, 15);
            lblCaloriaPorGrama.TabIndex = 9;
            lblCaloriaPorGrama.Text = "Caloria Por Grama:";
            // 
            // txtCaloriaPorGrama
            // 
            txtCaloriaPorGrama.Location = new Point(184, 50);
            txtCaloriaPorGrama.Name = "txtCaloriaPorGrama";
            txtCaloriaPorGrama.Size = new Size(129, 23);
            txtCaloriaPorGrama.TabIndex = 8;
            // 
            // lblNomeAlimento
            // 
            lblNomeAlimento.AutoSize = true;
            lblNomeAlimento.Location = new Point(29, 31);
            lblNomeAlimento.Name = "lblNomeAlimento";
            lblNomeAlimento.Size = new Size(95, 15);
            lblNomeAlimento.TabIndex = 7;
            lblNomeAlimento.Text = "Nome Alimento:";
            // 
            // txtNomeAlimento
            // 
            txtNomeAlimento.Location = new Point(29, 50);
            txtNomeAlimento.Name = "txtNomeAlimento";
            txtNomeAlimento.Size = new Size(129, 23);
            txtNomeAlimento.TabIndex = 6;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(339, 98);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(129, 23);
            comboBox1.TabIndex = 12;
            // 
            // btnEditar
            // 
            btnEditar.Location = new Point(184, 98);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(129, 23);
            btnEditar.TabIndex = 13;
            btnEditar.Text = "Editar Alimento";
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(339, 31);
            label1.Name = "label1";
            label1.Size = new Size(113, 15);
            label1.TabIndex = 15;
            label1.Text = "Proteína Por Grama:";
            // 
            // txtProteinaPorGrama
            // 
            txtProteinaPorGrama.Location = new Point(339, 50);
            txtProteinaPorGrama.Name = "txtProteinaPorGrama";
            txtProteinaPorGrama.Size = new Size(129, 23);
            txtProteinaPorGrama.TabIndex = 14;
            // 
            // frmEditarAlimento
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(493, 200);
            Controls.Add(label1);
            Controls.Add(txtProteinaPorGrama);
            Controls.Add(btnEditar);
            Controls.Add(comboBox1);
            Controls.Add(btnCancelarCadastro);
            Controls.Add(btnBuscar);
            Controls.Add(lblCaloriaPorGrama);
            Controls.Add(txtCaloriaPorGrama);
            Controls.Add(lblNomeAlimento);
            Controls.Add(txtNomeAlimento);
            Name = "frmEditarAlimento";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Editar Alimento";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnCancelarCadastro;
        private Button btnBuscar;
        private Label lblCaloriaPorGrama;
        private TextBox txtCaloriaPorGrama;
        private Label lblNomeAlimento;
        private TextBox txtNomeAlimento;
        private ComboBox comboBox1;
        private Button btnEditar;
        private Label label1;
        private TextBox txtProteinaPorGrama;
    }
}