

namespace Program3
{
    internal class Archer : Unit
    {

        public Archer()
        {
            int health = 80;
            int defense = 0;
        }
        public override void Attack()
        {
            Console.WriteLine("궁수 유닛이 공격합니다");
        }
    }
}
