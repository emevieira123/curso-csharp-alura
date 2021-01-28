using System;
using System.Diagnostics;

namespace _01._3.Finalizador_antes
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 1000000; i++)
            {
                Livro livro = new Livro();
            }

            GC.Collect();

            Console.ReadKey();
        }
    }

    class Livro
    {
        static int UltimoId = 0;
        public string Introducao { get; set; }
        public string Texto { get; set; }
        public string Conclusao { get; set; }
        public int Id { get; }

        public Livro()
        {
            UltimoId++;
            Id = UltimoId;
            //Trace.WriteLine("Livro " + Id + " está sendo criado");
        }
        // ˜Livro()
        // {
        //     //Liberar somente os recursos não-gerenciados

        //     Trace.WriteLine("Livro" + Id + " está sendo finalizado");
        // }
    }
}
