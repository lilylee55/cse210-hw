using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Grade Percentage: ");
        string grade = Console.ReadLine();
        int gradePercentage = int.Parse(grade);
        
        string letter = "";
        if (gradePercentage >= 90)
        {
            letter = "A";
        }
        else if (gradePercentage >= 80)
        {
            letter = "B";
        }
        else if (gradePercentage >= 70)
        {
            letter = "C";
        }
        else if (gradePercentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        string sign = "";
        if ((gradePercentage % 10 >= 7 && gradePercentage >= 90) || (gradePercentage < 60))
        {
            sign = "";
        }
        else if (gradePercentage % 10 >= 7)
        {
            sign = "+";
        }
        else if (gradePercentage % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        // show letter and sign
        Console.WriteLine($"Your grade is {letter}{sign}.");

        if (gradePercentage >= 70)
        {
            Console.WriteLine("Congratulations, you passed!");
        }
        else
        {
            Console.WriteLine("Sorry, you failed. You can do better next time.");
        }
    }
}