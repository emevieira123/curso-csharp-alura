using System;
using System.IO;
using System.Text;
using System.Collections.Generic;
using System.Xml.Linq;
using System.Xml;

namespace _02._1.string_builder
{
    class Program
    {
        static void Main(string[] args)
        {
            string materias = string.Empty;
            materias += "Português";
            Console.WriteLine(materias);
            materias += ", Matemática";
            Console.WriteLine(materias);
            materias += ", Geografia";
            Console.WriteLine(materias);

            Console.ReadKey();

            //<i mage url="$(ProjectDir)/img1.png"/>
        }
    }
}
