using System;

namespace Exo2_CalculPerimetreRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            double largeur, hauteur , perimetre;
            String uniteMesure;
            Console.WriteLine("CALCUL DU PERIMETRE D'UN RECTANGLE");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Unité de mesure (mm,cm,m ... :");
            uniteMesure = Console.ReadLine();
                       
            Console.WriteLine("Largeur :");
            largeur = Double.Parse(Console.ReadLine());

            Console.WriteLine("Hauteur :");
            hauteur = Double.Parse(Console.ReadLine());

            perimetre = 2 * hauteur + 2 * largeur;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Pèrimetre du rectangle : " + perimetre + uniteMesure);

        }
    }
}
