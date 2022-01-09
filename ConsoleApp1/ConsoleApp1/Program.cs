using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public struct s
    {
        public int i { get; set; }
    };

    class Program
    {
        //static void Main()
        //{
        //    var listint = new List<int>
        //  {
        //      1,2,3,4,3,3,5
        //  };
        //    String str = "weq";
        //    string st2 = "";
        //    var listStr = new List<string>();
        //    foreach (var elem in listint)
        //    {
        //        if ((elem % 2) == 0)
        //        {
        //            listStr.Add(elem.ToString());
        //            listint.Remove(elem);
        //        }
        //    }
        //}
        static void Main()
        {

            var numbers = new List<int> { 65, 56, 21, 46, 11, 11 };

            var firstResult = numbers.Skip(3).Select(e =>
            {
                Console.WriteLine(e);
                return e;
            }
            );

            Console.WriteLine("55");
            var secondResult = firstResult.OrderByDescending(r => r).Distinct().ToList();

            foreach (var e in secondResult)
                Console.WriteLine(e);
        }
    }
}
