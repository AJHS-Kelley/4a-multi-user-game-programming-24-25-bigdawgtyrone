using System;
using System.Linq;
using System.Collections;




class Collections {
  static void Main() {
 
 /*
  In c# a collection is known as an Array.
  -- EACH ITEM IN THE ARRAY IS KNOWN AS AN ELEMENT.
  -- NUMBER OF ELEMENTS IN AN ARRAY CANNOT CHANGED.
  -- CONTENTS OF EACH ELEMENT CAN CHANGE.
  -- ARRAYS ARE ORDERED, MEANING EACH ITEM HAS A FIXED POSITION.
  -- POSITION OF THE ELEMENT IS THE INDEX.
  -- FIRST ELEMENT INDEX IS 0.
 */


  // DECLARE AND DEFINING AN ARRAY
  string[] breakfastFoods = {"cheeseburger", "double cheeseburger", "triple cheeseburger", "Double Triple Bossy Deluxe on a raft, 4x4 animal style, extra shingles with a shimmy and a squeeze, light axle grease; make it cry, burn it, and let it swim", "Waffles"};
  int[] testScores = {70, 74, 80, 84, 90};
  double[] GPA = {1.8D, 2.4D, 6.3D, 3.8D, 0.000001};

  // Print Array Contents -- All Elements on Single Line
  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("breakfastFoods: \n" + String.Join("\n", breakfastFoods));
  // Console.WriteLine(); // Print an empty line to the screen.

  // // Print Array Elements on Seperate Lines
  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("testScores: \n" + String.Join("\n", testScores));
  // Console.WriteLine(); 

  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("GPA's: \n" + String.Join("\n", GPA));
  // Console.WriteLine(); 

  // // How long is my array? DETERMINING ARRAY LENGTH
  // Console.WriteLine("The length of the breakfastFoods array is : " + breakfastFoods.Length);
  // // .length is known as a PROPERTY of the array.

  // // Accessing Elements in the array with the index.
  // Console.WriteLine("The first element in breakfastFoods is: " + breakfastFoods[0]);
  // // PRINT THE 2rd ELEMENT OF THE testScores array.
  // // PRINT THE 3rd ELEMENT OF THE GPA array.

  // Shortcut to Acces Last Item in an Array
  // Console.WriteLine("The last element of breakfastFoods is: " + breakfastFoods[breakfastFoods.Length - 1]);
  // Console.WriteLine("The last element of testScores is: " + testScores[testScores.Length - 1]);

  // CHANGING ELEMENTS IN THE ARRAY
  // breakfastFoods[2] = "Super infinity nutrient";
  // testScores[3] = 12;
  // GPA[0] = 0.9D;

  // Console.WriteLine("The elements of each array are:\n");
  // Console.WriteLine("breakfastFoods: \n" + String.Join("\n", breakfastFoods));
  // Console.WriteLine(); Print an empty line to the screen.


  // COMMON ERRORS WITH ARRAYS
  // Console.WriteLine(breakfastFoods[99]); // Index Out of Bounds -- Accesing index that does not exist in the array.

  // testScores[0] = "99"; // Error Message "Cannot implicitly convert convert dataType to dataType"
  // Trying to put incorrect data type into the array.



  


  } // DON'T DELETEEEEE (3 spaces)!!!!
}