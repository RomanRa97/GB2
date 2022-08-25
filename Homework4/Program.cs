Random number1 = new Random();

int number = number1.Next(1,1000001);

if (number % 23 == 0 & number % 7 == 0) Console.Write("Число " + number + " кратно 23 и 7");

else
{
    Console.Write("Число " + number + " не кратно 23 и 7");
}