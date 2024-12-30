using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Proyecto.Model;

namespace Proyecto.Controller
{
    internal class VectorControl
    {
        private VectorModelo vector;

        public void CrearVector(int dimension)
        {
            vector = new VectorModelo(dimension);
        }

        public int[] ObtenerVectorDesdeVista(TableLayoutPanel tlp)
        {
            int dimension = tlp.Controls.Count;
            int[] vector = new int[dimension];

            for (int i = 0; i < dimension; i++)
            {
                TextBox textBox = (TextBox)tlp.Controls[i];
                if (int.TryParse(textBox.Text, out int valor))
                {
                    vector[i] = valor;
                }
                else
                {
                    MessageBox.Show("Por favor, ingresa un valor numérico válido en el campo " + (i + 1));
                    return null;  
                }
            }

            return vector;
        }

        public bool ValidarDimension(int[] vectorUno, int[] VectorDos)
        {
            bool resultado;

            if (vectorUno.Length == VectorDos.Length)
            {
                resultado = true;
            }

            else
            {
                resultado = false;
            }

            return resultado;
        }

        public int[] Sumar(int[]vectorUno, int[] vectorDos)
        {
            int[] resultado = new int[0];
            bool coincidenDimensiones = ValidarDimension(vectorUno, vectorDos);


            if (coincidenDimensiones)
            {
                resultado = new int[vectorUno.Length];
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = vectorUno[i] + vectorDos[i];
                }
            }
            else { MessageBox.Show("No coinciden las dimensiones de los vectores."); }

            return resultado;
        }

        public int[] Restar(int[]vectorUno, int[]vectorDos)
        {
            int[] resultado = new int[0];
            bool coincidenDimensiones = ValidarDimension(vectorUno, vectorDos);


            if (coincidenDimensiones)
            {
                resultado = new int[vectorUno.Length];
                for (int i = 0; i < resultado.Length; i++)
                {
                    resultado[i] = vectorUno[i] - vectorDos[i];
                }
            }
            else { MessageBox.Show("No coinciden las dimensiones de los vectores."); }

            return resultado;
        }

        public int[] ProductoPorEscalar(int[]vector, int n)
        {
            if (vector != null )
            {
                try
                {
                    for (int i = 0; i < vector.Length; i++)
                    {
                        vector[i] = vector[i] * n;
                    }


                }
                catch (Exception)
                {

                    throw;
                }
                
            }
            else
            { 
                MessageBox.Show("Asegúrese de que estén cargados todos los valores del vector");
                vector = new int[0];
            }

            return vector;

        }

        public int ProductoEscalar(int[] vectorUno, int[] vectorDos)
        {
            int resultado = 0;
            bool coincidenDimensiones = ValidarDimension(vectorUno, vectorDos);

            if (coincidenDimensiones)
            {

                for (int i = 0; i < vectorUno.Length; i++)
                {
                    resultado += vectorUno[i] * vectorDos[i];
                }
            }
            else { MessageBox.Show("Las dimensiones de los vectores no coinciden"); }

            return resultado;
        }

        public int[] ProductoVectorial(int[]vectorUno, int[]vectorDos)
        { 
            int[] resultado = new int[3];

            if (vectorUno != null && vectorDos != null)
            {
                if (vectorUno.Length is 3 && vectorDos.Length is 3)
                {
                    resultado[0] = (vectorUno[1] * vectorDos[2]) - (vectorUno[2] * vectorDos[1]);
                    resultado[1] = (vectorUno[2] * vectorDos[0]) - (vectorUno[0] * vectorDos[2]);
                    resultado[2] = (vectorUno[0] * vectorDos[1]) - (vectorUno[1] * vectorDos[0]);
                }
                else { MessageBox.Show("Para realizar esta operacioón es necesario que la dimensión de ambos vectores sea TRES."); }
            }
            else { MessageBox.Show("Asegúrese de que estén cargados todos los valores de los vectores."); }

            return resultado;
        }
    }
}
