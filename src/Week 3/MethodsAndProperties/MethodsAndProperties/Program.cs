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

            // 1b. Find the number of words in the sentence.

            //int countSpaces = 0;
            //int counter = 0;

            //while (counter < sentence.Length)
            //{
            //    if (sentence.Substring(counter, 1) == " ")
            //    {
            //        countSpaces = countSpaces + 1;
            //    }
            //    counter = counter + 1;
            //}

            //int words = countSpaces + 1;

            //Console.WriteLine("There are " + words + " words in the sentence.");



            // 1c. Find the number of occurences of the letter "O". Both uppercase and lowercase should be counted.

            //int countLetterO = 0;
            //int counter = 0;

            //while (counter < sentence.Length)
            //{
            //    if (sentence.Substring(counter, 1) == "o")
            //    {
            //        countLetterO = countLetterO + 1;
            //    }
            //    else if (sentence.Substring(counter, 1) == "O")
            //    {
            //        countLetterO = countLetterO + 1;
            //    }
            //        counter = counter + 1;
            //}

            //Console.WriteLine(countLetterO); 

            string canadaPrime = "Justin Pierre James Trudeau";

            // EXERCISE 2
            // The solutions provided should work without modification for any name containing only letters and spaces.
            // 2a. Extract the first name into a new variable.

            int positionFirstSpace = canadaPrime.IndexOf(" ");

            string firstname = canadaPrime.Substring(0, positionFirstSpace);

            Console.WriteLine(firstname);


            // 2b. Extract the last name into a new variable.

            int positionLastSpace = canadaPrime.LastIndexOf(" ");

            string lastname = canadaPrime.Substring(positionLastSpace + 1);

            Console.WriteLine(lastname);

            // 2c. Extract all the middle names into a new variable.
            string middlenames = canadaPrime.Substring(positionFirstSpace + 1, positionLastSpace - positionFirstSpace);

            Console.WriteLine(middlenames);
            Console.ReadKey();
        }

    }
}
