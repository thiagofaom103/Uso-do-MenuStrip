namespace POO3C1T_50_ThiagoFreire
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
            this.pnlBase = new System.Windows.Forms.Panel();
            this.lblCadastro = new System.Windows.Forms.Label();
            this.lblIdade = new System.Windows.Forms.Label();
            this.lblData = new System.Windows.Forms.Label();
            this.lblCelular = new System.Windows.Forms.Label();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.txtData = new System.Windows.Forms.TextBox();
            this.txtCelular = new System.Windows.Forms.TextBox();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.pnlBase.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlBase
            // 
            this.pnlBase.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.pnlBase.Controls.Add(this.lblCadastro);
            this.pnlBase.Location = new System.Drawing.Point(-2, -5);
            this.pnlBase.Name = "pnlBase";
            this.pnlBase.Size = new System.Drawing.Size(806, 140);
            this.pnlBase.TabIndex = 0;
            // 
            // lblCadastro
            // 
            this.lblCadastro.AutoSize = true;
            this.lblCadastro.BackColor = System.Drawing.Color.Transparent;
            this.lblCadastro.Cursor = System.Windows.Forms.Cursors.SizeNESW;
            this.lblCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCadastro.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblCadastro.Location = new System.Drawing.Point(143, 44);
            this.lblCadastro.Name = "lblCadastro";
            this.lblCadastro.Size = new System.Drawing.Size(228, 55);
            this.lblCadastro.TabIndex = 0;
            this.lblCadastro.Text = "Cadastro";
            this.lblCadastro.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIdade
            // 
            this.lblIdade.AutoSize = true;
            this.lblIdade.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdade.Location = new System.Drawing.Point(27, 161);
            this.lblIdade.Name = "lblIdade";
            this.lblIdade.Size = new System.Drawing.Size(45, 28);
            this.lblIdade.TabIndex = 1;
            this.lblIdade.Text = "Idade";
            // 
            // lblData
            // 
            this.lblData.AutoSize = true;
            this.lblData.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblData.Location = new System.Drawing.Point(27, 215);
            this.lblData.Name = "lblData";
            this.lblData.Size = new System.Drawing.Size(128, 28);
            this.lblData.TabIndex = 2;
            this.lblData.Text = "Data de Nascimento";
            // 
            // lblCelular
            // 
            this.lblCelular.AutoSize = true;
            this.lblCelular.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCelular.Location = new System.Drawing.Point(27, 271);
            this.lblCelular.Name = "lblCelular";
            this.lblCelular.Size = new System.Drawing.Size(55, 28);
            this.lblCelular.TabIndex = 3;
            this.lblCelular.Text = "Celular";
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Font = new System.Drawing.Font("Microsoft Uighur", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEstado.Location = new System.Drawing.Point(27, 322);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(82, 28);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado Civil";
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(84, 160);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(203, 20);
            this.txtIdade.TabIndex = 15;
            // 
            // txtData
            // 
            this.txtData.Location = new System.Drawing.Point(187, 217);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(100, 20);
            this.txtData.TabIndex = 16;
            // 
            // txtCelular
            // 
            this.txtCelular.Location = new System.Drawing.Point(91, 273);
            this.txtCelular.Name = "txtCelular";
            this.txtCelular.Size = new System.Drawing.Size(196, 20);
            this.txtCelular.TabIndex = 17;
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(124, 322);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(163, 20);
            this.txtEstado.TabIndex = 18;
            // 
            // btnCadastro
            // 
            this.btnCadastro.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.Location = new System.Drawing.Point(312, 160);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(168, 190);
            this.btnCadastro.TabIndex = 19;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(492, 362);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.txtCelular);
            this.Controls.Add(this.txtData);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.lblCelular);
            this.Controls.Add(this.lblData);
            this.Controls.Add(this.lblIdade);
            this.Controls.Add(this.pnlBase);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlBase.ResumeLayout(false);
            this.pnlBase.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlBase;
        private System.Windows.Forms.Label lblIdade;
        private System.Windows.Forms.Label lblData;
        private System.Windows.Forms.Label lblCelular;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.Label lblCadastro;
        private System.Windows.Forms.TextBox txtIdade;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.TextBox txtCelular;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.Button btnCadastro;
    }
}

