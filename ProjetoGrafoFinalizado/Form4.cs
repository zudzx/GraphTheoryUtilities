using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ProjetoGrafoFinalizado
{
    public partial class Form4 : Form
    {
        int numeroCidades;
        string[] nomesCidades;
        double[,] matrizAdjacencia;
        int indiceCidade = 0;
        
        public Form4()
        {
            InitializeComponent();
        }


        private void Form4_Load(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            numeroCidades = int.Parse(textBox1.Text);
            nomesCidades = new string[numeroCidades];
            matrizAdjacencia = new double[numeroCidades, numeroCidades];

            // Inicializar a matriz de adjacência com valores infinitos (sem ligação)
            for (int i = 0; i < numeroCidades; i++)
            {
                for (int j = 0; j < numeroCidades; j++)
                {
                    if (i != j)
                        matrizAdjacencia[i, j] = double.MaxValue;
                    else
                        matrizAdjacencia[i, j] = 0;
                }
            }

            MessageBox.Show("Matriz de adjacência criada com sucesso!");
        }

        private void butto2_Click(object sender, EventArgs e)
        {
            if (indiceCidade < numeroCidades)
            {
                string nomeCidade = textBox2.Text;
                nomesCidades[indiceCidade] = nomeCidade;
                comboBox1.Items.Add(nomeCidade);
                comboBox2.Items.Add(nomeCidade);
                indiceCidade++;
                textBox2.Clear();
            }
            else
            {
                MessageBox.Show("Todas as cidades já foram adicionadas.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int cidadeA = comboBox1.SelectedIndex;
            int cidadeB = comboBox2.SelectedIndex;
            double distancia = double.Parse(textBox3.Text);

            if (cidadeA != cidadeB && distancia >= 0)
            {
                matrizAdjacencia[cidadeA, cidadeB] = distancia;
                matrizAdjacencia[cidadeB, cidadeA] = distancia; // Não direcionado
                textBox3.Clear();
                AtualizarMatrizAdjacencia();
            }
            else
            {
                MessageBox.Show("Selecione cidades diferentes e uma distância válida.");
            }
        }

        private void AtualizarMatrizAdjacencia()
        {
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = numeroCidades;
            dataGridView1.RowCount = numeroCidades;

            for (int i = 0; i < numeroCidades; i++)
            {
                dataGridView1.Columns[i].Name = nomesCidades[i];
                dataGridView1.Rows[i].HeaderCell.Value = nomesCidades[i];
                for (int j = 0; j < numeroCidades; j++)
                {
                    if (matrizAdjacencia[i, j] == double.MaxValue)
                        dataGridView1.Rows[i].Cells[j].Value = "∞";
                    else
                        dataGridView1.Rows[i].Cells[j].Value = matrizAdjacencia[i, j].ToString();
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int cidadeA = comboBox1.SelectedIndex;
            int cidadeB = comboBox2.SelectedIndex;

            if (cidadeA != cidadeB && matrizAdjacencia[cidadeA, cidadeB] != double.MaxValue)
            {
                MessageBox.Show($"A distância entre {nomesCidades[cidadeA]} e {nomesCidades[cidadeB]} é de {matrizAdjacencia[cidadeA, cidadeB]} km.");
            }
            else
            {
                MessageBox.Show("Essas cidades não são adjacentes ou a distância não foi definida.");
            }

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cidadeA = comboBox1.SelectedIndex;
            int cidadeB = comboBox2.SelectedIndex;

            double[] distancias = new double[numeroCidades];
            bool[] visitado = new bool[numeroCidades];
            int[] predecessores = new int[numeroCidades];

            // Inicializar distâncias e predecessores
            for (int i = 0; i < numeroCidades; i++)
            {
                distancias[i] = double.MaxValue;
                visitado[i] = false;
                predecessores[i] = -1;
            }

            distancias[cidadeA] = 0;

            for (int i = 0; i < numeroCidades - 1; i++)
            {
                int u = MenorDistancia(distancias, visitado);
                visitado[u] = true;

                for (int v = 0; v < numeroCidades; v++)
                {
                    if (!visitado[v] && matrizAdjacencia[u, v] != double.MaxValue &&
                        distancias[u] != double.MaxValue && distancias[u] + matrizAdjacencia[u, v] < distancias[v])
                    {
                        distancias[v] = distancias[u] + matrizAdjacencia[u, v];
                        predecessores[v] = u;
                    }
                }
            }

            ExibirCaminho(cidadeA, cidadeB, predecessores, distancias);
        }

        private int MenorDistancia(double[] distancias, bool[] visitado)
        {
            double menor = double.MaxValue;
            int indice = -1;

            for (int i = 0; i < distancias.Length; i++)
            {
                if (!visitado[i] && distancias[i] <= menor)
                {
                    menor = distancias[i];
                    indice = i;
                }
            }

            return indice;
        }

        // Função para exibir o caminho e a distância
        private void ExibirCaminho(int cidadeA, int cidadeB, int[] predecessores, double[] distancias)
        {
            if (distancias[cidadeB] == double.MaxValue)
            {
                MessageBox.Show("Não há caminho entre as duas cidades.");
            }
            else
            {
                Stack<int> caminho = new Stack<int>();
                for (int v = cidadeB; v != -1; v = predecessores[v])
                {
                    caminho.Push(v);
                }

                string caminhoStr = "";
                while (caminho.Count > 0)
                {
                    caminhoStr += nomesCidades[caminho.Pop()] + " ";
                    if (caminho.Count > 0) caminhoStr += "-> ";
                }

                MessageBox.Show($"Caminho mínimo: {caminhoStr}\nDistância total: {distancias[cidadeB]} km");
            }
        }
    }
}
