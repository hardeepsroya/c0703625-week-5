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
    class dog
    {
        public dog(string name, string breed, dog next_dog, dog previous_dog)
        {
            dog_name = name;
            dog_breed = breed;
            next_dog = next;
            previous_dog = previous;
        }
        public string dog_name;
        public string dog_breed;
            public dog next_dog;
            public dog previous_dog;
            
    }
    class birthday_party
    {
        public dog peanut;
        public dog fifi;
        public dog clarence;
        public dog roy;
     
        public dog head;
        public dog tail;
        public dog temporary;
        public void invite()
        {
            peanut = new dog("peanut", "Bichon");
            fifi = new dog("fifi","Poodle");
            clarence = new dog("clarence","German Sheppard");
            roy = new dog("roy", "Beagle");\

            peanut.previous_dog = null;
            peanut.next_dog = fifi;
            fifi.previous_dog = peanut;
            fifi.next_dog = clarence;
            clarence.previous_dog = fifi;
            clarence.next_dog = roy;
            roy.previous_dog = clarence;
            roy.next_dog = null;
        }
    }
}
