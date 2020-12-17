﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Sobrecargas : IAulaItem
    {
        public void Executar()
        {
            //VOLUME DO CUBO = lado ^ 3;
            int lado = 3;
            System.Console.WriteLine("VolumeDoCubo: " + Volume(lado));

            //VOLUME DO CILINDRO = altura * PI * raio ^ 2;
            double raio = 2;
            int altura = 10;
            System.Console.WriteLine("VolumeDoCilindro: " + Volume(altura, raio));

            //VOLUME DO PRISMA = largura * profundidade * altura
            long largura = 10;
            altura = 6;
            int profundidade = 4;
            System.Console.WriteLine("VolumeDoPrisma: " + Volume(largura, profundidade, altura));
        }

        double Volume(double lado)
        {
            return Math.Pow(lado, 3);
        }

        double Volume(double altura, double raio)
        {
            return altura * Math.PI * Math.Pow(raio, 2);
        }

        double Volume(double largura, double profundidade, double altura)
        {
            return largura * profundidade * altura;
        }
    }
}
