namespace Ex026_PRL_Repetidores_VIsual_102322
{
    partial class Form1
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
            this.ListaPar = new System.Windows.Forms.ListBox();
            this.ListaImpar = new System.Windows.Forms.ListBox();
            this.BtnPara = new System.Windows.Forms.Button();
            this.BtnLimpar = new System.Windows.Forms.Button();
            this.BtnEnquanto = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ListaPar
            // 
            this.ListaPar.FormattingEnabled = true;
            this.ListaPar.Location = new System.Drawing.Point(52, 67);
            this.ListaPar.Name = "ListaPar";
            this.ListaPar.Size = new System.Drawing.Size(136, 121);
            this.ListaPar.TabIndex = 0;
            // 
            // ListaImpar
            // 
            this.ListaImpar.FormattingEnabled = true;
            this.ListaImpar.Location = new System.Drawing.Point(194, 67);
            this.ListaImpar.Name = "ListaImpar";
            this.ListaImpar.Size = new System.Drawing.Size(136, 121);
            this.ListaImpar.TabIndex = 1;
            // 
            // BtnPara
            // 
            this.BtnPara.Location = new System.Drawing.Point(52, 194);
            this.BtnPara.Name = "BtnPara";
            this.BtnPara.Size = new System.Drawing.Size(89, 32);
            this.BtnPara.TabIndex = 2;
            this.BtnPara.Text = "Para";
            this.BtnPara.UseVisualStyleBackColor = true;
            this.BtnPara.Click += new System.EventHandler(this.BtnPara_Click);
            // 
            // BtnLimpar
            // 
            this.BtnLimpar.Location = new System.Drawing.Point(147, 194);
            this.BtnLimpar.Name = "BtnLimpar";
            this.BtnLimpar.Size = new System.Drawing.Size(89, 32);
            this.BtnLimpar.TabIndex = 5;
            this.BtnLimpar.Text = "Limpar";
            this.BtnLimpar.UseVisualStyleBackColor = true;
            this.BtnLimpar.Click += new System.EventHandler(this.BtnLimpar_Click);
            // 
            // BtnEnquanto
            // 
            this.BtnEnquanto.Location = new System.Drawing.Point(241, 194);
            this.BtnEnquanto.Name = "BtnEnquanto";
            this.BtnEnquanto.Size = new System.Drawing.Size(89, 32);
            this.BtnEnquanto.TabIndex = 6;
            this.BtnEnquanto.Text = "Enquanto";
            this.BtnEnquanto.UseVisualStyleBackColor = true;
            this.BtnEnquanto.Click += new System.EventHandler(this.BtnEnquanto_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Par:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(201, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Impar:";
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(131, 232);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(120, 20);
            this.txtTamanho.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 298);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BtnEnquanto);
            this.Controls.Add(this.BtnLimpar);
            this.Controls.Add(this.BtnPara);
            this.Controls.Add(this.ListaImpar);
            this.Controls.Add(this.ListaPar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox ListaPar;
        private System.Windows.Forms.ListBox ListaImpar;
        private System.Windows.Forms.Button BtnPara;
        private System.Windows.Forms.Button BtnLimpar;
        private System.Windows.Forms.Button BtnEnquanto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTamanho;
    }
}

