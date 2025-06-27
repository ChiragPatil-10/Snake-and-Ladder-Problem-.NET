using System;

class SnakeAndLadder
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Snake and Ladder Simulator\n");

        int player1Position = 0;
        int player2Position = 0;
        int diceRollCount = 0;
        bool isPlayer1Turn = true;

        Random random = new Random();

        while (player1Position < 100 && player2Position < 100)
        {
            diceRollCount++;
            int dieRoll = random.Next(1, 7); 
            int option = random.Next(0, 3);  

            string currentPlayer = isPlayer1Turn ? "Player 1" : "Player 2";
            ref int currentPosition = ref isPlayer1Turn ? ref player1Position : ref player2Position;

            Console.WriteLine($"\nTurn #{diceRollCount}: {currentPlayer}'s turn");
            Console.WriteLine($"{currentPlayer} rolls the die... Die shows: {dieRoll}");

            switch (option)
            {
                case 0:
                    Console.WriteLine("Option: No Play! Player stays at position " + currentPosition);
                    break;

                case 1:
                    if (currentPosition + dieRoll <= 100)
                    {
                        currentPosition += dieRoll;
                        Console.WriteLine("Option: Ladder! Player moves ahead by " + dieRoll + " positions.");
                    }
                    else
                    {
                        Console.WriteLine("Option: Ladder! Move exceeds 100. Player stays at position " + currentPosition);
                    }
                    Console.WriteLine("Ladder hit! " + currentPlayer + " gets another turn.");
                    continue;  
                case 2: 
                    currentPosition -= dieRoll;
                    if (currentPosition < 0)
                        currentPosition = 0;
                    Console.WriteLine("Option: Snake! Player moves behind by " + dieRoll + " positions.");
                    break;
            }

            Console.WriteLine(currentPlayer + " current position: " + currentPosition);

            isPlayer1Turn = !isPlayer1Turn;
        }

        Console.WriteLine("\n Game Over!");
        if (player1Position == 100)
            Console.WriteLine(" Player 1 wins the game!");
        else
            Console.WriteLine(" Player 2 wins the game!");

        Console.WriteLine($"Total dice rolls in the game: {diceRollCount}");
    }
}
