//get user input
Console.WriteLine("how much money would you like");
double userInput = double.Parse(Console.ReadLine());
//create a dictionary of coins and bills of type double, int

Dictionary<double, int> BillsAndCoins = new Dictionary<double, int>()
{
    { 100, 0},
    { 50,0 },
    { 20,0 },
    { 10,0 },
    { 5,0 },
    { 1,0 },
    { 0.25,0 },
    { 0.1,0 },
    { 0.05,0 },
    { 0.01,0 },
};

//set value remaining as user input
double valueRemaining = userInput;

// check for the greatest value that is less than or equal to value remaining
// subtract that value from value remaing and add that value as many times as needed to the right side of the list
// keep checking until value remaining equals zero


for (int i = 0; i <= BillsAndCoins.Count; i++)
{
    //print list
   Console.WriteLine(BillsAndCoins[i]);
   Console.WriteLine(valueRemaining == BillsAndCoins[i]);
    
}
