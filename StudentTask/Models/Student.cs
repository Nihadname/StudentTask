using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentTask.Models
{
    public class Student
    {
        private static int IdCounter { get; set; }
        public int Id { get; set; }
        public string FulllName { get; set; }
        public int Point { get; set; }

        public Student(string fullName,int point)
        {
            IdCounter++;
            Id = IdCounter;
            FulllName = fullName;
            Point = point;
            
        }
        public void StudentInfo()
        {
            Console.WriteLine($"id:{Id} fullName:{FulllName}point:{Point}");
        }
    }
}
