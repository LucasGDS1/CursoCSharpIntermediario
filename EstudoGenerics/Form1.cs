using EstudoGenerics.Entities;
using EstudoGenerics.Repositorio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EstudoGenerics
{
    public partial class Form1 : Form
    {
        RepositorioEmpresa repositorioEmpresa = new RepositorioEmpresa();
        RepositorioPessoa repositorioPessoa = new RepositorioPessoa();


        public Form1()
        {
            InitializeComponent();
        }

        public void Cadastros()
        {
            Empresa empresa = new Empresa
            {
                Nome = txtNomeEmpresa.Text != null ? txtNomeEmpresa.Text : null
            };

            if (txtCodigoEmpresa.Text != "")
            {
                empresa.Id = Convert.ToInt32(txtCodigoEmpresa.Text);
            };

            Pessoa pessoa = new Pessoa
            {
                Nome = txtNomePessoa.Text != null ? txtNomePessoa.Text : null
            };

            if (txtCodigoPessoa.Text != "")
            {
                pessoa.Id = Convert.ToInt32(txtCodigoPessoa.Text);
            };

            repositorioEmpresa.Insert(empresa);
            repositorioPessoa.Insert(pessoa);

        }

        public void ListarCadastros()
        {
            //Limpa a listagem anterior;
            listCadEmpresas.Items.Clear(); 
            foreach (var emp in repositorioEmpresa.Get())
            {
                //var row = 
                var lvi = new ListViewItem(new string[] { emp.Nome, emp.Id.ToString()});
                listCadEmpresas.Items.Add(lvi);
            };

            listCadPessoas.Items.Clear();
            foreach (var pessoa in repositorioPessoa.Get())
            {
                var row = new string[] { pessoa.Nome, pessoa.Id.ToString(), };
                var lvi = new ListViewItem(row);
                listCadPessoas.Items.Add(lvi);
            };
        }

        private void btnListaCadastro_Click(object sender, EventArgs e)
        {
            //Adiciona na lista o retorno do Get() da Classe especifica;
            ListarCadastros();

            //View recebe os detalhes para visualização como: Nome das colunas;
            listCadEmpresas.View = View.Details;
            listCadPessoas.View = View.Details;

            //Resize das colunas da ListView de acordo com os itens retornados do Get da Classe;
            listCadEmpresas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            listCadEmpresas.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            Cadastros();
        }
    }
}
