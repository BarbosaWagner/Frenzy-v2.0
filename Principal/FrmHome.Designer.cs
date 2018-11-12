namespace Frenzy
{
    partial class FrmHome
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnGerarVolantes = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnConferirApostas = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.btnInfo = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Frenzy";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Enabled = false;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(29, 23);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(48, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btnGerarVolantes
            // 
            this.btnGerarVolantes.ActiveBorderThickness = 1;
            this.btnGerarVolantes.ActiveCornerRadius = 20;
            this.btnGerarVolantes.ActiveFillColor = System.Drawing.Color.Lavender;
            this.btnGerarVolantes.ActiveForecolor = System.Drawing.Color.Black;
            this.btnGerarVolantes.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerarVolantes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGerarVolantes.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerarVolantes.BackgroundImage")));
            this.btnGerarVolantes.ButtonText = "Gerar Volantes";
            this.btnGerarVolantes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerarVolantes.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarVolantes.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarVolantes.IdleBorderThickness = 1;
            this.btnGerarVolantes.IdleCornerRadius = 20;
            this.btnGerarVolantes.IdleFillColor = System.Drawing.Color.White;
            this.btnGerarVolantes.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarVolantes.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerarVolantes.Location = new System.Drawing.Point(157, 171);
            this.btnGerarVolantes.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnGerarVolantes.Name = "btnGerarVolantes";
            this.btnGerarVolantes.Size = new System.Drawing.Size(243, 245);
            this.btnGerarVolantes.TabIndex = 5;
            this.btnGerarVolantes.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGerarVolantes.Click += new System.EventHandler(this.btnGerarVolantes_Click);
            // 
            // btnConferirApostas
            // 
            this.btnConferirApostas.ActiveBorderThickness = 1;
            this.btnConferirApostas.ActiveCornerRadius = 20;
            this.btnConferirApostas.ActiveFillColor = System.Drawing.Color.Lavender;
            this.btnConferirApostas.ActiveForecolor = System.Drawing.Color.Black;
            this.btnConferirApostas.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnConferirApostas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnConferirApostas.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConferirApostas.BackgroundImage")));
            this.btnConferirApostas.ButtonText = "Conferir Apostas";
            this.btnConferirApostas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConferirApostas.Font = new System.Drawing.Font("Century Gothic", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConferirApostas.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConferirApostas.IdleBorderThickness = 1;
            this.btnConferirApostas.IdleCornerRadius = 20;
            this.btnConferirApostas.IdleFillColor = System.Drawing.Color.White;
            this.btnConferirApostas.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConferirApostas.IdleLineColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnConferirApostas.Location = new System.Drawing.Point(412, 171);
            this.btnConferirApostas.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.btnConferirApostas.Name = "btnConferirApostas";
            this.btnConferirApostas.Size = new System.Drawing.Size(243, 245);
            this.btnConferirApostas.TabIndex = 6;
            this.btnConferirApostas.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.Color.Transparent;
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.ImageActive = null;
            this.btnSair.Location = new System.Drawing.Point(720, 23);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(41, 55);
            this.btnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnSair.TabIndex = 7;
            this.btnSair.TabStop = false;
            this.btnInfo.SetToolTip(this.btnSair, "Sair");
            this.btnSair.Zoom = 10;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // FrmHome
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnConferirApostas);
            this.Controls.Add(this.btnGerarVolantes);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 600);
            this.MinimumSize = new System.Drawing.Size(815, 600);
            this.Name = "FrmHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frenzy";
            this.Load += new System.EventHandler(this.FrmHome_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnSair)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGerarVolantes;
        private Bunifu.Framework.UI.BunifuThinButton2 btnConferirApostas;
        private Bunifu.Framework.UI.BunifuImageButton btnSair;
        private System.Windows.Forms.ToolTip btnInfo;
    }
}