using Ejercicio2.Models;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Controladora controladora = new Controladora();

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string patente = tbPatente.Text;
            int tipoVehiculo = cmbTipoVehiculo.SelectedIndex;
            int modelo = Convert.ToInt32(tbModelo.Text);

            bool esElectrico = cbEsElectronico.Checked;

            controladora.RegistrarVehiculo(patente, tipoVehiculo, modelo, esElectrico);

            //Limpio campos
            tbPatente.Clear();
            cmbTipoVehiculo.SelectedIndex = -1;
            tbModelo.Clear();
            cbEsElectronico.Checked = false;
        }

        private void btnVerEstadistica_Click(object sender, EventArgs e)
        {
            Estadistica fEstadistica = new Estadistica();

            controladora.ListarElectricosOrdenados();

            if (controladora.ContadorElectricos > 0)
            {
                fEstadistica.lsbResultados.Items.Add("Vehículos eléctricos:");

                for (int i = 0; i < controladora.ContadorElectricos; i++) {

                    string patente;
                    int modelo;
                    int tipo;
                    controladora.VerVehiculoElectrico(i, out patente, out modelo, out tipo);

                    string tipoVehiculo = "";
                    switch(tipo)
                    {
                        case 1:
                            tipoVehiculo = "Automóvil";
                            break;
                        case 2:
                            tipoVehiculo = "Motocicleta";
                            break;
                        case 3:
                            tipoVehiculo = "Camioneta";
                            break;
                        case 4:
                            tipoVehiculo = "Camión";
                            break;
                        default:
                            tipoVehiculo = "Inexistente";
                            break;
                    }
                    fEstadistica.lsbResultados.Items.Add($"{patente} - {modelo} - {tipoVehiculo}");

                    fEstadistica.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("No se han registrado vehículos.");
            }
            
            fEstadistica.Dispose();
        }
    }
}
