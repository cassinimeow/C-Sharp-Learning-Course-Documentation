using System;

namespace Review
{
  class Program
  {
    static void Main(string[] args)
    {
    
    /*
    //Compound Interest Calculator
    Console.WriteLine("Compound Interest Calculator!");

    Console.WriteLine("What is the principal amount?");
    double principal = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is the interest rate?");
    double interestRate = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is the number of years?");
    double years = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("What is the number of times the interest is compounded per year?");
    double timesCompounded = Convert.ToDouble(Console.ReadLine());

    
    double compoundInterest = principal * Math.Pow((1 + (interestRate / timesCompounded)), timesCompounded * years);
    Console.WriteLine("The compound interest is " + compoundInterest);


    //Dog Years Calculator
    Console.WriteLine("Dog Years Calculator!");

    Console.WriteLine("What is your age?");
    double age = Convert.ToDouble(Console.ReadLine());

    double dogYears = age * 7;
    Console.WriteLine("Your age in dog years is " + dogYears);


    //String Interpolation
    string beginning = "GDG";
    string middle = "PUP Manila Campus";
    string end = "Thank you for reading.";


    string story = $"Im a Game Developer in {beginning} at {middle} that's all. {end}";

    Console.WriteLine(story);
    
// String concatenation
    string firstName = "John";
    string lastName = "Doe";
    string fullName = firstName + " " + lastName;
    Console.WriteLine("Full Name (Concatenation): " + fullName);

// String interpolation
    int age = 30;
    string interpolatedString = $"Name: {firstName} {lastName}, Age: {age}";
    Console.WriteLine("Interpolated String: " + interpolatedString);

// Bracket notation
    string name = "Alice";
    char firstLetter = name[0];
    Console.WriteLine("First letter using bracket notation: " + firstLetter);

// .ToUpper
    string upperCaseName = name.ToUpper();
    Console.WriteLine("Uppercase Name: " + upperCaseName);

// .ToLower
    string lowerCaseName = name.ToLower();
    Console.WriteLine("Lowercase Name: " + lowerCaseName);

// .Length
    string sentence = "The quick brown fox jumps over the lazy dog";
    int sentenceLength = sentence.Length;
    Console.WriteLine("Length of the sentence: " + sentenceLength);

// .IndexOf()
    int indexOfWord = sentence.IndexOf("fox");
    Console.WriteLine("Index of the word 'fox': " + indexOfWord);


    //Comparison Operators
    int num1 = 10;
    int num2 = 20;

    bool isEqual = num1 == num2;
    bool isNotEqual = num1 != num2;
    bool isGreaterThan = num1 > num2;
    bool isLessThan = num1 < num2;
    bool isGreaterThanOrEqual = num1 >= num2; 
    bool isLessThanOrEqual = num1 <= num2;

    Console.WriteLine("Is num1 equal to num2? " + isEqual);
    Console.WriteLine("Is num1 not equal to num2? " + isNotEqual);
    Console.WriteLine("Is num1 greater than num2? " + isGreaterThan);
    Console.WriteLine("Is num1 less than num2? " + isLessThan);
    Console.WriteLine("Is num1 greater than or equal to num2? " + isGreaterThanOrEqual);
    Console.WriteLine("Is num1 less than or equal to num2? " + isLessThanOrEqual);

    //Logical Operators
    bool condition1 = true;
    bool condition2 = false;

    bool andResult = condition1 && condition2;
    bool orResult = condition1 || condition2;
    bool notResult = !condition1;

    Console.WriteLine("Condition 1 AND Condition 2: " + andResult);
    Console.WriteLine("Condition 1 OR Condition 2: " + orResult);
    Console.WriteLine("NOT Condition 1: " + notResult);*/

    //If, Else If, Else
    int num1 = 10;
    int num2 = 20;

    if (num1 > num2){
      Console.WriteLine("num1 is greater than num2");
    }
    else if (num1 < num2){
      Console.WriteLine("num1 is less than num2");
    }
    else{
      Console.WriteLine("num1 is equal to num2");
    }

    //Switch Statement
    int day = 4;

    switch (day){
      case 1:
        Console.WriteLine("Today is Monday");
        break;

      case 2:
        Console.WriteLine("Today is Tuesday");
        break;

      case 3:
        Console.WriteLine("Today is Wednesday");
        break;

      case 4:
        Console.WriteLine("Today is Thursday");
        break;

      case 5:
        Console.WriteLine("Today is Friday");
        break;

      case 6: 
        Console.WriteLine("Today is Saturday");
        break;

      case 7: 
        Console.WriteLine("Today is Sunday");
        break;

      default:
        Console.WriteLine("Invalid day");
        break;
    }

      //Terinary Operator
      int num3 = 10;
      int num4 = 20;

      int result = num3 > num4 ? num1 : num2;
      Console.WriteLine("The greater number is " + result);
    }
  }
}
