Console.WriteLine("Введите число:");
int a = Convert.ToInt32(Console.ReadLine());
int i = 0;
Console.WriteLine("Числа:");
while (i <= a){
    if (i%2==0) Console.WriteLine(i);
    i++;
}