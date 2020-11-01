using System;
using System.Collections.Generic;
using System.Text;

namespace RepositorioGenerico.Exercicio01.Entities
{
    public class ValoresInteiros
    {
        public List<int> valorInteiro { get; set; }

        public ValoresInteiros()
        {
            valorInteiro = new List<int>();
        }

        public void InsereElemento(int value)
        {
            valorInteiro.Add(value);
        }
    }
}
