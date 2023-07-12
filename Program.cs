using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TryParse
{
    internal class Program
    {
        static void Main(string[] args)
        {
             try
             {
                 Console.WriteLine("Enter the string");
                  string str = Console.ReadLine();
                  int num;
                  int.TryParse(str, out num);
                 Console.WriteLine("TryParse Method");
                 Console.WriteLine("str1:\t" +num);
                 Console.WriteLine("Parse Method");
                 int parse = int.Parse(str);
                 Console.WriteLine("Parse:\t" + parse);

                 Console.WriteLine("Convert Method");
                 int condou=Convert.ToInt32(str);
                 Console.WriteLine("Convert:\t" + condou);

             }
             catch (Exception e) 
             {
                 Console.WriteLine("Error!!!" + e.Message);
             }
             finally { Console.ReadKey(); }
            
        }
    }
}
