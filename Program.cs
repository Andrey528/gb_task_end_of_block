void Print_array(List<string> array)
{
    Console.Write($"[");
    for (int i = 0; i < array.Count; i++)
    {
        if (i == array.Count - 1) 
            Console.Write($"\"{array[i]}\"");
        else 
            Console.Write($"\"{array[i]}\", ");
    }
    Console.Write($"]");
}

Console.WriteLine($"Пользователь вводит с клавиатуры строки. " +
    $"Каждую строку пользователь разделяет через ,");

string[] usrArray = Console.ReadLine()!.Split(',');
List<string> newArray = new List<string>();
int stringLength = 3;
Random r = new Random();

for (int index = 0; index < usrArray.Length; index++)
{
    if (usrArray[index].Length <= stringLength)
        newArray.Add(usrArray[index]);
}

Print_array(newArray);