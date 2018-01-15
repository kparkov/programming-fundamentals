using System;
using System.Collections.Generic;
using System.Text;

namespace SU
{
    public class SuCalculatorApp
    {
        public void Run()
        {
            //Værdier:
            //
            //EducationType = 1: Ungdomsuddannelser
            //EducationType = 2: Videregående
            //
            //residenceType = 1: Hjemmeboende
            //residenceType = 2: Udeboende



            decimal additionalValue = CalculateAdditional(2, 100000);
            decimal baseValue = CalculateBase(1, 2, 18, true, true);

            Console.WriteLine("Denne applikation gør ikke noget endnu. Afvent venligst implementering.");
            //AskQuestionGetInt("Her er første spørgsmål");
            AskQuestionGetBool("Svar Ja eller Nej");

            Presentation(baseValue, additionalValue);
        }

        //Stil spørgsmål, få Integer tilbage:
        public int AskQuestionGetInt(string question)
        {
            bool isUserReplyValidInt = false;
            Console.WriteLine(question);
            string userReply;
            int succesfullyparsedValue = 0;

            while (isUserReplyValidInt == false)
            {
                userReply = Console.ReadLine();
                isUserReplyValidInt = int.TryParse(userReply, out succesfullyparsedValue);
                
                if (isUserReplyValidInt == false)
                {
                    Console.WriteLine("Dette ser ikke ud til at være et tal. Prøv igen...");   
                }
            }
            return succesfullyparsedValue;
        }

        //Stil spørgsmål, få Booelan tilbage:
        public bool AskQuestionGetBool(string question)
        {
            string userReply;

            while (true)
            {
                Console.WriteLine(question);
                userReply = Console.ReadLine();

                if (userReply.ToLower().StartsWith("j")) 
                {
                    return true;
                }

                if (userReply.ToLower().StartsWith("n"))
                {
                    return false;
                }
                Console.WriteLine("Det ser ikke ud som om du kan finde ud af at skrive enten Ja eller Nej. Er du sikker på du overhovedet er uddanelsesmoden?");
            }
        }


        //Beregn grundsats:
        private decimal CalculateBase(int educationType, int residenceType, int age, bool startedBefore_1_7_2017, bool haveDispensation)
        {
            //hvis alder er for lav, returnér tom:
            if (age < 18) 
            { 
                return 0; 
            }

            if (educationType == 1)
            {
                if (residenceType == 1)
                {
                    if (startedBefore_1_7_2017 == true)
                    {
                        if (age <=19)
                        {
                            return 1348;
                        }
                        else if (age >= 20)
                        {
                            return 3028;
                        }
                    }
                    else if (startedBefore_1_7_2017 == false)
                    {
                        return 946;
                    }
                }
                else if (residenceType == 2)
                {
                    if (age <=19)
                    {
                        if (haveDispensation == true)
                        {
                            return 3907;
                        }
                        else if (haveDispensation == false)
                        {
                            return 946;
                        }
                    }
                    else if (age >= 20)
                    {

                        return 6090;
                    }
                }
            }
            else if (educationType == 2)
            {
                if (residenceType == 1)
                {
                    if (startedBefore_1_7_2017 == true)
                    {
                        return 3028;
                    }
                    else if (startedBefore_1_7_2017 == false)
                    {
                        return 946;
                    }
                }
                else if (residenceType == 2)
                {
                    return 6090;
                }
            }
            return 0;
        }


        //Beregn tillægsværdier:
        private decimal CalculateAdditional(int residenceType, int parentsIncome)
        {
            if (residenceType == 1)
            {
                return 3000;
            }
            else if (residenceType == 2)
            {
                if (parentsIncome < 100000)
                {
                    return 3000;
                }
                else if (parentsIncome >= 100000 && parentsIncome < 299999)
                {
                    return 2000;
                }
                else if (parentsIncome >= 300000 && parentsIncome < 499999)
                {
                    return 1000;
                }
                else if (parentsIncome > 499999)
                {
                    return 0;
                }
            } return 0;
        } 

        //Print udregningen:
        private void Presentation(decimal baseValue, decimal additionalValue)
        {
            Console.WriteLine("Din grundsats er: " + baseValue);
            Console.WriteLine("Din tillægssats er: " + additionalValue);
            Console.WriteLine("Så din aktuelle sats er: " + (baseValue + additionalValue));
        }
    }
}
