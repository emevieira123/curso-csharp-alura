using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class UsandoDynamic : IAulaItem
    {
        public void Executar()
        {
            
            string s = "Certificação C#"; // O tipo é definido na compilação
            var v = "Certificação C#";    // O tipo é definido na compilação (por inferência)
            object o = "Certificação C#"; // O tipo é definido na compilação
            dynamic d = "Certificação C#";

            System.Console.WriteLine(s);
            System.Console.WriteLine(v);
            System.Console.WriteLine(o);

            s = s.ToUpper();
            v = v.ToUpper();
            o = ((string)o).ToUpper();

            System.Console.WriteLine(s);
            System.Console.WriteLine(v);
            System.Console.WriteLine(o);

            // s = 123;
            // v = 123;
            o = 123;

            o = (int)o + 4;

            System.Console.WriteLine(o);

            System.Console.WriteLine(d);

            d = d.ToUpper();
            System.Console.WriteLine(d);

            d = 123;
            System.Console.WriteLine(d);

            d = d + 4;
            System.Console.WriteLine(d);
        }
    }
}
