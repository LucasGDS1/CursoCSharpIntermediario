using EstudoGenerics.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace EstudoGenerics.Repositorio
{
    public class RepositorioEmpresa
    {
        private List<Empresa> empresas;
        public RepositorioEmpresa()
        {
            empresas = new List<Empresa>();
        }

        public List<Empresa> Get()
        {
            return empresas;
        }

        public void Insert(Empresa empresa)
        {
            empresas.Add(empresa);
        }
    }
}
