﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Delegates : IAulaItem
    {
        public void Executar()
        {
            Calculadora.Executar();
        }
    }

    delegate double MetodoMultiplicacao(double input);

    class Calculadora
    {
        static double Duplicar(double input)
        {
            return input * 2;
        }

        static double Triplicar(double input)
        {
            return input * 3;
        }

        public static void Executar()
        {

            //Executa diretamente o método
            Console.WriteLine($"Duplicar(7.5): {Duplicar(7.5)}");

            //Executa diretamente o método
            Console.WriteLine($"Triplicar(7.5): {Triplicar(7.5)}");

            MetodoMultiplicacao metodoMultiplicacao = Duplicar;
            Console.WriteLine(metodoMultiplicacao(7.5));

            metodoMultiplicacao = Triplicar;
            Console.WriteLine($"Triplicar(7.5): {metodoMultiplicacao(7.5)}");

            //instacia um delegate com um método anônimo
            MetodoMultiplicacao metodoQuadrado = delegate (double input)
            {
                return input * input;
            };

            double quadrado = metodoQuadrado(5);
            System.Console.WriteLine("quadrado: {0}", quadrado);

            //instacia um delegado com um expressão lambda
            MetodoMultiplicacao metodoCubo = input => input * input * input;

            double cubo = metodoCubo(4.375);
            System.Console.WriteLine("cubo: {0}", cubo);
        }
    }
}
