namespace Proyecto.View
{
    partial class MatrizView
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
            tlpMatriz = new TableLayoutPanel();
            btnGenerar = new Button();
            numFilas = new NumericUpDown();
            numColumnas = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            numColumnas2 = new NumericUpDown();
            numFilas2 = new NumericUpDown();
            btnGenerar2 = new Button();
            tlpMatriz2 = new TableLayoutPanel();
            numEscalar = new NumericUpDown();
            label5 = new Label();
            tlpMatrizProd = new TableLayoutPanel();
            btnEscalar = new Button();
            tlpResultado = new TableLayoutPanel();
            btnSumar = new Button();
            btnRestar = new Button();
            btnProdMatricial = new Button();
            lblIgual = new Label();
            btnDeterminante = new Button();
            label6 = new Label();
            ((System.ComponentModel.ISupportInitialize)numFilas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numColumnas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numColumnas2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numFilas2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numEscalar).BeginInit();
            SuspendLayout();
            // 
            // tlpMatriz
            // 
            tlpMatriz.ColumnCount = 2;
            tlpMatriz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMatriz.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMatriz.Location = new Point(71, 148);
            tlpMatriz.Name = "tlpMatriz";
            tlpMatriz.RowCount = 2;
            tlpMatriz.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMatriz.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMatriz.Size = new Size(200, 100);
            tlpMatriz.TabIndex = 0;
            // 
            // btnGenerar
            // 
            btnGenerar.Location = new Point(168, 90);
            btnGenerar.Name = "btnGenerar";
            btnGenerar.Size = new Size(103, 23);
            btnGenerar.TabIndex = 1;
            btnGenerar.Text = "Generar";
            btnGenerar.UseVisualStyleBackColor = true;
            btnGenerar.Click += btnGenerar_Click;
            // 
            // numFilas
            // 
            numFilas.Location = new Point(71, 92);
            numFilas.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numFilas.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numFilas.Name = "numFilas";
            numFilas.Size = new Size(36, 23);
            numFilas.TabIndex = 2;
            numFilas.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numColumnas
            // 
            numColumnas.Location = new Point(126, 92);
            numColumnas.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numColumnas.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numColumnas.Name = "numColumnas";
            numColumnas.Size = new Size(36, 23);
            numColumnas.TabIndex = 3;
            numColumnas.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 62);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 4;
            label1.Text = "Filas";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 62);
            label2.Name = "label2";
            label2.Size = new Size(61, 15);
            label2.TabIndex = 5;
            label2.Text = "Columnas";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(411, 62);
            label3.Name = "label3";
            label3.Size = new Size(61, 15);
            label3.TabIndex = 11;
            label3.Text = "Columnas";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(354, 62);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 10;
            label4.Text = "Filas";
            // 
            // numColumnas2
            // 
            numColumnas2.Location = new Point(411, 92);
            numColumnas2.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numColumnas2.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numColumnas2.Name = "numColumnas2";
            numColumnas2.Size = new Size(36, 23);
            numColumnas2.TabIndex = 9;
            numColumnas2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // numFilas2
            // 
            numFilas2.Location = new Point(356, 92);
            numFilas2.Maximum = new decimal(new int[] { 4, 0, 0, 0 });
            numFilas2.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            numFilas2.Name = "numFilas2";
            numFilas2.Size = new Size(36, 23);
            numFilas2.TabIndex = 8;
            numFilas2.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // btnGenerar2
            // 
            btnGenerar2.Location = new Point(453, 90);
            btnGenerar2.Name = "btnGenerar2";
            btnGenerar2.Size = new Size(101, 23);
            btnGenerar2.TabIndex = 7;
            btnGenerar2.Text = "Generar";
            btnGenerar2.UseVisualStyleBackColor = true;
            btnGenerar2.Click += btnGenerar2_Click;
            // 
            // tlpMatriz2
            // 
            tlpMatriz2.ColumnCount = 2;
            tlpMatriz2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMatriz2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMatriz2.Location = new Point(354, 148);
            tlpMatriz2.Name = "tlpMatriz2";
            tlpMatriz2.RowCount = 2;
            tlpMatriz2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMatriz2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMatriz2.Size = new Size(200, 100);
            tlpMatriz2.TabIndex = 6;
            // 
            // numEscalar
            // 
            numEscalar.Location = new Point(12, 211);
            numEscalar.Minimum = new decimal(new int[] { 100, 0, 0, int.MinValue });
            numEscalar.Name = "numEscalar";
            numEscalar.Size = new Size(53, 23);
            numEscalar.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 193);
            label5.Name = "label5";
            label5.Size = new Size(43, 15);
            label5.TabIndex = 13;
            label5.Text = "Escalar";
            label5.Click += label5_Click;
            // 
            // tlpMatrizProd
            // 
            tlpMatrizProd.ColumnCount = 2;
            tlpMatrizProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMatrizProd.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpMatrizProd.Location = new Point(71, 293);
            tlpMatrizProd.Name = "tlpMatrizProd";
            tlpMatrizProd.RowCount = 2;
            tlpMatrizProd.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMatrizProd.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpMatrizProd.Size = new Size(200, 102);
            tlpMatrizProd.TabIndex = 1;
            // 
            // btnEscalar
            // 
            btnEscalar.Location = new Point(12, 247);
            btnEscalar.Name = "btnEscalar";
            btnEscalar.Size = new Size(53, 23);
            btnEscalar.TabIndex = 14;
            btnEscalar.Text = "Prod";
            btnEscalar.UseVisualStyleBackColor = true;
            btnEscalar.Click += btnEscalar_Click;
            // 
            // tlpResultado
            // 
            tlpResultado.ColumnCount = 2;
            tlpResultado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResultado.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tlpResultado.Location = new Point(601, 148);
            tlpResultado.Name = "tlpResultado";
            tlpResultado.RowCount = 2;
            tlpResultado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResultado.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tlpResultado.Size = new Size(182, 100);
            tlpResultado.TabIndex = 7;
            // 
            // btnSumar
            // 
            btnSumar.Location = new Point(292, 148);
            btnSumar.Name = "btnSumar";
            btnSumar.Size = new Size(43, 23);
            btnSumar.TabIndex = 15;
            btnSumar.Text = "+";
            btnSumar.UseVisualStyleBackColor = true;
            btnSumar.Click += btnSumar_Click;
            // 
            // btnRestar
            // 
            btnRestar.Location = new Point(292, 185);
            btnRestar.Name = "btnRestar";
            btnRestar.Size = new Size(43, 23);
            btnRestar.TabIndex = 16;
            btnRestar.Text = "-";
            btnRestar.UseVisualStyleBackColor = true;
            btnRestar.Click += btnRestar_Click;
            // 
            // btnProdMatricial
            // 
            btnProdMatricial.Location = new Point(292, 225);
            btnProdMatricial.Name = "btnProdMatricial";
            btnProdMatricial.Size = new Size(43, 23);
            btnProdMatricial.TabIndex = 17;
            btnProdMatricial.Text = "X";
            btnProdMatricial.UseVisualStyleBackColor = true;
            btnProdMatricial.Click += btnProdMatricial_Click;
            // 
            // lblIgual
            // 
            lblIgual.AutoSize = true;
            lblIgual.Location = new Point(570, 189);
            lblIgual.Name = "lblIgual";
            lblIgual.Size = new Size(15, 15);
            lblIgual.TabIndex = 18;
            lblIgual.Text = "=";
            // 
            // btnDeterminante
            // 
            btnDeterminante.Location = new Point(12, 276);
            btnDeterminante.Name = "btnDeterminante";
            btnDeterminante.Size = new Size(53, 23);
            btnDeterminante.TabIndex = 19;
            btnDeterminante.Text = "Determinante";
            btnDeterminante.UseVisualStyleBackColor = true;
            btnDeterminante.Click += btnDeterminante_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(50, 334);
            label6.Name = "label6";
            label6.Size = new Size(15, 15);
            label6.TabIndex = 20;
            label6.Text = "=";
            // 
            // MatrizView
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label6);
            Controls.Add(btnDeterminante);
            Controls.Add(lblIgual);
            Controls.Add(btnProdMatricial);
            Controls.Add(btnRestar);
            Controls.Add(btnSumar);
            Controls.Add(tlpResultado);
            Controls.Add(btnEscalar);
            Controls.Add(tlpMatrizProd);
            Controls.Add(label5);
            Controls.Add(numEscalar);
            Controls.Add(label3);
            Controls.Add(label4);
            Controls.Add(numColumnas2);
            Controls.Add(numFilas2);
            Controls.Add(btnGenerar2);
            Controls.Add(tlpMatriz2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numColumnas);
            Controls.Add(numFilas);
            Controls.Add(btnGenerar);
            Controls.Add(tlpMatriz);
            Name = "MatrizView";
            Text = "MatrizView";
            ((System.ComponentModel.ISupportInitialize)numFilas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numColumnas).EndInit();
            ((System.ComponentModel.ISupportInitialize)numColumnas2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numFilas2).EndInit();
            ((System.ComponentModel.ISupportInitialize)numEscalar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TableLayoutPanel tlpMatriz;
        private Button btnGenerar;
        private NumericUpDown numFilas;
        private NumericUpDown numColumnas;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private NumericUpDown numColumnas2;
        private NumericUpDown numFilas2;
        private Button btnGenerar2;
        private TableLayoutPanel tlpMatriz2;
        private NumericUpDown numEscalar;
        private Label label5;
        private TableLayoutPanel tlpMatrizProd;
        private Button btnEscalar;
        private TableLayoutPanel tlpResultado;
        private Button btnSumar;
        private Button btnRestar;
        private Button btnProdMatricial;
        private Label lblIgual;
        private Button btnDeterminante;
        private Label label6;
    }
}