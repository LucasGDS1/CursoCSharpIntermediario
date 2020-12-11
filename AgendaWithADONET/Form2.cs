using AgendaWithADONET.DAO;
using AgendaWithADONET.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AgendaWithADONET
{
    public partial class Form2 : Form
    {
        private Contato contato;
        public Form2(Contato contato = null)
        {
            this.contato = contato;
            InitializeComponent();
        }
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            //Sistema verifica se tem valores no classe Contato, se tiver retorna,se não aparece os campos em branco
            if(this.contato != null)
            {
                txtNome.Text = contato.nome;
                txtEmail.Text = contato.email;
                txtTelefone.Text = contato.telefone;
            } else
            {
                txtNome.Text = string.Empty;
                txtEmail.Text = string.Empty;
                txtTelefone.Text = string.Empty;
            }
        }

        //Clicando em cancelar, o modal será fechado
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            ContatosDAO contatos = new ContatosDAO();
            if (this.contato == null)
            {
                Contato contato = new Contato()
                {
                    nome = txtNome.Text,
                    email = txtEmail.Text,
                    telefone = txtTelefone.Text
                };

                contatos.Inserir(contato);
            } else
            {
                this.contato.nome = txtNome.Text;
                this.contato.email = txtEmail.Text;
                this.contato.telefone = txtTelefone.Text;

                contatos.Editar(this.contato);
            }
            this.Close();
        }
    }
}
