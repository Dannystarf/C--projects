using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string gradePercentage = Console.ReadLine();
        int grade = int.Parse(gradePercentage);

        string letter;

        if (grade >= 90)
        {
            letter = "A";
            if (grade < 93)
            {
                letter = "A-";
            }
        }

        else if (grade >= 80)
        {
            letter = "B";
            if (grade < 83)
            {
                letter = "B-";
            }
            else if (grade >= 87)
            {
                letter = "B+";
            }
        }

        else if (grade >= 70)
        {
            letter = "C";
            if (grade <73)
            {
                letter = "C-";
            }
            else if (grade >= 77)
            {
                letter = "C+";
            }
        }

        else if (grade >= 60)
        {
            letter = "D";
            if (grade < 63)
            {
                letter = "D-";
            }
            else if (grade >= 67)
            {
                letter = "D+";
            }
        }

        else
        {
            letter = "F";
        }

        Console.WriteLine($"You have {letter} in this course");

        if (grade >= 70)
        {
            Console.WriteLine("Congratulations you passed this course");
        }
        else
        {
            Console.WriteLine("Ops, you failed. But this is not the end of the road, it an opportunity to try again but this time with a lot of expereinces.");
        }    
    }
}