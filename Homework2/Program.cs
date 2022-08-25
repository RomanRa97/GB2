Random number1 = new Random();

int number = number1.Next(1,65537);

string value = number.ToString();

if (value.Length > 2) Console.WriteLine(value + " -> " + value[2]);

else
{
    Console.WriteLine(value + " -> " + "третьей цифры нет");
}