using BankStatementAnalyzer.Models;

namespace BankStatementAnalyzer.Services
{
    public class Categorizer
    {
        public void Categorizes(List<Transaction> transactions)
        {
            foreach (var transaction in transactions)
            {
                string description = transaction.Description.ToLower();

                if (description.Contains("starbucks") ||
                    description.Contains("dunkin") ||
                    description.Contains("coffee"))
                {
                    transaction.Category = "Coffee";
                }
                else if (description.Contains("amazon") ||
                         description.Contains("walmart") ||
                         description.Contains("target"))
                {
                    transaction.Category = "Shopping";
                }
                else if (description.Contains("uber") ||
                         description.Contains("lyft") ||
                         description.Contains("taxi"))
                {
                    transaction.Category = "Transportation";
                }
                else if (description.Contains("netflix") ||
                         description.Contains("hulu") ||
                         description.Contains("spotify"))
                {
                    transaction.Category = "Entertainment";
                }
                else
                {
                    transaction.Category = "Other";
                }
            }
        }
    }
}