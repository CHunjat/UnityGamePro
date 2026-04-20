
namespace Program3
{
    internal class Guard : Unit
    {
        public Guard()
        {
           int health = 100;
           int defense = 10;
        }

        public override void Attack()
        {
            Console.WriteLine("경비병 유닛이 공격합니다");
        }
    }
}
