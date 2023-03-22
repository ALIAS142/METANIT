//Найдем количество положительных чисел в массиве:
// мойвариант:
// int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4, 5, 6 };

// int count = 0;

// for (int i = 0; i < numbers.Length; i++)
// {
//     if(numbers[i] > 0);
//     {count = numbers[i];
//     }
   
// }
//  Console.WriteLine(count);

//  2 вариант:

int[] numbers = { -4, -3, -2, -1, 0, 1, 2, 3, 4 };
int result = 0;
foreach(int number in numbers)
{
    if(number > 0)
    {
        result++; 
    }
}
Console.WriteLine($"Число элементов больше нуля: {result}");

// result++ - >>> result = result + 1