using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<int> left = new List<int>();
        List<int> right = new List<int>();
        int totalDistance = 0;

        try
        {
            // Use "using" statement for automatic resource cleanup
            using (StreamReader sr = new StreamReader("C:\\Users\\mkeilwert\\Desktop\\Advent2024\\AdventMK24\\AdventOfCode\\Properties\\Day1Input.txt"))
            {
                string line;
                while (!string.IsNullOrEmpty(line = sr.ReadLine()))
                {
                    // Split based on three spaces
                    string[] parts = line.Split(new[] { "   " }, StringSplitOptions.None);
                    if (parts.Length == 2) // Ensure two parts exist
                    {
                        left.Add(int.Parse(parts[0]));
                        right.Add(int.Parse(parts[1]));
                    }
                    else
                    {
                        Console.WriteLine($"Invalid line format: {line}");
                    }
                }
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
            return; // Exit on error
        }

        // Sort both lists
        left.Sort();
        right.Sort();

        // Calculate total distance
        for (int i = 0; i < left.Count; i++)
        {
            totalDistance += Math.Abs(left[i] - right[i]);
        }

        // Output result
        Console.WriteLine($"Total Distance: {totalDistance}");
    }
}
