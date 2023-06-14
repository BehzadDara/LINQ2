// TakeWhile

var sample1 = new int[] { 1, 3, 5, 2, 7, 9, 1, 0, 3, 8 };
Console.WriteLine($"take while a condition is false: {string.Join(", ", sample1.TakeWhile(n => n < 6))}");
// 1, 3, 5, 2

// Zip
var sample21 = new int[] { 0, 2, 4, 5, 6 };
var sample22 = new int[] { 1, 3, 5, 7, 8 };
Console.WriteLine($"dot product of two array: {string.Join(", ", sample21.Zip(sample22, (a, b) => a * b))}");
// 0, 6, 20, 35, 48

// SelectMany
var sample31 = new int[] { 0, 5, 9};
var sample32 = new int[] { 1, 7, 8};
Console.WriteLine($"two select together: {string.Join(", ", sample31.SelectMany(a => sample32.Where(b => a < b), (a, b) => (a, b)))}");
// (0, 1), (0, 7), (0, 8), (5, 7), (5, 8)

// Eager and Lazy SELECT
var sample41 = new int[] { 5, 4, 1, 2, 8, 6, 7, 2, 0 };
var i1 = 0;
var q1 = sample41.Select(n => ++i1); // lazy
Console.WriteLine("print i1 without ToList:");
foreach (var v1 in q1)
{
    Console.WriteLine($"v1 = {v1}, i1 = {i1}");
}
var i2 = 0;
var q2 = sample41.Select(n => ++i2).ToList(); // eager
Console.WriteLine("print i2 with ToList:");
foreach (var v2 in q2)
{
    Console.WriteLine($"v2 = {v2}, i2 = {i2}");
}
// 1,2,3,4 ... // 9,9,9,9 ...

