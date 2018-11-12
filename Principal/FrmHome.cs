using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace Frenzy
{
    public partial class FrmHome : Form
    {
        public FrmHome()
        {
            InitializeComponent();
        }

        private void FrmHome_Load(object sender, EventArgs e)
        {

        }

        private void btnGerarVolantes_Click(object sender, EventArgs e)
        {
            this.Hide();
            var frm_GV_Qtd = new Frm_GV_Qtd();
            frm_GV_Qtd.ShowDialog();
        }

        private void btnSair_Click(object sender, EventArgs e)
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
