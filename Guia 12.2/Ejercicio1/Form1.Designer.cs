namespace Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnAgregarCompetidor = new Button();
            btnCargarTiemposDeCompetidores = new Button();
            btnVerResultados = new Button();
            SuspendLayout();
            // 
            // btnAgregarCompetidor
            // 
            btnAgregarCompetidor.Location = new Point(52, 12);
            btnAgregarCompetidor.Name = "btnAgregarCompetidor";
            btnAgregarCompetidor.Size = new Size(136, 44);
            btnAgregarCompetidor.TabIndex = 0;
            btnAgregarCompetidor.Text = "Agregar Competidor";
            btnAgregarCompetidor.UseVisualStyleBackColor = true;
            btnAgregarCompetidor.Click += btnAgregarCompetidor_Click;
            // 
            // btnCargarTiemposDeCompetidores
            // 
            btnCargarTiemposDeCompetidores.Location = new Point(52, 84);
            btnCargarTiemposDeCompetidores.Name = "btnCargarTiemposDeCompetidores";
            btnCargarTiemposDeCompetidores.Size = new Size(136, 44);
            btnCargarTiemposDeCompetidores.TabIndex = 1;
            btnCargarTiemposDeCompetidores.Text = "Cargar Tiempos de competidores";
            btnCargarTiemposDeCompetidores.UseVisualStyleBackColor = true;
            btnCargarTiemposDeCompetidores.Click += btnCargarTiemposDeCompetidores_Click;
            // 
            // btnVerResultados
            // 
            btnVerResultados.Location = new Point(52, 156);
            btnVerResultados.Name = "btnVerResultados";
            btnVerResultados.Size = new Size(136, 44);
            btnVerResultados.TabIndex = 2;
            btnVerResultados.Text = "Ver Resultados";
            btnVerResultados.UseVisualStyleBackColor = true;
            btnVerResultados.Click += btnVerResultados_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(240, 214);
            Controls.Add(btnVerResultados);
            Controls.Add(btnCargarTiemposDeCompetidores);
            Controls.Add(btnAgregarCompetidor);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ejercicio 1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnAgregarCompetidor;
        private Button btnCargarTiemposDeCompetidores;
        private Button btnVerResultados;
    }
}
