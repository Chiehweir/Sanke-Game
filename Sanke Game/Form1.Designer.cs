namespace Snake_Game
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.newEasy = new System.Windows.Forms.ToolStripMenuItem();
            this.newNormal = new System.Windows.Forms.ToolStripMenuItem();
            this.newHard = new System.Windows.Forms.ToolStripMenuItem();
            this.optionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.score_label = new System.Windows.Forms.Label();
            this.loop_label = new System.Windows.Forms.Label();
            this.arena = new Snake_Game.DoubleBufferedPanel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.optionToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1264, 25);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newEasy,
            this.newNormal,
            this.newHard});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(84, 21);
            this.toolStripMenuItem3.Text = "New Game";
            // 
            // newEasy
            // 
            this.newEasy.Name = "newEasy";
            this.newEasy.ShortcutKeyDisplayString = "";
            this.newEasy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.newEasy.Size = new System.Drawing.Size(164, 22);
            this.newEasy.Text = "Easy";
            this.newEasy.Click += new System.EventHandler(this.newEasy_Click);
            // 
            // newNormal
            // 
            this.newNormal.Name = "newNormal";
            this.newNormal.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D2)));
            this.newNormal.Size = new System.Drawing.Size(164, 22);
            this.newNormal.Text = "Normal";
            this.newNormal.Click += new System.EventHandler(this.newNormal_Click);
            // 
            // newHard
            // 
            this.newHard.Name = "newHard";
            this.newHard.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D3)));
            this.newHard.Size = new System.Drawing.Size(164, 22);
            this.newHard.Text = "Hard";
            this.newHard.Click += new System.EventHandler(this.newHard_Click);
            // 
            // optionToolStripMenuItem
            // 
            this.optionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loopToolStripMenuItem});
            this.optionToolStripMenuItem.Name = "optionToolStripMenuItem";
            this.optionToolStripMenuItem.Size = new System.Drawing.Size(60, 21);
            this.optionToolStripMenuItem.Text = "Option";
            // 
            // loopToolStripMenuItem
            // 
            this.loopToolStripMenuItem.CheckOnClick = true;
            this.loopToolStripMenuItem.Name = "loopToolStripMenuItem";
            this.loopToolStripMenuItem.Size = new System.Drawing.Size(106, 22);
            this.loopToolStripMenuItem.Text = "Loop";
            this.loopToolStripMenuItem.Click += new System.EventHandler(this.loopToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Chiller", 40F);
            this.label1.ForeColor = System.Drawing.Color.Green;
            this.label1.Location = new System.Drawing.Point(933, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 62);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score :";
            // 
            // score_label
            // 
            this.score_label.AutoSize = true;
            this.score_label.Font = new System.Drawing.Font("Chiller", 40F);
            this.score_label.ForeColor = System.Drawing.Color.Green;
            this.score_label.Location = new System.Drawing.Point(1076, 281);
            this.score_label.Name = "score_label";
            this.score_label.Size = new System.Drawing.Size(137, 62);
            this.score_label.TabIndex = 5;
            this.score_label.Text = "Length";
            this.score_label.Visible = false;
            // 
            // loop_label
            // 
            this.loop_label.AutoSize = true;
            this.loop_label.Font = new System.Drawing.Font("Chiller", 40F);
            this.loop_label.ForeColor = System.Drawing.Color.Green;
            this.loop_label.Location = new System.Drawing.Point(969, 365);
            this.loop_label.Name = "loop_label";
            this.loop_label.Size = new System.Drawing.Size(101, 62);
            this.loop_label.TabIndex = 6;
            this.loop_label.Text = "Loop";
            this.loop_label.Visible = false;
            // 
            // arena
            // 
            this.arena.BackColor = System.Drawing.Color.Transparent;
            this.arena.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.arena.Location = new System.Drawing.Point(0, 28);
            this.arena.Name = "arena";
            this.arena.Size = new System.Drawing.Size(830, 650);
            this.arena.TabIndex = 1;
            this.arena.MouseClick += new System.Windows.Forms.MouseEventHandler(this.arena_MouseClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.loop_label);
            this.Controls.Add(this.score_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.arena);
            this.Controls.Add(this.menuStrip1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Snake";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem newEasy;
        private System.Windows.Forms.ToolStripMenuItem newNormal;
        private System.Windows.Forms.ToolStripMenuItem newHard;
        public  DoubleBufferedPanel arena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label score_label;
        private System.Windows.Forms.ToolStripMenuItem optionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loopToolStripMenuItem;
        private System.Windows.Forms.Label loop_label;
    }

}

