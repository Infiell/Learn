int repetitions;
string message;

Console.Write("Введите сообщение для вывода: ");
message = Console.ReadLine();
Console.Write("Введите количество выводов данного сообщения: ");
repetitions = Convert.ToInt32(Console.ReadLine());

for (int i = 0; i < repetitions; i++)
{
    Console.WriteLine(message);
}