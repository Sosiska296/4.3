double[] пиццa = new double[5]; 
Console.WriteLine("Введите 5 чисел:");
for (int i = 0; i < 5; i++)
{
    Console.Write($"Элемент {i + 1}: ");
    while (!double.TryParse(Console.ReadLine(), out пиццa[i])) ;
}
    Console.WriteLine("Итoг:");
for (int i = 4; i >= 0; i--)
{
    Console.Write(пиццa[i] + " ");
}
    Console.WriteLine();