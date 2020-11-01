namespace EstudoGenerics
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem("");
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNomePessoa = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCodigoEmpresa = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtNomeEmpresa = new System.Windows.Forms.TextBox();
            this.txtCodigoPessoa = new System.Windows.Forms.TextBox();
            this.btnListaCadastro = new System.Windows.Forms.Button();
            this.listCadEmpresas = new System.Windows.Forms.ListView();
            this.clmNome = new System.Windows.Forms.ColumnHeader();
            this.clmCodigo = new System.Windows.Forms.ColumnHeader();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.listCadPessoas = new System.Windows.Forms.ListView();
            this.clmNomePessoa = new System.Windows.Forms.ColumnHeader();
            this.clmCodigoPessoa = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ficha de Cadastro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(85, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(95, 15);
            this.label2.TabIndex = 0;
            this.label2.Text = "Nome da pessoa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(84, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 15);
            this.label3.TabIndex = 0;
            this.label3.Text = "Número da ficha";
            // 
            // txtNomePessoa
            // 
            this.txtNomePessoa.Location = new System.Drawing.Point(196, 132);
            this.txtNomePessoa.Name = "txtNomePessoa";
            this.txtNomePessoa.Size = new System.Drawing.Size(100, 23);
            this.txtNomePessoa.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(0, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 23);
            this.label4.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(0, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 23);
            this.label5.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(369, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(96, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Número da ficha";
            // 
            // txtCodigoEmpresa
            // 
            this.txtCodigoEmpresa.Location = new System.Drawing.Point(485, 80);
            this.txtCodigoEmpresa.Name = "txtCodigoEmpresa";
            this.txtCodigoEmpresa.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoEmpresa.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(369, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 15);
            this.label7.TabIndex = 3;
            this.label7.Text = "Nome da empresa";
            // 
            // txtNomeEmpresa
            // 
            this.txtNomeEmpresa.Location = new System.Drawing.Point(485, 132);
            this.txtNomeEmpresa.Name = "txtNomeEmpresa";
            this.txtNomeEmpresa.Size = new System.Drawing.Size(100, 23);
            this.txtNomeEmpresa.TabIndex = 4;
            // 
            // txtCodigoPessoa
            // 
            this.txtCodigoPessoa.Location = new System.Drawing.Point(196, 83);
            this.txtCodigoPessoa.Name = "txtCodigoPessoa";
            this.txtCodigoPessoa.Size = new System.Drawing.Size(100, 23);
            this.txtCodigoPessoa.TabIndex = 1;
            // 
            // btnListaCadastro
            // 
            this.btnListaCadastro.Location = new System.Drawing.Point(85, 259);
            this.btnListaCadastro.Name = "btnListaCadastro";
            this.btnListaCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnListaCadastro.TabIndex = 5;
            this.btnListaCadastro.Text = "Listar";
            this.btnListaCadastro.UseVisualStyleBackColor = true;
            this.btnListaCadastro.Click += new System.EventHandler(this.btnListaCadastro_Click);
            // 
            // listCadEmpresas
            // 
            this.listCadEmpresas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNome,
            this.clmCodigo});
            this.listCadEmpresas.HideSelection = false;
            this.listCadEmpresas.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.listCadEmpresas.Location = new System.Drawing.Point(84, 288);
            this.listCadEmpresas.Name = "listCadEmpresas";
            this.listCadEmpresas.Size = new System.Drawing.Size(212, 97);
            this.listCadEmpresas.TabIndex = 6;
            this.listCadEmpresas.UseCompatibleStateImageBehavior = false;
            // 
            // clmNome
            // 
            this.clmNome.Text = "Nome";
            // 
            // clmCodigo
            // 
            this.clmCodigo.Text = "Codigo";
            // 
            // btnCadastro
            // 
            this.btnCadastro.Location = new System.Drawing.Point(84, 182);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.Size = new System.Drawing.Size(75, 23);
            this.btnCadastro.TabIndex = 7;
            this.btnCadastro.Text = "Cadastrar";
            this.btnCadastro.UseVisualStyleBackColor = true;
            this.btnCadastro.Click += new System.EventHandler(this.btnCadastro_Click);
            // 
            // listCadPessoas
            // 
            this.listCadPessoas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.clmNomePessoa,
            this.clmCodigoPessoa});
            this.listCadPessoas.HideSelection = false;
            this.listCadPessoas.Location = new System.Drawing.Point(369, 288);
            this.listCadPessoas.Name = "listCadPessoas";
            this.listCadPessoas.Size = new System.Drawing.Size(216, 97);
            this.listCadPessoas.TabIndex = 10;
            this.listCadPessoas.UseCompatibleStateImageBehavior = false;
            // 
            // clmNomePessoa
            // 
            this.clmNomePessoa.Text = "Nome";
            this.clmNomePessoa.Width = 100;
            // 
            // clmCodigoPessoa
            // 
            this.clmCodigoPessoa.Text = "Codigo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(685, 451);
            this.Controls.Add(this.listCadPessoas);
            this.Controls.Add(this.btnCadastro);
            this.Controls.Add(this.listCadEmpresas);
            this.Controls.Add(this.btnListaCadastro);
            this.Controls.Add(this.txtCodigoPessoa);
            this.Controls.Add(this.txtNomeEmpresa);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtCodigoEmpresa);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNomePessoa);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNomePessoa;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCodigoEmpresa;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtNomeEmpresa;
        private System.Windows.Forms.TextBox txtCodigoPessoa;
        private System.Windows.Forms.Button btnListaCadastro;
        private System.Windows.Forms.ListView listCadEmpresas;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.ColumnHeader clmNome;
        private System.Windows.Forms.ColumnHeader clmCodigo;
        private System.Windows.Forms.ListView listCadPessoas;
        private System.Windows.Forms.ColumnHeader clmNomePessoa;
        private System.Windows.Forms.ColumnHeader clmCodigoPessoa;
    }
}

