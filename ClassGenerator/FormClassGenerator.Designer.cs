namespace ClassGenerator
{
    partial class FormClassGenerator
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTxtBoxConteudo = new System.Windows.Forms.RichTextBox();
            this.radioBtnJson = new System.Windows.Forms.RadioButton();
            this.txtBoxClasse = new System.Windows.Forms.TextBox();
            this.lblClasse = new System.Windows.Forms.Label();
            this.lblNamespace = new System.Windows.Forms.Label();
            this.txtBoxNamespace = new System.Windows.Forms.TextBox();
            this.lblPasta = new System.Windows.Forms.Label();
            this.txtBoxPasta = new System.Windows.Forms.TextBox();
            this.btnSelecionarPasta = new System.Windows.Forms.Button();
            this.btnGerar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // richTxtBoxConteudo
            // 
            this.richTxtBoxConteudo.Location = new System.Drawing.Point(13, 38);
            this.richTxtBoxConteudo.Name = "richTxtBoxConteudo";
            this.richTxtBoxConteudo.Size = new System.Drawing.Size(348, 269);
            this.richTxtBoxConteudo.TabIndex = 0;
            this.richTxtBoxConteudo.Text = "";
            // 
            // radioBtnJson
            // 
            this.radioBtnJson.AutoSize = true;
            this.radioBtnJson.Checked = true;
            this.radioBtnJson.Location = new System.Drawing.Point(13, 13);
            this.radioBtnJson.Name = "radioBtnJson";
            this.radioBtnJson.Size = new System.Drawing.Size(53, 19);
            this.radioBtnJson.TabIndex = 1;
            this.radioBtnJson.TabStop = true;
            this.radioBtnJson.Text = "JSON";
            this.radioBtnJson.UseVisualStyleBackColor = true;
            // 
            // txtBoxClasse
            // 
            this.txtBoxClasse.Location = new System.Drawing.Point(62, 349);
            this.txtBoxClasse.Name = "txtBoxClasse";
            this.txtBoxClasse.Size = new System.Drawing.Size(299, 23);
            this.txtBoxClasse.TabIndex = 2;
            // 
            // lblClasse
            // 
            this.lblClasse.AutoSize = true;
            this.lblClasse.Location = new System.Drawing.Point(13, 352);
            this.lblClasse.Name = "lblClasse";
            this.lblClasse.Size = new System.Drawing.Size(43, 15);
            this.lblClasse.TabIndex = 3;
            this.lblClasse.Text = "Classe:";
            // 
            // lblNamespace
            // 
            this.lblNamespace.AutoSize = true;
            this.lblNamespace.Location = new System.Drawing.Point(13, 316);
            this.lblNamespace.Name = "lblNamespace";
            this.lblNamespace.Size = new System.Drawing.Size(72, 15);
            this.lblNamespace.TabIndex = 3;
            this.lblNamespace.Text = "Namespace:";
            // 
            // txtBoxNamespace
            // 
            this.txtBoxNamespace.Location = new System.Drawing.Point(91, 313);
            this.txtBoxNamespace.Name = "txtBoxNamespace";
            this.txtBoxNamespace.Size = new System.Drawing.Size(270, 23);
            this.txtBoxNamespace.TabIndex = 2;
            // 
            // lblPasta
            // 
            this.lblPasta.AutoSize = true;
            this.lblPasta.Location = new System.Drawing.Point(13, 388);
            this.lblPasta.Name = "lblPasta";
            this.lblPasta.Size = new System.Drawing.Size(38, 15);
            this.lblPasta.TabIndex = 4;
            this.lblPasta.Text = "Pasta:";
            // 
            // txtBoxPasta
            // 
            this.txtBoxPasta.Enabled = false;
            this.txtBoxPasta.Location = new System.Drawing.Point(57, 385);
            this.txtBoxPasta.Name = "txtBoxPasta";
            this.txtBoxPasta.Size = new System.Drawing.Size(272, 23);
            this.txtBoxPasta.TabIndex = 2;
            // 
            // btnSelecionarPasta
            // 
            this.btnSelecionarPasta.Location = new System.Drawing.Point(335, 385);
            this.btnSelecionarPasta.Name = "btnSelecionarPasta";
            this.btnSelecionarPasta.Size = new System.Drawing.Size(26, 23);
            this.btnSelecionarPasta.TabIndex = 5;
            this.btnSelecionarPasta.Text = "...";
            this.btnSelecionarPasta.UseVisualStyleBackColor = true;
            this.btnSelecionarPasta.Click += new System.EventHandler(this.btnSelecionarPasta_Click);
            // 
            // btnGerar
            // 
            this.btnGerar.Location = new System.Drawing.Point(286, 414);
            this.btnGerar.Name = "btnGerar";
            this.btnGerar.Size = new System.Drawing.Size(75, 23);
            this.btnGerar.TabIndex = 6;
            this.btnGerar.Text = "Gerar";
            this.btnGerar.UseVisualStyleBackColor = true;
            this.btnGerar.Click += new System.EventHandler(this.btnGerar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(205, 414);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // FormClassGenerator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 450);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnGerar);
            this.Controls.Add(this.btnSelecionarPasta);
            this.Controls.Add(this.txtBoxPasta);
            this.Controls.Add(this.lblPasta);
            this.Controls.Add(this.txtBoxNamespace);
            this.Controls.Add(this.lblNamespace);
            this.Controls.Add(this.lblClasse);
            this.Controls.Add(this.txtBoxClasse);
            this.Controls.Add(this.radioBtnJson);
            this.Controls.Add(this.richTxtBoxConteudo);
            this.Name = "FormClassGenerator";
            this.Text = "C# Class Generator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTxtBoxConteudo;
        private System.Windows.Forms.RadioButton radioBtnJson;
        private System.Windows.Forms.TextBox txtBoxClasse;
        private System.Windows.Forms.Label lblClasse;
        private System.Windows.Forms.Label lblNamespace;
        private System.Windows.Forms.TextBox txtBoxNamespace;
        private System.Windows.Forms.Label lblPasta;
        private System.Windows.Forms.TextBox txtBoxPasta;
        private System.Windows.Forms.Button btnSelecionarPasta;
        private System.Windows.Forms.Button btnGerar;
        private System.Windows.Forms.Button btnLimpar;
    }
}

