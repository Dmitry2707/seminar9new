Console.WriteLine("Выберите задание");
Console.WriteLine("задание 66");
Console.WriteLine("задание 68");
int n = Convert.ToInt32(Console.ReadLine());
switch (n)
{
    case 1:
        task1();
        break;
    case 2:
        task2();
        break; 
}
void task1()
{        
int InputNumber(string input)
{
     Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
 }

 void PrintSum(int m, int n, int sum)
 {
     sum = sum + n;
     if (n <= m)
    {
         Console.Write($" {sum} ");
         return;
     }
     PrintSum(m, n - 1, sum);

 }
 int m = InputNumber("Ввод m: ");
 int n = InputNumber("Ввод n: ");
 int temp = m;

 if (m > n)
 {
     m = n;
     n = temp;
 }
 Console.Write($"{m}, {n} ->");
 PrintSum(m, n, temp = 0);
}
void task2()
{
    int InputNumber(string input)
{
Console.Write(input);
int output = Convert.ToInt32(Console.ReadLine());
return output;
}
int Akkerman(int m, int n)
{
if (m == 0)
{
return n + 1;
}
else if (n == 0 && m > 0)
{
return Akkerman(m - 1, 1);
}
else
{
return Akkerman(m - 1, Akkerman(m, n - 1));
}
}

int m = InputNumber("Ввод m: ");
int n = InputNumber("Ввод n: ");
int akkermanFunction = Akkerman(m, n);
Console.Write($"m = {m}, n = {n} - > A(m,n) = {akkermanFunction} ");
    
  }

