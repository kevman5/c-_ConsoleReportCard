using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASP_ReportCard
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Enter Number of Students: ");
            int totStudents1 = int.Parse(Console.ReadLine());
            string[][] studinfo = new string[totStudents1][];
            
            for (int i = 0; i < totStudents1; i++)
            {
                studinfo[i] = new string[5];
                Console.Write("Enter Student Name: ");
                studinfo[i][0] = Console.ReadLine();
                Console.Write("Enter English Marks (Out Of 100) : ");
                studinfo[i][1] = Console.ReadLine();
                Console.Write("Enter Math Marks (Out Of 100) : ");
                studinfo[i][2] = Console.ReadLine();
                Console.Write("Enter Computer Marks (Out Of 100) : ");
                studinfo[i][3] = Console.ReadLine();
            }
            for (int i = 0; i < totStudents1; i++)
            {
                int total = 0;
                for (int j = 1; j < 4; j++)
                {
                    total += int.Parse(studinfo[i][j]);
                }
                studinfo[i][4] = total.ToString();
            }
            
            for (int j = 0; j <= studinfo.Length - 2; j++)
            {
                for (int i = 0; i <= studinfo.Length - 2; i++)
                {
                    if (int.Parse(studinfo[i][4]) < int.Parse(studinfo[i + 1][4]))
                    {
                        string[] count1 = studinfo[i + 1];
                        studinfo[i + 1] = studinfo[i];
                        studinfo[i] = count1;
                    }
                }
            }
            Console.WriteLine("\n##### **Report Card** #####");
            for (int i = 0; i < totStudents1; i++)
            {
                Console.WriteLine("###########################################");
                Console.WriteLine("Student: {0}, Position: {1}, Total: {2}/300", studinfo[i][0], (i + 1), studinfo[i][4]);
                Console.WriteLine("###########################################");
                
            }
            Console.ReadLine();
        }
    }
}


