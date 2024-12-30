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

namespace Proyecto.View
{
    public partial class VectorView : Form
    {
        VectorControl vectorControl = new VectorControl();

        public VectorView()
        {
            InitializeComponent();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            // Limpiar los Paneles antes de generar nuevos vectores
            tlpVectorUno.Controls.Clear();
            tlpVectorDos.Controls.Clear();
            tlpResultado.Controls.Clear(); // Limpiar el panel de resultados

            // Obtener la dimensión de los vectores desde numericUpDown
            int dimension = (int)numRn.Value;

            // Configurar el TableLayoutPanel para que tenga una sola fila
            tlpVectorUno.RowCount = 1; // Solo una fila
            tlpVectorUno.ColumnCount = dimension; // Número de columnas según la dimensión
            tlpVectorUno.ColumnStyles.Clear();  // Limpiar las estilos de columna anteriores

            // Establecer el estilo de las columnas para que se ajusten automáticamente
            for (int i = 0; i < dimension; i++)
            {
                tlpVectorUno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / dimension));
            }

            // Generar controles de TextBox para el vector 1 en tlpVectorUno
            for (int i = 0; i < dimension; i++)
            {
                TextBox textUno = new TextBox();
                textUno.Name = "txtVectorUno_" + i;
                textUno.Width = 60;
                textUno.TextChanged += TextBox_TextChanged; // Evento TextChanged
                tlpVectorUno.Controls.Add(textUno, i, 0);
            }

            // Configurar el TableLayoutPanel para el segundo vector
            tlpVectorDos.RowCount = 1;
            tlpVectorDos.ColumnCount = dimension;
            tlpVectorDos.ColumnStyles.Clear();

            for (int i = 0; i < dimension; i++)
            {
                tlpVectorDos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / dimension));
            }

            // Generar controles de TextBox para el vector 2 en tlpVectorDos
            for (int i = 0; i < dimension; i++)
            {
                TextBox textDos = new TextBox();
                textDos.Name = "txtVectorDos_" + i;
                textDos.Width = 60;
                textDos.TextChanged += TextBox_TextChanged; // Evento TextChanged
                tlpVectorDos.Controls.Add(textDos, i, 0);
            }
        }

        // Evento que se ejecuta cuando el texto en el TextBox cambia
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null)
            {
                if (string.IsNullOrWhiteSpace(textBox.Text))
                {
                    // Si el TextBox está vacío o en blanco, restaurar al color original
                    textBox.BackColor = SystemColors.Window; // Color original
                }
                else
                {
                    // Intentar convertir el valor a un entero
                    int number;
                    if (!int.TryParse(textBox.Text, out number))
                    {
                        // Si no es un número entero, poner el fondo de color rosa
                        textBox.BackColor = Color.Pink;
                    }
                    else
                    {
                        // Si es un número entero, restaurar al color original
                        textBox.BackColor = SystemColors.Window; // Color original
                    }
                }
            }
        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int[] vectorUno = vectorControl.ObtenerVectorDesdeVista(tlpVectorUno);
            int[] vectorDos = vectorControl.ObtenerVectorDesdeVista(tlpVectorDos);

            if (vectorUno != null && vectorDos != null)
            {
                int[] resultado = vectorControl.Sumar(vectorUno, vectorDos);
                MostrarResultadoEnPanel(resultado);
            }
        }

        private void btnRestar_Click(object sender, EventArgs e)
        {
            int[] vectorUno = vectorControl.ObtenerVectorDesdeVista(tlpVectorUno);
            int[] vectorDos = vectorControl.ObtenerVectorDesdeVista(tlpVectorDos);

            if (vectorUno != null && vectorDos != null)
            {
                int[] resultado = vectorControl.Restar(vectorUno, vectorDos);
                MostrarResultadoEnPanel(resultado);
            }
        }

        private void btnProductoEscalar_Click(object sender, EventArgs e)
        {
            int[] vectorUno = vectorControl.ObtenerVectorDesdeVista(tlpVectorUno);
            int[] vectorDos = vectorControl.ObtenerVectorDesdeVista(tlpVectorDos);

            if (vectorUno != null && vectorDos != null)
            {
                int resultado = vectorControl.ProductoEscalar(vectorUno, vectorDos);
                MessageBox.Show("Resultado del producto escalar: " + resultado);
            }
        }

        private void btnProdPorEscalar_Click(object sender, EventArgs e)
        {
            int escalar = (int)numEscalar.Value;
            int[] vectorUno = vectorControl.ObtenerVectorDesdeVista(tlpVectorUno);

            if (vectorUno != null)
            {
                int[] resultado = vectorControl.ProductoPorEscalar(vectorUno, escalar);
                MostrarResultadoEnPanel(resultado);
            }
        }

        private void btnProdVectorial_Click(object sender, EventArgs e)
        {
            int[] vectorUno = vectorControl.ObtenerVectorDesdeVista(tlpVectorUno);
            int[] vectorDos = vectorControl.ObtenerVectorDesdeVista(tlpVectorDos);

            if (vectorUno != null && vectorDos != null)
            {
                int[] resultado = vectorControl.ProductoVectorial(vectorUno, vectorDos);
                MostrarResultadoEnPanel(resultado);
            }
        }

        private void MostrarResultadoEnPanel(int[] resultado)
        {
            tlpResultado.Controls.Clear();
            tlpResultado.RowCount = 1;
            tlpResultado.ColumnCount = resultado.Length;
            tlpResultado.ColumnStyles.Clear();

            for (int i = 0; i < resultado.Length; i++)
            {
                tlpResultado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100f / resultado.Length));
            }

            for (int i = 0; i < resultado.Length; i++)
            {
                TextBox resultTextBox = new TextBox
                {
                    Text = resultado[i].ToString(),
                    ReadOnly = true,
                    Width = 60
                };
                tlpResultado.Controls.Add(resultTextBox, i, 0);
            }
        }

    }
}
