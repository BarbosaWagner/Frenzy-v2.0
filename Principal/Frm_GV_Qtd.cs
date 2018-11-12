using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frenzy
{
    public partial class Frm_GV_Qtd : Form
    {
        public Frm_GV_Qtd()
        {
            InitializeComponent();
        }

        private void Frm_GV_Qtd_Load(object sender, EventArgs e)
        {
            //...

        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            //GerarVolantesSolicitados
            PrgGeracao.Visible = true;
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frmHome = new FrmHome();
            frmHome.ShowDialog();
        }

        private void BtnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Confirmação:", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                // Fecha todos os forms abertos.
                for (int intIndex = Application.OpenForms.Count - 1; intIndex >= 0; intIndex--)
                {
                    Application.OpenForms[intIndex].Close();
                }
            }
        }
    }
}
