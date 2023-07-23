namespace MyDiet
{
    partial class FrmHistoricoDieta
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
            dgvDietaDia = new DataGridView();
            button1 = new Button();
            calHistoricoDieta = new MonthCalendar();
            btnVoltarHistorico = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvDietaDia).BeginInit();
            SuspendLayout();
            // 
            // dgvDietaDia
            // 
            dgvDietaDia.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvDietaDia.Location = new Point(12, 25);
            dgvDietaDia.Name = "dgvDietaDia";
            dgvDietaDia.RowTemplate.Height = 25;
            dgvDietaDia.Size = new Size(482, 249);
            dgvDietaDia.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            button1.Location = new Point(380, 437);
            button1.Name = "button1";
            button1.Size = new Size(114, 23);
            button1.TabIndex = 5;
            button1.Text = "Exibir Histórico";
            button1.UseVisualStyleBackColor = true;
            // 
            // calHistoricoDieta
            // 
            calHistoricoDieta.Location = new Point(12, 298);
            calHistoricoDieta.Name = "calHistoricoDieta";
            calHistoricoDieta.TabIndex = 6;
            // 
            // btnVoltarHistorico
            // 
            btnVoltarHistorico.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnVoltarHistorico.Location = new Point(260, 437);
            btnVoltarHistorico.Name = "btnVoltarHistorico";
            btnVoltarHistorico.Size = new Size(114, 23);
            btnVoltarHistorico.TabIndex = 7;
            btnVoltarHistorico.Text = "Voltar";
            btnVoltarHistorico.UseVisualStyleBackColor = true;
            btnVoltarHistorico.Click += btnVoltarHistorico_Click;
            // 
            // FrmHistoricoDieta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(506, 472);
            Controls.Add(btnVoltarHistorico);
            Controls.Add(calHistoricoDieta);
            Controls.Add(button1);
            Controls.Add(dgvDietaDia);
            Name = "FrmHistoricoDieta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Histórico Dieta";
            ((System.ComponentModel.ISupportInitialize)dgvDietaDia).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvDietaDia;
        private Button button1;
        private MonthCalendar calHistoricoDieta;
        private Button btnVoltarHistorico;
    }
}