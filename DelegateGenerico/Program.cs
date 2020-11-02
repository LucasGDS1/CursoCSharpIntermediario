using System;
using System.Collections;
using System.Linq;

namespace ExDelegateGenerico
{
    class Program
    {
        //Delegate aponta para um método que recebe por parâmetro um Array genérico
        delegate void meuDelegateGenerico<T>(T[] arrayGenerico, T valorGenerico );
        delegate int[] retornaMeuDelegateGenerico<T>(T[] retornaArrayGenerico);
        static void Main(string[] args)
        {
            int valorInformado = 2;
            var meuArray = new int[] {1, 2, 3, 4};

            //Instância do delegate que recebe um método que tem o parâmetro T Array, conforme o delegate foi declarado
            //Chama o nome do método que tem o memso parâmetro do delegate
            var rodaAcao = new meuDelegateGenerico<int>(recebeDelegateArray);
            
            //Duplicando os valores de cada elemento do array;
            rodaAcao(meuArray, valorInformado);

            var retornaAcao = new retornaMeuDelegateGenerico<int>(retornaArray);
            retornaAcao(meuArray);
            
            foreach(var item in retornaArray(meuArray))
            {
                Console.WriteLine("Valores multiplicados do array: " + item);
            }

        }

        //Método genérico que recebe um Array e um valor qualquer;
        static void recebeDelegateArray(int[] array, int valor)
        {
            for(var i = 0; i < array.Count(); i++)
            {
                array[i] *= valor;
            }
        }

        //Método genérico que recebe um Array;
        static int[] retornaArray(int[] array)
        {
            //Correto seria o array ser Global, mas aqui foi apenas um exemplo
            return array;
        }
    }
}
