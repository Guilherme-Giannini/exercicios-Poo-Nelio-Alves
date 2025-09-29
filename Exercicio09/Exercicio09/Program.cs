// Laço for each 
// isso é apenas uma revisão!

using System.Runtime.Serialization.Formatters;

namespace Exercicio09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] vect = new string[] { "maria", "Alex", "Bob" };
            for (int i = 0; i < vect.Length; i++)
            {
                Console.WriteLine(vect[i]);
            }

            Console.WriteLine( "´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´´");

            foreach (string obj in vect)
            {
                Console.WriteLine(obj);
            }
        }
    }
}
