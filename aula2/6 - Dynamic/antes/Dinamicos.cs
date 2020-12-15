using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Dinamicos : IAulaItem
    {
        public void Executar()
        {
            object objeto = 1;
            // objeto = objeto + 3;

            dynamic dinamico = 1;
            dinamico = dinamico + 3;
            System.Console.WriteLine(dinamico);

            // dinamico.teste();
        }
    }
}
