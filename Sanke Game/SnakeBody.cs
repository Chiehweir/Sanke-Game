using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Sanke_Game
{
    class SnakeBody
    {
        private const int width = 5;
        private const int height = 5;

        public int Width { get { return width; } }
        public int Height { get { return height; } }

        public SnakeBody()
        {
            using (SolidBrush body = new SolidBrush(Color.Green))
            {
                
            }
            
        }


    }
}
