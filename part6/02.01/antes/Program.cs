using System;

namespace _02._01
{
    class Program
    {
        static void Main(string[] args)
        {
            string alura = "Alura";
            string caelum = "Caelum";
            string casaDoCodigo = "Casa do Código";

            System.Console.WriteLine(alura);
            System.Console.WriteLine(caelum);
            System.Console.WriteLine(casaDoCodigo);

            //MATRIZ = ARRAY

            // string[] empresas = new string[3];
            // empresas[0] = alura;
            // empresas[1] = caelum;
            // empresas[2] = casaDoCodigo;

            // string[] empresas = new string[]
            // {
            //     alura, caelum, casaDoCodigo
            // };

            string[] empresas = {alura, caelum, casaDoCodigo};
            
            Imprimir(empresas);
            //altera a variável não afeta o valor do elemento do array!
            caelum = "Caelum Ensino e Inovação";

            Imprimir(empresas);
            //mudando valor de um elemento do array
            empresas[1] = "Caelum Ensino e Inovação";

            Imprimir(empresas);

            System.Console.WriteLine("Primeiro elemento: " + empresas[0]);
            System.Console.WriteLine("Último elemento: " + empresas[empresas.Length - 1]);

            //Localizando índice da primeira ocorrência no array
            System.Console.WriteLine("O índice de Casa do Código é: " + Array.IndexOf(empresas, "Casa do Código"));

            //Localizando índice da ultima ocorrência no 
            System.Console.WriteLine("O último índice de Casa do Código é: " + Array.LastIndexOf(empresas, "Casa do Código"));

            //Revertendo a sequencia do array
            Array.Reverse(empresas);
            Imprimir(empresas);

            //Revertendonovamento a sequencia do array
            Array.Reverse(empresas);
            Imprimir(empresas);

            //Redimensionando um array (truncando a última posição)
            Array.Resize(ref empresas, 2);
            Imprimir(empresas);

            //Redimensionando um array (deixando a última posição vazia)
            Array.Resize(ref empresas, 3);
            Imprimir(empresas);

            empresas[empresas.Length - 1] = "Casa do Código";

            //Ordenando o Array pela ordem natural dos elementos (alfabéticos)
            Array.Sort(empresas);
            Imprimir(empresas);

            //Copiando um array em outro
            string[] copia = new string[2];
            Array.Copy(empresas, 1, copia, 0, 2);
            Imprimir(copia);

            //Clonando um Array em um novo Array
            string[] clone = empresas.Clone() as string[];
            Imprimir(clone);

            //Limpando alguns índices do Array
            Array.Clear(clone, 1, clone.Length - 1);
            Imprimir(clone);
        }

        private static void Imprimir(string[] empresas)
        {
            // for (int i = 0; i < empresas.Length; i++)
            // {
            //     string empresa = empresas[i];
            //     System.Console.WriteLine(empresa);
            // }

            foreach (var empresa in empresas)
            {
                System.Console.WriteLine(empresa);
            }

            System.Console.WriteLine();
        }
    }
}
