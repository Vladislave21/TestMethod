using TestMethod;

List<int> oldValues = new List<int>() { 1, 2, 3 };
List<int> newValues = WorkWithNumbers.IncrementValues(oldValues);

Console.Write("Old values: ");
oldValues.ForEach(x =>  Console.Write($"{x} "));

Console.Write("\n\nNew values: ");
newValues.ForEach(x => Console.Write($"{x} "));
Console.WriteLine();