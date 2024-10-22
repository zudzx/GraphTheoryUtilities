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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnNaoDirecionado_Click(object sender, EventArgs e)
        {
            Form3 naoDirecionadoForm = new Form3(); 
            naoDirecionadoForm.Show(); 
            this.Hide();
        }

        private void btnPonderado_Click(object sender, EventArgs e)
        {
            Form4 ponderadoForm = new Form4(); // Instancia o Form4
            ponderadoForm.Show(); // Exibe o Form4
            this.Hide();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit(); // Fecha o aplicativo
        }
    }
}
