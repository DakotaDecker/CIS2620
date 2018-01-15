
// Program written by: Eric Bjerke & Dakota Decker
// Program date: 1-13-18
// Program description: Ch2 Case Problem 1
// Encounterd issues: None

using static System.Console;

class GreenvilleRevenue
{
    static void Main()
    {
        const int FEE = 25;
        int numLastYearContestants, numThisYearContestants;
        string revenue, condition, difference;
        bool areThereFewerContestants;

        Write("Enter number of contestants from last year's contest: ");
        numLastYearContestants = int.Parse(ReadLine());
        Write("Enter number of contestants this year: ");
        numThisYearContestants = int.Parse(ReadLine());

        areThereFewerContestants = numLastYearContestants > numThisYearContestants;
        if (areThereFewerContestants)
        {
            condition = "fewer";
            difference = (numLastYearContestants - numThisYearContestants).ToString();
        }
        else
        {
            condition = "more";
            if (numThisYearContestants == numLastYearContestants)
            {
                difference = "no";
            }
            else
            {
                difference = (numThisYearContestants - numLastYearContestants).ToString();
            }
        }

        WriteLine("Last year there were {0} contestants.", numLastYearContestants);
        WriteLine("This year there are {0} contestants.", numThisYearContestants);
        WriteLine("There are {0} {1} contestants this year than last.", difference, condition);

        revenue = (FEE * numThisYearContestants).ToString("c");
        WriteLine("This year's expected revenue is {0}.", revenue);


        Read();
    }
}
