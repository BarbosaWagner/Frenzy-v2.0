using System;
using System.Collections.Generic;
using System.IO;

namespace GeradorDeTodosOsVolantes
{
    public class Arquivo
    {
        public static string volantes = @"C:\temp\volantes.txt";

        public void GravarVolantes(List<string> listaDeVolantes)
        {
            using (StreamWriter writer = new StreamWriter(volantes))
            {
                foreach (var linha in listaDeVolantes)
                {
                    writer.WriteLine(linha);
                }
            }
        }
    }
}
