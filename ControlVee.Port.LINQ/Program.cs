using System;
using System.Collections.Generic;
using System.Linq;

namespace ControlVee.Port.LINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrayOfInt = new int[] { 0,1,2,3,4,5,6,7,8,9 };
            List<string> listOfString = new List<string>()
            {
                "zero",
                "one",
                "two",
                "three",
                "four",
                "five",
                "six",
                "seven",
                "eight",
                "nine"
            };
            List<Test> listOfTest = new List<Test>()
            {
                new Test(){ I = 0, S = "zero",  D = 0.0001d },
                new Test(){ I = 1, S = "one",   D = 1.1111d },
                new Test(){ I = 2, S = "two",   D = 2.2222d },
                new Test(){ I = 3, S = "three", D = 3.3333d },
                new Test(){ I = 4, S = "four",  D = 4.4444d },
                new Test(){ I = 5, S = "five",  D = 5.5555d },
                new Test(){ I = 6, S = "six",   D = 6.6666d },
                new Test(){ I = 7, S = "seven", D = 7.7777d },
                new Test(){ I = 8, S = "eight", D = 8.8888d },
                new Test(){ I = 9, S = "nine",  D = 9.9999d },
            };
            Dictionary<int, Test> dictionaryOfTest;

            var queryA = from x in arrayOfInt
                        select x;

            var queryB = from x in listOfString
                        select x;

            var queryC = from x in listOfTest
                        select x;

            var queryD = from x in arrayOfInt
                         where x < 5
                         select x;

            var queryE = from x in arrayOfInt
                         where x > 5
                         select x;

            var queryF = from x in listOfString
                         where x.Length > 3
                         select x;

            var queryG = from x in listOfString
                         where x.Length < 3
                         select x;

            int i = 5;
            var queryH = from x in listOfString
                         where x.Length < i
                         select x;

            foreach (var item in queryH)
            {
                Console.Write(item);
            }
        }
    }

    class Test
    {
        public int I { get; set; }
        public string S { get; set; }
        public double D { get; set; }
    }
}
