// See https://aka.ms/new-console-template for more information
using System.Collections;
Console.WriteLine("Hello, c#!");
//using net libraries
Random dice = new Random();
//Random dice = new(); -> simplified way of writign
int roll = dice.Next(1,7);
Console.WriteLine(roll);