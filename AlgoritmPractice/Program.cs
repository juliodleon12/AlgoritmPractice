// See https://aka.ms/new-console-template for more information

using AlgoritmPractice;

Algorithms algorithms = new Algorithms();

var Fibonnacci = algorithms.FibonacciSequence(5);
for (int i = 0; i < Fibonnacci.Count; i++)
{
	Console.WriteLine("With for loop: "+Fibonnacci[i]);
}
foreach (var n in Fibonnacci)
{
	Console.WriteLine("With foreach loop: "+n);
}

Console.WriteLine("\n\n");
var p = 4;
var Polindrome = algorithms.polindromeCheck(p);
Console.WriteLine(p + " is Polindrome True or False? : " + Polindrome.Result);

Console.WriteLine("\n\n");
var factorial = algorithms.factorialCalculation(p);
Console.WriteLine($"What is factorial of {p}? : " + factorial);