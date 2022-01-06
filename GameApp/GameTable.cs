using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameApp
{
    class GameTable
    {
        private int x = 3, y = 3;

        public void Move(Operations operation)
        {
            if(x != 0 && x != 9 && y != 0 && y != 9)
            {
                switch (operation)
                {
                    case Operations.UP: x = x - 1; break;
                    case Operations.DOWN: x = x + 1; break;
                    case Operations.RIGHT: y = y + 1; break;
                    case Operations.LEFT: y = y - 1; break;
                }
            } else
            {
                Console.WriteLine("You have arrived at the end");
            }

            Console.WriteLine($"currentX = {x} currentY = {y}");
        }
    }
}
