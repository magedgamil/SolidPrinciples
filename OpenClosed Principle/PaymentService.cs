//before applying open closed principle
//public class PaymentService
//{

//    public void ProcessPayment(string paymentType)
//    {
//        if (paymentType == "CreditCard")
//        {
//            Console.WriteLine("Processing Credit Card Payment...");
//            // Credit Card logic here
//        }
//        else if (paymentType == "PayPal")
//        {
//            Console.WriteLine("Processing PayPal Payment...");
//            // PayPal logic here
//        }
//        else if (paymentType == "BankTransfer")
//        {
//            Console.WriteLine("Processing Bank Transfer Payment...");
//            // Bank Transfer logic here
//        }
//        else
//        {
//            throw new Exception("Invalid payment type.");
//        }
//    }
//}

//after applying open closed principle

public class PaymentService
{
    private readonly IPaymentMethod _paymentMethod;

    public PaymentService(IPaymentMethod paymentMethod)
    {
        _paymentMethod = paymentMethod;
    }

    public void ProcessPayment()
    {
        _paymentMethod.ProcessPayment();
    }
}
