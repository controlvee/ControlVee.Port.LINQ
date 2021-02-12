using System;
using System.Collections.Generic;

namespace ControlVee.Port.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInt = new int[] { 0,1,2,3,4,5,6,7,8,9 };
            List<string> listOfString = new List<string>();
            Dictionary<int, Test> dictionaryOfTest = new Dictionary<int, Test>();
        }
    }

    class Test
    {
        public int I { get; set; }
        public string S { get; set; }
        public double D { get; set; }
    }
}
