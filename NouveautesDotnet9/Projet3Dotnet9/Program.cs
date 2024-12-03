// See https://aka.ms/new-console-template for more information
var quartiers = new[] { "bonaberi", "ssadi", "bonaberi", "ange-raphael", "makepe", "ssadi" };

var counts = quartiers.CountBy(x => x);

foreach (var count in counts)
{
    Console.WriteLine(count);
}