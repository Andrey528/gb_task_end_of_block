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
int index2 = 0;
int stringLength = 3;
Random r = new Random();

for (int index1 = 0; index1 < usrArray.Length; index1++)
{
    if (usrArray[index1].Length <= stringLength)
    {
        newArray.Add(usrArray[index1]);
        index2++;
    }
}

Print_array(newArray);