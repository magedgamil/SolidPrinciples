
//before applying LSP

//public class Bird
//{
//    public virtual void Fly()
//    {
//        Console.WriteLine("Flying...");
//    }
//}

//public class Sparrow : Bird { }

//public class Penguin : Bird
//{
//    // Penguins cannot fly, so we override to throw an exception.
//    public override void Fly()
//    {
//        throw new InvalidOperationException("Penguins cannot fly!");
//    }
//}

//public class BirdService
//{
//    public void MakeBirdFly(Bird bird)
//    {
//        bird.Fly();
//    }
//}

//class Program
//{
//    static void Main()
//    {
//        BirdService birdService = new BirdService();

//        Bird sparrow = new Sparrow();
//        birdService.MakeBirdFly(sparrow); // Works fine.

//        Bird penguin = new Penguin();
//        birdService.MakeBirdFly(penguin); // Throws an exception at runtime!
//    }
//}


//after applying LSP

public class Bird { }

public class Sparrow : Bird, IFlyable
{
    public void Fly()
    {
        Console.WriteLine("Sparrow flying...");
    }
}

public class Penguin : Bird
{
    public void Swim()
    {
        Console.WriteLine("Penguin swimming...");
    }
}