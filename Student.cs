using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfile
{
    public class Student
    {
        public Node head;
        public int count = 0;
        //public Student prev;
        // private tha ye
        //public Node current; // e bhi private hi tha


        public Student()
        {
            head = null;
            //current = head;
        }


        public void AddNode(string a, string b, string c, string d, string e, string f, string g)
        {
            if (head == null)
            {
                head = new Node(a, b, c, d, e, f,g);
                count++;
            }
            else
            {
                head.AddNode(a, b, c, d, e, f,g);
                count++;
            }
        }
        public int NodeCount()
        {
            return count;
        }
        //public void showProfile()
        //{
        //    //Console.WriteLine(studentID + name + department + semester + cgpa + campus);
        //    AddNode(studentID, name, department, semester, cgpa, campus);
        //}
        public void Print()
        {
            Console.WriteLine("\n EnrollmentID|      Name       |Department|Semester| CGPA | Campus | Attendance");
            if (head != null)
                head.Print();
        }
        public void Traverse(string x, ConsoleKeyInfo y)
        {
            Console.WriteLine("\n EnrollmentID|      Name       |Department|Semester| CGPA | Campus | Attendance");
            if (head != null)
                head.Traverse(x, y);
        }

        public void MarkAttendance(string a, string b)
        {
            Console.WriteLine("\nEnrollmentID|      Name       |Department|Semester| Attendance");
            if (head != null)
                head.MarkAttendance(a, b);
        }
        //string path = "C:/Users/Talal/Documents/Visual Studio 2015/Projects/StudentProfile/StudentProfile/bin/Debug/StudentProfile.txt";

        //public void SaveAttendance(string a, string b, string c, string d, string e, string f, string g)
        //{
        //    ReadFile read = new ReadFile(path);
        //    read.WriteFile();
        //}
    }
}
