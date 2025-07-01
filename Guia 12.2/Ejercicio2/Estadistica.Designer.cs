namespace Ejercicio2
{
    partial class Estadistica
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
            lsbResultados = new ListBox();
            btnCerrar = new Button();
            groupBox1 = new GroupBox();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lsbResultados
            // 
            lsbResultados.FormattingEnabled = true;
            lsbResultados.ItemHeight = 15;
            lsbResultados.Location = new Point(6, 22);
            lsbResultados.Name = "lsbResultados";
            lsbResultados.Size = new Size(319, 139);
            lsbResultados.TabIndex = 0;
            // 
            // btnCerrar
            // 
            btnCerrar.DialogResult = DialogResult.OK;
            btnCerrar.Location = new Point(120, 168);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(75, 23);
            btnCerrar.TabIndex = 1;
            btnCerrar.Text = "Cerrar";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnCerrar);
            groupBox1.Controls.Add(lsbResultados);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(331, 197);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Resultados";
            // 
            // Estadistica
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 221);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Estadistica";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Estadistica";
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        public ListBox lsbResultados;
        private Button btnCerrar;
        private GroupBox groupBox1;
    }
}