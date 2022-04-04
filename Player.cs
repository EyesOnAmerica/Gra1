using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gra1
{
    class Player
    {
        public int x, y;
        public Player(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
        public void update()
        {
            Console.WriteLine("Updating");
        }
    }
}
