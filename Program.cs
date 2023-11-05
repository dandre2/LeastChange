//get user input
Console.WriteLine("how much money would you like");
decimal userInput = decimal.Parse(Console.ReadLine());
//create a dictionary of coins and bills of type double, int

Dictionary<decimal, int> BillsAndCoins = new Dictionary<decimal, int>()
{
    { 100, 0},
    { 50,0 },
    { 20,0 },
    { 10,0 },
    { 5,0 },
    { 1,0 },
    { 0.25m,0 },
    { 0.1m,0 },
    { 0.05m,0 },
    { 0.01m,0 },
};

//set value remaining as user input
decimal valueRemaining = userInput;

// check for the greatest value that is less than or equal to value remaining
// subtract that value from value remaing and add that value as many times as needed to the right side of the list
// keep checking until value remaining equals zero
//while (valueRemaining > 0) {
foreach (var keyValue in BillsAndCoins)
{
    while (valueRemaining>=keyValue.Key) 
    {
        valueRemaining -= keyValue.Key;
        BillsAndCoins[keyValue.Key] += 1;
    }
}

foreach (var keyValue in BillsAndCoins)
{
    Console.WriteLine($"Bill: {keyValue.Key} Quantity: {keyValue.Value}");
}