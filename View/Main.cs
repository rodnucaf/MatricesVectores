using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Proyecto.Model;
using Proyecto.Controller;

namespace Proyecto.View
{
    public partial class Main : Form
    {
        // Mantener una referencia a la vista actual
        private Form currentView = null;

        public Main()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Si ya hay una vista abierta, la cerramos
            if (currentView != null && !currentView.IsDisposed)
            {
                currentView.Close();
            }

            // Crear una nueva vista de matriz
            MatrizView view = new MatrizView();

            // Mostrar la nueva vista
            currentView = view;
            view.Show();
        }

        private void btnVector_Click(object sender, EventArgs e)
        {
            // Si ya hay una vista abierta, la cerramos
            if (currentView != null && !currentView.IsDisposed)
            {
                currentView.Close();
            }

            // Crear una nueva vista de vector
            VectorView view = new VectorView();

            // Mostrar la nueva vista
            currentView = view;
            view.Show();
        }


    }
}
