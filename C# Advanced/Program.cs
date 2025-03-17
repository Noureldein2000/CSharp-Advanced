// See https://aka.ms/new-console-template for more information
using C__Advanced.Generics;

Console.WriteLine("Hello, World of Generics!\n");


var genericList = new GenericList<string,double>();
genericList.add("1");
genericList.add("2");
genericList.add("3");
genericList.remove("1");

Console.WriteLine($"count of items is {genericList.CountItem}\n");
Console.WriteLine($"Sum of T2 {genericList.Sum(2,4)}");
Console.WriteLine($"Sum of T2 {genericList.Sum(2.3,-4)}");
Console.WriteLine($"Sum of T2 {genericList.Sum(2.3,39.2)}");


var genericList2 = new GenericList2<Person>();
