//Operador de coalescência nula

namespace Exercicio02;
class Program
{
    static void Main(string[] args)
    {
        double? x = null;
        double? y = 10;

        double a = x ?? 5; // se x for null, a recebe 5
        double b = y ?? 5; // se y for null, b recebe 5

        Console.WriteLine(a); // 5
        Console.WriteLine(b); // 10
    }
}


