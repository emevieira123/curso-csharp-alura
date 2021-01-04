using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class OperadoresISeAS : IAulaItem
    {
        public void Executar()
        {
            Animal animal = new Animal();
            Gato gato = new Gato();
            //Cliente cliente = new Cliente("José da Silva", 30);

            Alimentar(animal);
            Alimentar(gato);
            //Alimentar(cliente);
            

        }

        public void Alimentar(object obj)
        {
            // Operador IS retorna um booleano
            // Ja o Operador AS garante uma conversão mais segura
            
            // Animal animal = obj as Animal;

            if (obj is Animal animal)
            {
                animal.Beber();
                animal.Comer();
                return;
            }            
            System.Console.WriteLine("obg não é um animal");
        }

    }

}
