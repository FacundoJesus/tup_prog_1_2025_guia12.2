using Microsoft.Win32.SafeHandles;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Competencia competencia = new Competencia();

        private void btnAgregarCompetidor_Click(object sender, EventArgs e)
        {
            Form2 fInscripcion = new Form2();

            if (fInscripcion.ShowDialog() == DialogResult.OK)
            {

                string nombre = fInscripcion.tbName.Text;

                competencia.AgregarCompetidor(nombre);

            }
            else
            {
                MessageBox.Show("Competidor no Agregado.");
            }
            fInscripcion.Dispose();
        }

        private void btnCargarTiemposDeCompetidores_Click(object sender, EventArgs e)
        {
            Form3 fCargaTiempo = new Form3();

            int nroCompetidor = 0;

            fCargaTiempo.lbNumeroCompetidor.Text = $"{nroCompetidor}";

            if (fCargaTiempo.ShowDialog() == DialogResult.OK && nroCompetidor < competencia.Contador)
            {
                nroCompetidor++;
                int horas = Convert.ToInt32(fCargaTiempo.nudHoras.Value);
                int minutos = Convert.ToInt32(fCargaTiempo.nudMinutos.Value);

                competencia.CargarTiempo(nroCompetidor, horas, minutos);
            }
            else
            {
                MessageBox.Show("Carga de Tiempo errónea.");
            }

            fCargaTiempo.Dispose();

        }

        private void btnVerResultados_Click(object sender, EventArgs e)
        {
            Form4 fResultados = new Form4();

            competencia.OrdenarListadoPorTiempo();

            for (int i = 0; i< competencia.Contador; i++)
            {
                string nombre;
                int tiempo;
                competencia.VerRegistro(i, out nombre, out tiempo);

                int hs = tiempo / 60;
                int mins = tiempo % 60;

                fResultados.lsbResultados.Items.Add($"Nro Competidor:{i} - Nombre: {nombre} - Tiempo:{hs - mins}");
            }
            fResultados.ShowDialog();
            fResultados.Dispose();
        }
    }
}
