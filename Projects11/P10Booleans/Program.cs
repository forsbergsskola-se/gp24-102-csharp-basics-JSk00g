Console.WriteLine ("What is your age");

int age = int.Parse (Console.ReadLine ());

bool isChild = age > 0 && age < 12;
bool isTeen = age > 13 && age < 19;
bool isAdult = age > 19 && age < 100; 

Console.WriteLine ($"You are a Child: {isChild}");
Console.WriteLine ($"You are a Teen: {isTeen}");
Console.WriteLine ($"You are an Adult: {isAdult}");