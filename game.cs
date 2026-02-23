string guessGame = "mango";
int tries = 0;
int maxTries = 3;
while(tries < maxTries && tries != maxTries)
{
    Console.Write("guess the fruit: ");
    string userGuess = Console.ReadLine();
    tries++;

    if(userGuess == guessGame)
    {
        Console.WriteLine("congratulations! you guessed it right.");
        break;
    }
    else if(tries == maxTries)
    {
        Console.WriteLine("sorry, you've used all your tries. The correct answer was: " + guessGame);
    }
    else
    {
        Console.WriteLine("wrong guess, try again.");
    }
}