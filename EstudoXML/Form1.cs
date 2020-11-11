using EstudoXML.Repositorio;
using System;
using System.Windows.Forms;

namespace EstudoXML
{
    public partial class Form1 : Form
    {
        private RepositorioDeMetodos repositorioDeMetodos;
        public Form1()
        {
            InitializeComponent();
            repositorioDeMetodos = new RepositorioDeMetodos();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblTitulo.Text = repositorioDeMetodos.CarregarTituloAgenda();
            ChamaListas();
            ChamaCadastro();
        }

        private void ChamaListas()
        {
            foreach(var item in repositorioDeMetodos.CarregarListaEmpresa())
            {
                lbxEmpresas.Items.Add(item.ToString());
            }

            foreach (var item in repositorioDeMetodos.CarregarListaPessoa())
            {
                lbxPessoas.Items.Add(item);
            }
        }

        private void ChamaCadastro()
        {
            //Dados estáticos como exemplo de preenchimento
            string id = "4";
            string nome = "Lucas Gabriel";
            string idade = "22";

            repositorioDeMetodos.CadastrarContatoPessoa(id,nome,idade);
        }
    }
}
