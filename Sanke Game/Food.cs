using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Game
{
    public class Food
    {
        public bool Eaten { get; set; }
        public Point Location { get; private set; }
        public List<Point> Foods { get; private set; }


        public Food(Point location, Grid grid)
        {
            Eaten = false;
            Location = location;
        }
    }
}
