// --------
// Part 1

int sum = 0;
foreach (var line in File.ReadLines("input.txt"))
{
    // LINQ solution - select only the numbers in a string
    string numsOnly = string.Concat(line.Where(c => c >= '0' && c <= '9'));

    string calibrationValue = numsOnly.First().ToString() + numsOnly.Last().ToString(); 
    sum += int.Parse(calibrationValue);
}

Console.WriteLine($"Part 1: {sum}");

// --------
// Part 2

sum = 0;
foreach (var line in File.ReadLines("input.txt"))
{
    var cleanLine = line
        .Replace("one", "o1e")
        .Replace("two", "t2o")
        .Replace("three", "t3e")
        .Replace("four", "f4r")
        .Replace("five", "f5e")
        .Replace("six", "s6x")
        .Replace("seven", "s7n")
        .Replace("eight", "e8t")
        .Replace("nine", "n9e");
    
    // LINQ solution - select only the numbers in a string
    string numsOnly = string.Concat(cleanLine.Where(c => c >= '0' && c <= '9'));
    
    string calibrationValue = numsOnly.First().ToString() + numsOnly.Last().ToString(); 
    sum += int.Parse(calibrationValue);
}

Console.WriteLine($"Part 2: {sum}");
