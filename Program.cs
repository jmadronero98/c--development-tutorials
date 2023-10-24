// Random dice = new Random();
// int roll1 = dice.Next();
// int roll2 = dice.Next(101);
// int roll3 = dice.Next(50, 101);

// Console.WriteLine($"First roll: {roll1}");
// Console.WriteLine($"Second roll: {roll2}");
// Console.WriteLine($"Third roll: {roll3}");

// int firstValue = 500;
// int secondValue = 600;
// int largerValue = Math.Max(firstValue,secondValue);
// Console.WriteLine(largerValue);

// Random dice = new Random();

// int roll1 = dice.Next(1, 7);
// int roll2 = dice.Next(1, 7);
// int roll3 = dice.Next(1, 7);

// int total = roll1 + roll2 + roll3;

// Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

// if (total > 14) {
//     Console.WriteLine("You win!");
// }

// if (total < 15) {
//     Console.WriteLine("You Lose!");
// }


// string message = "The quick brown fox jumps over the lazy dog.";
// bool result = message.Contains("dog");
// Console.WriteLine(result);

// if(message.Contains("fox")) {
//     Console.WriteLine("What does the fox say?");
// }

// string[] studentNames = new string[] {"Sophia", "Andrew", "Emma", "Logan"};
// double[] assignmentScores = new double[] {95.6, 91.6, 89.2, 93};

// Console.WriteLine("Student\t\tGrade\tLetter\tGrade");

// int iteration = 0;
// foreach (string studentName in studentNames) {

//     string currentStudentLetterGrade="";
//     double currentStudentGrade = assignmentScores[iteration];
    
//     if (currentStudentGrade >= 97) {
//         currentStudentLetterGrade = "A+";
//     } else if (currentStudentGrade >= 93) {
//         currentStudentLetterGrade = "A";

//     }else if (currentStudentGrade >= 90){
//         currentStudentLetterGrade = "A-";

//     }else if (currentStudentGrade >= 87){
//         currentStudentLetterGrade = "B+";

//     }else if (currentStudentGrade >= 83){
//         currentStudentLetterGrade = "B";

//     }else if (currentStudentGrade >= 80){
//         currentStudentLetterGrade = "B-";

//     }else if (currentStudentGrade >= 77){
//         currentStudentLetterGrade = "C+";

//     }else if (currentStudentGrade >= 73){
//         currentStudentLetterGrade = "C";

//     }else if (currentStudentGrade >= 70){
//         currentStudentLetterGrade = "C-";

//     }else if (currentStudentGrade >= 67){
//         currentStudentLetterGrade = "D+";

//     }else if (currentStudentGrade >= 63){
//         currentStudentLetterGrade = "D";

//     }else (currentStudentGrade >= 60){
//         currentStudentLetterGrade = "D-";
//     }

//     Console.WriteLine($"{studentName}\t\t{currentStudentGrade}\t{currentStudentLetterGrade}");

//     iteration++;
// }

// Random random = new Random();
//     int randomValue = random.
// Random random = new Random();
// int randomValue = random.Next(0,2);
// Console.WriteLine(randomValue==0 ? "tail" :"head");

// string permission = "Admin|Manager";
// int level = 55;

// if(permission.Contains("Admin")) { 
//   if (level > 55) {  
//     Console.WriteLine("Welcome, Super Admin User");
//   } else {
//     Console.WriteLine("Welcome, Admin User");
//   }
// } else if (permission.Contains("Manager")) {
//     if (level >= 20) {
//     Console.WriteLine("Contact an Admin for access");
//     } else {
//     Console.WriteLine("You do not have sufficient privileges");
//     }
// } else {
//     Console.WriteLine("You do not have sufficient privileges.");
// }

// bool flag = true;
// if (flag)
// {
//     int value = 10;
//     Console.WriteLine("Inside of code block: " + value);
// }
// Console.WriteLine($"Outside of code block: {value}");

// int firstInteger = 5;

// if(firstInteger > 0) {
//     int secondVariable = 6;
//     int sum = firstInteger + secondVariable;
// }
//     Console.WriteLine(firstInteger);

// bool flag = true;
// if (flag)
//     Console.WriteLine(flag);

// int[] numbers = { 4, 8, 15, 16, 23, 42 };
// bool found = false;
// int total = 0;

// foreach (int number in numbers) {

//     total += number;

//     if (number == 42)
//     {
//        found = true;

//     }

// }

// if (found) {
//     Console.WriteLine("Set contains 42");

// }

// Console.WriteLine($"Total: {total}");
// int firstInteger = 1;
// if(firstInteger > 0) {
//     int secondInteger = 8;
//     firstInteger += secondInteger;
// }
// Console.WriteLine()

// string sku = "01-MN-L";

// string[] product = sku.Split('-');

// foreach(string prod in product) {
//     Console.WriteLine(prod);
// }

// for (int x=10; x>=0; x--) {
//     Console.WriteLine(x);
// }

// for(int i = 1; i <=100;i++) {

//     if((i%3==0) && (i%5==0)) {
//         Console.WriteLine($"{i} FizzBuzz");
//     } else if (i%3==0) {
//         Console.WriteLine($"{i} Fizz");
//     } else if (i%5==0) {
//         Console.WriteLine($"{i} Buzz");
//     } else {
//         Console.WriteLine(i);
//     }
// }

// Random random = new Random();
// int current = 0;

// do
// {
//     current = random.Next(1, 11);
//     Console.WriteLine(current);
// } while (current != 7);

// int monster = 10;
// int hero = 10;
// bool isHero = true;
// bool isMonster = false;
// Random random = new Random();
// while(monster > 0){
//     int minusPoints = random.Next(1,11); 
//     //Console.WriteLine($"Minus points is: {minusPoints}");  
//     if(isHero) {
//         monster -= minusPoints;
//         Console.WriteLine($"Monster was damaged and lost {(10-monster)} and now has a {monster} health.");
//         isHero = false;
//         isMonster = true;
//     } else if (isMonster){
//         hero -=minusPoints;
//         Console.WriteLine($"Hero was damaged and lost {(10-hero)} and now has a {hero} health.");
//         isHero = true;
//         isMonster = false;
//     }

//     if(monster <= 0) {
//         Console.WriteLine("Hero Wins!");
//         break;
//     } else if (hero <= 0){
//         Console.WriteLine("Monster Wins!");
//         break;
//     }
// }

// Revised
// int hero = 10;
// int monster = 10;

// Random dice = new Random();

// do
// {
//     int roll = dice.Next(1, 11);
//     monster -= roll;
//     Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

//     if (monster <= 0) continue;

//     roll = dice.Next(1, 11);
//     hero -= roll;
//     Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

// } while (hero > 0 && monster > 0);

// Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");


// string? readResult;
// Console.WriteLine("Enter a string:");
// do {
//     readResult = Console.ReadLine();
// } while (readResult == null);

// string? readResult;
// string valueEntered = "";
// int numValue = 0;
// bool validNumber = false;

// Console.WriteLine("Enter an integer value between 5 and 10");

// do
// {
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         valueEntered = readResult;
//     }

//     validNumber = int.TryParse(valueEntered, out numValue);

//     if (validNumber == true)
//     {
//         if (numValue <= 5 || numValue >= 10)
//         {
//             validNumber = false;
//             Console.WriteLine($"You entered {numValue}. Please enter a number between 5 and 10.");
//         }
//     }
//     else 
//     {
//         Console.WriteLine("Sorry, you entered an invalid number, please try again");
//     }
// } while (validNumber == false);

// Console.WriteLine($"Your input value ({numValue}) has been accepted.");

// readResult = Console.ReadLine();

// string? readResult;
// string roleName = "";
// bool validEntry = false;

// do
// {                
//     Console.WriteLine("Enter your role name (Administrator, Manager, or User)");
//     readResult = Console.ReadLine();
//     if (readResult != null) 
//     {
//         roleName = readResult.Trim();
//     }

//     if (roleName.ToLower() == "administrator" || roleName.ToLower() == "manager" || roleName.ToLower() == "user") 
//     {
//         validEntry = true;
//     }
//     else
//     {
//         Console.Write($"The role name that you entered, \"{roleName}\" is not valid. ");
//     }

// } while (validEntry == false);

// Console.WriteLine($"Your input value ({roleName}) has been accepted.");
// readResult = Console.ReadLine();

// string[] myStrings = new string[2] { "I like pizza. I like roast chicken. I like salad", "I like all three of the menu choices" };
// int stringsCount = myStrings.Length;

// string myString = "";
// int periodLocation = 0;

// for (int i = 0; i < stringsCount; i++)
// {
//     myString = myStrings[i];
//     Console.WriteLine($"myString {myString}");
//     Console.WriteLine($"stringsCount {stringsCount}");
//     periodLocation = myString.IndexOf(".");
//     Console.WriteLine($"periodLocation {periodLocation}");

//     string mySentence;

//     // extract sentences from each string and display them one at a time
//     while (periodLocation != -1)
//     {

//         // first sentence is the string value to the left of the period location
//         mySentence = myString.Remove(periodLocation);
//         Console.WriteLine($"mySentence {mySentence}");

//         // the remainder of myString is the string value to the right of the location
//         myString = myString.Substring(periodLocation + 1);
//         Console.WriteLine($"myString1 {myString}");

//         // remove any leading white-space from myString
//         myString = myString.TrimStart();
//         Console.WriteLine($"myString2 {myString}");

//         // update the comma location and increment the counter
//         periodLocation = myString.IndexOf(".");
//         Console.WriteLine($"periodLocation2 {periodLocation}");

//        //Console.WriteLine(mySentence);
//         Console.WriteLine($"mySentence2 {mySentence}");
//     }
 
//     mySentence = myString.Trim();
//     Console.WriteLine($"mySentence3 {mySentence}");

//     Console.WriteLine(mySentence);
//     Console.WriteLine($"mySentence4 {mySentence}");
// }

// string[][] jaggedArray = new string[][]
// {
//     new string[] { "one1", "two1", "three1", "four1", "five1", "six1" },
//     new string[] { "one2", "two2", "three2", "four2", "five2", "six2" },
//     new string[] { "one3", "two3", "three3", "four3", "five3", "six3" },
//     new string[] { "one4", "two4", "three4", "four4", "five4", "six4" },
//     new string[] { "one5", "two5", "three5", "four5", "five5", "six5" },
//     new string[] { "one6", "two6", "three6", "four6", "five6", "six6" },
//     new string[] { "one7", "two7", "three7", "four7", "five7", "six7" },
//     new string[] { "one8", "two8", "three8", "four8", "five8", "six8" }
// };

// foreach (string[] array in jaggedArray)
// {
//     foreach (string value in array)
//     {
//         Console.WriteLine(value);
//     }
//     Console.WriteLine();
// }

// Console.WriteLine("Signed integral types:");

// Console.WriteLine($"sbyte  : {sbyte.MinValue} to {sbyte.MaxValue}");
// Console.WriteLine($"short  : {short.MinValue} to {short.MaxValue}");
// Console.WriteLine($"int    : {int.MinValue} to {int.MaxValue}");
// Console.WriteLine($"long   : {long.MinValue} to {long.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Unsigned integral types:");

// Console.WriteLine($"byte   : {byte.MinValue} to {byte.MaxValue}");
// Console.WriteLine($"ushort : {ushort.MinValue} to {ushort.MaxValue}");
// Console.WriteLine($"uint   : {uint.MinValue} to {uint.MaxValue}");
// Console.WriteLine($"ulong  : {ulong.MinValue} to {ulong.MaxValue}");

// Console.WriteLine("");
// Console.WriteLine("Floating point types:");
// Console.WriteLine($"float  : {float.MinValue} to {float.MaxValue} (with ~6-9 digits of precision)");
// Console.WriteLine($"double : {double.MinValue} to {double.MaxValue} (with ~15-17 digits of precision)");
// Console.WriteLine($"decimal: {decimal.MinValue} to {decimal.MaxValue} (with 28-29 digits of precision)");

// int value = (int)1.5m; // casting truncates
// Console.WriteLine(value);

// int value2 = Convert.ToInt32(1.5m); // converting rounds up
// Console.WriteLine(value2);

// string value = "102";
// int result = 0;
// if (int.TryParse(value, out result))
// {
//     Console.WriteLine($"Measurement: {result}");
// }
// else
// {
//     Console.WriteLine("Unable to report the measurement.");
// }

// string[] pallets = { "B14", "A11", "B12", "A13" };

// Console.WriteLine("Sorted...");
// Array.Sort(pallets);
// foreach (var pallet in pallets)
// {
//     Console.WriteLine($"-- {pallet}");
// }

// this is an example of composite formatting

// string first = "Hello";
// string second = "World";
// string result = string.Format("{0} {1}!", first, second);
// Console.WriteLine(result);

// string first = "Hello";
// string second = "World";
// Console.WriteLine("{1} {0}!", first, second);
// Console.WriteLine("{0} {0} {0}!", first, second);

// //this is an example of string interpolation
// string first = "Hello";
// string second = "World";
// Console.WriteLine($"{first} {second}!");
// Console.WriteLine($"{second} {first}!");
// Console.WriteLine($"{first} {first} {first}!");

// //this is an example of formatting currency
// decimal price = 123.45m;
// int discount = 50;
// Console.WriteLine($"Price: {price:C} (Save {discount:C})");

// //this is an example of formatting numbers
// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N} units");

// decimal measurement = 123456.78912m;
// Console.WriteLine($"Measurement: {measurement:N4} units");

// //this is an example of formatting percentage
// decimal tax = .36785m;
// Console.WriteLine($"Tax rate: {tax:P2}");
// Tax rate: 36.79 %

// //combination approaches
// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// Console.WriteLine(yourDiscount);

// decimal price = 67.55m;
// decimal salePrice = 59.99m;
// string yourDiscount = String.Format("You saved {0:C2} off the regular {1:C2} price. ", (price - salePrice), price);
// yourDiscount += $"A discount of {((price - salePrice)/price):P2}!"; //inserted
// Console.WriteLine(yourDiscount);

// explore string interpolation
// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");

// output
// Invoice Number: 1201
// Shares: 25.457 Product
//     Sub Total: $2,750.00
//         Tax: 15.83 %


// other example
// Console.WriteLine($"     Total Billed: {total:C}");

// int invoiceNumber = 1201;
// decimal productShares = 25.4568m;
// decimal subtotal = 2750.00m;
// decimal taxPercentage = .15825m;
// decimal total = 3185.19m;

// Console.WriteLine($"Invoice Number: {invoiceNumber}");
// Console.WriteLine($"   Shares: {productShares:N3} Product");
// Console.WriteLine($"     Sub Total: {subtotal:C}");
// Console.WriteLine($"           Tax: {taxPercentage:P2}");
// Console.WriteLine($"     Total Billed: {total:C}");

// //output
// Invoice Number: 1201
//    Shares: 25.457 Product
//      Sub Total: $2,750.00
//            Tax: 15.83%
//      Total Billed: $3,185.19

// other example
// string customerName = "Ms. Barros";

// string currentProduct = "Magic Yield";
// int currentShares = 2975000;
// decimal currentReturn = 0.1275m;
// decimal currentProfit = 55000000.0m;

// string newProduct = "Glorious Future";
// decimal newReturn = 0.13125m;
// decimal newProfit = 63000000.0m;

// Console.WriteLine($"Dear {customerName},");
// Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
// Console.WriteLine($"Currently, you own {currentShares:N} shares at a return of {currentReturn:P}.\n");
// Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P}.  Given your current volume, your potential profit would be {newProfit:C}.\n");

// Console.WriteLine("Here's a quick comparison:\n");

// string comparisonMessage = "";

// comparisonMessage = currentProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", currentReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", currentProfit).PadRight(20);

// comparisonMessage += "\n";
// comparisonMessage += newProduct.PadRight(20);
// comparisonMessage += String.Format("{0:P}", newReturn).PadRight(10);
// comparisonMessage += String.Format("{0:C}", newProfit).PadRight(20);

// Console.WriteLine(comparisonMessage);


/*
if ipAddress consists of 4 numbers
and
if each ipAddress number has no leading zeroes
and
if each ipAddress number is in range 0 - 255

then ipAddress is valid

else ipAddress is invalid
*/

// string[] ipv4Input = {"107.31.1.5", "255.0.0.255", "555..0.555", "255...255"};
// string[] address;
// bool validLength = false;
// bool validZeroes = false;
// bool validRange = false;

// //int counter = 0;
// foreach (string ip in ipv4Input) {
//     address = ip.Split(".", StringSplitOptions.RemoveEmptyEntries);

//     //Console.WriteLine($"this is the address: {address[counter]}");

//     ValidateLength(); 
//     ValidateZeroes(); 
//     ValidateRange();

//     if (validLength && validZeroes && validRange) 
//     {
//         Console.WriteLine($"{ip} is a valid IPv4 address");
//     } 
//     else 
//     {
//         Console.WriteLine($"{ip} is an invalid IPv4 address");
//     }
//     //counter++;
// }

// void ValidateLength() {
//     validLength = address.Length == 4 ? true : false;
// }

// void ValidateZeroes() 
// {
//     foreach (string number in address) 
//     {
//         if (number.Length > 1 && number.StartsWith("0")) 
//         {
//             validZeroes = false;
//             return;
//         }
//     }

//     validZeroes = true;
// }

// void ValidateRange() {
//     foreach (string number in address) 
//     {
//         if (int.Parse(number) > 255) 
//         {
//             validRange = false;
//             return;
//         }
//     }
//     validRange = true;
// }

// Random random = new Random();
// int luck = random.Next(100);

// string[] text = {"You have much to", "Today is a day to", "Whatever work you do", "This is an ideal time to"};
// string[] good = {"look forward to.", "try new things!", "is likely to succeed.", "accomplish your dreams!"};
// string[] bad = {"fear.", "avoid major decisions.", "may have unexpected outcomes.", "re-evaluate your life."};
// string[] neutral = {"appreciate.", "enjoy time with friends.", "should align with your values.", "get in tune with nature."};

// TellFortune();
// luck = random.Next(100);
// TellFortune();

// void TellFortune() 
// {
//     Console.WriteLine("A fortune teller whispers the following words:");
//     string[] fortune = (luck > 75 ? good : (luck < 25 ? bad : neutral));
//     for (int i = 0; i < 4; i++) 
//     {
//         Console.Write($"{text[i]} {fortune[i]} ");
//     }
// }

//USE VALUE AND REFERENCE TYPE PARAMETERS
// int a = 3;
// int b = 4;
// int c = 0;

// Multiply(a, b, c);
// Console.WriteLine($"global statement: {a} x {b} = {c}");

// void Multiply(int a, int b, int c) 
// {
//     c = a * b;
//     Console.WriteLine($"inside Multiply method: {a} x {b} = {c}");
// }
//--------------------------------------------------------------------------
// int[] array = {1, 2, 3, 4, 5};

// PrintArray(array);
// Clear(array);
// PrintArray(array);

// void PrintArray(int[] array) 
// {
//     foreach (int a in array) 
//     {
//         Console.Write($"{a} ");
//     }
// }

// void Clear(int[] array) 
// {
//     for (int i = 0; i < array.Length; i++) 
//     {
//         array[i] = 0;
//     }
// }

// string status = "Healthy";

// Console.WriteLine($"Start: {status}");
// SetHealth(status, false);
// Console.WriteLine($"End: {status}");

// void SetHealth(string status, bool isHealthy) 
// {
//     status = (isHealthy ? "Healthy" : "Unhealthy");
//     Console.WriteLine($"Middle: {status}");
// }

// string[] guestList = {"Rebecca", "Nadia", "Noor", "Jonte"};
// string[] rsvps = new string[10];
// int count = 0;

// //void RSVP(string name, int partySize, string allergies, bool inviteOnly) {
// void RSVP(string name, int partySize = 1, string allergies = "none", bool inviteOnly = true) {

// if (inviteOnly) {
//     bool found = false;
//     foreach (string guest in guestList) {
//         if (guest.Equals(name)) {
//             found = true;
//             break;
//         }
//     }
//     if (!found) {
//         Console.WriteLine($"Sorry, {name} is not on the guest list");
//         return;
//     }
// }

//     rsvps[count] = $"Name: {name}, \tParty Size: {partySize}, \tAllergies: {allergies}";
//     count++;
// }

// void ShowRSVPs() {
//     Console.WriteLine("\nTotal RSVPs:");
//     for (int i = 0; i < count; i++) {
//         Console.WriteLine(rsvps[i]);
//     }
// }

//RSVP(name: "Linh", partySize: 2, allergies: "none", inviteOnly: false); //used name arguments

// RSVP("Rebecca", 1, "none", true);
// RSVP("Nadia", 2, "Nuts", true);
// RSVP("Linh", 2, "none", false);
// RSVP("Tony", 1, "Jackfruit", true);
// RSVP("Noor", 4, "none", false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

//Declare optional parameters
// RSVP("Rebecca");
// RSVP("Nadia", 2, "Nuts");
// RSVP(name: "Linh", partySize: 2, inviteOnly: false);
// RSVP("Tony", allergies: "Jackfruit", inviteOnly: true);
// RSVP("Noor", 4, inviteOnly: false);
// RSVP("Jonte", 2, "Stone fruit", false);
// ShowRSVPs();

// double total = 0;
// double minimumSpend = 30.00;

// double[] items = {15.97, 3.50, 12.25, 22.99, 10.98};
// double[] discounts = {0.30, 0.00, 0.10, 0.20, 0.50};

// for (int i = 0; i < items.Length; i++)
// {
//     total += GetDiscountedPrice(i);
//     Console.WriteLine($"Total: {total}");
// }

// total -= TotalMeetsMinimum() ? 5.00 : 0.00;
// double totalMeetsMinum = TotalMeetsMinimum() ? 5.00 : 0.00;
// Console.WriteLine($"boolean: {totalMeetsMinum}");
// Console.WriteLine($"Total: {total}");

// Console.WriteLine($"Total: ${FormatDecimal(total)}");

// double GetDiscountedPrice(int itemIndex)
// {
//     return items[itemIndex] * (1 - discounts[itemIndex]);
// }

// bool TotalMeetsMinimum()
// {
//     return total >= minimumSpend;
// }

// string FormatDecimal(double input)
// {
//     return input.ToString().Substring(0, 5);
// }

// string ReverseWord(string word) {
//     Console.WriteLine(word.Length);
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//         Console.WriteLine(result);
//     }
//     return result;
// }

// ReverseWord("snake");

// string input = "there are snakes at the zoo";

// Console.WriteLine(input);
// Console.WriteLine(ReverseSentence(input));

// string ReverseSentence(string input) 
// {
//     string result = "";
//     string[] words = input.Split(" ");

//     foreach(string word in words) 
//     {

//         result += ReverseWord(word) + " ";
//     }
//     return result.Trim();
// }

// string ReverseWord(string word) 
// {
//     string result = "";
//     for (int i = word.Length - 1; i >= 0; i--) 
//     {
//         result += word[i];
//     }
//     return result;
// }

// Random random = new Random();

// Console.WriteLine("Would you like to play? (Y/N)");
// if (ShouldPlay()) 
// {
//     PlayGame();
// }

// bool ShouldPlay() 
// {
//     string response = Console.ReadLine();
//     return response.ToLower().Equals("y");
// }

// void PlayGame() 
// {
//     var play = true;

//     while (play) {
//         var target = GetTarget();
//         var roll = RollDice();

//         Console.WriteLine($"Roll a number greater than {target} to win!");
//         Console.WriteLine($"You rolled a {roll}");
//         Console.WriteLine(WinOrLose(roll, target));
//         Console.WriteLine("\nPlay again? (Y/N)");

//         play = ShouldPlay();
//     }
// }

// int GetTarget() 
// {
//     return random.Next(1, 6);
// }

// int RollDice() 
// {
//     return random.Next(1, 7);
// }

// string WinOrLose(int roll, int target) 
// {
//     if (roll > target) 
//     {
//         return "You win!";
//     }
//     return "You lose!";
// }

using System;

string[] pettingZoo = 
{
    "alpacas", "capybaras", "chickens", "ducks", "emus", "geese", 
    "goats", "iguanas", "kangaroos", "lemurs", "llamas", "macaws", 
    "ostriches", "pigs", "ponies", "rabbits", "sheep", "tortoises",
};

PlanSchoolVisit("School A");
PlanSchoolVisit("School B", 3);
PlanSchoolVisit("School C", 2);
PlanSchoolVisit("School C", 5);


void PlanSchoolVisit(string schoolName, int groups = 6) 
{
    RandomizeAnimals(); 
    string[,] group1 = AssignGroup(groups);
    Console.WriteLine(schoolName);
    PrintGroup(group1);
}

void RandomizeAnimals() 
{
    Random random = new Random();

    for (int i = 0; i < pettingZoo.Length; i++) 
    {
        int r = random.Next(i, pettingZoo.Length);

        string temp = pettingZoo[r];
        pettingZoo[r] = pettingZoo[i];
        pettingZoo[i] = temp;
    }
}

string[,] AssignGroup(int groups = 6) 
{
    string[,] result = new string[groups, pettingZoo.Length/groups];
    int start = 0;

    for (int i = 0; i < groups; i++) 
    {
        for (int j = 0; j < result.GetLength(1); j++) 
        {
            result[i,j] = pettingZoo[start++];
        }
    }

    return result;
}

void PrintGroup(string[,] groups) 
{
    for (int i = 0; i < groups.GetLength(0); i++) 
    {
        Console.Write($"Group {i + 1}: ");
        for (int j = 0; j < groups.GetLength(1); j++) 
        {
            Console.Write($"{groups[i,j]}  ");
        }
        Console.WriteLine();
    }
}