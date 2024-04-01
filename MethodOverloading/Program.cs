using System.ComponentModel.Design;
using System.Diagnostics.CodeAnalysis;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            var a = 56;
            var b = 42;

            var answer = Add(a, b);

            var x = 34.7m;
            var y = 68.9m;

            var decimalAnswer = Add(x, y);

            var answer3 = Add(0, 1, true);

            Console.WriteLine($"integer add: {answer} decimal add: {decimalAnswer}");
            Console.WriteLine(answer3);
            
        }

        public static int Add(int num1, int num2)
        {
            
            
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2) 
        {
           
            
            return num1 + num2;
          
        }

        public static string Add(int num1, int num2, bool dollars)
        {
            var sum = num1 + num2;
            
            if (dollars == true && sum == 1)
            {
                
                return $"{sum} dollar";
                
            }
            else if (dollars == false && sum == 1)
            {                           // is bool is always set to true this "else if " statement is unnessary
                return $"{sum} dollar"; // I added the false to cover all 3 parameter possiblities
            }                           // to make sure everything is grammatically correct.
            else 
            {
                return $"{sum} dollars";
            }

        }
    }
}
