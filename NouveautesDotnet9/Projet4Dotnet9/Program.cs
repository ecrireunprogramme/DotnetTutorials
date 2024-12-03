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

var aggregatedData = data.AggregateBy(
    keySelector: x => x.clubName,
    seed: 0,
    (totalScore, curr) => totalScore + curr.score);

foreach (var item in aggregatedData)
{
    Console.WriteLine(item);
}