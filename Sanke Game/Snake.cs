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

        public void Move(Direction newDirection)
        {
            if (newDirection == CurrentDirection)
            {
                newDirection = CurrentDirection;
            }

            switch (newDirection)
            {
                case Direction.UP:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, snakeBody.First.Value.Y - 10));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
                case Direction.RIGHT:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X + 10, snakeBody.First.Value.Y));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
                case Direction.DOWN:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, snakeBody.First.Value.Y + 10));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
                case Direction.LEFT:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X - 10, snakeBody.First.Value.Y));
                    grid.SnakeBody.RemoveLast();
                    CurrentDirection = newDirection;
                    break;
            }
        }

        public void MoveLoop(Direction newDirection, Form1 form)
        {
            switch (newDirection)
            {
                case Direction.UP:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, form.arena.Height - 10));
                    grid.SnakeBody.RemoveLast();
                    break;
                case Direction.RIGHT:
                    grid.SnakeBody.AddFirst(new Point(10, snakeBody.First.Value.Y));
                    grid.SnakeBody.RemoveLast();
                    break;
                case Direction.DOWN:
                    grid.SnakeBody.AddFirst(new Point(snakeBody.First.Value.X, 10));
                    grid.SnakeBody.RemoveLast();
                    break;
                case Direction.LEFT:
                    grid.SnakeBody.AddFirst(new Point(form.arena.Width - 10, snakeBody.First.Value.Y));
                    grid.SnakeBody.RemoveLast();
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
