// See https://aka.ms/new-console-template for more information
Console.WriteLine("How much money would you like?");
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

List<int> quantities = new List<int>()
{
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0,
    0
};
double valueRemaining = userInput;

for(int i = 0; i < BillsAndCoins.Count; i++)
{
    Console.WriteLine(BillsAndCoins[i]);
    Console.WriteLine(valueRemaining > BillsAndCoins[i]);
    if(valueRemaining > BillsAndCoins[i])
    {
        quantities[i] = 1;
    }
}

for (int i = 0; i < quantities.Count; i++)
{
    Console.WriteLine(quantities[i]);
}


