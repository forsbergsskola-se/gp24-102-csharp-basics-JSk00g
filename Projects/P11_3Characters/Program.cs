Console.WriteLine("Give me an input");
int number = int.Parse(Console.ReadLine());
bool isVowel = "aeiouAEIOU".IndexOf(c) >= 0;  
bool isConsonant = "bcdfghjklmnpqrstuvwxyz".IndexOf(c) >= 0;
bool number1 = number > 0 && number < 100;

if (isVowel)
{
    Console.WriteLine("Thats a vowel");
}

if (isConsonant)
{
    Console.WriteLine("Thats a consonant");
}

if (number1)
{
    Console.WriteLine("Thats a number");
}