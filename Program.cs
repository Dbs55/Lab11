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

// int variant = 17;
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