// Program written by: Eric Bjerke
// Program date: 1-13-18
// Program description: Ch2 Case Problem 1
// Encounterd issues: None

using static System.Console;

 class GreenvilleRevenue
 {
     static void Main()
     {
        int numLastYearContestants, numThisYearContestants;
        
        Write("Enter number of contestants from last year's contest: ");
        numLastYearContestants = int.Parse(ReadLine());
        Write("Enter number of contestants this year: ");
        numThisYearContestants = int.Parse(ReadLine());

        WriteLine("Last year there were {0} contestants.", numLastYearContestants);
        WriteLine("This year there are {0} contestants.", numThisYearContestants);
     }
 }
