using System;


int examAssignments = 5;
/*int[] studentScores = new int[10];
int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };    */
Console.WriteLine("Enter the number of students in the class: ");
int numberOfStudents = int.Parse(Console.ReadLine());
int[] studentCount = new int[numberOfStudents];
string[] studentNames = new string[numberOfStudents];
decimal [] studentGrades = new decimal[numberOfStudents];
string[] studentLetterGrades = new string[numberOfStudents];

for(int studentIndex=0; studentIndex<numberOfStudents; studentIndex++)
{
    Console.WriteLine($"\n student {studentIndex + 1} ");
   
Console.Write("Please enter the student name to calculate the grade for: ");

string currentStudent = Console.ReadLine();

int[] studentScores = new int[10];
for (int i = 0; i < examAssignments; i++)
{
    while (true)
    {
        Console.WriteLine($"Please enter the score for assignment {i + 1}: ");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int score) && score >= 0 && score <= 100)
        {
            studentScores[i] = score;
            break;
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid score between 0 and 100.");
        }
    }

}
// Student names
//string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };
string currentStudentLetterGrade = "";
Console.WriteLine("Student\t\tGrade\n");




     int sumAssignmentsScores = 0;

        decimal currentStudentGrade = 0;
        int gradedAssignments = 0;
        foreach (int score in studentScores)
        {
             gradedAssignments++;
            
           
            if (gradedAssignments <= examAssignments)
            
                sumAssignmentsScores += score;
            
            else
        
           sumAssignmentsScores += score / 10;
        
        }





        currentStudentGrade = (decimal)sumAssignmentsScores / examAssignments;

           if(currentStudentGrade >= 97)
        {
            currentStudentLetterGrade = "A+";
        }
        else if(currentStudentGrade >= 93)
        {
            currentStudentLetterGrade = "A";
        }
        else if(currentStudentGrade >= 90)
        {
            currentStudentLetterGrade = "A-";
        }
        else if(currentStudentGrade >= 87)
        {
            currentStudentLetterGrade = "B+";
        }
        else if(currentStudentGrade >= 83)
        {
            currentStudentLetterGrade = "B";
        }
        else if(currentStudentGrade >= 80)
        {
            currentStudentLetterGrade = "B-";
        }
        else if(currentStudentGrade >= 77)
        {
            currentStudentLetterGrade = "C+";
        }
        else if(currentStudentGrade >= 73)
        {
            currentStudentLetterGrade = "C";
        }
        else if(currentStudentGrade >= 70)
        {
            currentStudentLetterGrade = "C-";
        }
        else if(currentStudentGrade >= 67)
        {
            currentStudentLetterGrade = "D+";
        }
         else if(currentStudentGrade >= 63)
         {
             currentStudentLetterGrade = "D";
         }
         else if(currentStudentGrade >= 60)
         {
             currentStudentLetterGrade = "D-";
         }
         else
         {
             currentStudentLetterGrade = "F";
         }

         studentNames[studentIndex] = currentStudent;
         studentGrades[studentIndex] = currentStudentGrade;
         studentLetterGrades[studentIndex] = currentStudentLetterGrade;




         

        
        Console.WriteLine(currentStudent + ":\t\t" + currentStudentGrade + "\t" + currentStudentLetterGrade + "\n");


}
Console.WriteLine("\nClass Grades:");
Console.WriteLine("Student\t\tGrade\tLetter");
Console.WriteLine("--------------------------------");

for (int i = 0; i < numberOfStudents; i++)
{
    Console.WriteLine(
        $"{studentNames[i]}\t\t{studentGrades[i]:F1}\t" +
        $"{studentLetterGrades[i]}"
    );
}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
