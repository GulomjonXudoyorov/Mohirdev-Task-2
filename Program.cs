//1st task

// Console.Write("Enter the first number: ");
//             double num1 = Convert.ToDouble(Console.ReadLine());

//             Console.Write("Enter an operator (+, -, *, /): ");
//             char operation = Convert.ToChar(Console.ReadLine());

//             Console.Write("Enter the second number: ");
//             double num2 = Convert.ToDouble(Console.ReadLine());

//             double result = 0;

//             switch (operation)
//             {
//                 case '+':
//                     result = num1 + num2;
//                     break;
//                 case '-':
//                     result = num1 - num2;
//                     break;
//                 case '*':
//                     result = num1 * num2;
//                     break;
//                 case '/':
//                     if (num2 != 0)
//                         result = num1 / num2;
//                     else
//                         Console.WriteLine("Error: Division by zero is not allowed!");
//                         break;
//                 default:
//                     Console.WriteLine("Error: Invalid operator.");
//                     return;
//             }

//             Console.WriteLine($"Result: {result}");

//2nd task

Console.Write("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

int sum = 0;

for (int i = 0; i <= number; i++){
    sum+=i;
}

Console.WriteLine($"Result: {sum}");

//3rd task

// Console.Write("Enter a number:");
// int number = Convert.ToInt32(Console.ReadLine());
// string result = (number % 2 == 0)  ?  "Juft" : "Toq";
// Console.WriteLine($"Result: {result}");