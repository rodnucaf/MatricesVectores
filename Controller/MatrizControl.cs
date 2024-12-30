using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;
using Proyecto.Model;

namespace Proyecto.Controller
{
    internal class MatrizControl
    {
        private MatrizModelo matriz;

        

        public void CrearMatriz(int filas, int columnas)
        {
            matriz = new MatrizModelo(filas, columnas);   
        }

        public void AsignarValor(int fila, int columna, int valor, TableLayoutPanel tlpMatriz)
        {
            if (matriz != null)
            {
                try
                {
                    
                    matriz.AsignarValor(fila, columna, valor);

                    
                    foreach (Control control in tlpMatriz.Controls)
                    {
                        if (control is TextBox)
                        {
                            var position = (Tuple<int, int>)control.Tag; 
                            if (position.Item1 == fila && position.Item2 == columna)
                            {
                                control.Text = valor.ToString(); 
                            }
                        }
                    }
                }
                catch (ArgumentOutOfRangeException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        //Validar si las dimensiones de dos matrices coinciden
        public bool ValidarDimensionCuadradas(int[,] matrizUno, int[,] matrizDos)
        {
            bool resultado;

            if (matrizUno.GetLength(0) == matrizDos.GetLength(0) && matrizUno.GetLength(1) == matrizDos.GetLength(1))
            {
                resultado = true;
            }
            else { resultado = false; }

            return resultado;
        }
        //Validar si la matriz es cuadrada
        public bool ValidarDimension(int[,] matriz)
        {
            bool resultado;

            if (matriz.GetLength(0) == matriz.GetLength(1))
            {
                resultado = true;
            }
            else { resultado = false; }

            return resultado;
        }

        //Métodos de operaciones

        //SUMAR
        public int[,] Sumar(int[,] matrizUno, int[,]matrizDos)
        {
            bool dimension = ValidarDimensionCuadradas(matrizUno, matrizDos);
            int[,] matrizResultado = new int[0, 0];
            
            try
            {
                if (dimension)
                {
                    //Valores para la cantidad de filas y columnas
                    int filas = matrizUno.GetLength(0);
                    int columnas = matrizDos.GetLength(1);
                    matrizResultado = new int[filas, columnas];

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            matrizResultado[i, j] = matrizUno[i, j] + matrizDos[i, j];
                        }
                    }  
                }
                else
                { 
                    //Matriz con la dimensión mínima establecida por los numericUpDown en caso de que no coincidan las dimensiones
                    matrizResultado = new int[2, 2];      
                }
            }
            catch (Exception ex)
            {
                
                MessageBox.Show(ex.Message);
                
            }
            return matrizResultado;
        }

        //RESTAR
        public int[,] Restar(int[,] matrizUno, int[,] matrizDos)
        {
            bool dimension = ValidarDimensionCuadradas(matrizUno, matrizDos);
            int[,] matrizResultado = new int[0, 0];

            try
            {
                if (dimension)
                {
                    //Valores para la cantidad de filas y columnas
                    int filas = matrizUno.GetLength(0);
                    int columnas = matrizDos.GetLength(1);
                    matrizResultado = new int[filas, columnas];

                    for (int i = 0; i < filas; i++)
                    {
                        for (int j = 0; j < columnas; j++)
                        {
                            matrizResultado[i, j] = matrizUno[i, j] - matrizDos[i, j];
                        }
                    }

                }
                else
                {
                    //Matriz con la dimensión mínima establecida por los numericUpDown en caso de que no coincidan las dimensiones
                    matrizResultado = new int[2, 2];
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
                //return matrizResultado;
            }
            return matrizResultado;
        }
        //PRODUCTO ESCALAR
        public int[,] ProductoEscalar(int n, int[,] matriz)
        {
            int[,] matrizResultado = new int[0, 0];
            try
            {
                int filas = matriz.GetLength(0);
                int columnas = matriz.GetLength(1);
                matrizResultado = new int[filas, columnas];

                for (int i = 0; i<matriz.GetLength(0); i++)
                {
                    for (int j = 0; j<matriz.GetLength(1); j++)
                    {
                        matrizResultado[i, j] = matriz[i, j] * n;
                    }
                }
                return matrizResultado;
            }
            catch (Exception)
            {

                throw;
            }        
        }
       
        //PRODUCTO MATRICIAL
        public int[,] ProductoMatricial(int[,] matrizUno, int[,]matrizDos)
        {
           
            //arrays de 2 índices para cargar el número de filas y columnas
            int[] dimensionMatrizUno = new int[2];
            int[] dimensionMatrizDos = new int[2];
            //dimensión de la matrizUno
            dimensionMatrizUno[0] = matrizUno.GetLength(0);
            dimensionMatrizUno[1] = matrizUno.GetLength(1);
            //dimensión de la matrizDos
            dimensionMatrizDos[0] = matrizDos.GetLength(0);
            dimensionMatrizDos[1] = matrizDos.GetLength(1);
            //inicializada matriz reusultante en 0.
            int[,] matrizResultado = new int[0, 0];

            //El número de columnas de matrizUno debe coincidir con las filas de matrizDos.
            if (dimensionMatrizUno[1] == dimensionMatrizDos[0])
            {
                matrizResultado = new int[dimensionMatrizUno[0], dimensionMatrizDos[1]];
                for (int i = 0; i < dimensionMatrizUno[0]; i++) 
                {
                    for (int j = 0; j < dimensionMatrizDos[1]; j++) 
                    {
                        int suma = 0;
                        for (int k = 0; k < dimensionMatrizUno[1]; k++) 
                        {
                            suma += matrizUno[i, k] * matrizDos[k, j];
                        }
                        matrizResultado[i, j] = suma; 
                    }
                }
            }
            return matrizResultado;   
        }
        //DETERMINANTE
        public int Determinante(int[,] matriz)
        {
            int resultado = 0;
            //Corroborar que la matriz sea cuadrada
            if (matriz.GetLength(0) == matriz.GetLength(1) && matriz != null)
            {
                //Caso base para matrices de 2x2
                if (matriz.GetLength(0) is 2)
                {
                    resultado = matriz[0, 0] * matriz[1, 1] - matriz[0, 1] * matriz[1, 0];
                }
                else
                {
                    const int indiceColumna = 0;
                    //Determinante por cofactores, usando la primer columna
                    for (int i = 0; i < matriz.GetLength(1); i++)
                    {
                        int unoOMenosUno = (int)Math.Pow(-1, (indiceColumna + 1) + (i + 1));
                        int cofactor = matriz[i, indiceColumna];
                        int[,] submatriz = Submatriz(matriz, i, indiceColumna);
                        resultado += unoOMenosUno * cofactor * Determinante(submatriz);
                    }
                }
            }
            else
            {
                MessageBox.Show("La matriz debe ser cuadrada para poder calcular su determinante.");
            }

            return resultado;
        }

        //Eliminar columna y fila (Para el desarrolo por cofactores de determinantes)
        public int[,] Submatriz(int[,] matriz, int fila, int columna)
        {
            //no hace falta validar que la matriz sea cuadrada porque este método se va a invocar dentro de otro método que ya lo valida
            int cantidadFilasYCol = matriz.GetLength(0) - 1;
            int[,] submatriz = new int[cantidadFilasYCol, cantidadFilasYCol];
            int subI = 0;
            int subJ;

            for (int i = 0; i < matriz.GetLength(0); i++)  
            {
                if (i == fila) continue;  

                subJ = 0;  

                for (int j = 0; j < matriz.GetLength(1); j++)  
                {
                    if (j == columna) continue;  

                    submatriz[subI, subJ] = matriz[i, j];  
                    subJ++;  
                }
                subI++;  
            }

            return submatriz;  
        }
        



    }
}
