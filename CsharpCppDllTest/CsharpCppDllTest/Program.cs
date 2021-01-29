using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Runtime.InteropServices;//C#引用C++库文件必备

namespace CsharpCppDllTest
{
    class Program
    {
        [DllImport("DllTest(SumSub).dll")]//每引用1个函数需重新Import
        public static extern int mySum(int x, int y);
        [DllImport("DllTest(SumSub).dll")]
        public static extern int mySub(int x, int y);


        static void Main(string[] args)
        {
            int x = mySum(5, 9);

            x = x++;

            Console.WriteLine(x.ToString());

            string y = Console.ReadLine();
        }
    }
}
