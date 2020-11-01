using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoGenerics.Repositorio
{
    public class RepositorioPessoa
    {
        private List<Pessoa> pessoas;

        public RepositorioPessoa()
        {
            pessoas = new List<Pessoa>();
        }

        public List<Pessoa> Get()
        {
            return pessoas;
        }

        public void Insert(Pessoa pessoa)
        {
            pessoas.Add(pessoa);
        }
    }
}
