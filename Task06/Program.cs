// Конструкция switch

// Console.Write("Enter your name: ");
// string name = Console.ReadLine();


// switch (name)
// {
//     case "Bob":
//         Console.WriteLine("Your name - Bob");
//         break;
//     case "Tom":
//         Console.WriteLine("Your name - Tom");
//         break;
//     case "Sam":
//         Console.WriteLine("Your name - Sam");
//         break;
//          default:
//         Console.WriteLine("Unknown name");
//         break;
// }


// go to case:
// Console.Write("Enter number of case: ");
// int number = Convert.ToInt32(Console.ReadLine());

// switch (number)
// {
//     case 1:
//         Console.WriteLine("case 1");
//         goto case 5; // переход к case 5
//     case 2:
//         Console.WriteLine("case 2");
//         break;
//     case 3:
//         Console.WriteLine("case 3");
//         break;
//     case 4:
//         Console.WriteLine("case 4");
//         break;
//     case 5:
//         Console.WriteLine("case 5");
//         break;
//     default:
//         Console.WriteLine("default");
//         break;
// }

// Возвращение значения из switch

// int DoOperation(int op, int a, int b)
// {
//     switch (op)
//     {
//         case 1: return a + b;
//         case 2: return a - b;
//         case 3: return a * b;
//         default: return 0;
//     }
// }
 
// int result1 = DoOperation(1, 10, 5); // 15
// Console.WriteLine(result1);         // 15
 
// int result2 = DoOperation(3, 10, 5); // 50
// Console.WriteLine(result2);         // 50

// Сокращение:

int DoOperation(int op, int a, int b)
{
    int result = op switch {
        1 => a + b,
        2 => a - b,
        3 => a * b,
        _ => 0
    };
    return result;
}
int result1 = DoOperation(1, 10, 5); // 15
Console.WriteLine(result1);         // 15
 
int result2 = DoOperation(3, 10, 5); // 50
Console.WriteLine(result2); 