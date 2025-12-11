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


