using System;


// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
int secretNumber = 42;
// Display a message to the user asking them to guess the secret number.
Console.WriteLine("Lets play a game.");
    Console.WriteLine("-----------------");
// Display a prompt for the user's guess.
    Console.Write("Guess the secret number?  ");
// Take the user's guess as input and save it as a variable.
    int userGuess = int.Parse(Console.ReadLine());

    
// Give the user four chances to guess the number.
    for (int i = 0;  i < 3; i ++){
// Compare the user's guess with the secret number.
// Display a success message if the guess is correct, otherwise display a failure message.
if(secretNumber==userGuess){
    Console.WriteLine($"{userGuess} is a good guess.");
    break;
    }
    else
    {
    Console.WriteLine($"{userGuess} is a not a good guess.");
    }
    Console.WriteLine("Guess Again?  ");
    userGuess = int.Parse(Console.ReadLine());
}



