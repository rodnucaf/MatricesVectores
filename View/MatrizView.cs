using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Controller;
using Proyecto.Model;

namespace Proyecto.View
{
    public partial class MatrizView : Form
    {
        private MatrizControl controlador;

        public MatrizView()
        {
            InitializeComponent();
            controlador = new MatrizControl();
        }
        private void ConfigurarTableLayoutPanelGenerico(TableLayoutPanel tlp, int filas, int columnas, bool esResultado = false)
        {
            // Limpiar el TableLayoutPanel
            tlp.Controls.Clear();
            tlp.RowCount = filas;
            tlp.ColumnCount = columnas;

            // Ajustar el tamaño de las filas y columnas
            tlp.RowStyles.Clear();
            tlp.ColumnStyles.Clear();

            // Configurar las filas
            for (int i = 0; i < filas; i++)
            {
                tlp.RowStyles.Add(new RowStyle(SizeType.Percent, 100F / filas));
            }

            // Configurar las columnas
            for (int j = 0; j < columnas; j++)
            {
                tlp.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F / columnas));
            }

            // Crear las celdas (TextBox) en el TableLayoutPanel
            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < columnas; j++)
                {
                    TextBox txtBox = new TextBox();
                    txtBox.Dock = DockStyle.Fill;
                    txtBox.Margin = new Padding(0);  // Quitar márgenes
                    txtBox.Tag = new Tuple<int, int>(i, j); // Guardar la posición de la celda

                    // Si es un TableLayoutPanel de matrices (no resultado), se agrega la validación de valor entero
                    if (!esResultado)
                    {
                        // Agregar el evento TextChanged para validar y manejar los valores
                        txtBox.TextChanged += (sender, e) =>
                        {
                            if (int.TryParse(txtBox.Text, out int valor))
                            {
                                txtBox.BackColor = SystemColors.Window;  // Color de fondo predeterminado
                                controlador.AsignarValor(i, j, valor, tlp);  // Asignar el valor a la matriz
                            }
                            else
                            {
                                txtBox.BackColor = Color.Pink;  // Indicar error con color rosa
                            }

                            // Verificar si el campo está vacío y restablecer el color de fondo
                            if (string.IsNullOrWhiteSpace(txtBox.Text))
                            {
                                txtBox.BackColor = SystemColors.Window; // Restablecer cuando está vacío
                            }
                        };
                    }
                    else
                    {
                        // Si es un TableLayoutPanel de resultados, solo mostrar el valor de la matriz
                        txtBox.ReadOnly = true;  // Hacer solo lectura
                    }

                    tlp.Controls.Add(txtBox, j, i);  // Agregar el TextBox al TableLayoutPanel
                }
            }
        }

        private void ConfigurarTableLayoutPanelDos(int filas, int columnas)
        {
            // Llamar al método genérico para configurar tlpMatriz2
            ConfigurarTableLayoutPanelGenerico(tlpMatriz2, filas, columnas);
        }

        private void ConfigurarTableLayoutPanel(int filas, int columnas)
        {
            // Llamar al método genérico para configurar tlpMatriz
            ConfigurarTableLayoutPanelGenerico(tlpMatriz, filas, columnas);
        }


        private void ConfigurarTableLayoutPanelResultado(int[,] matrizResultado, TableLayoutPanel tlpResultado)
        {
            // Llamar al método genérico para configurar tlpResultado
            ConfigurarTableLayoutPanelGenerico(tlpResultado, matrizResultado.GetLength(0), matrizResultado.GetLength(1), esResultado: true);

            // Asignar los valores de la matriz a las celdas correspondientes
            for (int i = 0; i < matrizResultado.GetLength(0); i++)
            {
                for (int j = 0; j < matrizResultado.GetLength(1); j++)
                {
                    // Buscar el TextBox correspondiente
                    var control = tlpResultado.GetControlFromPosition(j, i);
                    if (control is TextBox txtBox)
                    {
                        txtBox.Text = matrizResultado[i, j].ToString(); // Asignar el valor de la matriz a la celda
                    }
                }
            }
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            int filas = (int)numFilas.Value;
            int columnas = (int)numColumnas.Value;

            //Crear matriz
            controlador.CrearMatriz(filas, columnas);
            //Configurar tlpMatriz según dimensión de la matriz creada
            ConfigurarTableLayoutPanel(filas, columnas);
        }

        private void btnGenerar2_Click(object sender, EventArgs e)
        {
            int filas = (int)numFilas2.Value;
            int columnas = (int)numColumnas2.Value;

            //Crear matriz
            controlador.CrearMatriz(filas, columnas);
            //Configurar tlpMatriz según dimensión de la matriz creada
            ConfigurarTableLayoutPanelDos(filas, columnas);

        }
        private int[,] ObtenerMatrizDesdeTableLayout(TableLayoutPanel tlp)
        {
            int filas = tlp.RowCount;
            int columnas = tlp.ColumnCount;
            int[,] matriz = new int[filas, columnas];

            foreach (Control control in tlp.Controls)
            {
                if (control is TextBox txtBox)
                {
                    var position = (Tuple<int, int>)txtBox.Tag;
                    int fila = position.Item1;
                    int columna = position.Item2;

                    if (int.TryParse(txtBox.Text, out int valor))
                    {
                        matriz[fila, columna] = valor;
                    }
                }
            }

            return matriz;
        }

        private void btnEscalar_Click(object sender, EventArgs e)
        {
            // Obtener la matriz desde el TableLayoutPanel correspondiente
            int[,] matriz = ObtenerMatrizDesdeTableLayout(tlpMatriz);

            // Obtener el valor escalar
            int escalar = (int)numEscalar.Value;

            // Realizar la operación de producto escalar
            int[,] resultado = controlador.ProductoEscalar(escalar, matriz);

            // Configurar el TableLayoutPanel para mostrar los resultados
            ConfigurarTableLayoutPanelResultado(resultado, tlpMatrizProd);
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int[,] matrizUno = ObtenerMatrizDesdeTableLayout(tlpMatriz);
            int[,] matrizDos = ObtenerMatrizDesdeTableLayout(tlpMatriz2);

            if (matrizUno.GetLength(0) != matrizDos.GetLength(0) || matrizUno.GetLength(1) != matrizDos.GetLength(1))
            {
                MessageBox.Show("Las dimensiones de las matrices no coinciden. Ambas matrices deben tener el mismo número de filas y columnas.", "Error de Dimensiones", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int[,] resultado = controlador.Sumar(matrizUno, matrizDos);
            ConfigurarTableLayoutPanelResultado(resultado, tlpResultado); // Configurar la matriz de resultados
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            // Obtener las matrices desde los TableLayoutPanel correspondientes
            int[,] matrizUno = ObtenerMatrizDesdeTableLayout(tlpMatriz);
            int[,] matrizDos = ObtenerMatrizDesdeTableLayout(tlpMatriz2);

            // Validar que ambas matrices tengan las mismas dimensiones
            if (matrizUno.GetLength(0) != matrizDos.GetLength(0) || matrizUno.GetLength(1) != matrizDos.GetLength(1))
            {
                MessageBox.Show("Las dimensiones de las matrices no coinciden. Ambas matrices deben tener el mismo número de filas y columnas.",
                                "Error de Dimensiones",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Salir si las dimensiones no coinciden
            }

            // Realizar la operación de resta
            int[,] resultado = controlador.Restar(matrizUno, matrizDos);

            // Configurar el TableLayoutPanel para mostrar los resultados
            ConfigurarTableLayoutPanelResultado(resultado, tlpResultado);
        }

        private void btnProdMatricial_Click(object sender, EventArgs e)
        {
            // Obtener las matrices desde los TableLayoutPanel correspondientes
            int[,] matrizUno = ObtenerMatrizDesdeTableLayout(tlpMatriz);
            int[,] matrizDos = ObtenerMatrizDesdeTableLayout(tlpMatriz2);

            // Validar que el número de columnas de la primera matriz coincida con el número de filas de la segunda
            if (matrizUno.GetLength(1) != matrizDos.GetLength(0))
            {
                MessageBox.Show("El número de columnas de la primera matriz debe ser igual al número de filas de la segunda matriz.",
                                "Error de Dimensiones",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Salir si las dimensiones no son compatibles
            }

            // Realizar la operación de producto matricial
            int[,] resultado = controlador.ProductoMatricial(matrizUno, matrizDos);

            // Configurar el TableLayoutPanel para mostrar los resultados
            ConfigurarTableLayoutPanelResultado(resultado, tlpResultado);
        }

        private void btnDeterminante_Click(object sender, EventArgs e)
        {
            // Obtener la matriz desde tlpMatriz
            int[,] matriz = ObtenerMatrizDesdeTableLayout(tlpMatriz);

            try
            {
                // Calcular el determinante usando el controlador
                int determinante = controlador.Determinante(matriz);

                // Mostrar el resultado en un MessageBox
                MessageBox.Show($"El determinante de la matriz es: {determinante}",
                                "Resultado del Determinante",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                // En caso de que haya un error (aunque ya se hace la validación en el método Determinante)
                MessageBox.Show("Hubo un error al calcular el determinante. " + ex.Message,
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
