﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Problem_1.Odd_Lines
{
    class OddLines
    {
        static void Main(string[] args)
        {
            try
            {
                
                StreamReader reader = new StreamReader(@"..\..\OddLines.cs", Encoding.GetEncoding("windows-1251"));

                string s;
                int lineNumber = 0;

                // algorithm: line number increases twice, the reader reads twice, console prints once
                using (reader)
                {
                    do
                    {
                        s = reader.ReadLine();
                        lineNumber++;
                        s = reader.ReadLine();
                        Console.WriteLine("Line {0, 2}: {1}", lineNumber, s);
                        lineNumber++;
                    } while (s != null);
                }
            }

            // in case no file is found
            catch (FileNotFoundException)
            {
                Console.WriteLine("File not found.");
            }
        }
    }
}
