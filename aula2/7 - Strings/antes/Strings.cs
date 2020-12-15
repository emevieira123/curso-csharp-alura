using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Strings : IAulaItem
    {
        public void Executar()
        {
            string a = "bom dia";
            string b = "b";

            //Adiciona ao conteúdo de "b"
            b = b + "om dia";
            System.Console.WriteLine($"a == b: {a == b}");
            System.Console.WriteLine($"(object)a == (object)b: {(object)a == (object)b}");

            string bomDia = "bom dia";
            System.Console.WriteLine($"bomDia[4]: {bomDia[4]}");

            var caractere = bomDia[4];
            System.Console.WriteLine($"caractere.GetType(): {caractere.GetType()}");
        }
    }
}
