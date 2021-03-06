﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public class Controller
    {
        private Snake snake;

        public Controller(Snake snake)
        {
            this.snake = snake;
        }

        public void Listen(Keys key)
        {
            switch (key)
            {
                case Keys.Left:
                case Keys.A:
                    if (snake.CurrentDirection == Direction.DOWN || snake.CurrentDirection == Direction.UP)
                    {
                        snake.Move(Direction.LEFT);
                    }
                    break;
                case Keys.Up:
                case Keys.W:
                    if (snake.CurrentDirection == Direction.LEFT || snake.CurrentDirection == Direction.RIGHT)
                    {
                        snake.Move(Direction.UP);
                    }
                    break;
                case Keys.Right:
                case Keys.D:
                    if (snake.CurrentDirection == Direction.DOWN || snake.CurrentDirection == Direction.UP)
                    {
                        snake.Move(Direction.RIGHT);
                    }
                    break;
                case Keys.Down:
                case Keys.S:
                    if (snake.CurrentDirection == Direction.LEFT || snake.CurrentDirection == Direction.RIGHT)
                    {
                        snake.Move(Direction.DOWN);
                    }
                    break;
            }
        }
    }
}
