using System.Diagnostics.Tracing;

namespace Program2
{

    public class Puzzle
    {

        public string word;
        public int index;
        public Puzzle()
        {
            word = "apple";
      
        }



        public void Enter(ref int Helath)
        {
            Helath--;
        }


        public void Render(in int index) //int in? in int? 
        {
            for (int i = 0; i < word.Length; i++)
            {
                if (i == index)
                {
                    Console.Write("_ ");
                }
                else
                {
                    Console.Write(word[i] + " ");

                }
            }
        }

        public void Validate(string input, out bool Correct)
        {
            if (input == word)
            {
                Correct = true;
            }
            else
            {
                Correct = false;
            }
        }


    }

    internal class Program
    {

        static void Main(string[] args)
        {
            #region 매개 변수 한정자
            int life = 5;

            Puzzle puzzle = new Puzzle();
            //Console.WriteLine("life : " + life);

            puzzle.Enter(ref life);

            //Console.WriteLine("life : " + life);



            Random random = new Random();
            int index = random.Next(0, puzzle.word.Length);

            puzzle.Render(in index);

           

            Console.ReadLine();



            #endregion
        }
    }
}
