using System;
using System.Runtime.CompilerServices;

// Display a message to the user asking them to guess the secret number.
Console.WriteLine("Lets play a game.");
    Console.WriteLine("-----------------");
// Display a prompt for the user's guess.
    Console.Write("Guess the secret number?  ");
// Take the user's guess as input and save it as a variable.
    int userGuess = int.Parse(Console.ReadLine());
// Display the user's guess back to the screen.
    Console.WriteLine($"{userGuess} is a good guess.");




