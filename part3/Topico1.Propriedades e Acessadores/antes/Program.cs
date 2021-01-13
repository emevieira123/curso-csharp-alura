using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topico1
{
    class Program
    {
        static void Main(string[] args)
        {
            Funcionario funcionario = Funcionario();
            // funcionario.salario = 1000;
            // System.Console.WriteLine(funcionario.salario);

            // funcionario.salario = -1200;
            // System.Console.WriteLine(funcionario.salario);

            //funcionario.Salario = -1200;
            funcionario.Salario = 1200;
            System.Console.WriteLine(funcionario.Salario);
        }
    }

    class Funcionario
    {
        decimal salario;

        public decimal Salario
        {
            get 
            {
                return salario;
            }
            set 
            {
                if(value < 0)
                {
                    throw new ArgumentOutOfRangeException("salário não pode ser negativo.")
                }
                salario = value;
            }
        }
    }
}
