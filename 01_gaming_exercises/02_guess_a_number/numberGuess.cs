using System;
class GuessNumber {
  static void Main() {
    int numGuesses = 0;
    int maxGuesses = 3;
    int guess;
    
    // Generate the secret number here.
    Random rnd = new Random(); // Create an object named 'rng' that is a copy of the Random() class.
    int secretNumber = rnd.Next(1,21); // Generate from 0 to 99
    // Console.WriteLine(secretNumber);
    // int secretNumber = rnd.Next(25, 1000)
    while(numGuesses < maxGuesses) {
        Console.WriteLine("Please guess an integer between 0 and 20.\n");
        guess = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(guess);
        Console.WriteLine("Guess: " + guess);
        numGuesses++;

        if (guess < secretNumber)
        {
            Console.WriteLine("Your guess is too low!\n");
        }
        else if (guess > secretNumber)
        {
            Console.WriteLine(" Your guess is too high!\n");
        }
        else 
        {
            Console.WriteLine("You got it... now do it again.\n");
            break; // Keyword to immediately exit a loop.
        }
        
        if (numGuesses >= maxGuesses)
        {
            Console.WriteLine("you lost... as i expected.");
        }
    }

        // Allow the user to guess the number.
        // Compared the guessed number to the secret number.
        // If match, print win, if > or < , give a hint
        // +1 to numGuesses
        // if true, print a "lose game" message, if false guess again

    

  }
}