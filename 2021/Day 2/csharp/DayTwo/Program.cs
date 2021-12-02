
var horizontal = 0;
var depth = 0;
var aim = 0;

var actionTableA = new Dictionary<string, Action<int>>()
{
    { "forward", (value) => horizontal += value },
    { "down", (value) => depth += value },
    { "up", (value) => depth -= value },
};

var actionTableB = new Dictionary<string, Action<int>>()
{
    { "forward", (value) =>
        {
            horizontal += value;
            depth += aim * value;
        }
    },
    { "down", (value) => aim += value },
    { "up", (value) => aim -= value },
};

var linesList = File.ReadAllLines("data.input")
    .Select(line => line.Split(' '))
    .ToList();

// Day 1 / A
linesList.ForEach(line => actionTableA[line[0]](int.Parse(line[1])));

Console.WriteLine(horizontal * depth);

// Day 1 / B
horizontal = 0;
depth = 0;
linesList.ForEach(line => actionTableB[line[0]](int.Parse(line[1])));

Console.WriteLine(horizontal * depth);