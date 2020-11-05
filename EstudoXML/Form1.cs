using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;

namespace EstudoXML
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CriaNovosElementos();
            lblTitulo.Text = CarregarTituloAgenda();
            CarregarListaEmpresa();
            CarregarListaPessoa();
        }

        private string CarregarTituloAgenda()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");
            XmlNode noTitulo = documentoXml.SelectSingleNode("/agenda/titulo");
            return noTitulo.InnerText;
        }

        private void CarregarListaEmpresa()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");
            XmlNodeList noLista = documentoXml.SelectNodes("/agenda/contatos/empresas/empresa");
            foreach (XmlNode item in noLista)
            {
                string id = item.Attributes["id"].Value;
                string nome = item.Attributes["name"].Value;
                string dataDeAbertura = item.Attributes["dataAbertura"].Value;
                lbxEmpresas.Items.Add(ToString(id, nome, dataDeAbertura));
            }
        }

        private void CarregarListaPessoa()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");
            XmlNodeList noLista = documentoXml.SelectNodes("/agenda/contatos/pessoas/pessoa");
            foreach (XmlNode item in noLista)
            {
                string id = item.Attributes["id"].Value;
                string nome = item.Attributes["name"].Value;
                string idade = item.Attributes["idade"].Value;
                lbxPessoas.Items.Add(ToString(id, nome, idade));
            }
        }

        private void CriaNovosElementos()
        {
            XmlDocument documentXml = new XmlDocument();
            documentXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");


            XmlAttribute id = documentXml.CreateAttribute("id");
            id.Value = "4";
            XmlAttribute name = documentXml.CreateAttribute("name");
            name.Value = "Lucas Gabriel";
            XmlAttribute idade = documentXml.CreateAttribute("idade");
            idade.Value = "22";

            if (Existe(id.Value))
            {
                MessageBox.Show($"O {name.Value} já existe na lista de contatos, por favor informe dados diferentes!");
            } else
            {
                XmlNode pessoa = documentXml.CreateElement("pessoa");//Create element é a tag do XML
                pessoa.Attributes.Append(id);
                pessoa.Attributes.Append(name);
                pessoa.Attributes.Append(idade);

                XmlNode pessoas = documentXml.SelectSingleNode("/agenda/contatos/pessoas");//Leitura do Nó onde serão adicionados os nós filhos
                pessoas.AppendChild(pessoa);

                documentXml.Save(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");
            }


        }

        private bool Existe(string id)
        {
            var existe = false;

            XmlDocument documentXml = new XmlDocument();
            documentXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");

            XmlNodeList listaContatos = documentXml.SelectNodes("/agenda/contatos/pessoas/pessoa");

            foreach (XmlNode item in listaContatos)
            {
                if (id.Equals(item.Attributes["id"].Value))
                {
                    existe = true;
                }
                else
                {
                    existe = false;
                }
            }
            return existe;
        }
        private string ToString(string value1, string value2, string value3)
        {
            return value1 + ", " + value2 + ", " + value3;
        }
    }
}
