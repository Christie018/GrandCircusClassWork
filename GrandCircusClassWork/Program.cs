/* Class Notes 1/22/2024
 * - Created a new project console app
 * - Put all unit 2 code in the same folder or project
 * - Variable are storage containers for data; data types enforce type security b not allowing anything other than that data type to be stored in the variable
 * - Going through different variable types today
 * - Int = 32 bytes of memory space
 * - Long = 64 bytes of memory space
 * - Float takes decimal numbers; put "f" after variable initialization
 * - Decimal variables need a "m" after the initialzation
 * - camelCase vs PascalCase
 * - Char types store  single letter, number, or special character
 * - Var data types wait until you initialize the variable to define it's type (NOT BEST PRACTICE)
 * - You can have special characters in strings, but you need to escape quotes with backslashs
 */

/* Going through GC C# 1/22/24 in Class */
using Microsoft.VisualBasic;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Transactions;

int x;
x = 5;
int y = 10;

int itemCount = 0;
long distance = 500000000000;
float temperature = 96.61f;
double price = 199.99;
decimal accountBalance = 1500.75M;

string camelCase;
string PascalCase;

bool isEligible = true;
string userName;
string franchiseName;

char studentGrade = 'A';
string firstName = "Scott";

int a = 5;
int b = 10;
int sum = a + b;
int difference = a - b;
int product = a * b;
int quotient = a / b;
int modulus = a % 2; //Determins if a number is even or odd
int modForThree = a % 3;

int counter = 10;
counter++;
counter += 5;
counter = +5;
counter = +5;

int length = 4;
int width = 3;
int area = length * width;
int perimeter = (length * 2) + (width * 2);

string userFirstName = "John";
string userLastName = "Doe";
string fullName = userFirstName + userLastName;
string fullNameWithSpace = userFirstName + " " + userLastName;

char firstInitial = userFirstName[0];
int stringLength = userLastName.Length;

string replaceName = fullNameWithSpace.Replace("o", "a"); //JahnDae
string otherReplacedName = fullName.Replace("Jahn", "Steve"); //SteveDae

char letter = 'A';
bool isDigit = Char.IsDigit(letter); //returns false
bool isLetter = Char.IsLetter(letter); // returns true

char char2 = '6';
bool isDigit2 = Char.IsDigit(char2); //returns true
bool isLetter2 =  Char.IsLetter(char2); //returns true

string originalText = "Hello World";
string weirdText = "HeLlO wORLD";
string spacedText = "      Hello world      ";
string upperText = originalText.ToUpper(); //HELLO WORLD
string lowerText = originalText.ToLower(); //hello world

bool haveProduct = originalText.ToLower() == weirdText.ToLower(); //world == hello world
haveProduct = originalText.ToLower() == spacedText.ToLower().Trim();
haveProduct = originalText.Replace(" ", "").ToLower() == spacedText.Replace(" ", "").ToLower();


fullNameWithSpace = userFirstName + " " + userLastName + ":";
string betterWay = $"{userFirstName} {userLastName}";
string longerMessage = $"{userFirstName} {userLastName} is My favorite user he has a grade of {studentGrade} and his eligibility is {studentGrade}";

Console.WriteLine($"{userFirstName} {userLastName} is my favorite user he has a grade of " + $"{studentGrade} and his eligibility is {isEligible}");

length = 0;
width = 0;

Console.WriteLine("What is the length of the room?");
string userLength = Console.ReadLine();
Console.WriteLine("What about the width?");
string userWidth = Console.ReadLine();

try
{
    length = int.Parse(userLength);
    width = int.Parse(userWidth);
}
catch(FormatException) 
{
    Console.Write("You gave me a bad number dude. So these calculations are wrong");
    Environment.Exit(1);
}

area = length * width;
perimeter = (length * 2) + (width * 2);

Console.Write($"Great! The perimeter of your room is {perimeter}.");
Console.WriteLine(($"Your area is {area}"));
Console.WriteLine($"Your cost will be {area * perimeter * 200}");

Console.ReadKey();

/* Going through Excersise about Strings, Numbers, and Console 1/22/24 */

//Excersise 1.1 Echo String
Console.WriteLine("Excersise 1.1 Echo String");
Console.WriteLine("Enter some text:");
string userInputString = Console.ReadLine();
Console.WriteLine(userInputString);

//Excersise 1.2 Adding a number to an integer
Console.WriteLine("Excersise 1.2 Adding a number to an integer");
Console.WriteLine("Enter a number:");
int userInputInt = int.Parse(Console.ReadLine());
userInputInt++;
Console.WriteLine(userInputInt);

//Excerside 1.3 Adding a number to a float
Console.WriteLine("Excerside 1.3 Adding a number to a float");
Console.WriteLine("Enter a number:");
float userInputFloat = float.Parse(Console.ReadLine());
userInputFloat = (float)(userInputFloat + .5);
Console.WriteLine(userInputFloat);

// EXERCISE 1.4: Adding Two Floats
Console.WriteLine("EXERCISE 1.4: Adding Two Floats");
Console.WriteLine("Enter a number:");
userInputFloat = float.Parse(Console.ReadLine());
Console.WriteLine("Enter another number:");
float userInputFloat2 = float.Parse(Console.ReadLine());
float userInputFloatTotal = userInputFloat + userInputFloat2;
Console.WriteLine("The sum is " + userInputFloatTotal);

//EXERCISE 1.5: Multiplying Floats
Console.WriteLine("EXERCISE 1.5: Multiplying Floats");
Console.WriteLine("Enter a number:");
userInputFloat = float.Parse(Console.ReadLine());
Console.WriteLine("Enter another number:");
userInputFloat2 = float.Parse(Console.ReadLine());
userInputFloatTotal = userInputFloat * userInputFloat2;
Console.WriteLine("The product is " + userInputFloatTotal);

//EXERCISE 1.6: Dividing Integers
Console.WriteLine("EXERCISE 1.6: Dividing Integers");
Console.WriteLine("Enter a number:");
userInputInt = int.Parse(Console.ReadLine());
Console.WriteLine("Enter another number:");
int userInputInt2 = int.Parse(Console.ReadLine());
int userInputIntTotal = userInputInt / userInputInt2;
Console.WriteLine("The result is " + userInputIntTotal);

// EXERCISE 1.7: Entering booleans
Console.WriteLine("EXERCISE 1.7: Entering booleans");
Console.WriteLine("Enter a boolean:");
bool userInputBool = bool.Parse(Console.ReadLine());
Console.WriteLine("You entered: " + userInputBool);
Console.WriteLine("The opposite of what you entered is " + !userInputBool);

/* 1/24/24 Class Work
 * - Going over git version control and git flow 
 - Starting w/ loops, switches, and conditionals
- You have to have a break statement after switch cases
- You should always have a  default at the end of a switch so that input doesn't break your code
- */

// Going through if loops

int i = 0;

int age = 12;

if (age < 13)
{
    Console.WriteLine("You are a child");
}
else if (age < 18)
{
    Console.WriteLine("You are a teenager");
} 
else
{
    Console.WriteLine("You are an adult");
}

Console.Write("What ais the game score");
int gameScore = int.Parse(Console.ReadLine());

if (gameScore >= 90)
{
    Console.WriteLine("Good job!");
}
else if (gameScore >= 70)
{
    Console.WriteLine("You gotta do better than that!");
}
else
{
    Console.WriteLine("You suck");
}

Console.WriteLine("New Message");

int dayNumber = 3;

switch (dayNumber)
{
    case 1:
        Console.WriteLine("Monday");
        break;
    case 2:
        Console.WriteLine("Tuesday");
        break;
    case 3:
        Console.WriteLine("Wednesday");
        break;
    case 4:
        Console.WriteLine("Thursday");
        break;
    case 5:
        Console.WriteLine("Friday");
        break;
    case 6:
        Console.WriteLine("Saturday");
        break;
    case 7:
        Console.WriteLine("Sunday");
        break;
    default:
        Console.WriteLine("That's not a day of the week");
        break;
}

Console.WriteLine("Select an option:\n 1.Play \n 2.Settings \n 3.Exit");
int option = int.Parse(Console.ReadLine());
// int option = int.Parse(userInput);

switch (option)
{
    case 1:
        Console.WriteLine("Starting game...");
        break;
    case 2:
        Console.WriteLine("Settings for the game are very complicated...");
        break;
    case 3:
        Console.WriteLine("Exiting game...");
        break;
    default:
        break;
}
Console.WriteLine("How are you feeling today ?");
// Fix Me userInput = Console.ReadLine(); //Bad

/* FIX MEE switch(userInput.ToLower().Trim())
{
    case "bad":
    case "sad":
    case "unhappy":
        Console.WriteLine("I'm sorry you aren't feeling great.");
        break;
    case "good":
    case "great":
    case "happy":
        Console.WriteLine("I'm happy you feel that way");
        break;
    default:
        Console.WriteLine("That's not a valid feeling.");
        break;
}
*/

for(i = 0; i < 10; i++)
{
    Console.WriteLine("Loop iteration {i}");
//i++ happens
}

for (i = 10; i> 0; i--)
{
    Console.WriteLine($"Loop interation{i}");
}


for (i = 0; i < 20; i += 2);
{
    Console.WriteLine($"Loop iteration " + i);
}

int number = int.Parse(Console.ReadLine());

for (i = 1; i<= number; i+=2)
{
    Console.WriteLine($"Loop iteration {i}");
}

for (int firstNumber = 1; firstNumber <=10; firstNumber++)
{
    Console.WriteLine($"Table for {firstNumber}");
    
    for (int secondNumber = 1; secondNumber <=10; secondNumber++)
    {
        Console.Write($"{firstNumber}*{secondNumber}");
        Console.WriteLine($"{firstNumber + secondNumber}");
    }
    Console.WriteLine();
}
Console.ReadKey();