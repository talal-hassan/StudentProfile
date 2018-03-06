using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StudentProfile
{
    

    
   
    public class Display
    {
        public void MainScreen()
        {
            //Changing Console colors
            Console.Title = "Student Profile";
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();    // For implementing colors for whole of the console screen
                                //Console.WriteLine("\nThis is my first console application in C#");

            //Welcome Screen
            Console.WriteLine("\n\n\n\n\n\n\n\n");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%                STUDNET  PROFILE                %%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%     (L)og In    %%    (S)ign Up    %%    (H)elp    %%    (E)xit      %%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
        }
        public void LogIN()
        {
            
            Console.Write("--------------------------------------------------------------------------------");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%                STUDNET  PROFILE                %%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("-%%%% (C)reate %% (D)elete %% (S)earch %% (A)ttendence %% (V)iew %% (E)xit %%%%-");
            Console.Write("-%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%%-");
            Console.Write("--------------------------------------------------------------------------------");
        }
    }

   

    class Program
    {
        static void Main(string[] args)
        {
            string path1;
            path1 = args[0];
            Console.Write(path1);
            Display display = new Display();
            display.MainScreen();
            


            string path = "C:/Users/Talal/Documents/Visual Studio 2015/Projects/StudentProfile/StudentProfile/bin/Debug/StudentProfile.txt";
            //Login Screen
            ConsoleKeyInfo choice;
            choice = Console.ReadKey(true);
            if (choice.Key == ConsoleKey.L)
            {
                Console.Clear();
                Console.WriteLine("\n\n\n\n\n\n\n");
                Console.Write("\t\t\t      UserName: ________________\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b"); string user;
                user = Console.ReadLine();
                //user = "talal";
                Console.Write("\n\n\t\t\t      Password: ________________\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");//string pass = "111";

                string pass = "";
                ConsoleKeyInfo key;

                do
                {
                    key = Console.ReadKey(true);
                    // Backspace Should Not Work
                    if (key.Key != ConsoleKey.Backspace && key.Key != ConsoleKey.Enter)
                    {
                        pass += key.KeyChar;
                        Console.Write("*");
                    }
                    else
                    {
                        if (key.Key == ConsoleKey.Backspace && pass.Length > 0)
                        {
                            pass = pass.Substring(0, (pass.Length - 1));
                            Console.Write("\b \b");
                        }
                    }
                }
                // Stops Receving Keys Once Enter is Pressed
                while (key.Key != ConsoleKey.Enter);
                //Console.WriteLine();
                //Console.WriteLine(pass);
                Console.Clear();
                ReadFile reader;
                reader = new ReadFile(path);

                DateTime today = DateTime.Now;
                if (user == "talal" && pass == "111")
                {
                    Console.WriteLine("\n\n\n\n");
                    Console.Write("\t\t\t\t\t\t\t"+today);
                    Console.WriteLine("\t\t\t \t\t\t \t\t  Welcome " + user);
                    display.LogIN();
                    ConsoleKeyInfo choice1;
                    choice1 = Console.ReadKey(true);
                    if (choice1.Key == ConsoleKey.C)
                    {
                        NewStudent student = new NewStudent();
                    }
                    else if (choice1.Key == ConsoleKey.D)
                    {

                    }
                    else if (choice1.Key == ConsoleKey.S)
                    {
                        reader.searchStudent();
                        Console.WriteLine("\n\n\t\t\t  Show All Students(Y/N)");
                        ConsoleKeyInfo choice2 = Console.ReadKey(true);
                        if (choice2.Key == ConsoleKey.Y)
                        {
                            reader.Print();
                        }
                    }
                    else if (choice1.Key == ConsoleKey.A)
                    {
                        Console.Clear();
                        Console.Write("\n\t\t\t::::::  << ATTANDANCE >>  ::::::");
                        Console.Write("\n\n\t\t           Enter Department: ____\b\b\b\b");
                        string dept = Console.ReadLine().ToUpper();
                        Console.Write("\n\t\t             Enter Semester: ____\b\b");
                        string semester = Console.ReadLine().ToUpper();

                        reader.MarkAttendance(dept, semester);

                        // StreamWriter attendance = new StreamWriter("@:Attendance.txt");
                        Console.WriteLine("\n\t Attendance Marked");
                        Console.WriteLine(today);
                        //  reader.WriteFile();
                    }
                    // Console.WriteLine("CONGRATULATIONS");
                    else if (choice1.Key == ConsoleKey.E)
                        Environment.Exit(0);
                }
                else
                    Console.WriteLine("Sorry! Try Again");
            }
            Console.Read();
        }
    }
}
