using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;
using System.IO;
using System.IO.Compression;


namespace Sorteios
{
    class Program
    {
        static void Main(string[] args)
        {
            Arquivo.DownloadDeSorteios();
            Arquivo.ExtrairArquivoZip();
            Arquivo.OrganizarSorteios();
            Arquivo.ImprimirSorteios();
        }
    }
}
