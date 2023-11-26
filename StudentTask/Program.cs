// See https://aka.ms/new-console-template for more information
using StudentTask.Models;
using System.Text.RegularExpressions;
using Group = StudentTask.Models.Group;

Console.WriteLine("Hello, World!");


// Adding students to the group
Group group = new Group("AB123", 10); 

Student student1 = new Student("nicat", 25);
Student student2 = new Student("qabil", 25);

group.AddStudent(student1);
group.AddStudent(student2);
Student[] allStudents = group.GetAllStudents();

foreach (var student in allStudents)
{
    if (student != null)
    {
        Console.WriteLine($"Name {student.FulllName} Point {student.Point}");
    }
}

Student OneStudent = group.GetStudent(2);
if(OneStudent != null)
{
    Console.WriteLine($"Name: {OneStudent.FulllName} Point: {OneStudent.Point}");
}
else
{
    Console.WriteLine("telebe tapilmayib");
}

Student student3 = new("KAMIL", 3);
group.AddStudent(student3);

string newGroupNo = "AB123";
if (group.CheckGroupNo(newGroupNo))
{
    group.GroupNo = newGroupNo;
    Console.WriteLine($"Group  {group.GroupNo}");
}
else
{
    Console.WriteLine("bilinmeyen nomre");
}