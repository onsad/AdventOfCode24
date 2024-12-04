using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2024.Day1
{
    public class Day1
    {
        public int GetResult()
        {
            var res = 0;
            var leftList = new List<int>();
            var rightList = new List<int>();

            using (StreamReader sr = File.OpenText("./Day1/input.txt"))
            {
                while (!sr.EndOfStream)
                {
                    var line = sr.ReadLine();

                    if (!string.IsNullOrEmpty(line))
                    {
                        var splittedLine = line.Split("   ");

                        if (splittedLine != null)
                        {
                            leftList.Add(int.Parse(splittedLine[0]));
                            rightList.Add(int.Parse(splittedLine[1]));
                        }
                    }
                }
            }

            leftList.Sort();
            rightList.Sort();

            for (int i = 0; i < leftList.Count; i++)
            {
                var partialRes = Math.Abs(leftList[i] - rightList[i]);
                res = res + partialRes;
            }

            return res;
        }

    }
}
