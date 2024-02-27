﻿string customerName = "Ms. Barros";

string currentProduct = "Magic Yield";
int currentShares = 2975000;
decimal currentReturn = 0.1275m;
decimal currentProfit = 55000000.0m;

string newProduct = "Glorious Future";
decimal newReturn = 0.13125m;
decimal newProfit = 63000000.0m;




// Your logic here
Console.WriteLine($"Dear {customerName},");
Console.WriteLine($"As a customer of our {currentProduct} offering we are excited to tell you about a new financial product that would dramatically increase your return.\n");
Console.WriteLine($"Currently, you own {currentShares:N2} shares at a return of {currentReturn:P2}.\n");
Console.WriteLine($"Our new product, {newProduct} offers a return of {newReturn:P2}. Given your current volume, your potential profit would be {newProfit:C}.\n");

Console.WriteLine("Here's a quick comparison:\n");

string comparisonMessage = "";

// Your logic here
//Console.WriteLine("1234567890123456789012345678901234567890");

 comparisonMessage = currentProduct.PadRight(24);
 comparisonMessage +=String.Format( "{0:P}", currentReturn).PadRight(24);
 comparisonMessage += String.Format( "{0:C}",currentProfit).PadLeft(10);

 comparisonMessage += "\n";
 comparisonMessage += newProduct.PadRight(24);
 comparisonMessage += String.Format( "{0:P}",newReturn).PadRight(24);
 comparisonMessage += String.Format( "{0:C}", newProfit).PadLeft(10);

Console.WriteLine(comparisonMessage);