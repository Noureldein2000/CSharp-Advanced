// See https://aka.ms/new-console-template for more information
using C__Advanced.Generics;
using C__Advanced.LINQ;

Console.WriteLine("Hello, World of Generics!\n");


var genericList = new GenericList<string, double>();
genericList.add("1");
genericList.add("2");
genericList.add("3");
genericList.remove("1");

Console.WriteLine($"count of items is {genericList.CountItem}\n");
Console.WriteLine($"Sum of T2 {genericList.Sum(2, 4)}");
Console.WriteLine($"Sum of T2 {genericList.Sum(2.3, -4)}");
Console.WriteLine($"Sum of T2 {genericList.Sum(2.3, 39.2)}");


var genericList2 = new GenericList2<Person>();

//------------------------------------- LINQ -------------------------------------
var student = new Student<int>();
student.addId(66);
student.addId(24);


Console.WriteLine($"print ids of student greater than 3 this is called (Deffered Execution)\n");
foreach (var std in student.Ids.Where(x => x > 18).ToList())
{
    Console.Write(std + ",");
}

Console.WriteLine($"print ids  sorted of student (Deffered Execution)\n");
foreach (var std in student.SortedIds(true))
{
    Console.Write(std + ",");
}

Console.WriteLine($"print ids  sorted Reversed of student (Deffered Execution)\n");
foreach (var std in student.IdsReverse())
{
    Console.Write(std + ",");
}