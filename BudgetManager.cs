namespace PersonalBudgetTracker4
{
    public class BudgetManager
    {
        private List<Transaction> transactions = new List<Transaction>();//Lagrar transaktioner i lista

        public void AddTransaction()//Lägger till transaktioner, metod.
        {
            Console.WriteLine("Income or Expense: ");
            string input = Console.ReadLine().ToLower();//User kan svara med stor o liten bokstav.
            decimal income = 0;
            decimal expense = 0;

            if(input== "income") { Console.WriteLine("How much: ");income = Convert.ToDecimal(Console.ReadLine());}
            else if (input == "expense") { Console.WriteLine("How much: ");expense = Convert.ToDecimal(Console.ReadLine()); }

            Console.WriteLine("Category: ");
            string category = Console.ReadLine();

            Console.WriteLine("Description: ");
            string description = Console.ReadLine();

            Console.WriteLine("Write the date of transaction in this format (YYYY-MM-DD): ");
            string date = Console.ReadLine();

            Transaction transaction = new Transaction(income, expense, description, category, date);
            transactions.Add(transaction);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Transaction Added.");
            Console.ResetColor();
        }
        public void ShowAll()//Visar alla transaktioner som finns
        {
            if(transactions.Count == 0)
            {
                Console.WriteLine("There are NO transactions.");
                return;
            }
            for(int i = 0; i< transactions.Count; i++)//Går igenom transaktionerna i lisan
            {
                Console.ForegroundColor= ConsoleColor.Green;
                Console.WriteLine("Transaction ID: "+ i);//visar id, position i lista 0, 1, 2
                transactions[i].ShowInfo();
                Console.ResetColor();
            }
        }
        public void CalculateBalance()//Räknar ut total balans.
        {
            decimal totalBalance = 0;
            for (int i = 0; i < transactions.Count; i++)
            {
                totalBalance += transactions[i].Income - transactions[i].Expense;
            }
            Console.WriteLine("Your current balance is " + totalBalance + " SEK ");
        }
        public void DeleteTransaction()//Metod för att ta bort transaktion.
        {
            ShowAll();//visar lista med transaktion infoi, så id är lätt o se.
            
            if(transactions.Count == 0)
            {
                Console.WriteLine("There are NO transactions to delete...");
                return;
            }
            int id = Convert.ToInt32(Console.ReadLine());
            if (id >= 0 && id < transactions.Count)
            {
                Transaction transaction = transactions[id];//Sparar transaktion infon innan bort.
                transactions.RemoveAt(id);//Här tas den bort.
                transaction.ShowInfo();//kallar på metoden så man får se info om borttagen trans, istället för o använda interpolation/Concatenation.

                Console.ForegroundColor = ConsoleColor.Green;//Ändrar färg till grön.
                Console.WriteLine("Transaction deleted!");//Skriver ut transaktion borttagen.
                Console.ResetColor();//Återställer färg
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;//Ändrar så wrong id skrivs ut i rött.
                Console.WriteLine("Wrong ID, try again..");
                Console.ResetColor();//ÅTerställer färg igen.
            }
        }
    }
}
