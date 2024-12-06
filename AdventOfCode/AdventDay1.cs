using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

List<int> left = new List<int>();
List<int> right = new List<int>();
int totalDistance = 0;

try
{
    String line;
    StreamReader sr = new StreamReader("C:\\Users\\mkeilwert\\Desktop\\Advent2024\\AdventMK24\\AdventOfCode\\Properties\\Day1Input.txt");
    line = sr.ReadLine();

    while (!string.IsNullOrEmpty(line));
    {
        string[] parts = line.Split(' ');
        left.Add(int.Parse(parts[0]));
        right.Add(int.Parse(parts[1]));

        line = sr.ReadLine();
    }
    sr.Close();
}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
}

left.Sort();
right.Sort();

for (int i = 0; i < left.Count; i++)
{
    int diff = Math.Abs(left[i] - right[i]);
    totalDistance += diff;
}

Console.WriteLine(totalDistance);