

namespace Enums
{
    public class Bullet
    {
        private static int _id;
        public int Id { get; set; }
        public BulletType Type { get; set; }//mermi tipi
        public Bullet(BulletType type)
        {
            Id = ++_id;
            Type = type;
        }
    }
}
