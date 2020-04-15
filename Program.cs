using System;
using System.Collections.Generic;

namespace cSharpLists
{

    public class CardClass {
        public string name;
        public int age;
    }

    class Program
    {
        static void Main(string[] args)
        {
            // start of arrays
            string[] myNewStringArray = new string[] {"Will", "Fave", "Infinity Works"};
            // grabbing index 1
            Console.WriteLine(myNewStringArray[1]);
            for(int i = 0; i < myNewStringArray.Length; i++){
                Console.WriteLine(myNewStringArray[i]);
            }

            int[] myNewIntergerArray = new int[] {1, 2, 3, 4, 5};
            for(int i = 0; i < myNewStringArray.Length; i++){
                Console.WriteLine(myNewIntergerArray[i]);
            }
            // end of arrays

            List<CardClass> cards = new List<CardClass>();
            
        }
    }
}
