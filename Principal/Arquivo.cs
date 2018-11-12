using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Frenzy
{
    // Classe responsável por manipular os arquivos na máquina.
    public class Arquivo
    {
        public static string diretorioDePossibilidades = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Frenzy\Possibilidades\possibilidades.dat");
        public static string diretorioDeSorteios = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Frenzy\Sorteios");
        public static string diretorioDoFrenzy = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Frenzy");
        public static List<string> listaDePossibilidades = new List<string>();
        public static List<string> listaDeSorteios;

        #region RegiaoDosMetodos
        // Gravas todas as possibilidades geradas, no arquivo .dat.
        public static void GravarPossibilidades(List<string> listaDeVolantes)
        {
            Directory.CreateDirectory(diretorioDoFrenzy + @"\possibilidades\");
            using (StreamWriter writer = new StreamWriter(diretorioDePossibilidades))
            {
                foreach (var linha in listaDeVolantes)
                {
                    if (linha != "")
                        writer.WriteLine(linha);
                }
            }
        }

        // Gravas todas os sorteios no arquivo .dat.
        public static void GravarSorteios(List<string> listaDeSorteios)
        {
            using (StreamWriter writer = new StreamWriter(diretorioDeSorteios + @"\sorteios.txt"))
            {
                foreach (var linha in listaDeSorteios)
                {
                    if (linha != "")
                        writer.WriteLine(linha);
                }
            }
        }

        // Gera todas as possibilidades e grava no arquivo .dat.
        public static void GerarTodasAsPossibilidades()
        {
            int[] volante = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            int contadorDeLimite;
            int contadorDePosicao = 14;

            contadorDePosicao = 14; // Refere-se a 14ª posição do vetor volante.
            contadorDeLimite = volante[contadorDePosicao]; ;  // Valor inicial da 14ª posição do volante.
            int mudarPosicao = 0;

            while (volante[0] <= 11) // 3268760 -- 'volante[0] != 11' -- 'listaDePossibilidades.Count < 10000'
            {
                if (volante[14] <= 25)
                {
                    listaDePossibilidades.Add(FormatarVolante(volante));
                    volante[14]++;
                }
                else if (mudarPosicao == -1)
                {
                    contadorDePosicao--;
                    contadorDeLimite = volante[contadorDePosicao];
                    mudarPosicao = 0;
                }
                else
                {
                    mudarPosicao = MudarPosicao(volante, contadorDeLimite, contadorDePosicao);

                    if (mudarPosicao == -1)
                        continue;

                    volante[14 - mudarPosicao]++;
                    volante = AtualizarValorMinimoDasPosicoes(volante, mudarPosicao);
                }
            }

            GravarPossibilidades(listaDePossibilidades);
        }

        // Recebe o volante em vetor de inteiros e retorna com casas de 2 dígitos em string.
        public static string FormatarVolante(int[] vetorVolante)
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
        private static int[] AtualizarValorMinimoDasPosicoes(int[] vetorVolante, int posicaoInicial)
        {
            for (int j = (14 - posicaoInicial); j < 14; j++)
            {
                // Reinicia os valores de forma sequencial.
                vetorVolante[j + 1] = vetorVolante[j] + 1;
            }

            return vetorVolante;
        }

        // Verifica e retorna quantas posições do volante (de trás pra frente) atingiram seu limite.
        static int MudarPosicao(int[] vetorVolante, int contadorDeLimite, int contadorDePosicao)
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

        // Extrai sorteios do arquivo HTM.
        public static void OrganizarSorteios()
        {
            string diretorio = (diretorioDoFrenzy + @"\Sorteios\D_LOTFAC.HTM");
            listaDeSorteios = File.ReadAllLines(diretorio).ToList<string>();
            List<int> numerosLinhaTemporaria = new List<int>();
            List<string> listaTemporaria = new List<string>();

            // Responsável por eliminar as linhas vazias.
            int totalDeLinhasDoArquivoBaixado = listaDeSorteios.ToList().Count;
            foreach (var linha in listaDeSorteios.ToList())
            {
                if (linha.Length <= 1)
                {
                    listaDeSorteios.Remove(linha);
                    continue;
                }
            }

            for (int i = 0; i < listaDeSorteios.Count; i++)
            {
                // Identifica linha que contenha data de sorteio.
                if ((listaDeSorteios[i].Length > 29) && (listaDeSorteios[i].Substring(18, 1) == "/" || listaDeSorteios[i].Substring(19, 1) == "/"))
                {
                    for (int j = 0; j < 15; j++)
                    {
                        i++;
                        // Captura o número sorteado (na linha), converte para inteiro e guarda da lista com os números do sorteio.
                        numerosLinhaTemporaria.Add(Convert.ToInt32(listaDeSorteios[i].Substring((listaDeSorteios[i].IndexOf("\">")) + 2, 2)));
                    }
                    numerosLinhaTemporaria.Sort();
                    // Formata o vetor com os números para uma string e guarda na lista temporária.
                    listaTemporaria.Add(FormatarSorteio(numerosLinhaTemporaria));
                    numerosLinhaTemporaria.Clear();
                }
            }

            listaDeSorteios = listaTemporaria;
            GravarSorteios(listaDeSorteios);
        }

        // Transforma o vetor do volante com números inteiros, em uma string pronta para ser inclusa na lista de possibilidades.
        public static string FormatarSorteio(List<int> vetorSorteio)
        {
            string sorteioFormatado = "";
            foreach (var numero in vetorSorteio)
            {
                if (numero < 10)
                    sorteioFormatado += ("0" + numero + " ");
                else
                    sorteioFormatado += (numero + " ");
            }

            return sorteioFormatado;
        }

        // Faz o download do arquivo .zip com todos os sorteios.
        public static void DownloadDeSorteios()
        {
            try
            {
                var requisicao = (HttpWebRequest)WebRequest.Create(@"http://www1.caixa.gov.br/loterias/_arquivos/loterias/D_lotfac.zip");
                requisicao.MaximumAutomaticRedirections = 1;
                requisicao.AllowAutoRedirect = true;
                requisicao.CookieContainer = new CookieContainer();
                var response = (HttpWebResponse)requisicao.GetResponse();
                using (var responseStream = response.GetResponseStream())
                {
                    using (var fileStream = new FileStream(Path.Combine(diretorioDoFrenzy + @"\downloadSorteios.zip"), FileMode.Create))
                    {
                        //if (Directory.Exists(diretorioDoFrenzy))
                        responseStream.CopyTo(fileStream);
                    }
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Não foi possível efetuar o download dos sorteios.", ex);
            }
        }

        // Extrair o arquivo .zip baixado (com os sorteios).
        public static void ExtrairArquivoZip()
        {
            try
            {
                string arquivoZip = (diretorioDoFrenzy + @"\downloadSorteios.zip");
                string extrairPara = diretorioDoFrenzy + @"\Sorteios\";
                var fileInfo = new FileInfo(arquivoZip);
                long tamanhoArquivoZip = fileInfo.Length;

                if (tamanhoArquivoZip > 200000) // 200 mil bytes
                {
                    FazerBackupDeArquivo(diretorioDoFrenzy, @"\downloadSorteios.zip");

                    if (!(Directory.Exists(diretorioDoFrenzy + @"\Sorteios\")))
                        Directory.CreateDirectory(diretorioDoFrenzy + @"\Sorteios\");

                    Directory.Delete(diretorioDoFrenzy + @"\Sorteios\", true); // Apaga os arquivos da pasta Sorteios.
                    ZipFile.ExtractToDirectory(arquivoZip, extrairPara);
                }
                else
                {
                    throw new Exception("O arquivo .zip não existe ou é inválido!");
                }
            }
            catch (Exception ex)
            {
                RecuperarBackupDeArquivo("downloadSorteios.zip");
                ExtrairArquivoZip();
                throw new ArgumentException("Erro ao extrair arquivo baixado! Clique em 'continuar' para recuperar o último backup.", ex);
            }
        }

        // Guarda o arquivo passado na pasta de backup do Frenzy.
        public static void FazerBackupDeArquivo(string diretorioAtual, string nomeDoArquivo)
        {
            try
            {
                if (Directory.Exists(diretorioDoFrenzy + @"\Backup") == true)
                {
                    if (File.Exists(diretorioDoFrenzy + @"\Backup" + nomeDoArquivo))
                        File.Delete(diretorioDoFrenzy + @"\Backup" + nomeDoArquivo);
                    File.Copy(diretorioAtual + nomeDoArquivo, diretorioDoFrenzy + @"\Backup" + nomeDoArquivo);
                }
                else
                {
                    Directory.CreateDirectory(diretorioDoFrenzy + @"\Backup");
                    FazerBackupDeArquivo(diretorioAtual, nomeDoArquivo);
                }
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao fazer backup!", ex);
            }
        }

        // Recupera o arquivo passado, colocando-o na pasta raiz do Frenzy. Isso sobrescreve arquivos com mesmo nome.
        public static void RecuperarBackupDeArquivo(string nomeDoArquivo)
        {
            try
            {
                File.Copy(diretorioDoFrenzy + @"\Backup\" + nomeDoArquivo, diretorioDoFrenzy + @"\" + nomeDoArquivo);
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Não existe backup desse arquivo!", ex);
            }
        }

        // Faz o download do último sorteio em tempo real.
        public static string AtualizarUltimoSorteio()
        {
            List<string> ultimoSorteio = new List<string>();
            string siteLotofacil = @"http://loterias.caixa.gov.br/wps/portal/loterias/landing/lotofacil.htm";
            try
            {
                var requisicao = (HttpWebRequest)WebRequest.Create(siteLotofacil);
                requisicao.MaximumAutomaticRedirections = 1;
                requisicao.AllowAutoRedirect = true;
                requisicao.CookieContainer = new CookieContainer();
                var response = (HttpWebResponse)requisicao.GetResponse();
                using (var responseStream = response.GetResponseStream())
                {
                    using (var fileStream = new FileStream(Path.Combine(diretorioDoFrenzy + @"\resultadoAtual.txt"), FileMode.Create))
                    {
                        responseStream.CopyTo(fileStream);
                    }
                }

                return ConfirmarUltimoSorteio();
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro ao atualizar ultimo sorteio! Clique em 'Continuar' para utilizar a última atualização válida." + ex);
                //return ultimoSorteio;
            }
        }

        // Pega o download do último sorteio de tempo real e extrai os números sorteados, formando um volante em string.
        public static string ConfirmarUltimoSorteio()
        {
            try
            {
                List<string> dadosUltimoSorteio = File.ReadAllLines(diretorioDoFrenzy + @"\resultadoAtual.txt").ToList<string>();

                // Força o sistema à considerar apenas o intervalo de linhas que tenham a tabela do último sorteio.
                int contadorTemporario = 80;
                foreach (var linha in dadosUltimoSorteio.ToList())
                {
                    if (linha.IndexOf(@"table lotofacil") == -1 && contadorTemporario == 80)
                    {
                        dadosUltimoSorteio.Remove(linha);
                        continue;
                    }
                    else
                    {
                        //throw new ArgumentException("Linha: '"  + linha + "'");
                        if (contadorTemporario > 0)
                        {
                            contadorTemporario--;
                            continue;
                        }  
                        else
                            dadosUltimoSorteio.Remove(linha);
                    }
                }

                // Varre o intervalo de linhas selecionado para montar apenas o voltante com o último sorteio.
                string ultimoSorteio = "";
                List<int> numerosUltimoSorteio = new List<int>();
                foreach (var linha in dadosUltimoSorteio.ToList())
                {
                    // Se não encontrar o índice, pula a linha.
                    if (linha.IndexOf("<td>") == -1)
                        continue;
                    if (linha.Substring((linha.IndexOf("<td>")), 4) == "<td>")
                        numerosUltimoSorteio.Add(Convert.ToInt32(linha.Substring((linha.IndexOf("<td>")) + 4, 2)));
                }

                numerosUltimoSorteio.Sort();
                ultimoSorteio = FormatarSorteio(numerosUltimoSorteio);
                return ultimoSorteio;
            }
            // diretorioDoFrenzy + @"\resultadoAtual.txt"
            catch (Exception ex)
            {
                throw new ArgumentException("Não foi possível confirmar o último sorteio.", ex);
            }
        }

        // Programação defensiva:
        public void CarregarBackupDeSorteios()
        {
            using (StreamReader lerArquivo = new StreamReader(diretorioDeSorteios))
            {
                while (!(lerArquivo.EndOfStream))
                {
                    string linha = lerArquivo.ReadLine();
                    listaDeSorteios.Add(linha);
                }
            }
        }
        #endregion
    }
}
