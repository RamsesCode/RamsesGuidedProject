// initialize variables - graded assignments 
int currentAssignments = 5;

int[] sophiaScores = new int[] { 90, 86, 87, 98, 100 };
int[] andrewScores = new int[] { 92, 89, 81, 96, 90 };
int[] emmaScores = new int[] { 90, 85, 87, 98, 68 };
int[] loganScores = new int[] { 90, 95, 87, 88, 96 };

string [] studentNames = new string[] { "Sophia", "Andrew", "Emma", "Logan"};    //Student Names

foreach (string name in studentNames){
    Console.WriteLine($"{name}");
}

int sophiaSum = 0;    // readded this, wasnt supposed to be deleted 

decimal sophiaScore;   //must stay 

foreach(int score in sophiaScores){
                    //We will add the exam scores
                    sophiaSum += score;
}



sophiaScore = (decimal)sophiaSum / currentAssignments; // keep for now to use in foreach statements 

                
Console.WriteLine("Student\t\tGrade\n");



Console.WriteLine("Sophia:\t\t" + sophiaScore + "\tA-");


Console.WriteLine("Press the Enter key to continue");
Console.ReadLine();
