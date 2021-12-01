var linesAsInt = File.ReadAllLines("./data.input").Select(int.Parse).ToArray();

#region DayOneA
int? prevNum = null;
var totalIncreases = 0;

foreach (var num in linesAsInt)
{
    totalIncreases += num > prevNum ? 1 : 0;
    prevNum = num;
}

Console.WriteLine(totalIncreases);

#endregion

#region DayOneB

totalIncreases = 0;
int? prevThreeSum = null;

for (var i = 2; i < linesAsInt.Length; i++)
{
    var currentThreeSum = linesAsInt[i] + linesAsInt[i - 1] + linesAsInt[i - 2];
    totalIncreases += currentThreeSum > prevThreeSum ? 1 : 0;
    prevThreeSum = currentThreeSum;
}

Console.WriteLine(totalIncreases);

#endregion