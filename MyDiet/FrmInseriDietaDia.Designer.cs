namespace MyDiet
{
    partial class frmInseriDietaDia
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
            cbxAlimentos = new ComboBox();
            lblAlimentos = new Label();
            txtGramas = new TextBox();
            lblGramas = new Label();
            btnCadastradaDietaDia = new Button();
            btnCancelaDietaDia = new Button();
            SuspendLayout();
            // 
            // cbxAlimentos
            // 
            cbxAlimentos.FormattingEnabled = true;
            cbxAlimentos.Location = new Point(12, 48);
            cbxAlimentos.Name = "cbxAlimentos";
            cbxAlimentos.Size = new Size(121, 23);
            cbxAlimentos.TabIndex = 0;
            // 
            // lblAlimentos
            // 
            lblAlimentos.AutoSize = true;
            lblAlimentos.Location = new Point(12, 30);
            lblAlimentos.Name = "lblAlimentos";
            lblAlimentos.Size = new Size(61, 15);
            lblAlimentos.TabIndex = 1;
            lblAlimentos.Text = "Alimentos";
            // 
            // txtGramas
            // 
            txtGramas.Location = new Point(176, 48);
            txtGramas.Name = "txtGramas";
            txtGramas.Size = new Size(100, 23);
            txtGramas.TabIndex = 2;
            // 
            // lblGramas
            // 
            lblGramas.AutoSize = true;
            lblGramas.Location = new Point(176, 30);
            lblGramas.Name = "lblGramas";
            lblGramas.Size = new Size(47, 15);
            lblGramas.TabIndex = 3;
            lblGramas.Text = "Gramas";
            // 
            // btnCadastradaDietaDia
            // 
            btnCadastradaDietaDia.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnCadastradaDietaDia.Location = new Point(176, 115);
            btnCadastradaDietaDia.Name = "btnCadastradaDietaDia";
            btnCadastradaDietaDia.Size = new Size(100, 23);
            btnCadastradaDietaDia.TabIndex = 4;
            btnCadastradaDietaDia.Text = "Cadastrar";
            btnCadastradaDietaDia.UseVisualStyleBackColor = true;
            btnCadastradaDietaDia.Click += btnCadastradaDietaDia_Click;
            // 
            // btnCancelaDietaDia
            // 
            btnCancelaDietaDia.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            btnCancelaDietaDia.Location = new Point(12, 115);
            btnCancelaDietaDia.Name = "btnCancelaDietaDia";
            btnCancelaDietaDia.Size = new Size(100, 23);
            btnCancelaDietaDia.TabIndex = 5;
            btnCancelaDietaDia.Text = "Cancelar";
            btnCancelaDietaDia.UseVisualStyleBackColor = true;
            btnCancelaDietaDia.Click += btnCancelaDietaDia_Click;
            // 
            // frmInseriDietaDia
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(292, 153);
            Controls.Add(btnCancelaDietaDia);
            Controls.Add(btnCadastradaDietaDia);
            Controls.Add(lblGramas);
            Controls.Add(txtGramas);
            Controls.Add(lblAlimentos);
            Controls.Add(cbxAlimentos);
            Name = "frmInseriDietaDia";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inseri Dieta Dia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbxAlimentos;
        private Label lblAlimentos;
        private TextBox txtGramas;
        private Label lblGramas;
        private Button btnCadastradaDietaDia;
        private Button btnCancelaDietaDia;
    }
}