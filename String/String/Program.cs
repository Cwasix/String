string row = Console.ReadLine();
Console.WriteLine($"{row}");

string sign = "!!!";
string dash ="-";
string dollar = "$";

string[] line = { "0","1","2","3","4","5","6","7","8","9",};

int point = row.LastIndexOf(".");
Console.WriteLine($"{point}");

row = row.Remove(point);
row = row.Insert(point ,sign);
Console.WriteLine($"{row}");

for (int i = 0; i < line.Length; i++)
{
    point = row.LastIndexOf(line[i]);
    if (point > 0)
    {
        Console.WriteLine($"{point}");
        row = row.Insert(point, dash);
        Console.WriteLine($"{row}");
        row = row.Insert(point + 2, dollar);
        Console.WriteLine($"{row}");
    }
};
Console.WriteLine($"{point}");
Console.WriteLine($"{row}");
Console.ReadKey();