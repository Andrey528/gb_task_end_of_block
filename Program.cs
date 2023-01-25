Console.WriteLine($"Пользователь вводит с клавиатуры строки. " +
    $"Каждую строку пользователь разделяет через \n");

string[] usrArray = Console.ReadLine()!.Split('\n');
List<string> newArray = new List<string>();
int index2 = 0;

for (int index1 = 0; index1 < usrArray.Length; index1++)
{
    if ((new Random().Next(0, 1) == 1) && (index2 < 3))
    {

    }
}
