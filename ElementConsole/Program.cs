using ElementGenerator;
using System;

namespace ElementConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new ElementFactory();

            Console.WriteLine(factory.CreateElement("hs/top","Welcome!"));
            Console.WriteLine(factory.CreateElement("ps/main", "This is the main section."));
            Console.WriteLine(factory.CreateElement("ps/sub", "This is a sub-section."));
        }
    }
}
