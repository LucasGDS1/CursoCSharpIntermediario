namespace EstudoXML
{
    partial class Form1
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lbxEmpresas = new System.Windows.Forms.ListBox();
            this.lblTituloPessoa = new System.Windows.Forms.Label();
            this.lbxPessoas = new System.Windows.Forms.ListBox();
            this.lblTituloEmpresa = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTitulo.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTitulo.Location = new System.Drawing.Point(201, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(235, 31);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Agenda de Contatos";
            // 
            // lbxEmpresas
            // 
            this.lbxEmpresas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxEmpresas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxEmpresas.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbxEmpresas.FormattingEnabled = true;
            this.lbxEmpresas.ItemHeight = 15;
            this.lbxEmpresas.Location = new System.Drawing.Point(12, 114);
            this.lbxEmpresas.Name = "lbxEmpresas";
            this.lbxEmpresas.Size = new System.Drawing.Size(608, 90);
            this.lbxEmpresas.TabIndex = 1;
            // 
            // lblTituloPessoa
            // 
            this.lblTituloPessoa.AutoSize = true;
            this.lblTituloPessoa.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloPessoa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloPessoa.Location = new System.Drawing.Point(3, 222);
            this.lblTituloPessoa.Name = "lblTituloPessoa";
            this.lblTituloPessoa.Size = new System.Drawing.Size(235, 31);
            this.lblTituloPessoa.TabIndex = 2;
            this.lblTituloPessoa.Text = "Contatos de Pessoas";
            // 
            // lbxPessoas
            // 
            this.lbxPessoas.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbxPessoas.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbxPessoas.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.lbxPessoas.FormattingEnabled = true;
            this.lbxPessoas.ItemHeight = 15;
            this.lbxPessoas.Location = new System.Drawing.Point(12, 256);
            this.lbxPessoas.Name = "lbxPessoas";
            this.lbxPessoas.Size = new System.Drawing.Size(608, 90);
            this.lbxPessoas.TabIndex = 3;
            // 
            // lblTituloEmpresa
            // 
            this.lblTituloEmpresa.AutoSize = true;
            this.lblTituloEmpresa.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTituloEmpresa.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblTituloEmpresa.Location = new System.Drawing.Point(3, 80);
            this.lblTituloEmpresa.Name = "lblTituloEmpresa";
            this.lblTituloEmpresa.Size = new System.Drawing.Size(256, 31);
            this.lblTituloEmpresa.TabIndex = 4;
            this.lblTituloEmpresa.Text = "Contatos de Empresas";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(633, 419);
            this.Controls.Add(this.lblTituloEmpresa);
            this.Controls.Add(this.lbxPessoas);
            this.Controls.Add(this.lblTituloPessoa);
            this.Controls.Add(this.lbxEmpresas);
            this.Controls.Add(this.lblTitulo);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.HelpButton = true;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Agenda";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ListBox lbxEmpresas;
        private System.Windows.Forms.Label lblTituloPessoa;
        private System.Windows.Forms.ListBox lbxPessoas;
        private System.Windows.Forms.Label lblTituloEmpresa;
    }
}

