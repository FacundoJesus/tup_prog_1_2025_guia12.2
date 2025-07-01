namespace Ejercicio1
{
    partial class Form3
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
            label1 = new Label();
            label2 = new Label();
            lbNumeroCompetidor = new Label();
            btnAgregar = new Button();
            label3 = new Label();
            nudHoras = new NumericUpDown();
            nudMinutos = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)nudHoras).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutos).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 18);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 0;
            label1.Text = "Número Competidor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(83, 60);
            label2.Name = "label2";
            label2.Size = new Size(50, 15);
            label2.TabIndex = 1;
            label2.Text = "Tiempo:";
            // 
            // lbNumeroCompetidor
            // 
            lbNumeroCompetidor.AutoSize = true;
            lbNumeroCompetidor.BackColor = SystemColors.ActiveCaption;
            lbNumeroCompetidor.Location = new Point(166, 18);
            lbNumeroCompetidor.Name = "lbNumeroCompetidor";
            lbNumeroCompetidor.Size = new Size(12, 15);
            lbNumeroCompetidor.TabIndex = 2;
            lbNumeroCompetidor.Text = "-";
            // 
            // btnAgregar
            // 
            btnAgregar.DialogResult = DialogResult.OK;
            btnAgregar.Location = new Point(113, 105);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(75, 23);
            btnAgregar.TabIndex = 3;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(221, 60);
            label3.Name = "label3";
            label3.Size = new Size(10, 15);
            label3.TabIndex = 4;
            label3.Text = ":";
            // 
            // nudHoras
            // 
            nudHoras.Location = new Point(153, 58);
            nudHoras.Name = "nudHoras";
            nudHoras.Size = new Size(62, 23);
            nudHoras.TabIndex = 5;
            // 
            // nudMinutos
            // 
            nudMinutos.Location = new Point(237, 58);
            nudMinutos.Maximum = new decimal(new int[] { 59, 0, 0, 0 });
            nudMinutos.Name = "nudMinutos";
            nudMinutos.Size = new Size(62, 23);
            nudMinutos.TabIndex = 6;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(319, 143);
            Controls.Add(nudMinutos);
            Controls.Add(nudHoras);
            Controls.Add(label3);
            Controls.Add(btnAgregar);
            Controls.Add(lbNumeroCompetidor);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form3";
            Text = "Carga de tiempo del competidor";
            ((System.ComponentModel.ISupportInitialize)nudHoras).EndInit();
            ((System.ComponentModel.ISupportInitialize)nudMinutos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        public Label lbNumeroCompetidor;
        private Button btnAgregar;
        private Label label3;
        public NumericUpDown nudMinutos;
        public NumericUpDown nudHoras;
    }
}