namespace Ejercicio2
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
            groupBox1 = new GroupBox();
            cmbTipoVehiculo = new ComboBox();
            tbModelo = new TextBox();
            tbPatente = new TextBox();
            btnRegistrar = new Button();
            cbEsElectronico = new CheckBox();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnVerEstadistica = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbTipoVehiculo);
            groupBox1.Controls.Add(tbModelo);
            groupBox1.Controls.Add(tbPatente);
            groupBox1.Controls.Add(btnRegistrar);
            groupBox1.Controls.Add(cbEsElectronico);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(315, 193);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Datos de Ingreso";
            // 
            // cmbTipoVehiculo
            // 
            cmbTipoVehiculo.FormattingEnabled = true;
            cmbTipoVehiculo.Items.AddRange(new object[] { "Automóvil", "Motocicleta", "Camioneta", "Camión" });
            cmbTipoVehiculo.Location = new Point(174, 62);
            cmbTipoVehiculo.Name = "cmbTipoVehiculo";
            cmbTipoVehiculo.Size = new Size(121, 23);
            cmbTipoVehiculo.TabIndex = 6;
            // 
            // tbModelo
            // 
            tbModelo.Location = new Point(195, 94);
            tbModelo.Name = "tbModelo";
            tbModelo.Size = new Size(100, 23);
            tbModelo.TabIndex = 5;
            // 
            // tbPatente
            // 
            tbPatente.Location = new Point(195, 30);
            tbPatente.Name = "tbPatente";
            tbPatente.Size = new Size(100, 23);
            tbPatente.TabIndex = 4;
            // 
            // btnRegistrar
            // 
            btnRegistrar.Location = new Point(220, 136);
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.Size = new Size(75, 36);
            btnRegistrar.TabIndex = 1;
            btnRegistrar.Text = "Registrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            btnRegistrar.Click += btnRegistrar_Click;
            // 
            // cbEsElectronico
            // 
            cbEsElectronico.AutoSize = true;
            cbEsElectronico.Location = new Point(54, 136);
            cbEsElectronico.Name = "cbEsElectronico";
            cbEsElectronico.Size = new Size(109, 19);
            cbEsElectronico.TabIndex = 3;
            cbEsElectronico.Text = "¿Es electrónico?";
            cbEsElectronico.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 97);
            label3.Name = "label3";
            label3.Size = new Size(162, 15);
            label3.TabIndex = 2;
            label3.Text = "Modelo (Año de fabricación):";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(71, 65);
            label2.Name = "label2";
            label2.Size = new Size(97, 15);
            label2.TabIndex = 1;
            label2.Text = "Tipo de vehículo:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(113, 33);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Patente:";
            // 
            // btnVerEstadistica
            // 
            btnVerEstadistica.Location = new Point(343, 18);
            btnVerEstadistica.Name = "btnVerEstadistica";
            btnVerEstadistica.Size = new Size(75, 47);
            btnVerEstadistica.TabIndex = 4;
            btnVerEstadistica.Text = "Ver Estadística";
            btnVerEstadistica.UseVisualStyleBackColor = true;
            btnVerEstadistica.Click += btnVerEstadistica_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(429, 216);
            Controls.Add(btnVerEstadistica);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Control de paso";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox cbEsElectronico;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox cmbTipoVehiculo;
        private TextBox tbModelo;
        private TextBox tbPatente;
        private Button btnRegistrar;
        private Button btnVerEstadistica;
    }
}
