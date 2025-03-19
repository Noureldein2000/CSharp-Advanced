// See https://aka.ms/new-console-template for more information
using C__Advanced.Generics;
using C__Advanced.LINQ;
using System.Threading.Channels;

Console.WriteLine("Hello, World of Generics!\n");
//Console.WriteLine("choose which topic need to be Applied? Generic/LINQ/");

var genericList = new GenericList<string, double>();
genericList.add("1");
genericList.add("2");
genericList.add("3");
genericList.remove("1");

Console.WriteLine($"count of items is {genericList.CountItem}\n");
Console.WriteLine($"Sum of T2 {genericList.Sum(2, 4)}");
Console.WriteLine($"Sum of T2 {genericList.Sum(2.3, -4)}");
Console.WriteLine($"Sum of T2 {genericList.Sum(2.3, 39.2)}\n");


var genericList2 = new GenericList2<Person>();

//------------------------------------- LINQ -------------------------------------
var student = new Student<int>();
student.addId(8);
student.addId(4);
student.addId(0);
student.addId(2);
student.addId(4);
student.addId(9);
student.addId(3);
student.addId(1);
student.addId(3);
student.addId(10);
student.addId(-5);

var listParitions = student.Ids.Distinct().ToList();
Console.WriteLine("parition list is");
listParitions.ForEach(d =>
{
    Console.Write(" " + d + "\n");
    Console.WriteLine("---------------------------------------");

});

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

