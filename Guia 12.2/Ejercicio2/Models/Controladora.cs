using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2.Models
{
    internal class Controladora
    {
        private string[] patentes = new string[100];
        private int[] tiposVehiculos = new int[100];
        private bool[] sonElectricos = new bool[100];
        private int[] modelos = new int[100];
        public int Contador { get; private set; } = 0;

        private string[] patentesElectricos = new string[100];
        private int[] tiposVehiculosElectricos = new int[100];
        private int[] modelosElectricos = new int[100];
        public int ContadorElectricos { get; private set; } = 0;

        public void RegistrarVehiculo(string patente, int tipo, int modelo, bool esElectrico)
        {
            patentes[Contador] = patente;
            tiposVehiculos[Contador] = tipo;
            modelos[Contador] = modelo;
            sonElectricos[Contador] = esElectrico;
            Contador++;
        }

        public void VerVehiculoElectrico(int n, out string patente, out int modelo, out int tipo) {
            patente = "";
            modelo = 0;
            tipo = 0;
            if (n >= 0 && n < Contador) {
                patente = patentes[n];
                modelo = modelos[n];
                tipo = tiposVehiculos[n];
            }
        }

        public void ListarElectricosOrdenados()
        {
            for (int i = 0; i < Contador; i++) {
                if (sonElectricos[i] == true) {
                    patentesElectricos[ContadorElectricos] = patentes[i];
                    modelosElectricos[ContadorElectricos] = modelos[i];
                    tiposVehiculosElectricos[ContadorElectricos] = tiposVehiculos[i];
                    ContadorElectricos++;
                }
            }
        }

        public void OrdenarElectricos()
        {
            for (int i = 0; i < Contador; i++) { 
                for (int j = i+1; j < Contador; j++) {
                    intercambiarElectricos(i, j);
                }
            }

        }

        private void intercambiarElectricos(int n, int m)
        {
            string xPatente;
            int xModelo;
            int xTipo;
            if (modelos[n] > modelos[m])
            {
                xModelo = modelos[n];
                modelos[n] = modelos[m];
                modelos[m] = xModelo;

                xPatente = patentes[n];
                patentes[n] = patentes[m];
                patentes[m] = xPatente;

                xTipo = tiposVehiculos[n];
                tiposVehiculos[n] = tiposVehiculos[m];
                tiposVehiculos[m] = xTipo;
            }
        }

    }
}
