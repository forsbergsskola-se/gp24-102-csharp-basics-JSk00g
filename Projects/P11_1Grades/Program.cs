Console.WriteLine("Give me a Number");
int age = int.Parse(Console.ReadLine());
bool F = age <60;
bool D = age > 60 && age < 69;
bool C  = age > 70 && age < 79;
bool B = age > 80 && age < 89;
bool A = age > 90 && age < 100;

if (F)
{
    Console.WriteLine("F");
}

if (D)
{
    Console.WriteLine("D");
}

if (C)
{
    Console.WriteLine("C");
}

if (B)
{
    Console.WriteLine("B");
}

if (A)
{
    Console.WriteLine("A");
}