using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentProfile
{
    public class NewStudent
    {
       public NewStudent()
        {
            //StreamWriter writer = new StreamWriter(args[0]); in order to make it dynamic.
            StreamWriter writer = new StreamWriter("C:/Users/Talal/Documents/Visual Studio 2015/Projects/StudentProfile/StudentProfile/bin/Debug/StudentProfile.txt", true);
            //writer.AutoFlush = true;
            Console.Clear();
            Console.Write("\n\tElectrical Engineering (EE)\t          Computer Engineering (CE)");
            Console.Write("\n\tSoftware Engineering (SE)\t          Information Technology (IT)");
            Console.Write("\n\tComputer Science (CS)\t                  Social Sciences (SS)");
            Console.Write("\n------------------------------------------------------------------------------");
            Console.WriteLine("\n\t\t\t:::: << ADD A NEW STUDENT >> ::::");
            //getting enrollment ID from the user and writing ot to file
            Console.Write("\n\t\t\t  EnrollmentID (XXX): __________\b\b\b\b\b\b\b\b\b");
            var msg = Console.ReadLine().ToUpper();
            writer.Write(msg + ",");

            //getting name from the user and writing it to file
            Console.Write("\n\t\t\t  Name: ________________________\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            msg = Console.ReadLine().ToUpper();
            writer.Write(msg + ",");

            //getting department from the user and writing it to file
           
            Console.Write("\n\t\t\t  Department: __________________\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b\b");
            msg = Console.ReadLine().ToUpper();
            writer.Write(msg + ",");

            //getting semester from the user and writing ot to file
            Console.Write("\n\t\t\t  Semester: ____________________\b\b\b\b\b\b\b\b\b");
            msg = Console.ReadLine().ToUpper();
            writer.Write(msg + ",");

            //getting CGPA from the user and writing ot to file
            Console.Write("\n\t\t          CGPA (In Decimal Form): ______\b\b\b\b\b\b");
            msg = Console.ReadLine().ToUpper();
            writer.Write(msg + ",");

            //getting campus from the user and writing ot to file
            Console.Write("\n\t\t      Campus(I)slamabad/(K)arachi/(L)ahore:\n\t\t\t\t   ________\b\b\b\b\b");
            msg = Console.ReadLine().ToUpper();
            writer.Write("BU" + msg + ",");

            writer.WriteLine("0");

            //closing the created file
            writer.Close();
        }
    }
}
