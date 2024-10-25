
Random random = new Random();


for (int k = 0; k < 6; k++)
{
    for (int i = 1; true; i++)
    {
        int KhatCount = 0;
        for (int j = 0; j < 10; j++)
        {
            int rnd = random.Next(1, 3);
            if (rnd == 2)
            {
                Console.WriteLine("Khat");
                KhatCount++;
            }
            else
            {
                Console.WriteLine("Shir");
            }

        }
        Console.WriteLine("--------------");
        if (KhatCount == 10)
        {
            Console.WriteLine(i);
            Console.WriteLine(i*45/3600+"Hours  taked");
            break;
        }
    }
    Thread.Sleep(2000);
}
