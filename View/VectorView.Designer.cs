namespace Proyecto.View
{
    partial class VectorView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnGenerar = new Button();
            numRn = new NumericUpDown();
            label1 = new Label();
            tlpVectorUno = new TableLayoutPanel();
            tlpVectorDos = new TableLayoutPanel();
            btnSumar = new Button();
            btnRestar = new Button();
            btnProdPorEscalar = new Button();
            tlpResultadoProdPorEscalar = new TableLayoutPanel();
            tlpResultado = new TableLayoutPanel();
            btnProductoEscalar = new Button();
            numEscalar = new NumericUpDown();
            btnProdVectorial = new Button();
            ((System.ComponentModel.ISupportInitialize)numRn).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEscalar).BeginInit();
            SuspendLayout();
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(139, 92);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(143, 23);
            btnGenerar.TabIndex = 0;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // numRn
            // 
            numRn.Location = new Point(82, 92);
            numRn.Maximum = new decimal(new int[] { 8, 0, 0, 0 });
            numRn.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numRn.Name = "numRn";
            numRn.Size = new Size(51, 23);
            numRn.TabIndex = 1;
            numRn.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(82, 74);
            label1.Name = "label1";
            label1.Size = new Size(162, 15);
            label1.TabIndex = 2;
            label1.Text = "Rn (Espacio al que pertenece)";
            // 
            // tlpVectorUno
            // 
            tlpVectorUno.ColumnCount = 2;
            tlpVectorUno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVectorUno.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVectorUno.Location = new Point(82, 121);
            tlpVectorUno.Name = "tlpVectorUno";
            tlpVectorUno.RowCount = 2;
            tlpVectorUno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVectorUno.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVectorUno.Size = new Size(200, 100);
            tlpVectorUno.TabIndex = 3;
            // 
            // tlpVectorDos
            // 
            tlpVectorDos.ColumnCount = 2;
            tlpVectorDos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVectorDos.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpVectorDos.Location = new Point(357, 121);
            tlpVectorDos.Name = "tlpVectorDos";
            tlpVectorDos.RowCount = 2;
            tlpVectorDos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVectorDos.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpVectorDos.Size = new Size(171, 100);
            tlpVectorDos.TabIndex = 4;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(301, 121);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(36, 23);
            btnSumar.TabIndex = 5;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(301, 150);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(36, 23);
            btnRestar.TabIndex = 6;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnProdPorEscalar
            // 
            btnProdPorEscalar.Location = new Point(12, 179);
            btnProdPorEscalar.Name = "btnProdPorEscalar";
            btnProdPorEscalar.Size = new Size(51, 23);
            btnProdPorEscalar.TabIndex = 8;
            btnProdPorEscalar.Text = "Prod";
            btnProdPorEscalar.UseVisualStyleBackColor = true;
            btnProdPorEscalar.Click += btnProdPorEscalar_Click;
            // 
            // tlpResultadoProdPorEscalar
            // 
            tlpResultadoProdPorEscalar.ColumnCount = 2;
            tlpResultadoProdPorEscalar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResultadoProdPorEscalar.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResultadoProdPorEscalar.Location = new Point(82, 261);
            tlpResultadoProdPorEscalar.Name = "tlpResultadoProdPorEscalar";
            tlpResultadoProdPorEscalar.RowCount = 2;
            tlpResultadoProdPorEscalar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResultadoProdPorEscalar.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResultadoProdPorEscalar.Size = new Size(200, 92);
            tlpResultadoProdPorEscalar.TabIndex = 4;
            // 
            // tlpResultado
            // 
            tlpResultado.ColumnCount = 2;
            tlpResultado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResultado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResultado.Location = new Point(580, 121);
            tlpResultado.Name = "tlpResultado";
            tlpResultado.RowCount = 2;
            tlpResultado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResultado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResultado.Size = new Size(176, 100);
            tlpResultado.TabIndex = 5;
            // 
            // btnProductoEscalar
            // 
            btnProductoEscalar.Location = new Point(301, 179);
            btnProductoEscalar.Name = "btnProductoEscalar";
            btnProductoEscalar.Size = new Size(36, 23);
            btnProductoEscalar.TabIndex = 7;
            btnProductoEscalar.Text = ".";
            btnProductoEscalar.UseVisualStyleBackColor = true;
            btnProductoEscalar.Click += btnProductoEscalar_Click;
            // 
            // numEscalar
            // 
            numEscalar.Location = new Point(12, 150);
            numEscalar.Minimum = new decimal(new int[] { 50, 0, 0, int.MinValue });
            numEscalar.Name = "numEscalar";
            numEscalar.Size = new Size(51, 23);
            numEscalar.TabIndex = 9;
            // 
            // btnProdVectorial
            // 
            btnProdVectorial.Location = new Point(301, 208);
            btnProdVectorial.Name = "btnProdVectorial";
            btnProdVectorial.Size = new Size(36, 23);
            btnProdVectorial.TabIndex = 10;
            btnProdVectorial.Text = "X";
            btnProdVectorial.UseVisualStyleBackColor = true;
            btnProdVectorial.Click += btnProdVectorial_Click;
            // 
            // VectorView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnProdVectorial);
            Controls.Add(numEscalar);
            Controls.Add(tlpResultado);
            Controls.Add(tlpResultadoProdPorEscalar);
            Controls.Add(btnProdPorEscalar);
            Controls.Add(btnProductoEscalar);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(tlpVectorDos);
            Controls.Add(tlpVectorUno);
            Controls.Add(label1);
            Controls.Add(numRn);
            Controls.Add(btnGenerar);
            Name = "VectorView";
            Text = "VectorView";
            ((System.ComponentModel.ISupportInitialize)numRn).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEscalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGenerar;
        private NumericUpDown numRn;
        private Label label1;
        private TableLayoutPanel tlpVectorUno;
        private TableLayoutPanel tlpVectorDos;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnProductoVectorial;
        private Button btnProdPorEscalar;
        private TableLayoutPanel tlpResultadoProdPorEscalar;
        private TableLayoutPanel tlpResultado;
        private Button btnProductoEscalar;
        private NumericUpDown numEscalar;
        private Button btnProdVectorial;
    }
}