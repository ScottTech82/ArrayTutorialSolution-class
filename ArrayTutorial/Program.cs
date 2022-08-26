// See https://aka.ms/new-console-template for more information





Console.WriteLine("Please provide your first game's score and press Enter: ");
string answer1 = Console.ReadLine();
int Bscore1 = Convert.ToInt32(answer1);

Console.WriteLine("Thank you, now please provide your Second score and press Enter: ");
string answer2 = Console.ReadLine();
int Bscore2 = Convert.ToInt32(answer2);

Console.WriteLine("Thank you, now please provide your Third score and press Enter: ");
string answer3 = Console.ReadLine();
int Bscore3 = Convert.ToInt32(answer3);

int[] Bowlscores = new int[3];
Bowlscores[0] = Bscore1;
Bowlscores[1] = Bscore2;
Bowlscores[2] = Bscore3;

Console.WriteLine($"You're total series is {Bowlscores[0] + Bowlscores[1] + Bowlscores[2]}, Great Job!");
/*
//Instead you can write it like this..

int[] scores = new int[3];
Console.Write("Enter 1st score: ");
string answer = Console.ReadLine();
scores[0] = Convert.ToInt32(answer);

Console.Write("Enter 2nd score: ");
string answer = Console.ReadLine();
scores[2] = Convert.ToInt32(answer);

Console.Write("Enter 3rd score: ");
string answer = Console.ReadLine();
scores[3] = Convert.ToInt32(answer);

int total = scores[0] + scores[1] + scores[3];
Console.WriteLine($"Your scores are {scores[0], scores[1], scores[3]} and total is {total}");
*/



/*
Console.WriteLine("Guess a number from 1 to 10: ");
string answer = Console.ReadLine();
int myNumber = Convert.ToInt32(answer);
Console.WriteLine($"The number is {myNumber}");



Console.Write("Enter a string and press Enter: ");
string? response = Console.ReadLine();
Console.WriteLine($"You typed {response}");



//An array of names
string[] names = { "Josh", "Billy", "Karl", "Sam", "James", "Caleb", "Jack", "Ian" };
Console.WriteLine($"{names[0]}, { names[1]}, { names[2]}, { names[3]}, { names[4]}, " +
    $"{ names[5]}, { names[6]}, { names[7]}");


//an array of integers written 2 different ways
int?[] scores2 = new int?[] { 95, 97, 100, 93, 100 };
Console.WriteLine($"{scores2[0],8:C}, {scores2[1],5}, {scores2[2],5}, {scores2[3],5}, {scores2[4],5}");

int[] scores = new int[5];
scores[0] = 100;
scores[1] = 95;
scores[2] = 97;
scores[3] = 100;
scores[4] = 7;
Console.WriteLine($"{scores[0],8:C}, {scores[1],5}, {scores[2],5}, {scores[3],5}, {scores[4],5}");


//bowling scores 
int[] games = { 145, 264, 244 };
int BowlingSeries = games[0] + games[1] + games[2];
Console.WriteLine(BowlingSeries);
// OR can write like
Console.WriteLine($"The bowling series score is {games[0] + games[1] + games[2]}");

*/