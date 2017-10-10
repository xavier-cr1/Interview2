using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HpInterview
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("input a int number > than 0:");
            //try parse if unfriendly user...
            var input = Convert.ToInt32(Console.ReadLine());
            if (input == 0) Console.WriteLine("Cannot divide by 0!");
            string finalStringResult = "";
            int denominator = 0;
            double finalDoubleResult = 0.0;
            for (int i = 1; i<= input; i++)
            {
                denominator += i;
                finalStringResult += PrintEquation(i);
                finalDoubleResult += (double)1 / denominator;
                if (i != input) finalStringResult += " + ";
            }
            Console.WriteLine("Equation:" + finalStringResult + " ");
            Console.WriteLine("Result:" + finalDoubleResult);
            Console.Read();
        }

        private static string PrintEquation(int indexer)
        {
            string stringResult= "";
            if(indexer == 1)
            {
                return "(1)";
            }
            else
            {
                for (int i = 1; i <= indexer; i++)
                {
                    stringResult += i;
                    if (i != indexer) stringResult += " + ";
                }
                return "(1/" + stringResult + ")";
            }
        }
    }
}
