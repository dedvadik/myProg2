int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100, 94, 90 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90, 89 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68, 89, 89, 89 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96, 96 };

int[] studentScores = new int[10];

string[] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan" };

Console.WriteLine("Student\t\tGrade\n");

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

    int sumAssignmentScores = 0;

    decimal currentStudentGrade;

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

    foreach (int score in studentScores)
    {
        sumAssignmentScores += score;
    }

    currentStudentGrade = (decimal)sumAssignmentScores / currentAssignments;

    Console.WriteLine($"{currentStudent}:\t\t {currentStudentGrade} \t{grade(currentStudentGrade)}");

}

Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();