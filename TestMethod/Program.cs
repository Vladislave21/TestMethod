using TestMethod;

List<int> oldValues = new List<int>() { 1, 2, 3 };
List<int> newValues = WorkWithNumbers.IncrementValues(oldValues);

ShowValues("Old values: ", oldValues);
ShowValues("New values: ", newValues);

void ShowValues(string message, List<int> values)
{
    Console.Write(message);
    values.ForEach(x => Console.Write($"{x} "));
    Console.WriteLine();
}