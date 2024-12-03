// See https://aka.ms/new-console-template for more information
(string clubName, int score)[] data =
[
    ("aigleroyal", 42),
    ("fovuclub", 5),
    ("cotonsport", 4),
    ("aigleroyal", 10),
    ("umsloum", 25),
    ("umsloum", 40)
];

var aggregatedData = data
    .GroupBy(
        entry => entry.clubName, 
        (key, group) => (key, group))
    .ToDictionary(
        tuple => tuple.key, 
        tuple => tuple.group.Sum(z => z.score));

foreach (var item in aggregatedData)
{
    Console.WriteLine(item);
}