using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ConversoesDeDynamic : IAulaItem
    {
        public void Executar()
        {
            dynamic d1 = 7;
            dynamic d2 = "String Qualquer";
            dynamic d3 = DateTime.Now;
            dynamic d4 = new List<int>() { 123, 456, 789};

            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
            System.Console.WriteLine(d3);
            System.Console.WriteLine(d4);

            int i = d1;
            string str = d2;
            DateTime dt = d3;
            List<int> lista = d4;

            System.Console.WriteLine(d1);
            System.Console.WriteLine(d2);
            System.Console.WriteLine(d3);
            System.Console.WriteLine(d4);

        }
    }
}
