using System;


// Create a variable to contain the secret number. This number should be hard-coded for now. 42 is a nice number.
int secretNumber = new Random().Next(1,10);
// Display a message to the user asking them to guess the secret number.
Console.WriteLine("Lets play a game.");
    Console.WriteLine("-----------------");
    Console.WriteLine("Please Select a Difficulty Level 1, 2, 3 ?");
    Console.WriteLine("1 - Easy -- 8 guesses.");
    Console.WriteLine("2 - Medium -- 6 guesses.");
    Console.WriteLine("3 - Hard -- 4 guesses.");
    int difficultyLevel = int.Parse(Console.ReadLine());

    int guesses = 0;
if(difficultyLevel == 1){
    guesses = 8;
}
    //Inform the user if their guess was too high or too low, when they guess incorrectly.
    else if(difficultyLevel == 2){
    guesses = 6;
}
    else if(difficultyLevel == 3){
    guesses = 4;
}

    
    Console.WriteLine("Guess the secret number?  ");
    
// Give the user four chances to guess the number.
    for (int i = guesses;  i > 0; i --){
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

       

    




