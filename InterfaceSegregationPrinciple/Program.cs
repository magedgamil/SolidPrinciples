//before ISP
//public interface IPrinter
//{
//    void Print();
//    void Scan();
//    void Fax();
//}

//public class BasicPrinter : IPrinter
//{
//    public void Print()
//    {
//        Console.WriteLine("Printing...");
//    }

//    public void Scan()
//    {
//        // BasicPrinter doesn't support scanning.
//        throw new NotImplementedException();
//    }

//    public void Fax()
//    {
//        // BasicPrinter doesn't support faxing.
//        throw new NotImplementedException();
//    }
//}

//public class MultifunctionPrinter : IPrinter
//{
//    public void Print()
//    {
//        Console.WriteLine("Printing...");
//    }

//    public void Scan()
//    {
//        Console.WriteLine("Scanning...");
//    }

//    public void Fax()
//    {
//        Console.WriteLine("Faxing...");
//    }
//}

IPrint basicPrinter = new BasicPrinter();
Console.WriteLine("Testing BasicPrinter:");
basicPrinter.Print(); // Should print without errors

// Demonstrating MultifunctionPrinter
IPrint multifunctionPrinter = new MultifunctionPrinter();
IScan multifunctionScanner = (IScan)multifunctionPrinter;
IFax multifunctionFax = (IFax)multifunctionPrinter;

Console.WriteLine("\nTesting MultifunctionPrinter:");
multifunctionPrinter.Print(); // Should print without errors
multifunctionScanner.Scan();   // Should scan without errors
multifunctionFax.Fax();        // Should fax without 