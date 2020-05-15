using System;

namespace convert_loop
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Début de la boucle \"for\"");

            for (int i = 0; i < 100; i++)
            {
                Console.WriteLine($"  i = {i}");
            }

            Console.WriteLine("Terminé!");
        }
    }
}
