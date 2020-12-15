using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class Objetos : IAulaItem
    {
        public void Executar()
        {
           int pontuacao = 10;
           Console.WriteLine($"pontuacao: {pontuacao}");

           System.Console.WriteLine("OBJECT COM VALOR PRIMITIVO");
           object meuObjeto;
           meuObjeto = pontuacao;
           System.Console.WriteLine($"meuObjeto: {meuObjeto}");
           System.Console.WriteLine($"meuObjeto.GetType(): {meuObjeto.GetType()}");

           System.Console.WriteLine();
           System.Console.WriteLine("OBJECT COM REFERÊNCIA DE OBJETO");

           meuObjeto = new Jogador();
           Jogador classRef;
           classRef = (Jogador)meuObjeto; //conversão explícita ou "cast"
           System.Console.WriteLine($"classRef.Pontuacao: {classRef.Pontuacao}");

        }
    }

    class Jogador
    {
        public int Pontuacao { get; set; } = 10;
    }
}
