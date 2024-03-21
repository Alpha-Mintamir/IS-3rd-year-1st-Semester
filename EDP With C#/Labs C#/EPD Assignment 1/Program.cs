//Q1.Write a program that takes a number and check if it is narcissistic or not

Console.WriteLine("enter the number? ");
            string number = Console.ReadLine();
            double sum = 0;
            int digit = number.Length;

            for(int i = 0; i < digit; i++)
            {
                sum += Math.Pow(int.Parse(number[i].ToString()), digit);
            }

            if(sum == int.Parse(number))
            {
                Console.WriteLine("yes the number is narccistist! ");
            }
            else
            {
                Console.WriteLine(" the number is not narcistsis! ");
            }






/*Q2.ROCK-Paper Scissor game . 2 players game. each round the players begin by saying
"Rock, Paper, Scissor" The rock crashes scissor,scissor cuts the paperand the paper
covers the rock*/



while (true)

{
    Random random = new Random();

    string[] game = { "rock", "paper", "scissor" };
    Console.WriteLine(" rock, paper, scissor, shoot");
    string player1 = Console.ReadLine();
    int theComputer = random.Next(0, 2);
    string computerRandom = game[theComputer];
    if ((player1 == game[0] && computerRandom == game[2]) || (player1 == game[1] && computerRandom == game[0]) || (player1 == game[2] && computerRandom == game[1]))
    {
        Console.WriteLine("Player 1 won");
    }
    else if ((player1 == game[2] && computerRandom == game[0]) || (player1 == game[0] && computerRandom == game[1]) || (player1 == game[1] && computerRandom == game[2]))
    {
        Console.WriteLine("The computer won");
    }

    else if (player1 == computerRandom)
    {
        Console.WriteLine("Try again, you and the computer chooses the same action");
        continue;
    }

}