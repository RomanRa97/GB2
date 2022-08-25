Random number1 = new Random();

int number = number1.Next(100,1000);

string value = number.ToString();

Console.WriteLine(number + " -> " + value[1]);