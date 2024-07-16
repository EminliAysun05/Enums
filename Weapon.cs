



namespace Enums
{
  public  enum BulletType
    {
        standart,
            hard,
            ultrahard
    }
    public class Weapon
    {
        private static int _id;
        public  int Id { get; set; }
        public BulletType AmmoType { get; }//mermi novunu
        private  Queue<Bullet> magazine = new Queue<Bullet> ();
        public int Capacity { get; set; }
        public int RemainingBullet => magazine.Count;//qalan gulle sayi ucun
        public Weapon(BulletType ammoType,int MagazineCapacity)
        {
            Capacity = MagazineCapacity;
            AmmoType = ammoType;

        }
        public void Fire()//atilan gulle novu nece gulle qaldigi
        {
            if(magazine.Count > 0)
            {
                Bullet nextBullet = magazine.Dequeue ();
                Console.WriteLine($" Firing next bullet - {nextBullet.Type}, Remaining ammo - {magazine.Count}");
                Console.WriteLine("Weapon is fired");
            }
            else
            {
                Console.WriteLine("Magazine count shouldn't be less than zero");
            }
        }
        public void Fill()
        {
           while(magazine.Count < Capacity)
            {
                magazine.Enqueue (new Bullet (AmmoType));
               
            }
            Console.WriteLine($"Magazine filled with {AmmoType} bullets");
        }
        public void PullTrigger()
        {
            if( magazine.Count > 0)
            {
                Bullet nextBullet = magazine.Peek ();
                Console.WriteLine($"The type of next bullet is {nextBullet.Type}, id of next bullet is  {nextBullet.Id}");
                Console.WriteLine("Pull trigger is completed");
            }
            else
            {
                Console.WriteLine("There is no bullet in the magazine");
            }
        }







    }
    //public class Bullet
    //{
    //    private static int _id;
    //    public int Id { get; set; }
    //    public BulletType Type { get; set; }//mermi tipi
    //    public Bullet(BulletType type)
    //    {
    //        Id = ++_id;
    //        Type = type;
    //    }
    //}
}
