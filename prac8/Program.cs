int node = Convert.ToInt32(Console.ReadLine());
int edge = Convert.ToInt32(Console.ReadLine());
Dictionary<int, List<int>> Dictionary = new Dictionary<int, List<int>>();
for (int i = 1; i < node + 1; i++) Dictionary.Add(i, new List<int>());
for (int i = 0; i < edge; i++)
{
    int vertexOne = Convert.ToInt32(Console.ReadLine());
    int vertexTwo = Convert.ToInt32(Console.ReadLine());
    Dictionary[vertexOne].Add(vertexTwo);
    Dictionary[vertexTwo].Add(vertexOne);
}
foreach (var item in Dictionary.Values) Console.WriteLine(String.Join(" ", item));