using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;

//Call which day you would like to solve
//↓↓↓↓↓↓
Day2Part1AndPart2();
//↑↑↑↑↑↑

void Day1Part1()
{
    string[] input = File.ReadAllLines("day1.txt");

    char firstNum = ' ';
    char lastNum = ' ';
    int rows = 1;
    int sum = 0;

    Console.WriteLine("Day 1 Part 1: ");
    Console.WriteLine();

    foreach (string line in input)
    {
        firstNum = line.First(c => Char.IsDigit(c));
        lastNum = line.Last(c => Char.IsDigit(c));
        string combinedNumber = firstNum.ToString() + lastNum.ToString();
        sum += Convert.ToInt32(combinedNumber);

        rows++;
        if(rows == 1000)
        {
            Console.WriteLine("Final sum is: " + sum);
        }
    }

}

void Day1Part2()
{
    string[] input = File.ReadAllLines("day1.txt");
    char firstNum = ' ';
    char lastNum = ' ';
    int sum = 0;
    int rows = 1;

    Console.WriteLine("Day 1 Part 2: ");
    Console.WriteLine();

    foreach (string line in input)
    {
        string newLine = line;
        newLine = Replacer(newLine);
        firstNum = newLine.First(c => Char.IsDigit(c));
        lastNum = newLine.Last(c => Char.IsDigit(c));
        string combinedNumber = firstNum.ToString() + lastNum.ToString();
        sum += Convert.ToInt32(combinedNumber);

        rows++;
        if (rows == 1001)
        {
            Console.WriteLine("Final sum is: " + sum);
        }
    }


    string Replacer(string fixline)
    {
        string stringNinEight = "nineight"; //98
        string stringEighThree = "eighthree"; //83
        string stringEighTwo = "eightwo"; //82
        string stringSeveNine = "sevenine"; //79
        string stringFiveIght = "fiveight"; //58
        string stringThreEight = "threeight"; //38
        string stringTwOne = "twone"; //21
        string stringOnEight = "oneight"; //18

        string stringOne = "one";
        string stringTwo = "two";
        string stringThree = "three";
        string stringFour = "four";
        string stringFive = "five";
        string stringSix = "six";
        string stringSeven = "seven";
        string stringEight = "eight";
        string stringNine = "nine";

        fixline = fixline.Replace(stringThreEight, "38");
        fixline = fixline.Replace(stringEighTwo, "82");
        fixline = fixline.Replace(stringEighThree, "83");
        fixline = fixline.Replace(stringOnEight, "18");
        fixline = fixline.Replace(stringSeveNine, "79");
        fixline = fixline.Replace(stringFiveIght, "58");
        fixline = fixline.Replace(stringTwOne, "21");
        fixline = fixline.Replace(stringNinEight, "98");

        fixline = fixline.Replace(stringOne, "1");
        fixline = fixline.Replace(stringTwo, "2");
        fixline = fixline.Replace(stringThree, "3");
        fixline = fixline.Replace(stringFour, "4");
        fixline = fixline.Replace(stringFive, "5");
        fixline = fixline.Replace(stringSix, "6");
        fixline = fixline.Replace(stringSeven, "7");
        fixline = fixline.Replace(stringEight, "8");
        fixline = fixline.Replace(stringNine, "9");

        return fixline;
    }
}

void Day2Part1AndPart2()
{

    var input = File.ReadAllLines("day2.txt").ToList();

    long answer1 = 0, answer2 = 0;

    var S = File.ReadAllLines("day2.txt").ToList();

    foreach (var s in S)
    {
        var s1 = s.Split(": ");
        var game = int.Parse(s1[0].Split(" ")[1]);
        bool possible = true;
        int maxred = 0, maxgreen = 0, maxblue = 0;
        foreach (var s2 in s1[1].Split("; "))
        {
            int blue = 0;
            int green = 0;
            int red = 0;

            foreach (var s3 in s2.Split(", "))
            {

                var s4 = s3.Split(" ");
                if (s4[1] == "red") red = int.Parse(s4[0]);
                if (s4[1] == "green") green = int.Parse(s4[0]);
                if (s4[1] == "blue") blue = int.Parse(s4[0]);
            }
            if (red > 12 || green > 13 || blue > 14) possible = false;
            if (maxred < red) maxred = red;
            if (maxgreen < green) maxgreen = green;
            if (maxblue < blue) maxblue = blue;

        }
        if (possible) answer1 += game;
        answer2 += maxred * maxgreen * maxblue;

    }
    Console.WriteLine($"Part1 = {answer1}");
    Console.WriteLine($"Part2 = {answer2}");
}

void Day3Part1()
{
    string[] input = File.ReadAllLines("day3.txt");
}

void Day3Part2()
{
    string[] input = File.ReadAllLines("day3.txt");
}

void Day4Part1()
{
    string[] input = File.ReadAllLines("day4.txt");
}

void Day4Part2()
{
    string[] input = File.ReadAllLines("day4.txt");
}