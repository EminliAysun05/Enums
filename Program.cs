namespace Enums
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool exit = false;
            while (!exit)
            {

            Console.WriteLine("Enter type of bullet 1 - Standart, 2 - Hard, 3 - Ultrahard");
            int bulletTypeChoice = int.Parse(Console.ReadLine());
            BulletType chosenBulletType;
            switch (bulletTypeChoice)
            {
                case 1:
                    chosenBulletType = BulletType.standart;
                    break;
                case 2:
                    chosenBulletType = BulletType.hard;
                    break;
                case 3:
                    chosenBulletType = BulletType.ultrahard;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Defaulting ultrahard");
                    chosenBulletType = BulletType.ultrahard;
                    break;
            }
            restart:
                Console.WriteLine("Please enter the capacity of magazine: ");
                int capacity = int.Parse(Console.ReadLine());
                if (capacity < 0)
                {
                    Console.WriteLine("You should't enter less than zero...");

                    goto restart;
                }

                Weapon weapon = new Weapon(chosenBulletType, capacity);
                weapon.Fill();

                Console.WriteLine("Select 1(for fire) and 2(for pulltrigger).If you want to stop program press 3");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        weapon.Fire();
                        break;
                    case 2:
                        weapon.PullTrigger();
                        break;
                    case 3:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid choice...Please try again"); ;

                        break;

                }




                //while (true)
                //{

                //    Console.WriteLine("Select 1 and 2");
                //    int choice = int.Parse(Console.ReadLine());

                //    switch (choice)
                //    {
                //        case 1:
                //            weapon.Fire();
                //            break;
                //        case 2:
                //            weapon.PullTrigger();
                //            break;
                //        default:
                //            Console.WriteLine("Invalid choice...Please try again...");

                //            break;

                //    }
            }
        }
    }
}
    

