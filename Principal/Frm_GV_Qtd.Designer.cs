namespace Frenzy
{
    partial class Frm_GV_Qtd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_GV_Qtd));
            this.BtnSair = new Bunifu.Framework.UI.BunifuImageButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnInicio = new Bunifu.Framework.UI.BunifuImageButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGerar = new Bunifu.Framework.UI.BunifuThinButton2();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnInfo = new System.Windows.Forms.ToolTip(this.components);
            this.PrgGeracao = new Bunifu.Framework.UI.BunifuProgressBar();
            ((System.ComponentModel.ISupportInitialize)(this.BtnSair)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnSair
            // 
            this.BtnSair.BackColor = System.Drawing.Color.Transparent;
            this.BtnSair.Image = ((System.Drawing.Image)(resources.GetObject("BtnSair.Image")));
            this.BtnSair.ImageActive = null;
            this.BtnSair.Location = new System.Drawing.Point(720, 23);
            this.BtnSair.Name = "BtnSair";
            this.BtnSair.Size = new System.Drawing.Size(41, 55);
            this.BtnSair.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnSair.TabIndex = 10;
            this.BtnSair.TabStop = false;
            this.btnInfo.SetToolTip(this.BtnSair, "Sair");
            this.BtnSair.Zoom = 10;
            this.BtnSair.Click += new System.EventHandler(this.BtnSair_Click);
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
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(81, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 33);
            this.label1.TabIndex = 8;
            this.label1.Text = "Frenzy";
            // 
            // BtnInicio
            // 
            this.BtnInicio.BackColor = System.Drawing.Color.Transparent;
            this.BtnInicio.Image = ((System.Drawing.Image)(resources.GetObject("BtnInicio.Image")));
            this.BtnInicio.ImageActive = null;
            this.BtnInicio.Location = new System.Drawing.Point(669, 30);
            this.BtnInicio.Name = "BtnInicio";
            this.BtnInicio.Size = new System.Drawing.Size(51, 41);
            this.BtnInicio.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.BtnInicio.TabIndex = 11;
            this.BtnInicio.TabStop = false;
            this.btnInfo.SetToolTip(this.BtnInicio, "Início");
            this.BtnInicio.Zoom = 10;
            this.BtnInicio.Click += new System.EventHandler(this.BtnInicio_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.label3.Location = new System.Drawing.Point(231, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(323, 30);
            this.label3.TabIndex = 14;
            this.label3.Text = "Quantos volantes deseja?";
            // 
            // btnGerar
            // 
            this.btnGerar.ActiveBorderThickness = 1;
            this.btnGerar.ActiveCornerRadius = 20;
            this.btnGerar.ActiveFillColor = System.Drawing.Color.Lavender;
            this.btnGerar.ActiveForecolor = System.Drawing.Color.Black;
            this.btnGerar.ActiveLineColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnGerar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnGerar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnGerar.BackgroundImage")));
            this.btnGerar.ButtonText = "Gerar";
            this.btnGerar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGerar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnGerar.IdleBorderThickness = 1;
            this.btnGerar.IdleCornerRadius = 25;
            this.btnGerar.IdleFillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerar.IdleForecolor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnGerar.IdleLineColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGerar.Location = new System.Drawing.Point(385, 279);
            this.btnGerar.Margin = new System.Windows.Forms.Padding(5);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(82, 44);
            this.btnGerar.TabIndex = 15;
            this.btnGerar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // textBox1
            // 
            this.textBox1.AcceptsReturn = true;
            this.textBox1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.Red;
            this.textBox1.Location = new System.Drawing.Point(315, 286);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(62, 32);
            this.textBox1.TabIndex = 16;
            this.textBox1.Text = "1";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox1.Enter += new System.EventHandler(this.btnGerar_Click);
            // 
            // PrgGeracao
            // 
            this.PrgGeracao.BackColor = System.Drawing.Color.DarkGray;
            this.PrgGeracao.BorderRadius = 5;
            this.PrgGeracao.Location = new System.Drawing.Point(192, 426);
            this.PrgGeracao.MaximumValue = 100;
            this.PrgGeracao.Name = "PrgGeracao";
            this.PrgGeracao.ProgressColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PrgGeracao.Size = new System.Drawing.Size(410, 10);
            this.PrgGeracao.TabIndex = 18;
            this.PrgGeracao.Value = 30;
            this.PrgGeracao.Visible = false;
            // 
            // Frm_GV_Qtd
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(799, 561);
            this.Controls.Add(this.PrgGeracao);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.BtnInicio);
            this.Controls.Add(this.BtnSair);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(815, 600);
            this.MinimumSize = new System.Drawing.Size(815, 600);
            this.Name = "Frm_GV_Qtd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frenzy";
            this.Load += new System.EventHandler(this.Frm_GV_Qtd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BtnSair)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnInicio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuImageButton BtnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuImageButton BtnInicio;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 btnGerar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ToolTip btnInfo;
        private Bunifu.Framework.UI.BunifuProgressBar PrgGeracao;
    }
}