using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Snake_Game
{
    public partial class Main : Form
    {
        private Grid grid;
        private string level;
        private DateTime start = DateTime.Now;
        private DateTime end;

        public Main()
        {
            InitializeComponent();

            Initialize();
        }
        
        private void SendMessage(int length)
        {
            score_label.Text = length.ToString();
        }

        #region Initialization

        /// <summary>
        /// Reset game,
        /// add timer tick event
        /// </summary>
        private void Initialize()
        {
            
            Reset();
            timer1.Tick += new EventHandler(RunFrame);
        }

        private void Reset()
        {
            SnakeMessage sendmessage = new SnakeMessage(SendMessage);
            grid = new Grid(arena.Size, sendmessage);
            grid.Renderer = new Renderer(grid);
            this.arena.Paint += new PaintEventHandler(this.arena_Paint);
            score_label.Text = "3";
        }

        /// <summary>
        /// Draw Snake Logo
        /// </summary>
        private void DrawCover()
        {
            using (Graphics g = this.CreateGraphics())
            using (SolidBrush field = new SolidBrush(Color.White))
            using (Pen pen = new Pen(Color.Green))
            using (Font arial24bold = new Font("Chiller", 100, FontStyle.Regular))
            {
                g.DrawString("Snake", arial24bold, Brushes.Green, 920, 85);
            }
        }

        #endregion

        #region Setting Level

        private void newEasy_Click(object sender, EventArgs e)
        {
            level = "Easy";
            SetDifficulty("Easy");
        }

        private void newNormal_Click(object sender, EventArgs e)
        {
            level = "Normal";
            SetDifficulty("Normal");
        }

        private void newHard_Click(object sender, EventArgs e)
        {
            level = "Hard";
            SetDifficulty("Hard");
        }

        // Use different timer's tick to set difficulty
        private void SetDifficulty(string level)
        {
            switch (level)
            {
                case "Easy":
                    timer1.Interval = 130;
                    break;
                case "Normal":
                    timer1.Interval = 80;
                    break;
                case "Hard":
                    timer1.Interval = 50;
                    break;
            }
            Reset();
            timer1.Start();
            score_label.Visible = true;
            if (loopToolStripMenuItem.Checked)
            {
                loop_label.Visible = true;
            }
            else
            {
                loop_label.Visible = false;
            }
        }

        #endregion

        #region Get input

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && timer1.Interval != 1000)
            {
                // Space to pause
                timer1.Enabled = !timer1.Enabled;
            }
            else
            {
                grid.Controller.Listen(e.KeyCode);
            }
        }

        #endregion


        #region Update screen

        public void RunFrame(object sender, EventArgs e)
        {
            arena.Invalidate(); //call arena_Paint()

            if (loopToolStripMenuItem.Checked)
                grid.Go(this, true);
            else
                grid.Go(this, false);
        }

        private void arena_Paint(object sender, PaintEventArgs e)
        {
            if (timer1.Enabled)
            {
                grid.Renderer.DrawArena(e.Graphics);
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            DrawCover();
        }

        private void loopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            loop_label.Visible = !loop_label.Visible;
        }

        #endregion

        public void EndOfTurn(string reason)
        {
            timer1.Stop();
            MessageBox.Show(reason);
            
            // 填写统计信息
            string stats;
            end = DateTime.Now;
            TimeSpan duration = end - start;
            string Duration = duration.TotalSeconds.ToString();
            stats = "Level: " + level + "\n";
            stats += "Score: " + score_label.Text + "\n";
            stats += string.Format("Duration: {0:f1}s", duration.TotalSeconds);

            // 重试
            var result = MessageBox.Show(stats, "Game Over", MessageBoxButtons.RetryCancel);
            if (result == DialogResult.Retry)
            {
                switch (level)
                {
                    case "Easy":
                        newEasy.PerformClick();
                        break;
                    case "Normal":
                        newNormal.PerformClick();
                        break;
                    case "Hard":
                        newHard.PerformClick();
                        break;
                }
                SnakeMessage sendmessage = new SnakeMessage(SendMessage);
            }
        }

        /// <summary>
        /// 显示坐标
        /// 显示网格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        #region 测试用代码

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            //MessageBox.Show(e.Location.ToString());
        }

        private void arena_MouseClick_1(object sender, MouseEventArgs e)
        {
            MessageBox.Show(e.Location.ToString());
        }

        private void ShowGrid(Graphics g)
        {
            //arena.backcolor = color.silver;
            //using (pen pen = new pen(color.black))
            //{
            //    for (int x = 0; x < 800; x += 10)
            //    {
            //        g.drawline(pen, x, 0, x, 600);
            //    }
            //    for (int y = 0; y < 800; y += 10)
            //    {
            //        g.drawline(pen, 0, y, 800, y);
            //    }
            //}
        }

        #endregion

    }
}
