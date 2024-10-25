class Program
{
    static void Main()
    {
        BirdService birdService = new BirdService();

        IFlyable sparrow = new Sparrow();
        birdService.MakeBirdFly(sparrow); // Works fine.

        // Penguin is not IFlyable, so we avoid passing it to MakeBirdFly().
        Penguin penguin = new Penguin();
        penguin.Swim(); // Works fine without breaking LSP.
    }
}
