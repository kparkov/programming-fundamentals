using System;
using System.Collections.Generic;
using System.Text;

namespace SU
{
    public class SuCalculatorApp
    {
        public void Run()
        {
  

            Console.WriteLine("Denne applikation gør ikke noget endnu. Afvent venligst implementering.");
            Console.ReadKey();
        }
        //int AskQuestionGetInt (string queston)

        //bool AskQuestionGetBool (string question)

        public bool AskQuestionGetBool(string question)
        {
            while 

            if ()
            {
                return;
            }

          
        }

        //Calculate baseValue
        //int education
        // 1) videregående
        // 2) Ungdomsuddannelse
        // 3) ingen af de,

        //int residens
        // 1) home
        // 2) alone

        //bool start
        // 1) før 2014

        //age
        // 1) over 20
        // 2) under 20
        // dsipentation bool


        private decimal CalculateBase(int education, int residens, int age, bool start, bool dispentation)
        {
            if (education == 1)
            {
                if (residens == 1)
                {
                    if (start == true)
                    {
                        return 3028;
                    }
                    else
                    {
                        return 946;
                    }
                }
                else
                    return 6090;
            }
            else if (education == 2)
            {
                if (residens == 1)
                {
                if (start == true)
                    {
                        if (age == 1)
                        {
                            return 3028;
                        }
                        else
                            return 1348;
                    }
                else
                    {
                        return 946;
                    }
                        }
                else
                {
                    if (age ==1)
                    {
                        return 6090;
                    }
                    else
                    {
                        if (dispentation == true)
                        {
                            return 3097;
                        }
                        else
                            return 946;
                    } 
                  
                   

                }
            }
            else
                return 0;
        }



        //CalculateAdditional
        //int Residence 
        // 1) home
        // 2) alone

        //Int Income 
        // 1) x<100,000 
        // 2) 100,000>x<299,999 
        // 3) 300,000<x>499,999
        // 4) x>500,000 
        //
        private decimal CalculateAdditional(int residens, int income)
        {
            if (residens == 1)
            {
                if (income == 1)
                {
                    return 3000;
                }
                else if (income == 2)
                {
                    return 2000;

                }
                else if (income == 3)
                {
                    return 1000;

                }
                else
                {
                    return 0;
                }

            }
            else
            {
                return 3000;

           }
        }


        //CalculateTotal
        private decimal CalculateTotal(decimal baseValue, decimal additionalValue)
        {
            return baseValue + additionalValue;
        }
        //Presentation
        private void Presentation(decimal CalculateTotal)
        {
            Console.WriteLine("Dit totale beløb til udbetaling er " + CalculateTotal);
        }
    }
}
