Console.WriteLine("Give me a number");
int number = int.Parse(Console.ReadLine());
bool integerEven = number % 2 == 0;
Console.WriteLine($"That number is an {(integerEven ? "even" : "odd")} number");