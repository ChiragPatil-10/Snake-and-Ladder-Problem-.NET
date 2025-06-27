using System;

class SnakeAndLadder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and Ladder Simulator\n");

        int playerPosition = 0;
        int diceRollCount = 0;
        Random random = new Random();

        while (playerPosition < 100)
        {
            diceRollCount++;

            int dieRoll = random.Next(1, 7); 
            Console.WriteLine("\nRoll #" + diceRollCount);
            Console.WriteLine("Player rolls the die... Die shows: " + dieRoll);

            int option = random.Next(0, 3); 

            switch (option)
            {
                case 0:
                    Console.WriteLine("Option: No Play! Player stays at position " + playerPosition);
                    break;

                case 1:
                    if (playerPosition + dieRoll <= 100)
                    {
                        playerPosition += dieRoll;
                        Console.WriteLine("Option: Ladder! Player moves ahead by " + dieRoll + " positions.");
                    }
                    else
                    {
                        Console.WriteLine("Option: Ladder! Move exceeds 100. Player stays at position " + playerPosition);
                    }
                    break;

                case 2: 
                    playerPosition -= dieRoll;
                    if (playerPosition < 0)
                        playerPosition = 0;
                    Console.WriteLine("Option: Snake! Player moves behind by " + dieRoll + " positions.");
                    break;
            }

            Console.WriteLine("Player current position: " + playerPosition);
        }

        Console.WriteLine("\n Player wins the game by reaching exactly 100!");
        Console.WriteLine(" Total number of dice rolls: " + diceRollCount);
    }
}
