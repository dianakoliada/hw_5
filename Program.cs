// 1
/*
Обчислення середнього заробітку: Напишіть програму, яка запитує користувача про зарплату кожного працівника за місяць. 
Після отримання всіх значень програма має обчислити та вивести середній заробіток.
*/

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



