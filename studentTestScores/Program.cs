using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace studentTestScores
{
    class Program
    {
        static void Main(string[] args)
        {
            int sumScores = 0;
            int averageScore = 0;

           // StringBuilder sb = new StringBuilder();

            List<int> testScore = new List<int> { 50, 55, 60, 65, 70, 75, 80, 85, 90, 95, 100 };

            foreach (int students in testScore)
            {
                sumScores += students;
                //sb.Append(students);
               // sb.Append("\r\n");
            }

            Console.WriteLine(sumScores);

            averageScore = sumScores / testScore.Count;
            Console.WriteLine(averageScore);

            string theFile = "averageScore.txt";
            StreamWriter file = new StreamWriter(theFile);
            using (file)
            {
                // file.WriteLine(sb);
                file.WriteLine(sumScores);
                file.WriteLine(averageScore);
             }

            StreamReader file2 = new StreamReader(theFile);
            using (file2)
            {
                Console.WriteLine(file2.ReadToEnd());
            }
        }

    }
}
