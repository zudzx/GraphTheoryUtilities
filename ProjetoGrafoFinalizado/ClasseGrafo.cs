using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoGrafoFinalizado
{
    internal class ClasseGrafo
    {
        private int[,] matrizGrafo;

        public ClasseGrafo(int V)
        {
            MatrizGrafo = new int[V, V];
        }

        public int[,] MatrizGrafo { get => matrizGrafo; set => matrizGrafo = value; }


        public bool VerificaSimples()
        {
            int tamanho = matrizGrafo.GetLength(0);
            for (int i = 0; i < tamanho; i++)
            {

                if (matrizGrafo[i, i] != 0)
                    return false;


                for (int j = i + 1; j < tamanho; j++)
                {
                    if (matrizGrafo[i, j] > 1)
                        return false;
                }
            }
            return true;
        }


        public string VerificaEuleriano()
        {
            int tamanho = matrizGrafo.GetLength(0);
            int[] graus = new int[tamanho];
            int impares = 0;


            for (int i = 0; i < tamanho; i++)
            {
                for (int j = 0; j < tamanho; j++)
                {
                    graus[i] += matrizGrafo[i, j];
                }


                if (graus[i] % 2 != 0)
                    impares++;
            }

            if (impares == 0)
                return "O grafo é Euleriano.";
            else if (impares == 2)
                return "O grafo possui uma trilha Euleriana.";
            else
                return "O grafo não é Euleriano e não possui uma trilha Euleriana.";
        }
    }
}
