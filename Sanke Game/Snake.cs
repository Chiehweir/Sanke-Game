using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Collections;

namespace Snake_Game
{
    public class Snake
    {
        private int length = 4;
        private Grid grid;

        public SnakeMessage MessageSender;
        public Point Location { get; private set; }
        public LinkedList<Point> snakeBody { get; private set; }
        public Direction CurrentDirection { get; private set; }

        public Snake(Point location, Grid grid, LinkedList<Point> snake)
        {
            Location = location;
            this.grid = grid;
            this.snakeBody = snake;
            CurrentDirection = Direction.RIGHT;
        }

        public void Move(Direction newDirection, bool isLoop = false)
        {
            switch (newDirection)
            {
                case Direction.UP:
                    if(isLoop)
                        grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, 650 - 10));
                    else
                        grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, snakeBody.First.Value.Y - 10));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
                case Direction.RIGHT:
                    if(isLoop)
                        grid.SnakeBody.AddFirst(new Point(10, snakeBody.First.Value.Y));
                    else
                        grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X + 10, snakeBody.First.Value.Y));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
                case Direction.DOWN:
                    if(isLoop)
                        grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, 10));
                    else
                        grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, snakeBody.First.Value.Y + 10));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
                case Direction.LEFT:
                    if(isLoop)
                        grid.SnakeBody.AddFirst(new Point(830 - 10, snakeBody.First.Value.Y));
                    else
                        grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X - 10, snakeBody.First.Value.Y));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
            }
        }
        
        public void Eat(Direction Direction)
        {
            switch (Direction)
            {
                case Direction.UP:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, snakeBody.First.Value.Y - 10));
                    break;
                case Direction.RIGHT:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X + 10, snakeBody.First.Value.Y));
                    break;
                case Direction.DOWN:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, snakeBody.First.Value.Y + 10));
                    break;
                case Direction.LEFT:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X - 10, snakeBody.First.Value.Y));
                    break;
            }
            length++;
            MessageSender(length);
        }
    }
}
