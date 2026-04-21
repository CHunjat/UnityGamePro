using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int createcount = 0;
            int select = 0;

            Unit unit = null;

            Barracks barracks = new Barracks();

            while (true)
            {
                Console.WriteLine("Please select an option");
                if (int.TryParse(Console.ReadLine(), out select))
                {
                    if (select >= 1 && select <=3)
                    {
                        barracks.Create(select); 
                    }
                }
                else if (select == 4)
                {
                    barracks.Battle();

                    Console.WriteLine("The battle is over");
                    break;
                }
                else
                {
                  Console.WriteLine("Please select an option");

                }
            }

        }
    }
}

