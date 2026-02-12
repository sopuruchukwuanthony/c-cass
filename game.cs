string guessGame = "mango";
int tries = 0;
int maxTries = 3;
while(tries < maxTries)
{
    Console.WriteLine("guess the fruit:");
    string userGuess = Console.ReadLine();
    tries++;

    if(userGuess == guessGame)
    {
        Console.WriteLine("congratulations! you guessed it right.");
        break;
    }
    else
    {
        Console.WriteLine("Game over. try again.");
    }
}