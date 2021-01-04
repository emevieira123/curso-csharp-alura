using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class MetodosAuxiliares : IAulaItem
    {
        public void Executar()
        {
            string textoDigitado = "123";
            // int numeroConvertido = textoDigitado;

            int numeroConvertido = int.Parse(textoDigitado);
            System.Console.WriteLine(numeroConvertido);

            textoDigitado = "abc";
            // numeroConvertido = int.Parse(textoDigitado);
            int.TryParse(textoDigitado, out numeroConvertido); // out torna a variavel em um parametro de retorno

            if( int.TryParse(textoDigitado, out numeroConvertido))
            {
                System.Console.WriteLine(numeroConvertido);
            }
            else
            {
                System.Console.WriteLine("A informação digitada não é um número");
            }

            textoDigitado = "123,45";
            decimal.TryParse(textoDigitado, 
            System.Globalization.NumberStyles.Currency, //moeda
            System.Globalization.CultureInfo.CurrentCulture, //pt-BR
            out decimal valorConvertido);
            System.Console.WriteLine(valorConvertido);
        }
    }
}
