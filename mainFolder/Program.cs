int examAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };
int[] beckyScores = new int[] { 92, 91, 90, 91, 92, 92, 92 };
int[] chrisScores = new int[] { 84, 86, 88, 90, 92, 94, 96, 98 };
int[] ericScores = new int[] { 80, 90, 100, 80, 90, 100, 80, 90 };
int[] gregorScores = new int[] { 91, 91, 91, 91, 91, 91, 91 };

int[] studentScores = new int[10];

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan", "Becky", "Chris", "Eric", "Gregor" };

Console.WriteLine("Student\t\tExam Score\tOverall\tGrade\tExtra Credit\n");

foreach (string name in studentNames)
{
    string currentStudent = name;

    if (currentStudent == "Sophia")
        studentScores = sophiaScores;
    else if (currentStudent == "Andrew")
        studentScores = andrewScores;
    else if (currentStudent == "Emma")
        studentScores = emmaScores;
    else if (currentStudent == "Logan")
        studentScores = loganScores;
    else if (currentStudent == "Becky")
        studentScores = beckyScores;
    else if (currentStudent == "Chris")
        studentScores = chrisScores;
    else if (currentStudent == "Eric")
        studentScores = ericScores;
    else if (currentStudent == "Gregor")
        studentScores = gregorScores;
    else
        continue;

    int sumAssignmentScores = 0;

    decimal currentStudentGrade;
    decimal examStudentScore = 0;       //--переменная для отображения отметки без дополнительных баллов//
    decimal extraCreditScore = 0;       //--переменная для отображения числа без доп баллов, в поле где указанно кол-во доп баллов// 
    decimal differenceScore = 0;        //--переменная для отображения кол-ва баллов которые добавляются за доп задания// 

    string grade(decimal currentStudentGrade)
    {
        if (currentStudentGrade >= 97)
            return "A+";
        else if (currentStudentGrade >= 93)
            return "A";
        else if (currentStudentGrade >= 90)
            return "A-";
        else if (currentStudentGrade >= 87)
            return "B+";
        else if (currentStudentGrade >= 83)
            return "B";
        else if (currentStudentGrade >= 80)
            return "B-";
        else if (currentStudentGrade >= 77)
            return "C+";
        else if (currentStudentGrade >= 73)
            return "C";
        else if (currentStudentGrade >= 70)
            return "C-";
        else if (currentStudentGrade >= 67)
            return "D+";
        else if (currentStudentGrade >= 63)
            return "D";
        else if (currentStudentGrade >= 60)
            return "D-";
        else
            return "F";
    }

    int gradedAssignmennts = 0;

    foreach (int score in studentScores)
    {
        gradedAssignmennts += 1;

        if (gradedAssignmennts <= examAssignments)
        {
            sumAssignmentScores += score;
        }
        else if (gradedAssignmennts > examAssignments)
        {
            sumAssignmentScores += score / 10;
        }
    }

    currentStudentGrade = (decimal)sumAssignmentScores / examAssignments;

    Console.WriteLine($"{currentStudent}:\t\t{examStudentScore}\t\t{currentStudentGrade}\t{grade(currentStudentGrade)}\t {extraCreditScore} ({differenceScore} pts)");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();