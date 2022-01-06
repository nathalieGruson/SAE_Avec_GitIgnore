using System;

namespace Exo4_CalculRemboursementSecu
{
    class Program
    {
        static void Main(string[] args)
        {
            const double  TAUX_RBST_SECU = 0.7;
            const double TAUX_RBST_MUTUELLE = 0.3;
            double fraisMedicaux , rbstMutuelle, rbstSecu ;
            Console.WriteLine("CALCUL DES REMBOURSEMENTS ");
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Frais médicaux : ");
            fraisMedicaux = Double.Parse(Console.ReadLine());

            rbstMutuelle = TAUX_RBST_MUTUELLE * fraisMedicaux;
            rbstSecu = TAUX_RBST_SECU * fraisMedicaux;
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Remboursement secu : " + rbstSecu + " euros");
            Console.WriteLine("Remboursement mutuelle : " + rbstMutuelle + " euros");

            Console.WriteLine("Remboursement secu : " + String.Format("{0:0.##}", rbstSecu)  + " euros");
            Console.WriteLine("Remboursement mutuelle : " + String.Format("{0:0.##}", rbstMutuelle) + " euros");

            

        }
    }
}
