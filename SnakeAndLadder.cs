class SnakeAndLadder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and LAdder Simulator");
        Console.WriteLine();
        
        int playerPosition = 0;

        Console.WriteLine("Player Initial position in the game is " + playerPosition);
        Console.WriteLine();

        while (playerPosition < 100)
        {
            Random random = new Random();

            int dieRoll = random.Next(1, 7);

            Console.WriteLine("Player Rolls the die..");
            Console.WriteLine("Die Shows: " + dieRoll);

            int option = random.Next(0, 3);
            Console.Write("Option: ");

            switch (option)
            {
                case 0:
                    Console.WriteLine("No Play!The Player Stays in the same position.");
                    break;

                case 1: 
                    if (playerPosition + dieRoll <= 100)
                    {
                        playerPosition += dieRoll;
                        Console.WriteLine("Option: Ladder!! Player moves ahead by " + dieRoll + " positions.");
                    }
                    else
                    {
                        Console.WriteLine("Option: Ladder!! Move exceeds 100. Player stays at position " + playerPosition);
                    }
                    break;
                case 2:
                    playerPosition -= dieRoll;
                    if (playerPosition < 0)
                        playerPosition = 0;
                    Console.WriteLine("Snake! Player moves behind by " + dieRoll + " positions");
                    break;
            }
            Console.WriteLine("Player current Position: " + playerPosition);
        }
        Console.WriteLine("Player wins the game!!");
            
        
    }
}

