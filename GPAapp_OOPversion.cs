using System;

class Student
{
    public string Name { get; }
    public int[] Scores { get; }
    public int ExamAssignments { get; }

    public Student(string name, int[] scores, int examAssignments)
    {
        Name = name;
        Scores = scores;
        ExamAssignments = examAssignments;
    }

    public decimal CalculateExamScore()
    {
        decimal examScoreTotal = 0;

        for (int i = 0; i < ExamAssignments; i++)
        {
            examScoreTotal += Scores[i];
        }

        return examScoreTotal / ExamAssignments;
    }

    public decimal CalculateOverallGrade()
    {
        decimal examScoreTotal = 0;
        decimal extraCreditPoints = 0;

        for (int i = 0; i < Scores.Length; i++)
        {
            if (i < ExamAssignments)
            {
                examScoreTotal += Scores[i];
            }
            else
            {
                // Each extra-credit assignment is worth 10%
                // of a normal exam assignment.
                extraCreditPoints += Scores[i] / 10m;
            }
        }

        return (examScoreTotal + extraCreditPoints) / ExamAssignments;
    }

    public decimal CalculateExtraCreditAverage()
    {
        int extraCreditAssignmentCount = Scores.Length - ExamAssignments;

        if (extraCreditAssignmentCount == 0)
        {
            return 0;
        }

        decimal extraCreditScoreTotal = 0;

        for (int i = ExamAssignments; i < Scores.Length; i++)
        {
            extraCreditScoreTotal += Scores[i];
        }

        return extraCreditScoreTotal / extraCreditAssignmentCount;
    }

    public decimal CalculateExtraCreditPoints()
    {
        decimal extraCreditPoints = 0;

        for (int i = ExamAssignments; i < Scores.Length; i++)
        {
            extraCreditPoints += Scores[i] / 10m;
        }

        return extraCreditPoints / ExamAssignments;
    }

    public string GetLetterGrade()
    {
        decimal overallGrade = CalculateOverallGrade();

        if (overallGrade >= 97)
            return "A+";
        else if (overallGrade >= 93)
            return "A";
        else if (overallGrade >= 90)
            return "A-";
        else if (overallGrade >= 87)
            return "B+";
        else if (overallGrade >= 83)
            return "B";
        else if (overallGrade >= 80)
            return "B-";
        else if (overallGrade >= 77)
            return "C+";
        else if (overallGrade >= 73)
            return "C";
        else if (overallGrade >= 70)
            return "C-";
        else if (overallGrade >= 67)
            return "D+";
        else if (overallGrade >= 63)
            return "D";
        else if (overallGrade >= 60)
            return "D-";
        else
            return "F";
    }

    public void DisplayGradeReport()
    {
        decimal examScore = CalculateExamScore();
        decimal overallGrade = CalculateOverallGrade();
        decimal extraCreditAverage = CalculateExtraCreditAverage();
        decimal extraCreditPoints = CalculateExtraCreditPoints();
        string letterGrade = GetLetterGrade();

        Console.WriteLine(
            $"{Name,-15}" +
            $"{examScore,10:F1}" +
            $"{overallGrade,12:F1}" +
            $"{letterGrade,8}" +
            $"{extraCreditAverage,12:F1} ({extraCreditPoints:F1} pts)"
        );
    }
}

class Program
{
    static void Main()
    {
        int examAssignments = 5;

        Student[] students =
        {
            new Student(
                "Sophia",
                new int[] { 90, 86, 87, 98, 100, 94, 90 },
                examAssignments
            ),

            new Student(
                "Andrew",
                new int[] { 92, 89, 81, 96, 90, 89 },
                examAssignments
            ),

            new Student(
                "Emma",
                new int[] { 90, 85, 87, 98, 68, 89, 89, 89 },
                examAssignments
            ),

            new Student(
                "Logan",
                new int[] { 90, 95, 87, 88, 96, 96 },
                examAssignments
            )
        };

        Console.WriteLine(
            $"{"Student",-15}" +
            $"{"Exam Score",10}" +
            $"{"Overall",12}" +
            $"{"Grade",8}" +
            $"{"Extra Credit",25}"
        );

        Console.WriteLine(new string('-', 70));

        foreach (Student student in students)
        {
            student.DisplayGradeReport();
        }

        Console.WriteLine("\nPress the Enter key to continue.");
        Console.ReadLine();
    }
}