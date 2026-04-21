namespace Class_4th
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ISelectable[] Group = new ISelectable[]
            {
                new Frame(),
                new Clock(),
                new Switch(),
            };

            bool isout = true;

            while (isout)
            {
                Console.WriteLine("1:액자, 2:시계, 3:스위치 / 4번을 누르면 나감");
                int inputkey =int.Parse(Console.ReadLine());
                if (inputkey == 1)
                {
                    Group[0].attack();

                }
                if (inputkey == 2)
                {
                    Group[1].attack();

                }
                if (inputkey == 3)
                {
                    Group[2].attack();

                }
                else if(inputkey == 4)
                {
                    Console.WriteLine("나간다 ㅋㅋ");
                    isout = false;
                    return;
                }   
            }
           
        }
    }
}
