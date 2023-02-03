namespace Test_Exercises
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccaount bancAcc = new BankAccaount();
            int i = 0;
            while (i != 5)
            {
                try
                {
                    Console.WriteLine("Deposit:");
                    bancAcc.Deposit(double.Parse(Console.ReadLine()));
                    Console.WriteLine("Withdraw:");
                    bancAcc.Withdraw(double.Parse(Console.ReadLine()));
                    
                }
                catch (InvalidOperationException ex)
                {
                    Console.WriteLine();
                    Console.WriteLine();
                    i++;
                    Console.WriteLine(ex.Message);
                }
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine(bancAcc.Balance());
        }
    }
}