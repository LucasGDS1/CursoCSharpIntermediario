using RepositorioGenerico.Exercicio01.Entities;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace RepositorioGenerico.Exercicio01.Repositorio
{
    public class RepositorioGenerico<T>
    {
        private List<T> list;
        
        public RepositorioGenerico()
        {
            list = new List<T>();
        }

        public void InserirNaLista(T meuObjeto)
        {
            list.Add(meuObjeto);
        }

        public List<T> GetListagem()
        {
            return list;
        }

        public int RetornaQuantidade<T>(List<T> listagem, T valorMinimo)
        {
            int quantiadeMaior = 0;

            foreach (var valoresDaListagem in listagem)
            {
                //Se faz necessário a conversão, mudança e casting da variável para comparar T com T;
                double valorDaListagem = (double)Convert.ChangeType(valoresDaListagem, typeof(double));
                double valorMinimoInformado = (double)Convert.ChangeType(valorMinimo, typeof(double));

                if (valorDaListagem > valorMinimoInformado)
                {
                    quantiadeMaior++;
                }
            }
            return quantiadeMaior;
        }

    }
}
