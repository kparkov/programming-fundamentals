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

            Console.WriteLine("Der er " + sentence.Length + " characters in the sentence");

            Console.ReadKey();

            // 1b. Find the number of words in the sentence.

            //int countSpace = 0;
            //int counter = 0;

            //sentence.IndexOf(" ", countSpace);

            //while (counter <= sentence.Length)
            //    {
            //    int countSpacePosition = sentence.IndexOf(" ", counter);
            //    countSpace = countSpace + 1;
            //    counter = countSpacePosition;
            //    }

            //Console.WriteLine("Der er " + countSpace + 1);
            //Console.ReadKey();

            // 1c. Find the number of occurences of the letter "O". Both uppercase and lowercase should be counted.

            string upperCaseIndifferent = sentence.ToUpper();

            int countOs = 0;
            int counter = 0;

            while (counter < sentence.Length)
            {
               if (upperCaseIndifferent.Substring(counter,1) == "O")
                {
                    countOs = countOs + 1;
                }
                counter = counter + 1;
            }

            Console.WriteLine(countOs);
            Console.ReadKey();



            string canadaPrime = "Justin Pierre James Trudeau";
            int canadaPrimeNameLength = canadaPrime.Length;

            
            // EXERCISE 2
            // The solutions provided should work without modification for any name containing only letters and spaces.
            // 2a. Extract the first name into a new variable.

            int firstNameLimit = canadaPrime.IndexOf(" ", 0);

            string theFirstName = canadaPrime.Substring(0, firstNameLimit);

            Console.WriteLine("The first name is: " + theFirstName);

            int lastNameLimit = canadaPrime.LastIndexOf(" ");

            string theLastName = canadaPrime.Substring(lastNameLimit, (canadaPrimeNameLength-lastNameLimit));
            

            Console.WriteLine("The last name is: " + theLastName);

            // 2b. Extract the last name into a new variable.

            string theMiddleNames = canadaPrime.Substring (firstNameLimit , (lastNameLimit-firstNameLimit));
                       

            Console.WriteLine("The middle names of the Prime Minister are: " + theMiddleNames);

            Console.ReadKey();

            // 2c. Extract all the middle names into a new variable.
        }
    }
}
