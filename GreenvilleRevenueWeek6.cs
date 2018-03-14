/*
    Eric Bjerke and Dakota Decker
    2/22/18
    Unit 5 Greenville Motto
*/

using static System.Console;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Case_Study_1
{
    class Program
    {
        static void Main(string[] args)
        {
            //initialize variables
            double FEE = 25, revenue;
            int thisYearContestantsCount, lastYearContestantsCount;
            int singers = 0, dancers = 0, musicians = 0, others = 0;

            //get numbers for THIS year, check if between 0-30
            do
            {
                Write("Enter number of contestants this year (0-30): ");
                thisYearContestantsCount = Convert.ToInt32(ReadLine());
            }
            while (thisYearContestantsCount < 0 || thisYearContestantsCount > 30);

            //initialize arrays
            string[] contestants = new string[thisYearContestantsCount];
            string[] talents = new string[thisYearContestantsCount];

            //get name and talent for each contestant this year, add to respective arrays
            for (int x = 0; x < thisYearContestantsCount; x++)
            {
                Write("What is contestant #{0}'s name? ", x + 1);
                string contestantName = ReadLine();
                WriteLine("What is {0}'s talent code?", contestantName);
                Write("Singing: S, Dancing: D, Musical Instrument: M, Other: O - ");
                string talentCode = ReadLine();
                contestants[x] = contestantName;
                talents[x] = talentCode;

                //increment respective talent counter
                switch (talentCode)
                {
                    case "S":
                        singers += 1;
                        break;
                    case "D":
                        dancers += 1;
                        break;
                    case "M":
                        musicians += 1;
                        break;
                    case "O":
                        others += 1;
                        break;
                    default:
                        WriteLine("Something went wrong.");
                        break;
                }
            }

            //display numbers of each type of contestant
            WriteLine("Number of singers this year: {0}", singers);
            WriteLine("Number of dancers this year: {0}", dancers);
            WriteLine("Number of musicians this year: {0}", musicians);
            WriteLine("Number of others: {0}", others);

            //display names of contestants if user would like
            string userInput = "";
            WriteLine("Check names of all contestants in each category?");
            do
            {
                Write("'S' for singers, 'D' for dancers, 'M' for musicians, 'O' for others, or 'continue' to skip: ");
                userInput = ReadLine();
                for (int x = 0; x < talents.Length; x++)
                {
                    if (talents[x] == userInput)
                    {
                        Write("{0} | ", contestants[x]);
                    }
                }
                WriteLine();
            }
            while (userInput != "continue");

            //get numbers for LAST year, check if between 0-30
            do
            {
                Write("Enter number of contestants last year (0-30): ");
                lastYearContestantsCount = Convert.ToInt32(ReadLine());
            }
            while (lastYearContestantsCount < 0 || lastYearContestantsCount > 30);

            //calculate revenue
            revenue = FEE * thisYearContestantsCount;

            WriteLine("Estimated " + revenue.ToString("C2") +
                " in entrance fee revenue this year.");

            if (thisYearContestantsCount > (lastYearContestantsCount * 2))
                WriteLine("The competition is more than twice as big this year!");
            else if ((thisYearContestantsCount > lastYearContestantsCount) && (thisYearContestantsCount < (lastYearContestantsCount * 2)))
                WriteLine("The competition is bigger than ever!");
            else
                WriteLine("A tighter race this year! Come out and cast your vote!");

            ReadLine();
        }
    }
}
