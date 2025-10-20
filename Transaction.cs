namespace PersonalBudgetTracker4
{
    public class Transaction
    {
        public decimal Income;
        public decimal Expense;
        public string Description;
        public string Category;
        public string Date;

        //skapar konstruktor
        public Transaction(decimal income, decimal expense, string description, string category, string date)
        {
            Income = income;
            Expense = expense;
            Description = description;
            Category = category;
            Date = date;
        }
        public void ShowInfo()//Metod som skriver ut info om transaktion
        {

        }
    }
}
