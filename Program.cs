// See https://aka.ms/new-console-template for more information
using System.Net.Security;

Console.WriteLine("Hello User!");
decimal gasGallons = ReadInput("how many gallons of gas?", 1, 1000);
decimal milesDriven = ReadInput("how many miles driven?", 1, 1000);
decimal score1 = ReadInput("what was the score in the first test?", 1, 100);
decimal score2 = ReadInput("what was the score in the second test?", 1, 100);
decimal score3 = ReadInput("what was the score in the third test?", 1, 100);
decimal score4 = ReadInput("what was the score in the fourth test?", 1, 100);
decimal score5 = ReadInput("what was the score in the fifth test?", 1, 100);
decimal valueA = ReadInput("what is the value of a?", 1, 1000);
decimal valueB = ReadInput("what is the value of b?", 1, 1000);
decimal valueC = ReadInput("what is the value of c?", 1, 1000);
decimal valueD = ReadInput("what is the value of d?", 1, 1000);

Console.WriteLine($"your car mileage is {MilesPerGallon} !");
Console.WriteLine($" your score average is {calculateAverage}");


decimal ReadInput(string prompt, decimal minValue, decimal maxValue)
{
    Console.WriteLine(prompt);

    string x = Console.ReadLine();
    decimal input = Convert.ToDecimal(x);
    if (minValue > input)
    {
        Console.WriteLine("Invalid number.");
        return ReadInput(prompt, minValue, maxValue);
    }
    if (maxValue < input)
    {
        Console.WriteLine("Invalid number.");
        return ReadInput(prompt, minValue, maxValue);
    }
    return input;

}

decimal MilesPerGallon()
{
    decimal GallonsUsed= (milesDriven/gasGallons);
    return GallonsUsed;
}



decimal calculateAverage()
{
    decimal AvgScore= (score1+score2+score3+score4+score5)/5;
    return  AvgScore;
}


