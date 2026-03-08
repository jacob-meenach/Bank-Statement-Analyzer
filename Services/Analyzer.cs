using BankStatementAnalyzer.Models;

namespace BankStatementAnalyzer.Services
{
    public class Analyzer
    {
        public Dictionary<string, decimal> Analyze(List<Transaction> transactions)
        {
            Dictionary<string, decimal> totals = new Dictionary<string, decimal>();

            foreach (var transaction in transactions)
            {
                if (!totals.ContainsKey(transaction.Category))
                {
                    totals[transaction.Category] = 0;
                }

                    totals[transaction.Category] += transaction.Amount;
            }

            return totals;
        }
    }
}