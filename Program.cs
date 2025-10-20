namespace PersonalBudgetTracker4
{
    public class Program
    {
        static void Main(string[] args)
        {
            BudgetManager budgetManager = new BudgetManager();

            bool running = true;

            while(running)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Personal budget tracker");
                Console.WriteLine("Select an option below");
                Console.WriteLine("1) Add Transaction");
                Console.WriteLine("2) Show All transactions");
                Console.WriteLine("3) Show total balance");
                Console.WriteLine("4) Delete transaction");
                Console.WriteLine("5) Exit personal budget tracker...");

                string choice = Console.ReadLine();
                Console.Clear();

                switch(choice)
                {
                    case "1": budgetManager.AddTransaction();break;
                    case "2": budgetManager.ShowAll();break;
                    case "3": budgetManager.CalculateBalance();break;
                    case "4": budgetManager.DeleteTransaction();break;
                    case "5": running = false; break;
                    default: Console.WriteLine("Try again-.-");break;
                }
            }
        }
    }
}
