namespace Ejercicio1
{
    partial class Form4
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
            lsbResultados = new ListBox();
            btnCerrar = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(64, 15);
            label1.TabIndex = 0;
            label1.Text = "Resultados";
            // 
            // lsbResultados
            // 
            lsbResultados.FormattingEnabled = true;
            lsbResultados.ItemHeight = 15;
            lsbResultados.Location = new Point(12, 36);
            lsbResultados.Name = "lsbResultados";
            lsbResultados.Size = new Size(397, 109);
            lsbResultados.TabIndex = 1;
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.OK;
            btnCerrar.Location = new Point(104, 161);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 2;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 203);
            Controls.Add(btnCerrar);
            Controls.Add(lsbResultados);
            Controls.Add(label1);
            Name = "Form4";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Ver Resultados";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        public ListBox lsbResultados;
        private Button btnCerrar;
    }
}