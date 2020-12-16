using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class MetodosDeExtensao : IAulaItem
    {
        public void Executar()
        {
            Impressora impressora = new Impressora("Este é\r\no meu documento");
            impressora.ImprimirDocumento();
            ImprimirDocumentoHTML(impressora.Documento);
            impressora.ImprimirDocumentoHTML();
        }
        void ImprimirDocumentoHTML(string documento)
        {
            System.Console.WriteLine($"<html><body>{documento}</body></html>");
        }

    }

    class Impressora
    {
        public string Documento { get; }

        public Impressora(string documento)
        {
            this.Documento = documento;
        }

        public void ImprimirDocumento()
        {
            Console.WriteLine();
            Console.WriteLine(Documento);
        }

        // public void ImprimirDocumentoHTML()
        // {
        //     System.Console.WriteLine($"<html><body>{Documento}</body></html>");
        // }
    }
    
   static class ImpressoraExtensions
    {
        public static void ImprimirDocumentoHTML(this Impressora impressora)
        {
            System.Console.WriteLine($"<html><body>{impressora.Documento}</body></html>");
        }
    }
}


