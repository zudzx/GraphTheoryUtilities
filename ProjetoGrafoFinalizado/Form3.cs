using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGrafoFinalizado
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private ClasseGrafo G1;

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void btnMatriz_Click(object sender, EventArgs e)
        {
            dgMatriz.RowCount = (int)nudVertices.Value;
            dgMatriz.ColumnCount = (int)nudVertices.Value;

            for (int i = 0; i < (int)nudVertices.Value; i++)
            {
                dgMatriz.Columns[i].Width = 50;

            }

            for (int i = 0; i < (int)nudVertices.Value; i++)
                for (int j = 0; j < (int)nudVertices.Value; j++)
                {
                    dgMatriz.Rows[i].Cells[j].Value = 0;
                }
        }

        private void btnSalvaMatriz_Click(object sender, EventArgs e)
        {
            G1 = new ClasseGrafo((int)nudVertices.Value);

            for (int i = 0; i < (int)nudVertices.Value; i++)
                for (int j = 0; j < (int)nudVertices.Value; j++)
                {
                    G1.MatrizGrafo[i, j] = Convert.ToInt16(dgMatriz.Rows[i].Cells[j].Value);
                }
            MessageBox.Show("Matriz copiada com sucesso!");
        }

        private void btnVerificaEuleriano_Click(object sender, EventArgs e)
        {
            if (G1 != null)
            {
                string resultado = G1.VerificaEuleriano();
                MessageBox.Show(resultado);
            }
            else
            {
                MessageBox.Show("Por favor, salve a matriz do grafo primeiro.");
            }
        }

        private void btnVerificaSimples_Click(object sender, EventArgs e)
        {
            if (G1 != null)
            {
                bool isSimples = G1.VerificaSimples();
                string mensagem = isSimples ? "O grafo é simples." : "O grafo não é simples.";
                MessageBox.Show(mensagem);
            }
            else
            {
                MessageBox.Show("Por favor, salve a matriz do grafo primeiro.");
            }
        }
    }
}
