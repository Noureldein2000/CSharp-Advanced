// See https://aka.ms/new-console-template for more information
using C__Advanced.Generics;
using C__Advanced.LINQ;
using C__Advanced.Operator_Overloading;
using System.Drawing;
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

Console.WriteLine("--------------------- Linq Join and Grouping ------------------");
var manageLINQ = new ManageLINQ();
Console.WriteLine("Get Employees With Dept using JOIN \n ");
foreach (var item in manageLINQ.GetEmployeeWithDeptJOIN())
{
    Console.WriteLine(item);

}
Console.WriteLine("------------");
Console.WriteLine("Get Employees With Dept using Grouping with Join \n ");
foreach (var item in manageLINQ.GetEmployeeWithDeptGrouping())
{
    var employess = string.Join(", ", item.Select(x => x.Name).ToList());
    Console.WriteLine($"{item.Key} : {employess}");
}

Console.WriteLine("------------");
Console.WriteLine("Get Employees With Dept using Method  GroupJoin \n ");
var groupJoinTuples = manageLINQ.GetEmployeeWithDeptGroupJoin().ToList();
foreach (var tuple in groupJoinTuples)
{
    var employeeNames = string.Join(", ", tuple.Item2.Select(x => x.Name).ToList());
    Console.WriteLine($"{tuple.Item1} : {employeeNames}");
}
Console.WriteLine("--------------------- Operator Overloading ------------------");
var p1 = new CustomPoint(50, 100);
var p2 = new CustomPoint(30, 120);
var p3 = p1 + p2;
Console.WriteLine($"p3 = {p3.X}{p3.Y}");
var p4 = p2 - p1;
Console.WriteLine($"p4 = {p4.X}{p4.Y}");

Console.WriteLine($"p1 > p2 ?({p1 > p2})");

Console.WriteLine($"p1 < p2 ?({p1 < p2})");

Console.WriteLine($"p1 == p2 ?({p1 == p2})");

CustomPoint p = (CustomPoint)5;
int x = new CustomPoint(6, 7);


