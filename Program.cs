using uppgift2.inkapsling.sep16.klasser;

namespace uppgift2.inkapsling.sep16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount konto1 = new BankAccount(); //första objektet
            konto1.deposit(1000); // lägger in pengar
            konto1.withdraw(500); //tar bort pengar
            konto1.getBalance(); // kollar mängden men värdet är privat och det finns ingen console.writeline för det.

        }
    }
}
