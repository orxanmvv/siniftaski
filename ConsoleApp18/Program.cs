namespace ConsoleApp18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false; do {

                Fire fire = new Fire(80, 40, true);
                Console.WriteLine("0-Informasiya almaq ucun");
                Console.WriteLine("1-Ates acmaq ucun");
                Console.WriteLine("2-Getremainbullet ucun");
                Console.WriteLine("3-Reload ucun");
                Console.WriteLine("4-Changefiremode ucun");
                Console.WriteLine("5-Programi bitir");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "0":
                        fire.Showfullinfo();
                        break;
                    case "1":
                        fire.Shoot();
                        break;
                    case "2":
                        fire.Getremainbulletcount();
                        break;
                    case "3":
                        fire.Reload();
                        break;
                    case "4":
                        fire.Changefirmode();
                        break;
                    case "5": exit = true;
                        Console.WriteLine("program bitdi");
                        break;
                    default:
                        Console.WriteLine("duzgun secim edin");
                        break;



                }
              

            } while (exit!=true);
          
          
        }
    }
}