using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Game
{
    public class Renderer
    {
        private Grid grid;

        public Renderer(Grid grid)
        {
            this.grid = grid;
        }

        public void DrawArena(Graphics g)
        {
            DrawFood(g);
            DrawSnake(g);

            #region 显示网格调试

            // 注意不与arena的背景色相同
            using (Pen pen = new Pen(Color.Black))
            {
                for (int x = 0; x < 860; x += 10)
                {
                    g.DrawLine(pen, x, 0, x, 860);
                }
                for (int y = 0; y < 860; y += 10)
                {
                    g.DrawLine(pen, 0, y, 850, y);
                }
            }

            #endregion
        }

        public void DrawFood(Graphics g)
        {
            using (SolidBrush foodColor = new SolidBrush(Color.Yellow))
            using (Pen foodBorder = new Pen(Color.Black))
            {
                foreach (var food in grid.Foods)
                {
                    g.FillRectangle(foodColor, new Rectangle(food.Location, new Size(10, 10)));
                    g.DrawRectangle(foodBorder, new Rectangle(food.Location.X - 1, food.Location.Y - 1, 11, 11));
                }
            }
        }

        public void DrawSnake(Graphics g)
        {
            using (SolidBrush bodyColor = new SolidBrush(Color.Green))
            using (Pen bodyBorder = new Pen(Color.Black))
            {
                foreach (Point body in grid.SnakeBody)
                {
                    g.FillRectangle(bodyColor, new Rectangle(body, new Size(10, 10)));
                    g.DrawRectangle(bodyBorder, new Rectangle(body.X - 1, body.Y - 1, 11, 11));
                }
            }
        }

    }
}
