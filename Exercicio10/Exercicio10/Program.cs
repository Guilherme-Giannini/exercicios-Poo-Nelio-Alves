//Listas 
//estrutura homogenea, ordenada, inicia vazia e seus elementos são alocados sob demanda, cada elemento ocupa umn "nó" ou nodo da lista ---> aponta para o próximo
// pertence a System.Collections.Generic
// List<T> onde T é o tipo dos elementos da lista
using System;
using System.Collections.Generic;

namespace Exercicio10;

class Program
{
    static void Main(string[] args)
    {
        List<string> list = new List<string>();

        list.Add("Maria");
        list.Add("Alex");
        list.Add("Bob");
        list.Add("Anna");
        list.Insert(2, "Marco");

        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }


        Console.WriteLine("list count " + list.Count);

        string s1 = list.Find(list => list[0] == 'A');

        Console.WriteLine("First 'A': " + s1);

        string s2 = list.FindLast(list => list[0] == 'A');
        Console.WriteLine("Last 'A': " + s2);

        int pos1 = list.FindIndex(list => list[0] == 'A');
        Console.WriteLine("First position 'A': " + pos1);

        int pos2 = list.FindLastIndex(list => list[0] == 'A');
        Console.WriteLine("Last position 'A': " + pos2);

        List<string> list2 = list.FindAll(list => list.Length == 5);
        Console.WriteLine("-------------------------------------");
        foreach (string obj in list2)
        {
            Console.WriteLine(obj);
        }
        list.Remove("Alex");
        Console.WriteLine("-------------------------------------");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        list.RemoveAt(1);
        Console.WriteLine("-------------------------------------");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        list.RemoveAll(list => list[0] == 'M');
        Console.WriteLine("---------------------------");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
        list.RemoveRange(0, 1);
        Console.WriteLine("---------------------------");
        foreach (string obj in list)
        {
            Console.WriteLine(obj);
        }
    }
}


