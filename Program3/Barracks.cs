using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Program3
{
    internal class Barracks
    {
        
        Unit[] units = new Unit[5];
        int unitCount = 0;

        public void Create(int select)
        {
          
                Console.WriteLine("배럭유닛을 선택하세요 최대 5개까지 선택가능함(1: 기사, 2: 궁수, 3: 경비병)");
                if(!int.TryParse(Console.ReadLine(), out int unitSelect))
                {
                    Console.WriteLine("문자를 입력하셨습니다 다시입력해주세요");
                return;
                }

                
                switch (unitSelect)
                {
                    case 1:
                        units[unitCount] = new Knight();
                        break;
                    case 2:
                        units[unitCount] = new Archer();
                        break;
                    case 3:
                        units[unitCount] = new Guard();
                        break;
                    default:
                        Console.WriteLine("잘못된 입력입니다. 다시 선택해주세요.");
                        break;
                }
                unitCount++;

                if (unitCount == units.Length)
                {
                    Console.WriteLine("꽉참");
                }
            
        }

        public void Battle()
        {
            foreach(Unit element in units)
            {
                element.Attack();
            }

        }

    }
}
