

Random rnd = new Random(); // juhuslike arvude klass

int myRandom;    // juhuslik arv
int i;          // Loendur



for (i = 0; i < 5; i++)
{
    myRandom = rnd.Next(1, 11); // juhuslik 1..10
    Console.WriteLine($"{i + 1}. {myRandom}");
}


//for(int i = 0; i< 3; i++)
//{
//    Console.WriteLine($"{i + 1 }. I will not skip Zoom classes.");
//}
