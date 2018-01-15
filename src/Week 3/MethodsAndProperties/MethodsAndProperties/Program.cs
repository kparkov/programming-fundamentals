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

            string presentation = "Der er " + sentence.Length + "tegn i sætningen.";

            // 1b. Find the number of words in the sentence. Number of spaces?

            //int countSpaces = 0;
            //int counter = 0;

            //while (counter < sentence.Length)
            //{
            //  if (sentence.Substring(counter, 1) == " ")
            //    {
            //        countSpaces = countSpaces + 1;
            //    }
            //    counter = counter + 1;
            //}

            //int words = countSpaces + 1;

            //Console.WriteLine(words);



            // 1c. Find the number of occurences of the letter "O". Both uppercase and lowercase should be counted.

            //int countOs = 0;
            //int counter = 0;

            //while (counter < sentence.Length)
            //{
            //    string currentCharacter = sentence.Substring(counter, 1).ToUpper();
            //    if (sentence.Substring(counter, 1) == "O")
            //    {
            //        countOs = countOs + 1;
            //    }
            //    counter = counter + 1;
            //}

            

            //Console.WriteLine(countOs);

        
            



            string canadaPrime = "Justin Pierre James Trudeau";

            // EXERCISE 2
            // The solutions provided should work without modification for any name containing only letters and spaces.
            // 2a. Extract the first name into a new variable.
        

            int positionFirstSpace = canadaPrime.IndexOf(" ");

            string firstName = canadaPrime.Substring(0, positionFirstSpace);

            // 2b. Extract the last name into a new variable.

            int positionLastSpace = canadaPrime.LastIndexOf(" ");

            string lastName = canadaPrime.Substring(positionLastSpace + 1, canadaPrime.Length - positionLastSpace - 1);

            string newLastName = canadaPrime.Substring(positionLastSpace);

            // 2c. Extract all the middle names into a new variable.

            string midleName = canadaPrime.Substring(positionFirstSpace + 1, positionLastSpace - positionFirstSpace);

            Console.WriteLine(midleName);
            Console.WriteLine(firstName);
            Console.WriteLine(lastName);




            Console.ReadKey();
        }
    }
}
