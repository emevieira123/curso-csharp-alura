using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class ConversoesExplicitas : IAulaItem
    {
        public void Executar()
        {
            double divida = 1_234_567_890.123;
            //long copia = divida;

            double salario = 1_237.89;
            long copiaSalario = (long)salario;
            System.Console.WriteLine(copiaSalario);

            Animal animal = new Gato();
            Gato gato = (Gato)animal; //Cast = conversão explícita
            System.Console.WriteLine(gato.GetType());
        }
    }
}
