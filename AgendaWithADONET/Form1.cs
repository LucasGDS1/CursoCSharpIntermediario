using AgendaWithADONET.DAO;
using AgendaWithADONET.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AgendaWithADONET
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CarregarAgenda();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            int id = (int)dgvContatos.CurrentRow.Cells[0].Value;
            ContatosDAO contatos = new ContatosDAO();
            contatos.Excluir(id);
            MessageBox.Show("Item excluir com sucesso");
            CarregarAgenda();
        }

        private void CarregarAgenda()
        {
            ContatosDAO contatos = new ContatosDAO();
            DataSet data = contatos.GetContatos();
            dgvContatos.DataSource = data.Tables["Contatos"];
            dgvContatos.Refresh();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.ShowDialog();
            CarregarAgenda();
        }



        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contato contato = new Contato()
            {
                id = (int)dgvContatos.CurrentRow.Cells[0].Value,
                nome = dgvContatos.CurrentRow.Cells[1].Value.ToString(),
                email = dgvContatos.CurrentRow.Cells[2].Value.ToString(),
                telefone = dgvContatos.CurrentRow.Cells[3].Value.ToString()

            };
            Form2 form = new Form2(contato);
            form.ShowDialog();
            CarregarAgenda();
        }
    }
}
