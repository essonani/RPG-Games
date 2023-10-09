namespace RPG_Games
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            Player player = new Player(100);
            Console.WriteLine("choose your player name");
            player.Name = Console.ReadLine();
            
            Console.WriteLine("hello " + player.Name);
            Enemy firstEnemy = new Enemy("spider");
            bool IsDead = false;
            Console.WriteLine("you have encountered "+ firstEnemy +"what would like to do?\n 1 - single attack \n2-triple attack\n 3-block\n 4-heal");
            while (!firstEnemy.IsDead && !player.IsDead)
            {
                string playerAction = Console.ReadLine();


                if (playerAction == "1")
                {
                    Console.WriteLine("you have chosen a single attack");
                    firstEnemy.Get_Hits(random.Next(1, 15));
                    player.Get_Hits(random.Next(1, 5));
                }
                else if (playerAction == "2")
                {
                    Console.WriteLine("you have chosen a triple attack");
                    for (int i = 0; i < 3; i++) 
                    {
                        firstEnemy.Get_Hits(random.Next(1, 15));
                        
                    }
                    player.Get_Hits(random.Next(1, 5));

                }
                else if (playerAction == "3")
                {
                    player.IsBlocking = true;
                    Console.WriteLine("you have chosen to block");
                    player.IsBlocking = false;
                }
               
                else if (playerAction == "4")
                {
                    Console.WriteLine(player + " have chosen to heal");
                    player.Heal(random.Next(1, 15));
                    player.Get_Hits(random.Next(1, 5));


                }
                else if (playerAction == "5")
                {
                    Console.WriteLine(" have chosen something else");
                    player.Get_Hits(random.Next(1, 5));
                }
                player.Get_Hits(random.Next(1,5));
            }

            if (!player.IsDead)
            {
                Boss boss = new Boss();
                while (!boss.IsDead && !player.IsDead)
                {
                    string playerAction = Console.ReadLine();


                    if (playerAction == "1")
                    {
                        Console.WriteLine("you have chosen a single attack");
                        firstEnemy.Get_Hits(random.Next(1, 15));
                        player.Get_Hits(random.Next(1, 5));
                    }
                    else if (playerAction == "2")
                    {
                        Console.WriteLine("you have chosen a triple attack");
                        for (int i = 0; i < 3; i++)
                        {
                            firstEnemy.Get_Hits(random.Next(1, 15));

                        }
                        player.Get_Hits(random.Next(1, 5));

                    }
                    else if (playerAction == "3")
                    {
                        player.IsBlocking = true;
                        Console.WriteLine("you have chosen to block");
                        player.IsBlocking = false;
                    }

                    else if (playerAction == "4")
                    {
                        Console.WriteLine(player + " have chosen to heal");
                        player.Heal(random.Next(1, 15));
                        player.Get_Hits(random.Next(1, 5));


                    }
                    else if (playerAction == "5")
                    {
                        Console.WriteLine(" have chosen something else");
                        player.Get_Hits(random.Next(1, 5));
                    }
                    player.Get_Hits(random.Next(1, 5));
                }
            }
           else
            {
                Console.WriteLine("gameover");
            }   

            
            
            
        }
    }
}