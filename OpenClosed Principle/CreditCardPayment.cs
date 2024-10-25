//before applying open closed principle
public class CreditCardPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing Credit Card Payment...");
    }
}
