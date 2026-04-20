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

            barracks.Create(select);
            barracks.Battle();


        }
    }
}

