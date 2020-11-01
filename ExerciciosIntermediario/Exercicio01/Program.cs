using RepositorioGenerico.Exercicio01.Entities;
using RepositorioGenerico.Exercicio01.Repositorio;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace RepositorioGenerico
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Instância da Classe
            ValoresInteiros valoresInteiros = new ValoresInteiros();

            //Repositórios
            RepositorioGenerico<ValoresInteiros> repositorioInteiro = new RepositorioGenerico<ValoresInteiros>();

            //Lista para passar como parâmetros do método
            //genérico de retorno da quantidade de itens maiores que o mínimo informado.
            var listaQtdeValoresMaiores = new List<int>();

            Console.Write("Informe quantidade máxima de itens para inserir na lista de inteiros: ");
            int qtdeItemsMaximaListInt = int.Parse(Console.ReadLine());
            Console.Write("Informe o valor mínimo de parâmetro de comparação da lista de inteiros: ");
            int valorMinimoInt = int.Parse(Console.ReadLine());


            //Inicio do prenchimento automático da lista de inteiros
            for (var i = 1; i <= qtdeItemsMaximaListInt; i++)
            {
                valoresInteiros.InsereElemento(new Random().Next(qtdeItemsMaximaListInt));
            };
            repositorioInteiro.InserirNaLista(valoresInteiros);
            //Final do prenchimento automático da lista de inteiros


            foreach (var percorre in repositorioInteiro.GetListagem())
            {
                foreach (var item in percorre.valorInteiro)
                {
                    Console.WriteLine("\nValores da lista: " + item);
                    listaQtdeValoresMaiores.Add(item);
                }
            };
            Console.WriteLine($"\nQuantidade de valores maiores que {valorMinimoInt}: " + repositorioInteiro.RetornaQuantidade(listaQtdeValoresMaiores, valorMinimoInt));

        }
    }
}
