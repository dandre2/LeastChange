//create a list of coins and bills of type double
//set value remaining as user input
//check for the greatest value that is less than or equal to value remaining
//subtract that value from value remaing and add that value as many times as needed to the right side of the list
// keep checking until value remaining equals zero
//print list

Console.WriteLine("how much money would you like");
double userInput = double.Parse(Console.ReadLine());
List<double> BillsAndCoins = new List<double>()
{
    100,
    50,
    20,
    10,
    5,
    1,
    0.25,
    0.1,
    0.05,
    0.01
};
double valueRemaining = userInput;

for (int i = 0; i <= BillsAndCoins.Count; i++)
{
    Console.WriteLine(BillsAndCoins[i]);
    Console.WriteLine(valueRemaining == BillsAndCoins[i]);

}
