// See https://aka.ms/new-console-template for more information
using System.Collections;
Console.WriteLine("Hello, c#!");
//using net libraries
Random dice = new Random();
//Random dice = new(); -> simplified way of writign
int roll = dice.Next(1,7);

Console.WriteLine($"Dice No: {roll}");
//Math class methods
int firstN = 500;
int secondN = 600;
int largerValue = System.Math.Max(firstN,secondN);
Console.WriteLine(largerValue);

//decision logic - if
int roll1 = dice.Next(1,7);
int roll2 = dice.Next(1,7);
int roll3 = dice.Next(1,7);

int total  = roll+roll2+roll3;
Console .WriteLine($"{roll} + {roll2} + {roll3} = {total}");

if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
{
    if ((roll1 == roll2) && (roll2 == roll3))
    {
        Console.WriteLine("You rolled triples!  +6 bonus to total!");
        total += 6;
    }
    else
    {
        Console.WriteLine("You rolled doubles!  +2 bonus to total!");
        total += 2;
    }
    Console.WriteLine($"Your total including the bonus: {total}");
}

if (total >= 16)
{
    Console.WriteLine("You win a new car!");
}
else if (total >= 10)
{
    Console.WriteLine("You win a new laptop!");
}
else if (total == 7)
{
    Console.WriteLine("You win a trip for two!");
}
else
{
    Console.WriteLine("You win a kitten!");
}

//Arrays
String[] orderId = new String[3];
orderId[0] = "A123";
orderId[1] = "B456";
orderId[2] = "C789";
//orderId[3] = "D101"; order out of bounds
Console.WriteLine($"1st: {orderId[0]}");
Console.WriteLine($"2nd: {orderId[1]}");
Console.WriteLine($"3rd: {orderId[2]}");
orderId[0] = "E121";
Console.WriteLine($"1st(modified): {orderId[0]}");
string[] fraudulentOrderIDs = [ "A123", "B456", "C789" ];
//string[] fraudulentOrderIDs = { "A123", "B456", "C789" }; older syntax

Console.WriteLine($"There are {fraudulentOrderIDs.Length} orders.");

string[] names = { "Sandani", "Nulanga", "Dias","Wickramanayake" };
foreach (string name in names)
{
    Console.WriteLine(name);
}

int[] inventory = { 200, 450, 700, 175, 250 };
int sum = 0;
foreach (int items in inventory)
{
    sum += items;
}

Console.WriteLine($"We have {sum} items in inventory.");
//array calling for each
String[] checkOrders = ["B123","C234","A345","C15","B177","G3003","C235","B179"];
foreach (string checkOrder in checkOrders)
{
   if(checkOrder.StartsWith("B"))
   {
      Console.WriteLine(checkOrder);
   }
}