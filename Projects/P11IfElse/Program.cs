Console.WriteLine("What is your age");

int age = int.Parse(Console.ReadLine());

if (age < 13) { 
    Console.WriteLine("You are a child");
}else if (age < 18) { 
    Console.WriteLine("You are a teenager");
}else {
    Console.WriteLine("You are an adult");
}

Console.WriteLine("Give me another integer");

int integer = int.Parse(Console.ReadLine());

Console.WriteLine($"The bigger number is: {(age > integer ? age : integer)}");

int biggerNumber = age < integer ? age : integer;

bool integerEven = biggerNumber % 2 == 0;
bool integerOdd = biggerNumber % 2 == 1;
Console.WriteLine($"That number is an {(integerOdd && integerEven ? "even" : "odd")} number");