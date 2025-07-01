using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    internal class Competencia
    {
        private string[] nombres = new string[100];
        private int[] tiempos = new int[100];
        public int Contador { get; private set; } //Read Only

        public void AgregarCompetidor(string nombre)
        {
            nombres[Contador] = nombre;
            Contador++;
        }

        public void VerRegistro(int idx, out string nombre, out int tiempo) {
            tiempo = 0;
            nombre = "";

            if (idx >=0 && idx < Contador) {
                nombre = nombres[idx];
                tiempo = tiempos[idx];
            }
        }

        public void CargarTiempo(int numeroCompetidor, int HH, int MM)
        {
            tiempos[numeroCompetidor] = HH * 60 + MM;

        }

        public void OrdenarListadoPorTiempo()
        {
            string xNombre;
            int xTiempo;
            for (int i = 0; i < Contador-1; i++) {
                for (int j = i+1; j < Contador; j++)
                {
                    if (tiempos[i] > tiempos[j])
                    {
                        xTiempo = tiempos[i];
                        tiempos[i] = tiempos[j];
                        tiempos[j] = xTiempo;

                        xNombre = nombres[i];
                        nombres[i] = nombres[j];
                        nombres[j] = xNombre;
                    }
                }
            }
        }


    }
}
