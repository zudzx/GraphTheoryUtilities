namespace ProjetoGrafoFinalizado
{
    partial class Form3
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
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.nudVertices = new System.Windows.Forms.NumericUpDown();
            this.btnMatriz = new System.Windows.Forms.Button();
            this.dgMatriz = new System.Windows.Forms.DataGridView();
            this.btnVerificaSimples = new System.Windows.Forms.Button();
            this.btnVerificaEuleriano = new System.Windows.Forms.Button();
            this.btnSalvaMatriz = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudVertices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numero de vértices";
            // 
            // nudVertices
            // 
            this.nudVertices.Location = new System.Drawing.Point(26, 54);
            this.nudVertices.Name = "nudVertices";
            this.nudVertices.Size = new System.Drawing.Size(117, 20);
            this.nudVertices.TabIndex = 1;
            // 
            // btnMatriz
            // 
            this.btnMatriz.Location = new System.Drawing.Point(241, 26);
            this.btnMatriz.Name = "btnMatriz";
            this.btnMatriz.Size = new System.Drawing.Size(394, 48);
            this.btnMatriz.TabIndex = 2;
            this.btnMatriz.Text = "Matriz de Adjacencia do Grafo";
            this.btnMatriz.UseVisualStyleBackColor = true;
            this.btnMatriz.Click += new System.EventHandler(this.btnMatriz_Click);
            // 
            // dgMatriz
            // 
            this.dgMatriz.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgMatriz.Location = new System.Drawing.Point(245, 89);
            this.dgMatriz.Name = "dgMatriz";
            this.dgMatriz.Size = new System.Drawing.Size(390, 209);
            this.dgMatriz.TabIndex = 3;
            // 
            // btnVerificaSimples
            // 
            this.btnVerificaSimples.Location = new System.Drawing.Point(245, 318);
            this.btnVerificaSimples.Name = "btnVerificaSimples";
            this.btnVerificaSimples.Size = new System.Drawing.Size(389, 28);
            this.btnVerificaSimples.TabIndex = 4;
            this.btnVerificaSimples.Text = "Verifica se é simples";
            this.btnVerificaSimples.UseVisualStyleBackColor = true;
            this.btnVerificaSimples.Click += new System.EventHandler(this.btnVerificaSimples_Click);
            // 
            // btnVerificaEuleriano
            // 
            this.btnVerificaEuleriano.Location = new System.Drawing.Point(245, 352);
            this.btnVerificaEuleriano.Name = "btnVerificaEuleriano";
            this.btnVerificaEuleriano.Size = new System.Drawing.Size(389, 28);
            this.btnVerificaEuleriano.TabIndex = 5;
            this.btnVerificaEuleriano.Text = "Verifica se o grafo é Euleriano";
            this.btnVerificaEuleriano.UseVisualStyleBackColor = true;
            this.btnVerificaEuleriano.Click += new System.EventHandler(this.btnVerificaEuleriano_Click);
            // 
            // btnSalvaMatriz
            // 
            this.btnSalvaMatriz.Location = new System.Drawing.Point(245, 386);
            this.btnSalvaMatriz.Name = "btnSalvaMatriz";
            this.btnSalvaMatriz.Size = new System.Drawing.Size(389, 25);
            this.btnSalvaMatriz.TabIndex = 6;
            this.btnSalvaMatriz.Text = "Salvar Matriz de Adjacencia";
            this.btnSalvaMatriz.UseVisualStyleBackColor = true;
            this.btnSalvaMatriz.Click += new System.EventHandler(this.btnSalvaMatriz_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSalvaMatriz);
            this.Controls.Add(this.btnVerificaEuleriano);
            this.Controls.Add(this.btnVerificaSimples);
            this.Controls.Add(this.dgMatriz);
            this.Controls.Add(this.btnMatriz);
            this.Controls.Add(this.nudVertices);
            this.Controls.Add(this.label1);
            this.Name = "Form3";
            this.Text = "Form3";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nudVertices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgMatriz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.NumericUpDown nudVertices;
        private System.Windows.Forms.Button btnMatriz;
        private System.Windows.Forms.DataGridView dgMatriz;
        private System.Windows.Forms.Button btnVerificaSimples;
        private System.Windows.Forms.Button btnVerificaEuleriano;
        private System.Windows.Forms.Button btnSalvaMatriz;
    }
}