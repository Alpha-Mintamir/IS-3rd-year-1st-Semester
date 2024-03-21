/*Q1 write a C# program that stores elements of type string
to store names of 5 students and print them*/
Console.WriteLine("Question number 1");
string[] studentsName = { "Alpha", "Dagmawi", "Haset", "Meaza", "Aschenaki" };
for (int i = 0; i < studentsName.Length; i++)
{
    Console.WriteLine(studentsName[i]);

}
Console.WriteLine();





/*Q2 write a C# program to read values from an 
 * array and print them in reverse order*/

Console.WriteLine("Question number 2");
string[] reverseStudentsName = { "Alpha", "Dagmawi", "Haset", "Meaza", "Aschenaki" };
for (int j = reverseStudentsName.Length - 1; j >= 0; j--)
{
    Console.WriteLine(reverseStudentsName[j]);
}
Console.WriteLine();

Console.WriteLine("Question number 3");




/*Q3 write a program in  C# to find the sum of all array elements*/

int[] numbers = { 23, 4, 3, 8, 2, 1 };
int sum = 0;
for (int k = 0; k < numbers.Length; k++)
{
    sum += numbers[k];
}
Console.WriteLine(sum);
Console.WriteLine();

Console.WriteLine("Question number 4");




/*Q4 write a program to find the largest element in an array*/
Console.WriteLine(numbers.Max());






/*Q5 write a program to check whether a given number is perfect or notn*/


int summ = 0;
int l = 0;
int m = 0;
List<int> store = new List<int>();
Console.WriteLine("Please write a number you want to check whether it is perfect or not");
int num = int.Parse(Console.ReadLine());

for (l = num; l >= 1; l--)
{
    if (num % l == 0)
    {
        store.Add(l);
    }
    else
    {
        continue;
    }
}
for (m = 1; m < store.Count; m++)
{
    summ += store[m];
};
if(summ == num)
{
    Console.WriteLine("The number is perfect number");
}
else
{
    Console.WriteLine("The number is not perfect number");
};



/*Q6   */