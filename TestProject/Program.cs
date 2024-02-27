string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;




// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our Magic Yield offerin we are excited to tell you about a new financial product that would dramatically increase your return. Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here

 comparisonMessage = currentProduct.PadRight(6);
 comparisonMessage += currentReturn.PadRight(24);
 comparisonMessage += currentProfit.PadLeft(10);
 comparisonMessage += newProduct.PadRight(24);
 comparisonMessage += newReturn.PadRight(24);
 comparisonMessage += newProfit.PadLeft(10);

Console.WriteLine(comparisonMessage);