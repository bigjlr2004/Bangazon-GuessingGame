using System;


// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
int secretNumber = new Random().Next(1,10);
// Display a message to the user asking them to guess the secret number.
Console.WriteLine("Lets play a game.");
    Console.WriteLine("-----------------");
    Console.WriteLine(secretNumber);
    Console.WriteLine("Guess the secret number?  ");
    
// Give the user four chances to guess the number.
    for (int i = 4;  i > 0; i --){
// Display a prompt for the user's guess.
    Console.Write($"You have {i} guesses.   ");
// Take the user's guess as input and save it as a variable.
    int userGuess = int.Parse(Console.ReadLine());

// Compare the user's guess with the secret number.
// Display a success message if the guess is correct, otherwise display a failure message.
if(secretNumber==userGuess){
    Console.WriteLine($"{userGuess} is a good guess.");
    break;
    }
    //Inform the user if their guess was too high or too low, when they guess incorrectly.
    else if(secretNumber > userGuess)
    {
    Console.WriteLine($"{userGuess} is a not a good guess.");
    Console.WriteLine($"{userGuess} is lower than the secret number.");
    }
    else if(secretNumber < userGuess)
    {
Console.WriteLine($"{userGuess} is a not a good guess.");
    Console.WriteLine($"{userGuess} is higher than the secret number.");
    }

}
  



