using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace yeald
{
    class Program
    {
        static List<int> value = new List<int>();
        static void FilledValue()
        {
            value.Add(1);
            value.Add(2);
            value.Add(3);
            value.Add(4);
            value.Add(5);
        }
       
        static void Main(string[] args)
        {
            FilledValue();
            foreach (int item in Filter())
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
        static IEnumerable<int> Filter()
        {
           // List<int> temp = new List<int>();
            foreach (int i in value)
            {
                if (i > 3)
                {
                   // temp.Add(i);
                    yield return i;
                }
            }
            //return temp;
        }
    }
}
