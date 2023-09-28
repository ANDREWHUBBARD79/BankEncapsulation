namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {


            var AndrewsAccount = new Bank_Account();

            Console.WriteLine("How much would you like to deposit?");

            var amountToDeposit = double.Parse(Console.ReadLine());

            AndrewsAccount.Deposit(amountToDeposit);

            Console.WriteLine($"Thank you! Your balance is now {AndrewsAccount.GetBalance()}");







        }
    }
}
