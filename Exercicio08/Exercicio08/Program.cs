// Boxing
// é o processo de converter um tipo de valor em um tipo de referência do tipo compatível.
// Unboxing
// é o processo de converter um tipo de referência do tipo compatível de volta para um tipo de valor.
class Program
{
    static void Main(string[] args)
    {
        int numero = 123; // Tipo de valor
        object obj = numero; // Boxing: conversão de tipo de valor para tipo de referência
        int numeroDesempacotado = (int)obj; // Unboxing: conversão de tipo de referência de volta para tipo de valor
        Console.WriteLine($"Número original: {numero}");
        Console.WriteLine($"Objeto após boxing: {obj}");
        Console.WriteLine($"Número após unboxing: {numeroDesempacotado}");
    }
}