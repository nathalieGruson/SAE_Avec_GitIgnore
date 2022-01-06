using System;

namespace Exo1_Salut
{
    class Program
    {
        static void Main(string[] args)
        {
            String nom, prenom;
            Console.WriteLine("Nom:");
            nom = Console.ReadLine();

            Console.WriteLine("Prénom:");
            prenom = Console.ReadLine();
            Console.WriteLine("-------------------");
            Console.WriteLine("Salut " + prenom + " "+ nom + " !");
        }
    }
}
