
namespace Ex025_PRL_Repetidores_Visual_102122
{
    partial class Form1
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
            this.btnEnquanto = new System.Windows.Forms.Button();
            this.btnPara = new System.Windows.Forms.Button();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.Lista = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btnEnquanto
            // 
            this.btnEnquanto.Location = new System.Drawing.Point(12, 27);
            this.btnEnquanto.Name = "btnEnquanto";
            this.btnEnquanto.Size = new System.Drawing.Size(114, 20);
            this.btnEnquanto.TabIndex = 0;
            this.btnEnquanto.Text = "Enquanto";
            this.btnEnquanto.UseVisualStyleBackColor = true;
            this.btnEnquanto.Click += new System.EventHandler(this.btnEnquanto_Click);
            // 
            // btnPara
            // 
            this.btnPara.Location = new System.Drawing.Point(257, 26);
            this.btnPara.Name = "btnPara";
            this.btnPara.Size = new System.Drawing.Size(114, 20);
            this.btnPara.TabIndex = 1;
            this.btnPara.Text = "Para";
            this.btnPara.UseVisualStyleBackColor = true;
            this.btnPara.Click += new System.EventHandler(this.btnPara_Click);
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(132, 27);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(119, 20);
            this.txtTamanho.TabIndex = 2;
            // 
            // Lista
            // 
            this.Lista.FormattingEnabled = true;
            this.Lista.Location = new System.Drawing.Point(12, 53);
            this.Lista.Name = "Lista";
            this.Lista.Size = new System.Drawing.Size(359, 173);
            this.Lista.TabIndex = 3;
//            this.Lista.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 243);
            this.Controls.Add(this.Lista);
            this.Controls.Add(this.txtTamanho);
            this.Controls.Add(this.btnPara);
            this.Controls.Add(this.btnEnquanto);
            this.Name = "Form1";
            this.Text = "Ex25_PRL_Repetidores_Visual_102122";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnEnquanto;
        private System.Windows.Forms.Button btnPara;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.ListBox Lista;
    }
}

