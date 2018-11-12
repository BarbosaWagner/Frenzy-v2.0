using System;
using System.Collections.Generic;

namespace GeradorDeTodosOsVolantes
{
    class Program
    {
        static int contadorDeLimite;
        static int contadorDePosicao = 14;

        static void Main(string[] args)
        {
            var listaDePossibilidades = new List<string>();
            int[] volante = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            contadorDePosicao = 14; // Refere-se a 14ª posição do vetor volante.
            contadorDeLimite = volante[contadorDePosicao]; ;  // Valor inicial da 14ª posição do volante.
            int mudarPosicao = 0;

            while (volante[0] <= 11) // 3268760 -- 'volante[0] != 11' -- 'listaDePossibilidades.Count < 10000'
            {
                if (volante[14] <= 25)
                {
                    listaDePossibilidades.Add(FormatarVolante(volante));
                    volante[14]++;
                    Console.WriteLine(listaDePossibilidades.Count);
                }
                else if (mudarPosicao == -1)
                {
                    contadorDePosicao--;
                    contadorDeLimite = volante[contadorDePosicao];
                    mudarPosicao = 0;
                }
                else
                {
                    mudarPosicao = MudarPosicao(volante);

                    if (mudarPosicao == -1)
                        continue;

                    volante[14 - mudarPosicao]++;
                    volante = AtualizarValorMinimoDasPosicoes(volante, mudarPosicao);
                }
            }

            var gravador = new Arquivo();
            gravador.GravarVolantes(listaDePossibilidades);
        }

        // Transforma o vetor do volante com números inteiros, em uma string pronta para ser inclusa na lista de possibilidades.
        static string FormatarVolante(int[] vetorVolante)
        {
            string volanteFormatado = "";
            foreach (var numero in vetorVolante)
            {
                if (numero < 10)
                    volanteFormatado += ("0" + numero + " ");
                else
                    volanteFormatado += (numero + " ");
            }

            return volanteFormatado;
        }

        // Após ter sido incrementado a posição anterior, precisa reiniciar as posições seguintes com esse método.
        static int[] AtualizarValorMinimoDasPosicoes(int[] vetorVolante, int posicaoInicial)
        {
            for (int j = (14 - posicaoInicial); j < 14; j++)
            {
                // Reinicia os valores de forma sequencial.
                vetorVolante[j + 1] = vetorVolante[j] + 1;
            }

            return vetorVolante;
        }

        // Verifica e retorna quantas posições de trás pra frente atingiram seu limite.
        static int MudarPosicao(int[] vetorVolante)
        {
            int contadorInterno = 0;
            int limite = contadorDeLimite + 10;
            for (int i = contadorDePosicao; i <= 14; i++)
            {
                if (vetorVolante[i] > limite)
                    contadorInterno++;
                limite++;
            }

            if (contadorInterno == (15 - contadorDePosicao))
                return -1; // Pra quando todas as posições verificadas tiverem com limite atingido.
            else
                return contadorInterno;
        }
    }
}
