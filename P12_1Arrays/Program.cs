Console.WriteLine("How many numbers do you want to give me?");
int numbers = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("OK, give me the numbers");
int[] giveMeNumbers = new int[numbers];
for (int i = 0; i < numbers; i++)
{
    int userAnswers = Convert.ToInt32(Console.ReadLine());
    giveMeNumbers[i] = userAnswers;
}
