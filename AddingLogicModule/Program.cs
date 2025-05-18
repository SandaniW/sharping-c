/* 
   have declare var out of the local scope so that it can be accessed
   both locally and globally. 
   if we declare inside locally it cannot be accesed outside the scope
*/
bool flag = true;
int value = 22;
if (flag)
{
   Console.WriteLine($"You will be {value} this year! You can do this");
}
value = 21;
Console.WriteLine($"You are still {value}! You did well");
/*
   writing if statements without codeblocks(for one liners). Reduce keystrokes but with good readability
*/
Console.WriteLine("\n");
bool check = true;
if (check)
   Console.WriteLine(check);
/*
   challenge activity
*/
Console.WriteLine("\n");
int[] numbers = { 4, 8, 15, 16, 23, 42 };
int total = 0;
bool found = false;
foreach (int number in numbers)
{
   total += number;

   if (number == 42)
   {
      found = true;

   }

}

if (found)
{
   Console.WriteLine("Set contains 42");

}

Console.WriteLine($"Total: {total}");
/*
   Evaluate expressions
*/

Console.WriteLine("\n");
Console.WriteLine("a" == "a");
Console.WriteLine("a" == "A");
Console.WriteLine(1 == 2);

string myValue = "a";
Console.WriteLine(myValue == "a");
//Trim-> removes trailing blanck spaces
// ToLower() & ToUpper() changes letter case
string value1 = " a";
string value2 = "A ";
Console.WriteLine(value1.Trim().ToLower() == value2.Trim().ToLower());

string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(pangram.Contains("fox"));
Console.WriteLine(pangram.Contains("cow"));

//negation
string pangram = "The quick brown fox jumps over the lazy dog.";
Console.WriteLine(!pangram.Contains("fox"));
Console.WriteLine(!pangram.Contains("cow"));

/*
    conditional operator
*/
int saleAmount = 1001;
int discount = saleAmount > 1000 ? 100 : 50;
Console.WriteLine($"Discount: {discount}");

//inline
int saleAmount = 1001;
// int discount = saleAmount > 1000 ? 100 : 50;

Console.WriteLine($"Discount: {(saleAmount > 1000 ? 100 : 50)}");

//coin flip
Random coin = new Random();
Console.WriteLine((coin.Next(0, 2) == 0) ? "heads" : "tails");

/*
 switch case
*/
Console.WriteLine("\n");
int employeeLevel = 100;
string employeeName = "John Smith";

string title = "";

switch (employeeLevel)
{
    case 100:
    case 200:
        title = "Senior Associate";
        break;
    case 300:
        title = "Manager";
        break;
    case 400:
        title = "Senior Manager";
        break;
    default:
        title = "Associate";
        break;
}

Console.WriteLine($"{employeeName}, {title}");
/*
   using while and do while
*/
Console.WriteLine("\n");
Random random = new Random();
int current = random.Next(1, 11);
/*
do
{
    current = random.Next(1, 11);

    if (current >= 8) continue;

    Console.WriteLine(current);
} while (current != 7);
*/
while (current >= 3)
{
    Console.WriteLine(current);
    current = random.Next(1, 11);
}
Console.WriteLine($"Last number: {current}");
/*
   hero monster battle game - challenge
*/
Console.WriteLine("\n");
int hero = 10;
int monster = 10;

Random dice = new Random();

do
{
    int roll = dice.Next(1, 11);
    monster -= roll;
    Console.WriteLine($"Monster was damaged and lost {roll} health and now has {monster} health.");

    if (monster <= 0) continue;

    roll = dice.Next(1, 11);
    hero -= roll;
    Console.WriteLine($"Hero was damaged and lost {roll} health and now has {hero} health.");

} while (hero > 0 && monster > 0);

Console.WriteLine(hero > monster ? "Hero wins!" : "Monster wins!");