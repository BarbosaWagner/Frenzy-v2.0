using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.IO;
using System.IO.Compression;
using System.Net;

namespace Sorteios
{
    static class Arquivo
    {
        public static List<string> listaDeSorteios;

        // INATIVO: Esse método imprime na tela todos os sorteios com seus respectivos números de concurso.
        public static void ImprimirSorteios()
        {
            Console.Clear();

            int concurso = 1;
            foreach (var linha in listaDeSorteios)
            {
                Console.WriteLine(concurso + " " + linha);
                concurso++;
            }
        }

        // Extrai sorteios do arquivo HTM.
        public static void OrganizarSorteios()
        {
            string diretorio = @"C:\temp\Sorteios\D_LOTFAC.HTM";
            listaDeSorteios = File.ReadAllLines(diretorio).ToList<string>();

            Console.Write("Organizando sorteios...");
            List<int> numerosLinhaTemporaria = new List<int>();
            List<string> listaTemporaria = new List<string>();

            // Responsável por eliminar as linhas vazias.
            foreach (var linha in listaDeSorteios.ToList())
            {
                if (linha.Length <= 1)
                {
                    listaDeSorteios.Remove(linha);
                    Console.Write(".");
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
                    Console.Write(".");
                }
            }

            listaDeSorteios = listaTemporaria;
            Console.WriteLine("Pronto!");
            Thread.Sleep(2000);
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
            CookieContainer myContainer = new CookieContainer();
            var requisicao = (HttpWebRequest)WebRequest.Create(@"http://www1.caixa.gov.br/loterias/_arquivos/loterias/D_lotfac.zip");
            requisicao.MaximumAutomaticRedirections = 1;
            requisicao.AllowAutoRedirect = true;
            requisicao.CookieContainer = myContainer;
            var response = (HttpWebResponse)requisicao.GetResponse();
            using (var responseStream = response.GetResponseStream())
            {
                using (var fileStream = new FileStream(Path.Combine(@"C:\Temp\", "downloadSorteios.zip"), FileMode.Create))
                {
                    responseStream.CopyTo(fileStream);
                }
            }
        }

        // Extrair o arquivo .zip baixado (com os sorteios).
        public static void ExtrairArquivoZip()
        {
            try
            {
                Directory.Delete(@"C:\Temp\Sorteios\", true);

                string extrairPara = @"C:\Temp\Sorteios\";
                string arquivo = @"C:\Temp\downloadSorteios.zip";

                ZipFile.ExtractToDirectory(arquivo, extrairPara);
            }
            catch
            {
                Console.WriteLine("Erro ao extrair arquivo baixado!");
            }
        }
    }
}