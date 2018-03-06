using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    public class ReadFile
    {
        public string studentID, name, department, semester, campus,attendance;
        public string cgpa;
        Student profile = new Student();
        public ReadFile(string path)
        {

            try
            {
                StreamReader obj = new StreamReader(path);

                string fileReader; string[] subFields; char splitter = ',';
                while ((fileReader = obj.ReadLine()) != null)
                {
                    subFields = fileReader.Split(splitter);
                    studentID = subFields[0];
                    name = subFields[1];
                    department = subFields[2];
                    semester = subFields[3];
                    cgpa = subFields[4];
                    campus = subFields[5];
                    attendance = subFields[6];

                    profile.AddNode(studentID, name, department, semester, cgpa, campus,attendance);
                    //showProfile();
                }
                //return "done";  // isko khatam krna pare ga I guess
                //return obj.ReadToEnd();
                obj.Close();
            }
            catch (IOException e)
            {
                Console.Write(e.Message);

            }
           // Console.WriteLine(profile.NodeCount());
           // profile.Print();

        }
       

        public void Print()
        {
            profile.Print();
        }
        public void MarkAttendance(string a, string b)
        {
            profile.MarkAttendance(a,b);
        }
        ConsoleKeyInfo choiceSearch;
        string search;
        public void searchStudent()
        {
            Console.Clear();
            Console.Write("\n\n\n\n\n\n\n\t\t\t       ");
            Console.WriteLine("Search The Student By:\n\n\t      (N)ame\t(E)nrollment\t(S)emester\t(D)epartment");// or bhi add ho sakte hain
            choiceSearch = Console.ReadKey(true);
            if (choiceSearch.Key == ConsoleKey.N)
            {
                Console.Write("\n\t\t Enter Name: _________________\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
                search = Console.ReadLine().ToUpper();
            }
            else if (choiceSearch.Key == ConsoleKey.E)
            {
                Console.Write("\n\t\t Enter EnrollmentID: _______________\b\b\b\b\b\b\b\b\b\b\b\b");
                search = Console.ReadLine().ToUpper();
            }
            else if (choiceSearch.Key == ConsoleKey.S)
            {
                Console.Write("\n\t\t Enter Semester: __\b\b\b");
                search = Console.ReadLine().ToUpper();
            }
            else if (choiceSearch.Key == ConsoleKey.D)
            {
                Console.Write("\n\tElectrical Engineering (EE)\t          Computer Engineering (CE)");
                Console.Write("\n\tSoftware Engineering (SE)\t          Information Technology (IT)");
                Console.Write("\n\tComputer Science (CS)\t                  Social Sciences (SS)");
                Console.Write("\n\n\n\t\t\t Enter Department: ___\b\b");
                search = Console.ReadLine().ToUpper();
            }
            else
            {
                Console.WriteLine("Sorry! Wrong Choice");
                searchStudent();
            }
            profile.Traverse(search, choiceSearch);
        }
        public void WriteFile(string q, string w, string e, string r, string t, string y, string u)
        {
            
            studentID = q;
            name = w;
            department = e;
            semester = r;
            cgpa = t;
            campus = y;
            attendance = u;
            // Program o = new Program();
            // o.
            string path = "C:/Users/Talal/Documents/Visual Studio 2015/Projects/StudentProfile/StudentProfile/bin/Debug/StudentProfile.txt";

            StreamWriter save = new StreamWriter(path);
           
            save.WriteLine(studentID + "," + name + "," + department + "," + semester + "," + cgpa + "," + campus + "," + attendance);
            save.AutoFlush = true;
        }
    }
}
