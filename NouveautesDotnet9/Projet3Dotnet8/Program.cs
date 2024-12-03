// See https://aka.ms/new-console-template for more information

var quartiers = new[] { "bonaberi", "ssadi", "bonaberi", "ange-raphael", "makepe", "ssadi" };

var counts = quartiers
    .GroupBy(x => x)
    .ToDictionary(g => g.Key, g => g.Count());

foreach (var count in counts)
{
    Console.WriteLine(count);
}