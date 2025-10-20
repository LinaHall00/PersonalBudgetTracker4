namespace PersonalBudgetTracker4
{
    public class Program
    {
        static void Main(string[] args)
        {
            BudgetManager budgetManager = new BudgetManager();//skpa ny budgetManager obejct

            bool running = true;//Bool, körs tills blir false

            while(running)//Här är main loop, körs tills bool running blir false
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine("Personal budget tracker");
                Console.WriteLine("Select an option below");
                Console.WriteLine("1) Add Transaction");
                Console.WriteLine("2) Show All transactions");
                Console.WriteLine("3) Show total balance");
                Console.WriteLine("4) Delete transaction");
                Console.WriteLine("5) Exit personal budget tracker...");

                string choice = Console.ReadLine();//Läser användarens input
                Console.Clear();

                switch(choice)//användarens input/ choice
                {
                    case "1": budgetManager.AddTransaction();break;//Lägg till transaktion
                    case "2": budgetManager.ShowAll();break;//Visa alla transaktioner
                    case "3": budgetManager.CalculateBalance();break;//Visa balans
                    case "4": budgetManager.DeleteTransaction();break;//Ta bort transaktion
                    case "5": running = false; break;//avslutar
                    default: Console.WriteLine("Try again-.-");break;//default, hanterar felinput
                }
            }
        }
    }
}
