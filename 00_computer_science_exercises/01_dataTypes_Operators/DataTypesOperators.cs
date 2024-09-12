// Data Types and Operators, Christian Ortiz, v0.3
using System;

class DataTypesOperators {
  static void Main() {
    // i alone am the christian one...
    /* <-- everything after this is counted as a comment until this
    
    
    
    -->  */

    // DATA TYPES
    // C# is STATICALLY TYPED -- once a variable has a data type, it cannot change

    // Float - float -- decimal numbers, +/- including 0.0

    // Double - double decimal numbers, +/-, including 0.0 <-- MOST COMMONLY USED DECIMAL

    // Integer - int -- whole number, +/-, including 0

    // VARIABLES ARE 'BUCKETS' WITH A NAME TO STORE DATA INSIDE
   
    // DECLARING (CREATING VARIABLES)
    // Method #1 -- Declared But Not Assigned
    // datatypes variableName;

    int myInteger = 2;
    double myDouble = 3.8;

    // Method #2 Declare AND Assign
    int myInteger2 = 1;
    double myDouble2 = 2.05D;

    // Strings -- Collections of Letters, numbers, special characters.
    string myString = "This is getting interesting...";

    // Boolean -- bool - True or False value
    bool myBool = true;
    bool fireResistance = true;
    bool hasPurpleKey = false;

    // Character -- char -- a single character.
    char myChar = 'A';

    // ASSIGN VALUES AFTER DECLARATION

    myInteger = 5;
    myBool = false;

    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine(myInteger);
    Console.WriteLine(myDouble);

    // PRINTING EXPRESSIONS TO THE CONSOLE TERMINAL
    Console.WriteLine(myInteger - 25);
    Console.WriteLine(myDouble + 5.5);


    // PRINTING VARIABLES TO THE CONSOLE TERMINAL
    Console.WriteLine(myInteger);
    Console.WriteLine(myDouble);

    // OPERATORS -- ARITHMETIC
    // Addition
    int myNewInt = myInteger + myInteger2;
    double myNewDouble = myDouble + myDouble2;
    double myNewNumber = myInteger + myDouble;
    
    // Subtraction
    myNewNumber = myDouble - myInteger;

    // Division
    myNewNumber =  myDouble / myInteger;

    // Multiplication
    myNewNumber = myDouble * myInteger;

    // MODULUS -- Divides, then Returns the REMAINDER
    // Most commonly used to determin EVEN or ODD
    myNewNumber = myDouble % 2 ;

    int students = 6;
    int numSlices = 36;
    int leftOvers;

    leftOvers = numSlices % students;

    // Increment / Decrement / Most frequently used in LOOPS
    int x = 0;
    // What is x equal to now?
    // Increment ++ adds 1 to the current value and puts the new value into the bucket
    x++;
    // Decrement -- subtracts 1 from the current value and puts the new value into the bucket
    x--;
    // Special Assignment Operators
    // x +=;
    // x *=;
    // x /=;
    // x -=;
    // x %=;
  // Take the current value, perform the calculation, put new value into the bucket

  // COMPARISON OPERATORS
  // EVALUATE THE EXPRESSION, RETURN true or false value
  int y = 5;
  int z = 3;

  // IS-EQUAL-TO == is the value on the left equal to the right?
  // Console.WriteLine(y == z);

  // // NOT-EQUAL-TO != is the value on the left not equal to the value on the right?
  // Console.WriteLine(y != z);

  // GREATER THAN >
  // Console.Writeline(y > z);
  // // GREATER THAN-OR-EQUAL-TO >=
  // Console.WriteLine(y >= z);
  // // LESS THAN <
  // Console.WriteLine(y < z);
  // // LESS THAN-OR-EQUAL-TO <=
  // Console.WriteLine(y <= z);

  // LOGICAL OPERATORS
  int b = 1;
  double c = 2.0D;
  string favColor = "Blue";
  // Logical and && -- all statements must be true
  // Console.WriteLine(b > 1 && c != 5.0D); // false because b is not > 1
  // Console.Writing(b == 1 && c < 10.0D); // both are true, whole expression is true
  // // if one expression most likely to be false, check for it FIRST!
  // Console.WriteLine(hasPurpleKey == true && playerLevel > 5)
  // Console.WriteLine(hasPurpleKey == true && playerLevel > 5 && hasFlameThrower == true && timeRemaining > 99);

  // // Logical OR || -- ONE statement must be true
  // Console.WriteLine(b > 1 || c != 5.0D); // true because c is not equal to 5.0
  // Console.WriteLine(b == 2 || c > 2 10.0D); // false because both expressions are false
  // // Check for statement most likely to be true first!
  // Console.WriteLine(hasBlueKey == true && playerLevel > 3);

  // Logical Not ! -- Returns the opposite value of the expression. 
  // Console.WriteLine(b > -1); // true
  // Console.WriteLine(!(b > -1)); // false

  // READING USER INPUT FROM CONSOLE / TERMINAL 
  // Console.WriteLine("What is your player name?  Type it then press ENTER.\n");

  //  CREATE A VARIABLE TO STORE THE DATA.
  //  string playerName = Console.ReadLine();
  // Console.WriteLine() ONLY RETURNS string data types.
  // Console.ReadLine("What is your age?  Type it and press ENTER.\n");
  // string age = Console.ReadLine();
  // Console.WriteLine(age + age);
// Adding string data types together is called  CONCATENATION

  // PRINT THE VARIABLE TO THE SCREEN
  // Console.WriteLine("Your player name is " + playerName);

  // INPUTTING NUMBERS FROM THE CONSOLE.
  Console.WriteLine("How many gallons of burger king frying oil can you drink in 2 hours? Enter an integer value and press ENTER.\n");
  int numGallons = Convert.ToInt32(Console.ReadLine());
  Console.WriteLine(numGallons + numGallons);

  }
}