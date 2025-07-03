/*
int first = 1;
string selected = "3";
//int result = first + selected; gives error cannot convert from string to int 
//cuz compilers do safe conversions
string result = first + selected;
Console.WriteLine(result);
*/
/*
int to decimal widening conversoin - nothing to lose - implicit conversion
int myInt = 3;
Console.WriteLine($"int: {myInt}");

decimal myDecimal = myInt;
Console.WriteLine($"decimal: {myDecimal}");
*/
/*
narrowing - explicit conversion
decimal myDecimal = 3.14m;
Console.WriteLine($"decimal: {myDecimal}");

int myInt = (int)myDecimal;
Console.WriteLine($"int: {myInt}");
*/
/*
decimal to float - narrowing
decimal myDecimal = 1.23456789m;
float myFloat = (float)myDecimal;

Console.WriteLine($"Decimal: {myDecimal}");
Console.WriteLine($"Float  : {myFloat}");
*/
/*
ToString method - found in most types

int num = 9;
string msg = num.ToString();
Console.WriteLine(msg);
*/
/* 
using Parse() method found in most data types
string num1 = "9";
string num2 = "10";

int sum = int.Parse(num1) + int.Parse(num2);
Console.WriteLine(sum);
TryParse() is a better method compared to Parse
*/
/*
using Convert class
string num1 = "9";
string num2 = "10";
int sum = Convert.ToInt32(num1) + Convert.ToInt32(num2);
Console.WriteLine(sum);
*/
/*
int truncates Convert rounds
decimal value = (int)2.5m;
decimal value2 = Convert.ToInt32(2.6m);
Console.WriteLine(value);
Console.WriteLine(value2);
int value3 = (int)1.5m; // casting truncates
Console.WriteLine(value3);

int value4 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value4);
*/
/*

//string weight = "60";
string weight = "hey sexy lady";
int result = 0;
if (int.TryParse(weight, out result))
{
   Console.WriteLine($"Weight is: {result}");
}
else
{
   Console.WriteLine("Couldn't get weight");
}
if (result > 0)
{
   Console.WriteLine($"New weight: {result-5}");
   
}
*/
/*
string[] values = { "12.3", "bell", "32", "hell" };
decimal total= 0m;
string msg = "";
foreach (string value in values)
{
   decimal number;
   if (decimal.TryParse(value, out number))
   {
      total += number;
   }
   else
   {
      msg += value;
   }
}
Console.WriteLine(msg);
Console.WriteLine(total);
*/
int value1 = 11;
decimal value2 = 6.2m;
float value3 = 4.3f;

// Your code here to set result1
// Hint: You need to round the result to nearest integer (don't just truncate)
int result1 = Convert.ToInt32(value1 / value2);
Console.WriteLine($"Divide value1 by value2, display the result as an int: {result1}");

// Your code here to set result2
decimal result2 = value2 / (decimal)value3;
Console.WriteLine($"Divide value2 by value3, display the result as a decimal: {result2}");

// Your code here to set result3
float result3 = value3 / value1;
Console.WriteLine($"Divide value3 by value1, display the result as a float: {result3}");