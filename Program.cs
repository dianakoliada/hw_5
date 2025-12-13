// 1
/*
Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
Після отримання всіх значень програма має обчислити та вивести середній заробіток.
*/

/* 

int[] salary = new int[5];
int salaryNumber;
int averageNum = 0;
int sum = 0;
int j;
int i;

for (i = 0; i <= 4; i++)
{
    Console.WriteLine("Enter a number:");
    salaryNumber = Convert.ToInt32(Console.ReadLine());
    salary[i] = salaryNumber;
};

for (j = 0; j < salary.Length; j++)
{
    sum += salary[j];
    averageNum = sum / salary.Length;
}
;

Console.WriteLine("The average salary is:" + averageNum);

*/


// 2
/*
Побудова графіку зірочками: Напишіть програму, яка будує графік за допомогою зірочок. 
Користувач повинен ввести кількість рядків графіка. 
Кожен рядок графіка має містити відповідну кількість зірочок.
*/

/*

Console.WriteLine("Enter rows number:");
int row = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i <= row; i++)
{
    for (int j = 0; j < i; j++)
    {
        Console.Write('*');
    }
    Console.WriteLine();
}
*/

// 3
/*
Генерація простих чисел: Напишіть програму, яка генерує прості числа від 1 до заданого користувачем числа. 
Просте число - це число, яке ділиться лише на 1 і на себе.
*/

/*
Console.WriteLine("Enter a number:");
int number = Convert.ToInt32(Console.ReadLine());

for (int i = 2; i <= number; i++)
{
    bool isPrime = true;

    for (int j = 2; j < i; j++)
    {
        if (i % j == 0)
        {
            isPrime = false;
            break;

        }
    }

    if (isPrime) Console.WriteLine(i);

}
*/


// 5
/*
Калькулятор оплати праці за годину: Напишіть "програму, яка запитує в користувача кількість годин, працюваних за день, та розмір годинної ставки. 
Після введення значень програма має обчислити та вивести оплату за день.
*/

/*
bool isLastEmployee = false;
var userInput = "";
bool isProperHoursInput = false;
bool isProperSalaryInput = false;
double hours = 0;
decimal salaryPerHour = 0;
decimal salaryTotal = 0;

do
{
    do
    {
        Console.WriteLine("Enter your working hours:");
        var userInputHours = Console.ReadLine();
        isProperHoursInput = double.TryParse(userInputHours, out hours);
    } while (!isProperHoursInput);

    do
    {
        Console.WriteLine("Enter your salary per hour:");
        var userInputSalary = Console.ReadLine();
        isProperSalaryInput = decimal.TryParse(userInputSalary, out salaryPerHour);
    } while (!isProperSalaryInput);

    salaryTotal = (decimal)hours * salaryPerHour;
    Console.WriteLine($"Congrats! Today you have earned {salaryTotal} UAH.");

    Console.WriteLine("Press any key.");
    userInput = Console.ReadLine();
    if (userInput == "-")
    {
        isLastEmployee = true;
        Console.WriteLine("That was the last employee.");
    }

} while (!isLastEmployee);
*/


// 6
/*
Генерація таблиці множення для конкретного числа: 
Напишіть програму, яка запитує в користувача число, а потім генерує таблицю множення для цього числа від 1 до 10.
*/

/*
var integer = 0;
bool isProperInteger = false;
var result = 0;

do
{
    Console.WriteLine("Enter any integer:");
    var userInput = Console.ReadLine();
    isProperInteger = int.TryParse(userInput, out integer);


} while (!isProperInteger);

for (int i = 1; i <= 10; i++)
{
    result = i * integer;
    Console.WriteLine($"{i} * {integer} = {result};");
}
*/




