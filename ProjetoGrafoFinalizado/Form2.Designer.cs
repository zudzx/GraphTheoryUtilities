namespace ProjetoGrafoFinalizado
{
    partial class Form2
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
            this.btnNaoDirecionado = new System.Windows.Forms.Button();
            this.btnPonderado = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNaoDirecionado
            // 
            this.btnNaoDirecionado.Location = new System.Drawing.Point(113, 56);
            this.btnNaoDirecionado.Name = "btnNaoDirecionado";
            this.btnNaoDirecionado.Size = new System.Drawing.Size(396, 68);
            this.btnNaoDirecionado.TabIndex = 0;
            this.btnNaoDirecionado.Text = "Grafo Não Direcionado";
            this.btnNaoDirecionado.UseVisualStyleBackColor = true;
            this.btnNaoDirecionado.Click += new System.EventHandler(this.btnNaoDirecionado_Click);
            // 
            // btnPonderado
            // 
            this.btnPonderado.Location = new System.Drawing.Point(113, 146);
            this.btnPonderado.Name = "btnPonderado";
            this.btnPonderado.Size = new System.Drawing.Size(396, 70);
            this.btnPonderado.TabIndex = 1;
            this.btnPonderado.Text = "Grafo Não Direcionado Ponderado";
            this.btnPonderado.UseVisualStyleBackColor = true;
            this.btnPonderado.Click += new System.EventHandler(this.btnPonderado_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(216, 234);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(192, 75);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 371);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnPonderado);
            this.Controls.Add(this.btnNaoDirecionado);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnNaoDirecionado;
        private System.Windows.Forms.Button btnPonderado;
        private System.Windows.Forms.Button btnSair;
    }
}