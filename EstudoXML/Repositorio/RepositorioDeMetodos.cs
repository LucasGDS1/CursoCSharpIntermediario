using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace EstudoXML.Repositorio
{
    public class RepositorioDeMetodos
    {
        public string CarregarTituloAgenda()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");
            XmlNode noTitulo = documentoXml.SelectSingleNode("/agenda/titulo");
            return noTitulo.InnerText;
        }

        public List<string> CarregarListaEmpresa()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");
            XmlNodeList noLista = documentoXml.SelectNodes("/agenda/contatos/empresas/empresa");

            var minhaLista = new List<string>();

            foreach (XmlNode item in noLista)
            {
                string id = item.Attributes["id"].Value;
                string nome = item.Attributes["name"].Value;
                string dataDeAbertura = item.Attributes["dataAbertura"].Value;

                minhaLista.Add((id,nome, dataDeAbertura).ToString());
            }
            return minhaLista;
        }

        public List<string> CarregarListaPessoa()
        {
            XmlDocument documentoXml = new XmlDocument();
            documentoXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");
            XmlNodeList noLista = documentoXml.SelectNodes("/agenda/contatos/pessoas/pessoa");

            var minhaLista = new List<string>();

            foreach (XmlNode item in noLista)
            {
                string id = item.Attributes["id"].Value;
                string nome = item.Attributes["name"].Value;
                string idade = item.Attributes["idade"].Value;

                minhaLista.Add((id, nome, idade).ToString());
            }
            return minhaLista;
        }

        public void CadastrarContatoPessoa(string idInfo, string nomeInfo, string idadeInfo)
        {
            XmlDocument documentXml = new XmlDocument();
            documentXml.Load(@"C:\Users\loja\Source\Repos\LucasGDS1\CursoCSharpIntermediario\EstudoXML\Agenda.xml");


            XmlAttribute id = documentXml.CreateAttribute("id");
            id.Value = idInfo;
            XmlAttribute name = documentXml.CreateAttribute("name");
            name.Value = nomeInfo;
            XmlAttribute idade = documentXml.CreateAttribute("idade");
            idade.Value = idadeInfo;

            if (Existe(id.Value))
            {
                MessageBox.Show($"O {name.Value} já existe na lista de contatos, por favor informe dados diferentes!");
            }
            else
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

        public string ToString(string value1, string value2, string value3)
        {
            return value1 + ", " + value2 + ", " + value3;
        }
    }
}
