using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto.Model
{
    internal class MatrizModelo
    {
        // Atributos
        private int nFilas;
        private int mColumnas;
        private int[,] matriz;

        // Constructor, recibe por parámetros la dimensión de la matriz nFilas x mColumnas
        public MatrizModelo(int filas, int columnas)
        {
            //cantidad filas, cantidad columnas
            this.nFilas = filas;
            this.mColumnas = columnas;

            // Se crea la matriz con la dimensión requerida
            this.matriz = new int[nFilas, mColumnas];
        }

        public void AsignarValor(int fila, int columna, int valor)
        {
            if (fila >= 0 && fila < nFilas && columna >= 0 && columna < mColumnas)
            {
                matriz[fila, columna] = valor;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Índices fuera de rango");
            }
        }






    }
}
