// Массив параметров и ключевое слово params

// void Sum(int initialValue, params int[]  numbers)
// {
//     int result = initialValue;
//     foreach (var n in numbers)
//     {
//         result += n;
//     }
//     Console.WriteLine(result);
// }
 
// int[] nums = { 1, 2, 3, 4, 5};
// Sum(10, nums);  // число 10 - передается параметру initialValue
// Sum(1, 2, 3, 4);
// Sum(1, 2, 3);
// Sum(20);

// Факториал

// int Factorial(int n)
// {
//     if (n == 1) return 1;
 
//     return n * Factorial(n - 1);
// }
 
// int factorial4 = Factorial(4);
// Console.WriteLine($"Factorial 4 = {factorial4}");

// Фибоначчи

// int Fibonachi(int n)
// {
//     if (n == 0 || n == 1) return n;
     
//     return Fibonachi(n - 1) + Fibonachi(n - 2);
// }
 
// int fib4 = Fibonachi(4);
// int fib5 = Fibonachi(5);
// int fib6 = Fibonachi(6);
 
// Console.WriteLine($"4 число Фибоначчи = {fib4}");
// Console.WriteLine($"5 число Фибоначчи = {fib5}");
// Console.WriteLine($"6 число Фибоначчи = {fib6}");


// вычисление чисел Фибоначчи с помощью циклов:
static int Fibonachi2(int n)
{
    int result = 0;
    int b = 1;
    int tmp;
 
    for (int i = 0; i < n; i++)
    {
        tmp = result;
        result = b;
        b += tmp;
    }
 
    return result;
   
}
int fib = 5;
Console.WriteLine(Fibonachi2(fib));


