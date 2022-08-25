//string Number = Console.ReadLine();

//int.TryParse(Number, out int value);

//if (value > 0 & value < 8)
    //if (value == 6 ^ value == 7) Console.WriteLine(value +" -> да");
    //else
    //{
    //    Console.WriteLine(value + " -> нет");
    //}
//else
//{
//    Console.WriteLine("Введен некорректный день недели");
//}


int value = int.Parse(Console.ReadLine());

if (value > 0 & value < 8)
    switch (value)
    {
    case 6:
        Console.WriteLine(value +" -> да");
        break;
    case 7:
        Console.WriteLine(value +" -> да");
        break;
    default:
        Console.WriteLine(value + " -> нет");
        break;
    }

else
{
    Console.WriteLine("Введен некорректный день недели");
}