namespace Proyecto.View
{
    partial class Main
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
            btnMatriz = new Button();
            btnVector = new Button();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnMatriz
            // 
            btnMatriz.Location = new Point(17, 92);
            btnMatriz.Name = "btnMatriz";
            btnMatriz.Size = new Size(150, 52);
            btnMatriz.TabIndex = 0;
            btnMatriz.Text = "MATRICES";
            btnMatriz.UseVisualStyleBackColor = true;
            btnMatriz.Click += button1_Click;
            // 
            // btnVector
            // 
            btnVector.Location = new Point(17, 34);
            btnVector.Name = "btnVector";
            btnVector.Size = new Size(150, 52);
            btnVector.TabIndex = 1;
            btnVector.Text = "VECTORES";
            btnVector.UseVisualStyleBackColor = true;
            btnVector.Click += btnVector_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(btnMatriz);
            panel1.Controls.Add(btnVector);
            panel1.Location = new Point(129, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 170);
            panel1.TabIndex = 2;
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(482, 448);
            Controls.Add(panel1);
            Name = "Main";
            Text = "Main";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnMatriz;
        private Button btnVector;
        private Panel panel1;
    }
}