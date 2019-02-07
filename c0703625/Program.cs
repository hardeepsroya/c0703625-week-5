using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace c0703625
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = new TestQuestions2();
            a.playingWithForLoops();
        }
    }

    class TestQuestions2

    {
        public int myFavoriteVariable = 0;
        public void playingWithForLoops()
        {
            // write a For Loop to add 10 numbers
            for (; MyMethod() ; )
            {
                if ( myFavoriteVariable>10)
                {
                    Console.WriteLine("i am out here");
                    break;
                }
         
                Console.WriteLine("i am in the for loop 10 time");
            }
        }
        public bool MyMethod()
        {
            myFavoriteVariable++;
            return true;
        }
    }
}
