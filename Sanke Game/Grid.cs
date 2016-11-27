using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Snake_Game
{
    public class Grid
    {
        private Size arenaSize;
        private Random random = new Random();

        public Renderer Renderer;
        public Snake Snake { get; private set; }
        public Food Food { get; private set; } // 补充食物种类
        public LinkedList<Point> SnakeBody { get; private set; }
        public List<Food> Foods { get; private set; }
        public Controller Controller { get; private set; }
        public SnakeMessage MessageSender;

        // 构造函数 注意method先后顺序
        public Grid(Size arenaSize, SnakeMessage messageSender)
        {
            this.arenaSize = arenaSize;
            MessageSender = messageSender;

            SnakeBody = new LinkedList<Point>();
            CreateSnake();
            Controller = new Controller(Snake);
            Foods = new List<Food>();
            CreateFood();
        }

        public void Go(Main form, bool loop)
        {
            if (HitTheWall())
            {
                if (loop)
                {
                    Console.WriteLine("loop!");
                    Snake.Move(Snake.CurrentDirection, true);
                }
                else
                {
                    Console.WriteLine("hit!");
                    form.EndOfTurn("You hit the wall");
                }
            }

            if (IsKnot())
            {
                Console.WriteLine("knot!");
                form.EndOfTurn("You eat yourself!");
            }

            if (IsNeighbor())
            {
                Snake.Eat(Snake.CurrentDirection);
                CreateFood();
            }

            Snake.Move(Snake.CurrentDirection);
            Console.WriteLine("Head " + SnakeBody.First.Value);
        }

        private bool IsNeighbor()
        {
            foreach (var food in Foods)
            {
                Console.WriteLine();
                Console.WriteLine("Food " + food.Location);
                if (SnakeBody.First.Value == food.Location)
                {
                    Console.WriteLine("eat!");
                    food.Eaten = true;
                    return true;
                }
            }
            return false;
        }

        private bool HitTheWall()
        {
            if (SnakeBody.First.Value.X == -10 || SnakeBody.First.Value.X == arenaSize.Width ||
                SnakeBody.First.Value.Y == -10 || SnakeBody.First.Value.Y == arenaSize.Height)
            {
                return true;
            }
            else
                return false;
        }

        private bool IsKnot()
        {
            for (int i = 1; i < SnakeBody.Count; i++)
            {
                if (SnakeBody.ElementAt(i) == SnakeBody.First.Value)
                    return true;
            }
            return false;
        }

        private void CreateFood()
        {
            Point location = new Point(random.Next(arenaSize.Width) / 10 * 10, random.Next(arenaSize.Height) / 10 * 10);
            Food newfood = new Food(location, this);
            Foods.Add(newfood);

            // 场上不止一种食物？
            if (Foods.Count > 1)
                Foods.RemoveAt(0);
        }

        private void CreateSnake()
        {
            Point location = new Point(random.Next(12, 790) / 10 * 10, random.Next(56, 590) / 10 * 10);
            Snake newsnake = new Snake(location, this, SnakeBody);
            SnakeBody.AddLast(location);
            for (int i = 4; i < 30; i += 10)
            {
                SnakeBody.AddLast(new Point(location.X - i, location.Y));
            }
            newsnake.MessageSender += this.MessageSender;
            Snake = newsnake;
        }
    }
}
