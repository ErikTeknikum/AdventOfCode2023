using System;
using System.Linq;
using System.Runtime.InteropServices;

//Call which day you would like to solve
//↓↓↓↓↓↓

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

void Day2Part1()
{
    string[] input = File.ReadAllLines("day2.txt");
}

void Day2Part2()
{
    string[] input = File.ReadAllLines("day2.txt");
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