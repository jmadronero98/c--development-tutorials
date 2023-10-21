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

