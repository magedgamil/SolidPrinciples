//before applying open closed principle
public class BankTransferPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Bank Transfer Payment...");
    }
}
