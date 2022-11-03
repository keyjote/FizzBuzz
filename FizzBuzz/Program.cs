// See https://aka.ms/new-console-template for more information

using FizzBuzz.Constants;
using FizzBuzz.Service;

Console.WriteLine("Running Fizz Buzz Clean Code Kat!");

for (var line = 1; line <= 100; line++) 
{
    var type = FbEvaluator.Evaluate(line);
    var outputLine = type switch
    {
        FizzBuzzType.Three => "Fizz",
        FizzBuzzType.Five => "Buzz",
        FizzBuzzType.Fifteen => "FizzBuzz",
        _ => line.ToString()
    };

    Console.WriteLine(outputLine);
}