using System;

namespace MethodsAndProperties
{
    class Program
    {
        static void Main(string[] args)
        {
            // EXERCISE: METHODICAL DISASSEMBLY

            string sentence = "The quick brown fox jumps over the lazy dog";

            // EXERCISE 1
            // The solutions provided should work without modification for any sentence consisting only of letters and spaces.

            // 1a. Find the number of characters in the sentence.
            
           
            string antalTegn = "Der er " + sentence.Length + " tegn i sætningen.";
           // Console.WriteLine(antalTegn);
            //Console.ReadKey();
;

            // 1b. Find the number of words in the sentence.

            int countSpaces = 0;
            int counter = 0;

            while (counter < sentence.Length)
            {
                if (sentence.Substring(counter, 1) == " ")
                {
                   countSpaces = countSpaces + 1;
                }
                counter = counter + 1;

                
                
            }

            int words = countSpaces + 1;
            Console.WriteLine(words);
            Console.ReadKey();
            // 1c. Find the number of occurences of the letter "O". Both uppercase and lowercase should be counted.

            string canadaPrime = "Justin Pierre James Trudeau";

            // EXERCISE 2
            // The solutions provided should work without modification for any name containing only letters and spaces.
            // 2a. Extract the first name into a new variable.

            int fornavnMellemrum = canadaPrime.IndexOf(" ");

            string fornavn = canadaPrime.Substring(0, fornavnMellemrum);

            Console.WriteLine(fornavn);

           // Console.ReadKey();

            // 2b. Extract the last name into a new variable.

            int positionLastSpace = canadaPrime.LastIndexOf(" ");
            string lastName = canadaPrime.Substring(positionLastSpace +1 );
            Console.WriteLine(lastName);
            Console.ReadKey();
            // 2c. Extract all the middle names into a new variable.


        }
    }
}
