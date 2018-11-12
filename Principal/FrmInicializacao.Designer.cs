namespace Frenzy
{
    partial class FrmInicializacao
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInicializacao));
            this.lblStart = new System.Windows.Forms.Label();
            this.timerBackEnd = new System.Windows.Forms.Timer(this.components);
            this.circleBar1 = new Frenzy.CircleBar();
            this.SuspendLayout();
            // 
            // lblStart
            // 
            this.lblStart.AutoSize = true;
            this.lblStart.BackColor = System.Drawing.Color.Transparent;
            this.lblStart.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStart.ForeColor = System.Drawing.SystemColors.Control;
            this.lblStart.Location = new System.Drawing.Point(12, 301);
            this.lblStart.MaximumSize = new System.Drawing.Size(594, 30);
            this.lblStart.MinimumSize = new System.Drawing.Size(594, 30);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(594, 30);
            this.lblStart.TabIndex = 2;
            this.lblStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timerBackEnd
            // 
            this.timerBackEnd.Enabled = true;
            this.timerBackEnd.Interval = 10;
            this.timerBackEnd.Tick += new System.EventHandler(this.timerBackEnd_Tick);
            // 
            // circleBar1
            // 
            this.circleBar1.BackColor = System.Drawing.Color.Transparent;
            this.circleBar1.ForeColor = System.Drawing.Color.Transparent;
            this.circleBar1.Location = new System.Drawing.Point(224, 105);
            this.circleBar1.Name = "circleBar1";
            this.circleBar1.Size = new System.Drawing.Size(167, 164);
            this.circleBar1.TabIndex = 0;
            // 
            // FrmInicializacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.ClientSize = new System.Drawing.Size(620, 400);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.circleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(620, 400);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(620, 400);
            this.Name = "FrmInicializacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frenzy";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.Inicializacao_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CircleBar circleBar1;
        public System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Timer timerBackEnd;
    }
}

