// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
int m = InputNumbers("Введите значение m: ");
int n = InputNumbers("Введите значение n: ");
int temp = m;

if (m > n) 
{
  m = n; 
  n = temp;
}

PrintSum(m, n, temp=0);

void PrintSum(int m, int n, int summ)
{
  summ = summ + n;
  if (n <= m)
  {
    Console.Write($"Сумма натуральных элементов в промежутке введенных значений = {summ} ");
    return;
  }
  PrintSum(m, n - 1, summ);
}

int InputNumbers(string input) 
{
  Console.Write(input);
  int output = Convert.ToInt32(Console.ReadLine());
  return output;
}