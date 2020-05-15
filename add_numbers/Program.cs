using System;

namespace add_numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int nombreA, nombreB, resultat;
            Console.WriteLine("Entrez le premier nombre : ");
            nombreA = int.Parse(Console.ReadLine());
            Console.WriteLine("Entrez le second nombre : ");
            nombreB = int.Parse(Console.ReadLine());

            resultat = nombreA + nombreB;

            Console.WriteLine($"Le résultat de l'addition est {resultat}");

        }
    }
}
