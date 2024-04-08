using System;

namespace Csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Credit Score Tracker!");

            // Instantiate and use your controllers here if needed

            // Example usage:
            var creditScoreController = new CreditScoreController();
            var creditScores = creditScoreController.GetCreditScores();
            foreach (var creditScore in creditScores.Value)
            {
                Console.WriteLine($"Credit Score ID: {creditScore.Id}, Score: {creditScore.Score}, Date: {creditScore.Date}");
            }

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
