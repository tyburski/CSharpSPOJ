List<int> inputList = new List<int>();
var input = Console.ReadLine();
while (input != string.Empty)
{
    if (Convert.ToInt32(input) == 42) break;
    inputList.Add(Convert.ToInt32(input));
    input = Console.ReadLine();
}
foreach (var i in inputList)
{
    Console.WriteLine(i);
}