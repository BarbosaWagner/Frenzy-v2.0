using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace Frenzy
{
    public partial class FrmInicializacao : Form
    {
        public FrmInicializacao()
        {
            InitializeComponent();
        }

        // Responsável por exibir o Form de inicialização.
        private void Inicializacao_Load(object sender, EventArgs e)
        {
            // Front-end.
        }

        public void CarregarInicializacaoParalela()
        {   
            
            #region CodigoPronto
            Thread.Sleep(2000);
            string diretorioDoFrenzy = (Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData) + @"\Frenzy");

            // Identifica se é a primeira execução.
            if ((File.Exists(diretorioDoFrenzy + @"\possibilidades\possibilidades.dat") == false))
            {
                // Cria diretórios e gera as possibilidades.
                try
                {
                    lblStart.Text = "Preparando-se para o primeiro uso";

                    // Cria a pasta do Frenzy em AppData/Local.
                    Directory.CreateDirectory(diretorioDoFrenzy);

                    // Gera todas as possibilidades da Lotofacil (mais de 3 milhões) e grava no arquivo .dat
                    Arquivo.GerarTodasAsPossibilidades();
                    lblStart.Text = "";
                }
                catch (Exception erro)
                {
                    throw new ArgumentException("Erro 1001", erro);
                }
            }

            lblStart.Text = "Atualizando sorteios";
            try
            {
                Arquivo.DownloadDeSorteios();
                Arquivo.ExtrairArquivoZip();
                Arquivo.OrganizarSorteios();

                string ultimoSorteio = Arquivo.AtualizarUltimoSorteio();

                if (ultimoSorteio == Arquivo.listaDeSorteios[Arquivo.listaDeSorteios.Count - 2])
                    lblStart.Text = "Ultimo sorteio já está atualizado!";
                else
                    lblStart.Text = "Atualizado com sucesso!";
            }
            catch (Exception ex)
            {
                throw new ArgumentException("Erro 1002", ex);
            }

            lblStart.Text = "Pronto!";
            #endregion
            
            Thread.Sleep(2000);

            // Fecha Form atual e abre o Form da Home.
            //FrmInicializacao.ActiveForm.Hide();
            var frmHome = new FrmHome();
            //frmHome.ShowDialog();
        }

        // Timer responsável por chamar a execução do processo de inicialização do backend.
        private void timerBackEnd_Tick(object sender, EventArgs e)
        {
            timerBackEnd.Enabled = false;
            Thread threadSecundaria = new Thread(new ThreadStart(CarregarInicializacaoParalela));
            threadSecundaria.Start();
        }
    }
}
