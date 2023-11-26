using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace StudentTask.Models
{
    public class Group 

    {
        private Student[] students; 

        private string _GroupNo;
        private int _studentLimit;
        public int StudentLimit
        {
            get { return _studentLimit; }
            set {
                if(value >= 5 && value <= 18)
                {
                    _studentLimit = value;
                }
                else
                {
                    Console.WriteLine("student limit  bur araliqda olmalifir");
                }
            
            
            }
        }
        public string GroupNo { get {
                return _GroupNo;
            
            } set {
            
            if(CheckGroupNo(value))
                {
                    Console.WriteLine("duzdur");
                    _GroupNo = value;
                }
                else
                {
                    Console.WriteLine("sehvdir"); 
                }
            } }
        public Group(string groupNo, int studentLimit)
        {
            GroupNo = groupNo;
            StudentLimit = studentLimit;
            students = new Student[studentLimit]; // Initialize students array
        }

        //private Student[] Students()
        //{
        //    Student student = new("Nihad Ibadzade", 67);
        //    Student student1 = new("Teymur filankesov", 77);
        //    Student student2 = new("Kamil Memmedov", 87);
        //    Student student3 = new("Amin ehmmedli", 64);
        //    Student student4 = new("Kazim filankesov", 56);
        //    Student student5 = new("Ehmed Kazimov", 78);
        //    Student[] studens = { student, student1, student2, student3, student4, student5 };
        //    return studens;
        //}

        public Student[] GetAllStudents()
        {
            return  students;
        }
        public Student GetStudent(int id)
        {
            foreach(Student student in students)
            {
                if(student.Id == id)
                {
                    return student;
                }
            }
            return null;
        }
        public void AddStudent(Student student)
        {
            bool add=false;
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i] == null)
                {
                    students[i] = student;
                    add = true;
                    break;
                }
            }
            if(!add)
            {
                Console.WriteLine("student limit kecmisik");
            }
        }
        public bool CheckGroupNo(string groupNo)
        {
            string pattern = "^[A-Z]{2}\\d{3}$";


            Regex regex =new Regex(pattern);
            return regex.IsMatch(groupNo);
        }
    }
}
