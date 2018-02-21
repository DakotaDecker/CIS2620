//initialize variables
double FEE = 25, revenue;
int thisYearContestantsCount, lastYearContestantsCount;

//get numbers, check if between 0-30
do
{
    Write("Enter number of contestants this year (0-30): ");
    thisYearContestantsCount = Convert.ToInt32(ReadLine());
}
while (thisYearContestantsCount < 0 || thisYearContestantsCount > 30);
do
{
    Write("Enter number of contestants this year (0-30): ");
    lastYearContestantsCount = Convert.ToInt32(ReadLine());
}
while (lastYearContestantsCount < 0 || lastYearContestantsCount > 30);

//calculate revenue
revenue = FEE * thisYearContestantsCount;

WriteLine("Estimated " + revenue.ToString("C2") +
    " in entrance fee revenue this year.");

if (thisYearContestantsCount > (lastYearContestantsCount * 2))
{
    WriteLine("The competition is more than twice as big this year!");
}
else if ((thisYearContestantsCount > lastYearContestantsCount) && (thisYearContestantsCount < (lastYearContestantsCount * 2)))
{
    WriteLine("The competition is bigger than ever!");
}
else
{
    WriteLine("A tighter race this year! Come out and cast your vote!");
}

ReadLine();