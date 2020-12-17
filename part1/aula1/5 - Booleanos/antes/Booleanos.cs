using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Booleanos : IAulaItem
    {
        public void Executar()
        {
            //bool possuiSaldo = 1;

            bool possuiSaldo = true;


            Console.WriteLine($"possuiSaldo: {possuiSaldo}");

            int dias = DateTime.Now.Day;
            Console.WriteLine($"dias: {dias}");

            //Atribui o diasPar o valor de uma expressão booleana.
            bool diasPar = (dias % 2 == 0); //Pega o resto da divisão de dias / 2 e faz a verificação se é par ou impar

            if (diasPar == true)
            {
                Console.WriteLine("dias é um número par");
            }
            else
            {
                Console.WriteLine("dias é um número impar");
            }



        }
    }
}
