using System;
class HelloWorld {
  static void Main() {
    // // In C# ALL STRINGS MUST USE DOUBLE-QUOTES "    "
    // string greeting = "HOLA COMO SE DICE.\n";
    // string goodbye = "See you later crocodile.\n";

    // // In C# strings are treated like an OBJECT that has properties and methods.
    // // PROPERTIES -- things that describe the object such as length, value, data type, etc.
    // // METHODS -- built in functions related to that project.

    // // Length is an important property for strings.
    // Console.WriteLine(greeting.Length);
    // Console.WriteLine(goodbye.Length);

    // if (greeting.Length > goodbye.Length)
    // {
    //   Console.WriteLine("The greeting has more characters than the goodbye");
    // }

    // // Useful String Methods

    // Console.WriteLine(greeting.ToUpper()); // Make entire string UPPERCASE
    // Console.WriteLine(greeting.ToLower()); // Make entire string lowercase

    // // String "Con-Cat-Uh-Nation"
    // string comboString = greeting + goodbye;
    // Console.WriteLine(comboString);

    // // String Concatenation Method #2
    // string comboString2 = string.Concat(greeting, goodbye);
    // Console.WriteLine(comboString2);

    // // String Interpolation -- Substituting Variables into Strings.
    // string comboString3 = $"My greeting is {greeting} and my goodbye is {goodbye}\n";
    // Console.WriteLine(comboString3);

    // // Substituting Variables into Strings Method 2.
    // Console.WriteLine("My greeting is " + greeting + "and my goodbye is " + goodbye + "\n");

    // // Accesing Parts of Strings
    // // index is a specific location of a character in a string
    // // ALL string indexes start at 0
    // Console.WriteLine(goodbye[0]); // Print the character at index 0
    // Console.WriteLine(goodbye[4]); 

    // // Where is it in my string?
    // Console.WriteLine(greeting.IndexOf("y"));
   
    // Finding parts of a string
    string fullName = "Your Mom";

    // What letter?
    int lastInitial = fullName.IndexOf("M");

    // find the subtring.
    string lastName = fullName.Substring(lastInitial);

    // print it.
    Console.WriteLine(lastName);





  }
}