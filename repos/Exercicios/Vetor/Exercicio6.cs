using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Exercicio6
    {
        internal static void Executar() 
        {
            {
                int tamanhoDoVetor = 3;
                double[] preco = new double[tamanhoDoVetor];
                int[] indice = new int[tamanhoDoVetor];
                double[] precoFinal = new double[tamanhoDoVetor];

                for (int i = 0; i < tamanhoDoVetor; i++)
                {
                    Console.Write($"Digite o {i + 1}º preço: R$ ");
                    preco[i] = double.Parse(Console.ReadLine().Replace('.', ','));
                }

                for (int i = 0; i < tamanhoDoVetor; i++)
                {
                    Console.Write($"Digite o índice de aumento do {i + 1}º preço: ");
                    indice[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < tamanhoDoVetor; i++)
                {
                    double aumento = (preco[i] * indice[i]) / 100.0;

                    precoFinal[i] = preco[i] + aumento;
                }

                Console.WriteLine("Preços finais:");
                for (int i = 0; i < tamanhoDoVetor; i++)
                {
                    Console.WriteLine($"Preço {i + 1}: R$ {precoFinal[i]:N2}");
                }
            }
        } 
    }
}
