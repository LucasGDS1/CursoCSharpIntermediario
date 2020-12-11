using System;
using System.Collections.Generic;
using System.Text;

namespace AgendaWithADONET.Entity
{
    public class Contato
    {
        public int id { get; set; }
        public string nome { get; set; }
        public string email { get; set; }
        public string telefone { get; set; }

        public Contato() { }
    }
}
