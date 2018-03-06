using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfile
{
    public class Node
    {
        public Node next;

        public string studentId, studentName, studentDepartment, studentSemester, studentCgpa, studentCampus,studentAttendance;
        public Node(string a, string b, string c, string d, string e, string f,string g)
        {
            next = null;
            studentId = a;
            studentName = b;
            studentDepartment = c;
            studentSemester = d;
            studentCgpa = e;
            studentCampus = f;
            if (g == "1")
                studentAttendance = "Present";
            else if (g == "2")
                studentAttendance = "Absent";
            else if (g == "0")
                studentAttendance = "NotMarked";
        }
        public void AddNode(string a, string b, string c, string d, string e, string f, string g)
        {
            if (next == null)
            {
                next = new Node(a, b, c, d, e, f,g);
               

            }
            else
            {
                next.AddNode(a, b, c, d, e, f,g);

            }
        }
        
        public void Print()
        {
          //  Console.WriteLine("\n EnrollmentID|      Name       |Department|Semester| CGPA | Campus | Attendance");

            Console.WriteLine("     " + studentId + "     |      " + studentName + "      |    " + studentDepartment + "    |   " + studentSemester + "    |  " + studentCgpa + " |   " + studentCampus + "  | " + studentAttendance);
            if (next != null)
                next.Print();
        }

        public void Traverse(string x, ConsoleKeyInfo y)
        {
            if (y.Key == ConsoleKey.N)
            {
                if (x == (string)studentName)
                    Console.WriteLine("     " + studentId + "     |      " + studentName + "      |    " + studentDepartment + "    |   " + studentSemester + "    |  " + studentCgpa + " |   " + studentCampus + "  | " + studentAttendance);
            }
            else if (y.Key == ConsoleKey.E)
            {
                if (x == (string)studentId)
                    Console.WriteLine("     " + studentId + "     |      " + studentName + "      |    " + studentDepartment + "    |   " + studentSemester + "    |  " + studentCgpa + " |   " + studentCampus + "  | " + studentAttendance);
            }
            else if (y.Key == ConsoleKey.S)
            {
                if (x == (string)studentSemester)
                    Console.WriteLine("     " + studentId + "     |      " + studentName + "      |    " + studentDepartment + "    |   " + studentSemester + "    |  " + studentCgpa + " |   " + studentCampus + "  | " + studentAttendance);
            }
            else if (y.Key == ConsoleKey.D)
            {
                if(x == (string)studentDepartment)
                    Console.WriteLine("     " + studentId + "     |      " + studentName + "      |    " + studentDepartment + "    |   " + studentSemester + "    |  " + studentCgpa + " |   " + studentCampus + "  | " + studentAttendance);
            }
            if (next != null)
            {
                next.Traverse(x, y);
            }

        }
        public void MarkAttendance(string a, string b)
        {
            if(a ==(string)studentDepartment && b== (string)studentSemester)
            {
                Console.Write("    " + studentId + "   |      " + studentName + "      |    " + studentDepartment + "    |    " + studentSemester + "   | " + "(P)/(A)");
                Attendance();
                Console.Write(studentAttendance); 
            }
            if (next != null)
                next.MarkAttendance(a, b);
            Console.WriteLine("\n\n\t\t  Updating Attendance");
            SaveAttendance();
        }
        public void Attendance()
        {
            ConsoleKeyInfo attendance= Console.ReadKey(true);
            if (attendance.Key == ConsoleKey.P)
            {
                studentAttendance = "1";
            }
            else if (attendance.Key == ConsoleKey.A)
                studentAttendance = "2";
            else
            {
                Attendance();
            }

            Console.WriteLine("\n");
        }
        string path = "C:/Users/Talal/Documents/Visual Studio 2015/Projects/StudentProfile/StudentProfile/bin/Debug/StudentProfile.txt";

        public void SaveAttendance()
        {
            ReadFile read = new ReadFile(path);
            read.WriteFile(studentId,studentName,studentDepartment,studentSemester,studentCgpa,studentCampus,studentAttendance);
            if (next != null)
                SaveAttendance();
        }
    }

}
