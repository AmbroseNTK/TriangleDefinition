using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDefinition
{
    class FileUtils
    {
        public static List<Case> ReadFile(string fileName)
        {
            List<Case> cases = new List<Case>();
            string[] lines = System.IO.File.ReadAllText(fileName).Split('\n');
            foreach(string line in lines)
            {
                string[] tokens = line.Split(';');
                if (tokens.Length == 4)
                {
                    try {
                        double a, b, c;
                        int expected;
                        if (double.TryParse(tokens[0], out a) && double.TryParse(tokens[1], out b) && double.TryParse(tokens[2], out c) && int.TryParse(tokens[3],out expected))
                        {
                            cases.Add(new Case(a, b, c, expected));
                        }
                        else
                        {
                            throw new Exception("Parse error: " + line);
                        }
                    }
                    catch (Exception ex)
                    {
                        throw ex;
                    }
                }
                else
                {
                    throw new Exception("Do not have enough columns: " + tokens.Length + "/4");
                }
            }
            return cases;
        }
        public static void WriteLog(List<Case> cases)
        {
            string log = "";
            int correct = 0;
            foreach(Case @case in cases)
            {
                log += @case + "\n";
                if (@case.IsCorrect())
                {
                    correct++;
                }
            }
            log += "Correct: " + correct + "/" + cases.Count + "; Rate: " + (double)correct / cases.Count * 100 + "%";
            System.IO.File.WriteAllText("result.txt", log);
        }
    }
}
