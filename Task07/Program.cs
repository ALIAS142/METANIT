// Перечисления enum

// DayTime dayTime = DayTime.Morning;
 
// if(dayTime == DayTime.Morning)  
//     Console.WriteLine("Good morning");
// else
//     Console.WriteLine("Hello");
 
// enum DayTime
// {
//     Morning,
//     Afternoon,
//     Evening,
//     Night
// }


// DayTime now = DayTime.Evening;
 
// PrintMessage(now);                   // Добрый вечер
// PrintMessage(DayTime.Afternoon);    // Добрый день
// PrintMessage(DayTime.Night);        // Доброй ночи
 
// void PrintMessage(DayTime dayTime)
// {
//     switch (dayTime)
//     {
//         case DayTime.Morning:
//             Console.WriteLine("Good morning");
//             break;
//         case DayTime.Afternoon:
//             Console.WriteLine("Good afternoon");
//             break;
//         case DayTime.Evening:
//             Console.WriteLine("Good evening");
//             break;
//         case DayTime.Night:
//             Console.WriteLine("Good night");
//             break;
//     }
// }
// enum DayTime
// {
//     Morning,
//     Afternoon,
//     Evening,
//     Night
// }


// перечисление Operation

DoOperation(10, 5, Operation.Add);          // 15
DoOperation(10, 5, Operation.Subtract);     // 5
DoOperation(10, 5, Operation.Multiply);     // 50
DoOperation(10, 5, Operation.Divide);       // 2
 
void DoOperation(double x, double y, Operation op)
{
    double result = op switch
    {
        Operation.Add => x + y,
        Operation.Subtract => x - y,
        Operation.Multiply => x * y,
        Operation.Divide => x / y
    };
    Console.WriteLine(result);
}
enum Operation
{Add,
Subtract,
 Multiply,
    Divide,
    
    
   
    
}