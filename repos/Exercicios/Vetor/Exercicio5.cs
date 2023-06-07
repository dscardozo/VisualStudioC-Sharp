using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algoritimos.Vetor
{
    internal static class Exercicio5
    {
        internal static void Executar()
        {
            char[] letras = new char[30];

            for (int i = 0; i < 30; i++)
            {
                Console.Write($"Digite a letra {i + 1}: ");
                letras[i] = char.Parse(Console.ReadLine());
            }

            bool temB = false;
            bool temR = false;
            bool temA = false;
            bool temS = false;
            bool temI = false;
            bool temL = false;
            
            foreach (char letra in letras)
            {
                if (letra == 'B' || letra == 'b')
                {
                    temB = true;
                }
                else if (letra == 'R'|| letra == 'r')
                {
                    temR = true;
                }
                else if (letra == 'A' || letra == 'a')
                {
                    temA = true;
                }
                else if (letra == 'S' || letra == 's')
                {
                    temS = true;
                }
                else if (letra == 'I' || letra == 'i')
                {
                    temI = true;
                }
                else if (letra == 'L' || letra == 'l')
                {
                    temL = true;
                }
            }
            
            if (temB && temR && temA && temS && temI && temL)
            {
                Console.WriteLine("Brasil encontrado no vetor");
            }
            else
            {
                Console.WriteLine("Brasil não encontrado no vetor");
            }
        }

    }
}
