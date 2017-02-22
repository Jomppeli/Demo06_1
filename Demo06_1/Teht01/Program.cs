using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teht01
{
    class Program
    {
        static void Main(string[] args)
        {
            string teksti = "teksti";
            System.IO.StreamWriter outputFile = new System.IO.StreamWriter("test.txt");
            while (teksti != " ")
            {
                Console.WriteLine("Write something (spacebar ends writing)");
                teksti = Console.ReadLine();
                outputFile.WriteLine(teksti);
                
            }
            outputFile.Close();

            string text = System.IO.File.ReadAllText("test.txt");
            Console.WriteLine("Contents of test.txt:\n" + text);
        }
    }
}
