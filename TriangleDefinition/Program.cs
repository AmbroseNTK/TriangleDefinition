using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleDefinition
{
    class Program
    {
        static void Main(string[] args)
        {

            Triangle triangle = new Triangle();
            try
            {
                
                List<Case> cases = FileUtils.ReadFile("test.txt");
                int correct = 0;
                foreach (Case @case in cases)
                {
                    @case.ActualType = triangle.Define(@case.A, @case.B, @case.C);
                    Console.WriteLine(@case);
                    
                    if (@case.IsCorrect())
                    {
                        correct++;
                    }
                }
                Console.WriteLine("Correct: " + correct + "/" + cases.Count + "; Rate: " + (double)correct / cases.Count *100 + "%");

                FileUtils.WriteLog(cases);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
