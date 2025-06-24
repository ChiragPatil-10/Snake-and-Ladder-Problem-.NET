class SnakeAndLadder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and LAdder Simulator");
        
        int playerInitialPosition = 0;

        Console.WriteLine("PLayer Initial position in the game is " + playerInitialPosition);

        Random random = new Random();

        int dieRoll = random.Next(1, 7);

        Console.WriteLine("Player Rolls the die..");
        Console.WriteLine("Die Shows: " + dieRoll);
    }
}