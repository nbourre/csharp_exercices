using System;
using System.Collections.Generic;

namespace collection_display
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new List<string>() {"Nicolas", "Lyne", "Marco", "Stevens", "France", "Mathieu", "James" };

            Console.WriteLine("Début de la liste");

            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine($"item[{i}] : {myList[i]}");
            }

            Console.WriteLine("Fin de la liste");
        }
    }
}
