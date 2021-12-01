// See https://aka.ms/new-console-template for more information

var linesAsInt = File.ReadAllLines("./data.input").Select(int.Parse);

int? prevNum = null;
var totalIncreases = 0;

foreach (var num in linesAsInt)
{
    totalIncreases += num > prevNum ? 1 : 0;
    prevNum = num;
}

Console.WriteLine(totalIncreases);