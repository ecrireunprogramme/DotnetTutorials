// See https://aka.ms/new-console-template for more information

IEnumerable<string> lines2 = File.ReadAllLines("output.txt");

// Initialize a counter for indexing
int index = 0;

foreach (string line in lines2)
{
    Console.WriteLine($"Line number: {index + 1}, Line: {line}");
    index++; // Increment the counter manually
}