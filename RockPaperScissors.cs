Console.ForegroundColor = ConsoleColor.White;
Console.BackgroundColor = ConsoleColor.Blue;
string playerMove = "";
int playerWins = 0;
int computerWins = 0;
bool restart = true;
while (restart)
{

    const string rock = "Rock";
    const string paper = "Paper";
    const string scissors = "Scissors";
    Console.WriteLine("Choose [r]ock, [p]aper or [s]cissors: ");
    playerMove = Console.ReadLine();
    if (playerMove == "r" || playerMove == "rock")
    {
        playerMove = rock;
    }
    else if (playerMove == "s" || playerMove == "scissors")
    {
        playerMove = scissors;
    }
    else if (playerMove == "p" || playerMove == "paper")
    {
        playerMove = paper;
    }
    else
    {
        Console.WriteLine("Invalid input. Try again...");
    }

    Random random = new Random();
    int computerRandomNum = random.Next(1, 4);
    string computerMove = "";
    switch (computerRandomNum)
    {
        case 1:
            computerMove = rock;
            break;
        case 2:
            computerMove = scissors;
            break;
        case 3:
            computerMove = paper;
            break;
    }
    Console.WriteLine($"The computer chose {computerMove}");
    
    if ((playerMove == rock && computerMove == scissors) || (playerMove == paper && computerMove == rock) || (playerMove == scissors && computerMove == paper))
    {
        Console.WriteLine("You win.");
        playerWins++;
    }
    else if ((playerMove == rock && computerMove == paper) || (playerMove == paper && computerMove == scissors) || (playerMove == scissors && computerMove == rock))
    {
        Console.WriteLine("You lose.");
        computerWins++;
    }
    else Console.WriteLine("This game was a draw.");

    Console.WriteLine($"The score is {playerWins} to {computerWins}!");
    Console.WriteLine("Would you like to play again?");
    string input = Console.ReadLine().ToLower();
    restart = (input == "yes");    
}
Console.WriteLine("Thank you for playing");