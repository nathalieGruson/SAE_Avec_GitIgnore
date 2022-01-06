using System;

namespace Exo3_CalculCommande
{
    class Program
    {
        static void Main(string[] args)
        {
            const double TAUX_TVA = 0.2;
            double quantite, prixUnitaireHT, prixTotalHT, prixTotalTTC;

            Console.WriteLine("CALCUL DU MONTANT D'UNE COMMANDE ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Quantité : ");
            quantite = Double.Parse(Console.ReadLine());
            Console.WriteLine("Prix unitaire HT : ");
            prixUnitaireHT = Double.Parse(Console.ReadLine());

            Console.WriteLine("-----------------------------------");
            prixTotalHT = quantite * prixUnitaireHT;
            prixTotalTTC = prixTotalHT * (1 + TAUX_TVA);
            Console.WriteLine("Prix total HT : " +  prixTotalHT + " euros");
            Console.WriteLine("Prix total TTC : " + prixTotalTTC + " euros");
            Console.WriteLine("-----------------------------------");



        }
    }
}
