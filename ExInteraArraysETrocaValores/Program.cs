using ExInteraArraysETrocaValores.Entities;
using System;
using System.Linq;

namespace ExInteraArraysETrocaValores
{
    class Program
    {
        static void Main(string[] args)
        {
            var meuPar = new Par<int, string>[]
            {
                new Par<int, string>(1,"b"),
                new Par<int, string>(3,"b"),
                new Par<int, string>(5,"a")
            };
            
            InteraArrays(meuPar);

            var novoObjeto = new Par<int, int>(15, 30);
            
            TrocaValores(novoObjeto);
            Console.WriteLine(novoObjeto);
        }
        
        //Se o método for genérico os Tipos dos parâmetros também devem ser genéricos
        private static void InteraArrays<T, U>(Par<T, U>[] array)
        {
            foreach (var item in array)
            {
                Console.WriteLine(item);
            }
        }

        private static void TrocaValores<T>(Par<T,T> array)
        {
            T aux;
            aux = array.Var1;
            array.Var1 = array.Var2;
            array.Var2 = aux;
        }
    }
}
