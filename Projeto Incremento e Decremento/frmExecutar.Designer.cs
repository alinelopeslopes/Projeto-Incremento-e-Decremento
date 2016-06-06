namespace Projeto_Incremento_e_Decremento
{
    partial class frmExecutar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExecutar));
            this.lbApresentacaoData = new System.Windows.Forms.Label();
            this.lbQuantidade = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.gbOpcoes = new System.Windows.Forms.GroupBox();
            this.rbDecrementar = new System.Windows.Forms.RadioButton();
            this.rbIncrementar = new System.Windows.Forms.RadioButton();
            this.btnExecutar = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.gbOpcoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbApresentacaoData
            // 
            this.lbApresentacaoData.AutoSize = true;
            this.lbApresentacaoData.Location = new System.Drawing.Point(109, 34);
            this.lbApresentacaoData.Name = "lbApresentacaoData";
            this.lbApresentacaoData.Size = new System.Drawing.Size(0, 13);
            this.lbApresentacaoData.TabIndex = 0;
            // 
            // lbQuantidade
            // 
            this.lbQuantidade.AutoSize = true;
            this.lbQuantidade.Location = new System.Drawing.Point(121, 98);
            this.lbQuantidade.Name = "lbQuantidade";
            this.lbQuantidade.Size = new System.Drawing.Size(155, 13);
            this.lbQuantidade.TabIndex = 1;
            this.lbQuantidade.Text = "Digite a quantidade em minutos";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(149, 130);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(100, 20);
            this.txtQuantidade.TabIndex = 2;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // gbOpcoes
            // 
            this.gbOpcoes.Controls.Add(this.rbDecrementar);
            this.gbOpcoes.Controls.Add(this.rbIncrementar);
            this.gbOpcoes.Location = new System.Drawing.Point(95, 172);
            this.gbOpcoes.Name = "gbOpcoes";
            this.gbOpcoes.Size = new System.Drawing.Size(200, 116);
            this.gbOpcoes.TabIndex = 3;
            this.gbOpcoes.TabStop = false;
            this.gbOpcoes.Text = "Opções";
            // 
            // rbDecrementar
            // 
            this.rbDecrementar.AutoSize = true;
            this.rbDecrementar.Location = new System.Drawing.Point(59, 75);
            this.rbDecrementar.Name = "rbDecrementar";
            this.rbDecrementar.Size = new System.Drawing.Size(86, 17);
            this.rbDecrementar.TabIndex = 1;
            this.rbDecrementar.TabStop = true;
            this.rbDecrementar.Text = "Decrementar";
            this.rbDecrementar.UseVisualStyleBackColor = true;
            // 
            // rbIncrementar
            // 
            this.rbIncrementar.AutoSize = true;
            this.rbIncrementar.Location = new System.Drawing.Point(59, 30);
            this.rbIncrementar.Name = "rbIncrementar";
            this.rbIncrementar.Size = new System.Drawing.Size(81, 17);
            this.rbIncrementar.TabIndex = 0;
            this.rbIncrementar.TabStop = true;
            this.rbIncrementar.Text = "Incrementar";
            this.rbIncrementar.UseVisualStyleBackColor = true;
            // 
            // btnExecutar
            // 
            this.btnExecutar.Location = new System.Drawing.Point(154, 304);
            this.btnExecutar.Name = "btnExecutar";
            this.btnExecutar.Size = new System.Drawing.Size(81, 41);
            this.btnExecutar.TabIndex = 4;
            this.btnExecutar.Text = "Executar";
            this.btnExecutar.UseVisualStyleBackColor = true;
            this.btnExecutar.Click += new System.EventHandler(this.btnExecutar_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmExecutar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(394, 372);
            this.Controls.Add(this.btnExecutar);
            this.Controls.Add(this.gbOpcoes);
            this.Controls.Add(this.txtQuantidade);
            this.Controls.Add(this.lbQuantidade);
            this.Controls.Add(this.lbApresentacaoData);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExecutar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Incremento e Decremento de data/hora";
            this.Load += new System.EventHandler(this.frmExecutar_Load);
            this.gbOpcoes.ResumeLayout(false);
            this.gbOpcoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbApresentacaoData;
        private System.Windows.Forms.Label lbQuantidade;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.GroupBox gbOpcoes;
        private System.Windows.Forms.RadioButton rbDecrementar;
        private System.Windows.Forms.RadioButton rbIncrementar;
        private System.Windows.Forms.Button btnExecutar;
        private System.Windows.Forms.Timer timer1;
    }
}