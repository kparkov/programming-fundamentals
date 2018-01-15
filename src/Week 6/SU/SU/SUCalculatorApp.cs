using System;
using System.Collections.Generic;
using System.Text;

namespace SU
{
    public class SuCalculatorApp
    {
        public void Run()
        {
            Console.WriteLine("Indtast din alder: ");
            Console.ReadLine();
            

           //Console.ReadKey();

            decimal extrasToSuBase = 0;
            decimal suBase = 0;
            int income = 0;
            bool continueProgram = true;





            while (continueProgram) ;

            //ungdomsudd = 1
            //videregående = 2
            //anden udd = 3
            //hjemmeboende = 1
            //udeboende = 2
            //alder u. 18 = 1
            // alder 18-19 = 2
            //alder 20+ = 3
            //edustart før 1/7-2014 = true
            //edustart efter 1/7-2014 = false
            
        }
        public decimal CalculateSuBase (int education, int residence, int age, bool eduStart, bool dispensation, bool continueProgram)
        {
            if (dispensation) return 3907;

            if (age < 18) continueProgram = false;

            if (education == 2 && residence == 2) return 6090;

            if (education == 2 && residence == 1 && eduStart) return 3028;

            if (education == 2 && residence == 1 && !eduStart) return 946;

            if (education == 1 && residence == 1 && eduStart)
            {
                if (age < 20) return 1348; else return 3028;
            }
            if (education == 1 && residence == 1 && !eduStart) return 946;
            


         
        }
            
        }



        //Tillægsydelse
        // hjemmeboende = 1
        // udeboende = 2

        public decimal CalculateExtraSU (int income, int residence)
        {
            if (residence == 1)
            {
                if (income < 100000)
                {
                    decimal extrasToSuBase = 3000;
                    return extrasToSuBase;
                }
                else if (income >= 100000 && income < 300000)
                {
                    decimal extrasToSuBase = 2000;
                    return extrasToSuBase;
                }
                else if (income >= 300000 && income < 500000)
                {
                    decimal extrasToSuBase = 1000;
                    return extrasToSuBase;
                }
                else if (income >= 500000)
                {
                    decimal extrasToSuBase = 0;
                    return extrasToSuBase;
                }
                  
            }
            else if (residence == 2)
            {
                decimal extrasToSuBase = 3000;
                return extrasToSuBase;
            }
        }
        

        public static void Presentation (decimal sUbase, decimal extrasToSuBase)
        {
            Console.WriteLine ("Du er berettiget til "+ sUbase + " kr. i grundydelse");
            BlankLine();
            if (extrasToSuBase == 0)
            {
                Console.WriteLine("Du er desværre ikke berettiget til tillæg");
            }
            else
            {
                Console.WriteLine("Derudover er du berettiget til " + extrasToSuBase + " kr. i tillægsydelse.");
            }
            
            
        }

        public static void BlankLine()
        {
            Console.WriteLine("");
        }
        



        //int.ToString("C"); => "C" for Currency, laver korrekt opstilling med separatorer.

    }
    
    

