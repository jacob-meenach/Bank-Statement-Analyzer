using BankStatementAnalyzer.Models; 

namespace BankStatementAnalyzer.Services
{
    public class CsvImporter
    {
        public List<Transaction> Import(string filePath)
        {
            List<Transaction> transactions = new List<Transaction>();

            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                string line = lines[i];

                string[] parts = line.Split(',');

                if (parts.Length < 3)
                {
                    continue;
                }
                
                Transaction transaction = new Transaction
                {
                    Date = DateTime.Parse(parts[0]),
                    Description = parts[1],
                    Amount = decimal.Parse(parts[2])
                };
                transactions.Add(transaction);
            }
            return transactions;
        }
    }
}