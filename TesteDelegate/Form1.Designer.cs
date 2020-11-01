namespace TesteDelegate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrimeiroValor = new System.Windows.Forms.TextBox();
            this.txtSegundoValor = new System.Windows.Forms.TextBox();
            this.btnAdicao = new System.Windows.Forms.Button();
            this.btnSubtracao = new System.Windows.Forms.Button();
            this.btnDivisao = new System.Windows.Forms.Button();
            this.btnMultiplicacao = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Valor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valor";
            // 
            // txtPrimeiroValor
            // 
            this.txtPrimeiroValor.Location = new System.Drawing.Point(98, 70);
            this.txtPrimeiroValor.Name = "txtPrimeiroValor";
            this.txtPrimeiroValor.Size = new System.Drawing.Size(208, 23);
            this.txtPrimeiroValor.TabIndex = 2;
            // 
            // txtSegundoValor
            // 
            this.txtSegundoValor.Location = new System.Drawing.Point(98, 116);
            this.txtSegundoValor.Name = "txtSegundoValor";
            this.txtSegundoValor.Size = new System.Drawing.Size(208, 23);
            this.txtSegundoValor.TabIndex = 2;
            // 
            // btnAdicao
            // 
            this.btnAdicao.Location = new System.Drawing.Point(312, 70);
            this.btnAdicao.Name = "btnAdicao";
            this.btnAdicao.Size = new System.Drawing.Size(89, 23);
            this.btnAdicao.TabIndex = 3;
            this.btnAdicao.Text = "Adição";
            this.btnAdicao.UseVisualStyleBackColor = true;
            this.btnAdicao.Click += new System.EventHandler(this.btnAdicao_Click);
            // 
            // btnSubtracao
            // 
            this.btnSubtracao.Location = new System.Drawing.Point(407, 69);
            this.btnSubtracao.Name = "btnSubtracao";
            this.btnSubtracao.Size = new System.Drawing.Size(87, 23);
            this.btnSubtracao.TabIndex = 3;
            this.btnSubtracao.Text = "Subtração";
            this.btnSubtracao.UseVisualStyleBackColor = true;
            this.btnSubtracao.Click += new System.EventHandler(this.btnSubtracao_Click);
            // 
            // btnDivisao
            // 
            this.btnDivisao.Location = new System.Drawing.Point(312, 115);
            this.btnDivisao.Name = "btnDivisao";
            this.btnDivisao.Size = new System.Drawing.Size(89, 23);
            this.btnDivisao.TabIndex = 3;
            this.btnDivisao.Text = "Divisão";
            this.btnDivisao.UseVisualStyleBackColor = true;
            this.btnDivisao.Click += new System.EventHandler(this.btnDivisao_Click);
            // 
            // btnMultiplicacao
            // 
            this.btnMultiplicacao.Location = new System.Drawing.Point(407, 115);
            this.btnMultiplicacao.Name = "btnMultiplicacao";
            this.btnMultiplicacao.Size = new System.Drawing.Size(87, 23);
            this.btnMultiplicacao.TabIndex = 3;
            this.btnMultiplicacao.Text = "Multiplicação";
            this.btnMultiplicacao.UseVisualStyleBackColor = true;
            this.btnMultiplicacao.Click += new System.EventHandler(this.btnMultiplicacao_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 15);
            this.label3.TabIndex = 1;
            this.label3.Text = "Resultado:";
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(98, 170);
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(208, 23);
            this.txtResultado.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 39);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 15);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operações";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtResultado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnMultiplicacao);
            this.Controls.Add(this.btnDivisao);
            this.Controls.Add(this.btnSubtracao);
            this.Controls.Add(this.btnAdicao);
            this.Controls.Add(this.txtSegundoValor);
            this.Controls.Add(this.txtPrimeiroValor);
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
        private System.Windows.Forms.TextBox txtPrimeiroValor;
        private System.Windows.Forms.TextBox txtSegundoValor;
        private System.Windows.Forms.Button btnAdicao;
        private System.Windows.Forms.Button btnSubtracao;
        private System.Windows.Forms.Button btnDivisao;
        private System.Windows.Forms.Button btnMultiplicacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label label4;
    }
}

