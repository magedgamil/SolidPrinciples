//before applying open closed principle
public class PayPalPayment : IPaymentMethod
{
    public void ProcessPayment()
    {
        Console.WriteLine("Processing PayPal Payment...");
    }
}
