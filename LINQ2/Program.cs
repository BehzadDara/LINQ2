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