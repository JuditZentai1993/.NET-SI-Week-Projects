using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortString
{
    class Program
    {
        static void Main(string[] args)
        {
            string test = "en vagyok a tuzok";
            string[] words = test.Split(' ');
            Array.Sort(words);
            string testReWritten = string.Join(" ", words);
            Console.WriteLine(testReWritten);
            Console.ReadLine();
        }
    }
}
