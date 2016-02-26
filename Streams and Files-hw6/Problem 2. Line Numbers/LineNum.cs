using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_2.Line_Numbers
{
    class LineNum
    {
        static void Main(string[] args)
        {
            StreamReader reader = null;
            StreamWriter writer = null;

            // open input (current) file
            try
            {
                reader = new StreamReader(@"..\..\LineNumbers.cs", Encoding.GetEncoding("windows-1251"));
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }

            // create output file
            try
            {
                writer = new StreamWriter(@"..\..\LineNumbers.txt");
            }
            catch (IOException)
            {
                Console.WriteLine("Unable to create output file.");
            }


            string s;
            int lineNumber = 1;
            using (reader)
            using (writer)
            {
                do // algorithm: read one line from input file, write line number + that line to output file
                {
                    s = reader.ReadLine();
                    writer.WriteLine("{0} {1}", lineNumber, s);
                    lineNumber++;
                } while (s != null);
            }
            Console.WriteLine("Task complete:\n");

            // print output file to the console
            string fileContents = File.ReadAllText(@"..\..\LineNumbers.txt");
            Console.WriteLine(fileContents);
    
        }
    }
}
