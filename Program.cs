using BankStatementAnalyzer.Models;
using BankStatementAnalyzer.Services;
using System.Linq;

namespace BankStatementAnalyzer
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bank Statement Analyzer");
            Console.WriteLine("------------------------");

            // Path to CSV File
            string filePath = "statement.csv";

            CsvImporter importer = new CsvImporter();
            Categorizer categorizer = new Categorizer();
            Analyzer analyzer = new Analyzer();

            // Import transactions
            List<Transaction> transactions = importer.Import(filePath);

            // Categorize them
            categorizer.Categorizes(transactions);

            // Analyze Totals
            var totals = analyzer.Analyze(transactions);

            // Print Results
            Console.WriteLine("\nSpending Summary:");
            Console.WriteLine("-----------------");

            foreach (var total in totals.OrderByDescending(x => x.Value))
            {
                Console.WriteLine($"{total.Key}: ${Math.Abs(total.Value):0.00}");
            }
        }
    }
}