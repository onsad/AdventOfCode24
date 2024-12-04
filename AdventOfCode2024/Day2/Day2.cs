using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Day2
{
    public class Day2
    {
        public int GetResult()
        {
            var res = 0;
            
            using (StreamReader sr = File.OpenText("./Day2/input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        var splittedLine = line.Split(" ");

                        
                    }
                }
            }

            return res;
        }
    }
}
