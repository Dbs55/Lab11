// int[] recordBooks = { 1042, 1058, 1071, 1093, 1105 };
// int target = 1072;
// bool found = false;

// foreach (int number in recordBooks)
// {
//     if (number == target)
//     {
//         found = true;
//         break;
//     }
// }
// Console.WriteLine(found ? "Студент найден" : "Студент не найден");

// int variant = 4;
// bool isPrime = true;

// if (variant < 2)
// {
//     isPrime = false;
// }
// else
// {
//     for (int divisor = 2; divisor < variant; divisor++)
//     {
//         if (variant % divisor == 0)
//         {
//             isPrime = false;
//             break;
//         }
//     }
// }
// Console.WriteLine(isPrime ? "Номер варианта простой" : "Номер варианта составной");

// int[] points = { 8, -1, 10, 9, -1, 7 };
// int sum = 0, count = 0;

// foreach (int p in points)
// {
//     if (p < 0)
//     {
//         continue;
//     }
//     sum += p;
//     count++;
// }
// Console.WriteLine($"Сумма: {sum}, работ: {count}");
// int[] groups = { 101, 104, 107, 104, 110 };
// bool dub = false;

// for (int i = 0; i < groups.Length && !dub; i++)
// {
//     for (int j = i + 1; j < groups.Length; j++)
//     {
//         if (groups[i] == groups[j])
//         {
//             Console.WriteLine($"Дубликат: {groups[i]}");
//             dub = true;
//             break;
//         }
//     }
// }
// Console.WriteLine(dub ? "Есть дубликаты" : "Дубликатов нет");

// int days = 5, lessons = 6;
// bool slotFound = false;

// for (int d = 1; d <= days && !slotFound; d++)
// {
//     for (int l = 1; l <= lessons; l++)
//     {
//         if (d == 3 && l == 4)
//         {
//             Console.WriteLine($"Слот: день {d}, урок {l}");
//             slotFound = true;
//             break;
//         }
//     }
// }
// if (!slotFound) Console.WriteLine("Свободных слотов нет");

//B

// int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
// int count = 0;
// for (int i = 0; i < numbers.Length; i++)
// {
//     if (numbers[i] % 2 == 0)
//     {
//         count += numbers[i];

//     }
//     else { continue; }
// }
// System.Console.WriteLine(count);

//Г

// int[] groups = { 101, 104, 107, 104, 110 };
// for (int i = 0; i < groups.Length; i++)
// {
//     for (int j = i + 1; j < groups.Length; j++)
//     {
//         if (groups[i] == groups[j])
//         {
//             Console.WriteLine("Есть дубликаты");
//             break;
//         }
//         else
//         {
//             continue;
//         }
//     }
// }

while (true)
{
    int number = int.Parse(Console.ReadLine());
    if (number == 0)
        break;

    bool isPrime = true;
    if (number <= 1)
    {
        Console.WriteLine($"{number} - не простое");
        continue;
    }
    for (int divisor = 2; divisor < number; divisor++)
    {
        if (number % divisor == 0)
        {
            isPrime = false;
            break;
        }
    }
    Console.WriteLine($"{number} - {(isPrime ? "простое" : "составное")}");
}


int[] groups = { 101, 10, 107, 1, 110 };
int[] groups2 = { 108, 94, 14, 11, 88, 99, 104 };
bool dub = false;

for (int i = 0; i < groups.Length && !dub; i++)
{
    for (int j = 0; j < groups2.Length; j++)
    {
        if (groups[i] == groups2[j])
        {
            Console.WriteLine($"Дубликат: {groups[i]}");
            dub = true;
            break;
        }
    }
}
Console.WriteLine(dub ? "Есть дубликаты" : "Дубликатов нет");
