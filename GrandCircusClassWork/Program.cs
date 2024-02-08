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
using System.Globalization;
using System.Net.Security;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
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

/* 1/25/2024 Class Work */

string userInput = "";

bool continueLooping = true;

while(continueLooping == true)
{
    Console.WriteLine("Do you want to play again (yes/no)?");
    userInput = Console.ReadLine();

    switch(userInput.ToLower().Trim())
    {
        case "yes":
        case "y":
            Console.WriteLine("Great, I love playing games with you.");
            break;
        default:
            Console.WriteLine("You didn't say yes, so I'll see you later");
            continueLooping = false;
            break;
    }
}

while (userInput.ToLower().Trim() != "exit")
{
    Console.Write("Enter your age (type 'exit' to stop): ");
    userInput = Console.ReadLine();
    try
    {
        age = int.Parse(userInput);
        Console.WriteLine($"In 5 years, you will be {age + 5}.");
    }
    catch
    {
        if(userInput.ToLower().Trim() != "exit")
        {
            Console.WriteLine("You didn't enter an age");
        }
    }

}

bool playAgain;

do
{
    Console.WriteLine("This is the spot where we play our game. Isn't it fun");
    Console.WriteLine("Now our game is done");
    Console.WriteLine("Do you want to play again");
    playAgain = Console.ReadLine() == "y" ? true : false;
}
while (playAgain == true);

int hoursWorked;
double hourlyWage = 0.0;
bool isDataValid = true;

do
{
    Console.WriteLine("What is your hourly wage?");
    userInput = Console.ReadLine();
    try
    {
        hourlyWage = double.Parse(userInput);
    }
    catch (FormatException)
    {
        isDataValid = false;
    }

    if (isDataValid == true)
    {
        if (hourlyWage < 1) ;
        {
            isDataValid = false;
        }
    }
}
while (isDataValid == false);

while (isDataValid = true);

Console.WriteLine("Goodbye");

Console.ReadKey();
Environment.Exit(0);

/* 1/29/24 Class Work
 * - Going through learning methods today
 * - If you're copying and pasting code, it should be made into a method
 * - void means there's no return type
 * - static is optional but will be gone into detail later in the course
 * - You need to store values that get returned from calling methods
- */

//random number generator
Random randomGenerator = new();

int randomInteger = randomGenerator.Next();
int newRandomInteger = randomGenerator.Next(1, 11);
int diceRoll = randomGenerator.Next(1, 7);

Console.WriteLine(); //Takes no input (parameters), give no output (return value)
Console.ReadLine(); //Takes no input (has no parameters), give you the text that was entered (Returns string)
Console.WriteLine("something"); //Takes input (has parameter), no return value
age = int.Parse("53"); // has a parameter (expecting input), has a return type\

DisplayGreeting();
PrintNameAndAge("Scott", 35);
sum = CalculateSum(2, 5);

string userAge = "35";
int validInteger = GetValidInteger(userAge);
if (validInteger == -999)
{
    Console.WriteLine("You gave me a bad number");
}

Console.ReadKey();

//creating method
static void DisplayGreeting()
{
    Console.WriteLine("What's your name?");
    string userName = Console.ReadLine();
    Console.WriteLine($"Hello,{userName} welcome to my program!");
    Console.WriteLine($"How old are you, {userName}?");
    int userAge = GetValidInteger(Console.ReadLine());

    PrintNameAndAge(userName, userAge);
    Random randomGenerator = new();
    int computerAge = randomGenerator.Next(userAge + 1, 200);
    // FIX ME int ageDifference = CalculateDifference(computerAge, userAge);
    // FIX ME string message = CreateGreeting(userName, ageDifference);
    // FIX ME Console.WriteLine(message);
}

//Creating a method with two parameters
static void PrintNameAndAge (string name, int age)
{
    name = "Jeff";
    Console.WriteLine($"Your name is {name}. You are {age} years old.");
}

//creating method with 3 parameters
static void PrimtNameAndTitle(string name, string title)
{
    Console.WriteLine($"Your name is {name}, your title is {title}");
}

//creating method that returns a value
static int CalculateSum (int firstNumber, int secondNumber)
{
    int returnValue = firstNumber + secondNumber;
    return returnValue;
}

static int GetValidInteger(string stringToCheck)
{
    int returnValue = 0;
    try
    {
        returnValue = int.Parse(stringToCheck);
    }
    catch (FormatException)
    {
        returnValue = -999;
    }
    return returnValue;
}

static string CreatingGreeting(string name)
{
    return "$Hello,{ name }";
}

static int GetValidAge(string stringToCheck)
{
    int returnValue = 0;

    do
    {
        try
        {
            returnValue = int.Parse(stringToCheck);
        }
        catch (FormatException)
        {
            returnValue = -1;
        }

        if (returnValue == -1)
        {
            Console.WriteLine("That is not an integer value. Please enter another value");
            stringToCheck = Console.ReadLine();
        }
    }
    while (returnValue < -1);

    return returnValue;
}

//Unit 3
/* 2/7/2024 Class work */

//A dictionary is made up of elements
//Each element has 2 pieces of information: key and value

Dictionary<string, string> capitals = new()
{
    {"Japan","Tokyo" },
    {"Russia","Moscow" }
};
capitals.Add("France", "Paris");
capitals.Add("Italy", "Rome");

//The key for this dictionary is the student ID
Dictionary<int, string> studentNames = new();
studentNames.Add(12345, "Mattie D UC");
studentNames.Add(123456, "Test");

Dictionary<Guid, string> games = new();
games.Add(Guid.NewGuid(), "Name of the game");

Console.WriteLine("What is your birthdate (mm/dd/yyyy)"); // 01/23/1971
string input = Console.ReadLine();
string[] dateParts = input.Split("/");
int birthMonth = int.Parse(dateParts[0]);

Dictionary<int, string> months = new()
{
    {1,"January" },
    {2,"February" },
    {3,"March" },
    {4,"May" }
};

months.Remove(2);
Console.WriteLine($"Your were born in the month of {months[birthMonth]}");

Dictionary<string, int> lunchVotes = new()
{
    {"pizza", 0 },
    {"subs", 0 },
    {"burgers", 0}
};

Console.WriteLine("What's for lunch todat, here are the current votes:");

foreach(var item in lunchVotes)
{
    Console.WriteLine($"{item.Key} has {item.Value} votes.");
}

Console.WriteLine("Enter the item you want");
input = Console.ReadLine();

if (lunchVotes.Keys.Contains(input.ToLower())) ;
{
    lunchVotes[input.ToLower()]++;
}

Console.ReadKey();