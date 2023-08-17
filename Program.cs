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
    Console.WriteLine("4 - Cheater -- Unlimited guesses.");

    
    string difficultyLevel = "";
    int guesses = 0;
    bool intResultTryParse = false;
    int intStr;
    bool cheatMode = false;
    while(!intResultTryParse){
     intResultTryParse = int.TryParse(difficultyLevel, out intStr);
            if(intResultTryParse){
            if(intStr == 1){
                guesses = 8;
            }
            else if(intStr == 2){
                guesses = 6;
            }
            else if(intStr == 3){
                guesses = 4;
            }
            else if(intStr == 4){
                cheatMode = true;
            }
    } else {
        Console.WriteLine("Please enter a difficulty level between 1 - 4");
        difficultyLevel = Console.ReadLine();
    }
    }

    
   
    
if(cheatMode){
 for (int i = 0;  i <= 0; i --){
// Display a prompt for the user's guess.
    Console.WriteLine($"You have unlimited guesses.   ");
     Console.WriteLine("Guess the secret number   ?");
// Take the user's guess as input and save it as a variable.
    string userGuess = Console.ReadLine();
    intResultTryParse = int.TryParse(userGuess, out intStr);
// Compare the user's guess with the secret number.
// Display a success message if the guess is correct, otherwise display a failure message.
while(!intResultTryParse){
    Console.WriteLine("Please enter a numeric value between 1 and 10.");
     userGuess = Console.ReadLine();
     intResultTryParse = int.TryParse(userGuess, out intStr);
}
if(secretNumber==intStr){
    Console.WriteLine($"{intStr} is a good guess.");
    break;
    }
    //Inform the user if their guess was too high or too low, when they guess incorrectly.
    else if(secretNumber > intStr)
    {
    Console.WriteLine($"{intStr} is a not a good guess.");
    Console.WriteLine($"{intStr} is lower than the secret number.");
    }
    else if(secretNumber < intStr)
    {
Console.WriteLine($"{intStr} is a not a good guess.");
    Console.WriteLine($"{intStr} is higher than the secret number.");
    }

}} else {
    for (int i = guesses;  i > 0; i --){
// Display a prompt for the user's guess.
    Console.WriteLine($"You have {i} guesses.   ");
     Console.WriteLine("Guess the secret number   ?");
// Take the user's guess as input and save it as a variable.
    string userGuess = Console.ReadLine();
        intResultTryParse = int.TryParse(userGuess, out intStr);
// Compare the user's guess with the secret number.
// Display a success message if the guess is correct, otherwise display a failure message.
while(!intResultTryParse){
    Console.WriteLine("Please enter a numeric value between 1 and 10.");
     userGuess = Console.ReadLine();
     intResultTryParse = int.TryParse(userGuess, out intStr);
}

// Compare the user's guess with the secret number.
// Display a success message if the guess is correct, otherwise display a failure message.
if(secretNumber==intStr){
    Console.WriteLine($"{intStr} is a good guess.");
    break;
    }
    //Inform the user if their guess was too high or too low, when they guess incorrectly.
    else if(secretNumber > intStr)
    {
    Console.WriteLine($"{intStr} is a not a good guess.");
    Console.WriteLine($"{intStr} is lower than the secret number.");
    }
    else if(secretNumber < intStr)
    {
Console.WriteLine($"{intStr} is a not a good guess.");
    Console.WriteLine($"{intStr} is higher than the secret number.");
    }
}}
   
       

    




