namespace RaceGame
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.BGpic1 = new System.Windows.Forms.PictureBox();
            this.player = new System.Windows.Forms.PictureBox();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.BGpic2 = new System.Windows.Forms.PictureBox();
            this.enemy1 = new System.Windows.Forms.PictureBox();
            this.enemy2 = new System.Windows.Forms.PictureBox();
            this.LabelLose = new System.Windows.Forms.Label();
            this.restartButton = new System.Windows.Forms.Button();
            this.coin = new System.Windows.Forms.PictureBox();
            this.labelCoins = new System.Windows.Forms.Label();
            this.labelInGameCoins = new System.Windows.Forms.Label();
            this.BGmenu = new System.Windows.Forms.PictureBox();
            this.labelMenu = new System.Windows.Forms.Label();
            this.menuButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.diffListBox = new System.Windows.Forms.CheckedListBox();
            this.goToMenuButton = new System.Windows.Forms.Button();
            this.fpsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BGpic1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpic2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGmenu)).BeginInit();
            this.SuspendLayout();
            // 
            // BGpic1
            // 
            this.BGpic1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGpic1.BackgroundImage")));
            this.BGpic1.Location = new System.Drawing.Point(0, 0);
            this.BGpic1.Name = "BGpic1";
            this.BGpic1.Size = new System.Drawing.Size(840, 650);
            this.BGpic1.TabIndex = 0;
            this.BGpic1.TabStop = false;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.player.Image = ((System.Drawing.Image)(resources.GetObject("player.Image")));
            this.player.Location = new System.Drawing.Point(435, 530);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(50, 100);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 1;
            this.player.TabStop = false;
            // 
            // timer
            // 
            this.timer.Enabled = true;
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // BGpic2
            // 
            this.BGpic2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BGpic2.BackgroundImage")));
            this.BGpic2.Location = new System.Drawing.Point(0, -650);
            this.BGpic2.Name = "BGpic2";
            this.BGpic2.Size = new System.Drawing.Size(840, 650);
            this.BGpic2.TabIndex = 2;
            this.BGpic2.TabStop = false;
            // 
            // enemy1
            // 
            this.enemy1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.enemy1.Image = ((System.Drawing.Image)(resources.GetObject("enemy1.Image")));
            this.enemy1.Location = new System.Drawing.Point(170, -130);
            this.enemy1.Name = "enemy1";
            this.enemy1.Size = new System.Drawing.Size(50, 100);
            this.enemy1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy1.TabIndex = 3;
            this.enemy1.TabStop = false;
            // 
            // enemy2
            // 
            this.enemy2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.enemy2.Image = ((System.Drawing.Image)(resources.GetObject("enemy2.Image")));
            this.enemy2.Location = new System.Drawing.Point(420, -400);
            this.enemy2.Name = "enemy2";
            this.enemy2.Size = new System.Drawing.Size(50, 100);
            this.enemy2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.enemy2.TabIndex = 4;
            this.enemy2.TabStop = false;
            // 
            // LabelLose
            // 
            this.LabelLose.AutoSize = true;
            this.LabelLose.BackColor = System.Drawing.Color.Red;
            this.LabelLose.Font = new System.Drawing.Font("Comic Sans MS", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLose.ForeColor = System.Drawing.SystemColors.Control;
            this.LabelLose.Location = new System.Drawing.Point(102, 183);
            this.LabelLose.Name = "LabelLose";
            this.LabelLose.Size = new System.Drawing.Size(634, 135);
            this.LabelLose.TabIndex = 5;
            this.LabelLose.Text = "YOU LOSE!!!";
            // 
            // restartButton
            // 
            this.restartButton.BackColor = System.Drawing.Color.DarkGray;
            this.restartButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.restartButton.FlatAppearance.BorderSize = 5;
            this.restartButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.restartButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.restartButton.Location = new System.Drawing.Point(272, 386);
            this.restartButton.Name = "restartButton";
            this.restartButton.Size = new System.Drawing.Size(300, 90);
            this.restartButton.TabIndex = 6;
            this.restartButton.Text = "Try Again";
            this.restartButton.UseVisualStyleBackColor = false;
            this.restartButton.Click += new System.EventHandler(this.restartButton_Click);
            // 
            // coin
            // 
            this.coin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.coin.Image = ((System.Drawing.Image)(resources.GetObject("coin.Image")));
            this.coin.Location = new System.Drawing.Point(470, -600);
            this.coin.Name = "coin";
            this.coin.Size = new System.Drawing.Size(30, 30);
            this.coin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.coin.TabIndex = 7;
            this.coin.TabStop = false;
            // 
            // labelCoins
            // 
            this.labelCoins.AutoSize = true;
            this.labelCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelCoins.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelCoins.ForeColor = System.Drawing.SystemColors.Control;
            this.labelCoins.Location = new System.Drawing.Point(325, 333);
            this.labelCoins.Name = "labelCoins";
            this.labelCoins.Size = new System.Drawing.Size(194, 37);
            this.labelCoins.TabIndex = 8;
            this.labelCoins.Text = "Picked Coins: 0";
            // 
            // labelInGameCoins
            // 
            this.labelInGameCoins.AutoSize = true;
            this.labelInGameCoins.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.labelInGameCoins.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelInGameCoins.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInGameCoins.ForeColor = System.Drawing.SystemColors.Control;
            this.labelInGameCoins.Location = new System.Drawing.Point(12, 9);
            this.labelInGameCoins.Name = "labelInGameCoins";
            this.labelInGameCoins.Size = new System.Drawing.Size(112, 37);
            this.labelInGameCoins.TabIndex = 9;
            this.labelInGameCoins.Text = "Coins: 0";
            // 
            // BGmenu
            // 
            this.BGmenu.Image = ((System.Drawing.Image)(resources.GetObject("BGmenu.Image")));
            this.BGmenu.Location = new System.Drawing.Point(0, 0);
            this.BGmenu.Name = "BGmenu";
            this.BGmenu.Size = new System.Drawing.Size(840, 660);
            this.BGmenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BGmenu.TabIndex = 10;
            this.BGmenu.TabStop = false;
            // 
            // labelMenu
            // 
            this.labelMenu.AutoSize = true;
            this.labelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.labelMenu.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelMenu.Location = new System.Drawing.Point(25, 183);
            this.labelMenu.Name = "labelMenu";
            this.labelMenu.Size = new System.Drawing.Size(794, 67);
            this.labelMenu.TabIndex = 11;
            this.labelMenu.Text = "THE INCREDIBLE RACE GAME!!!";
            // 
            // menuButton
            // 
            this.menuButton.BackColor = System.Drawing.Color.Blue;
            this.menuButton.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.menuButton.FlatAppearance.BorderSize = 5;
            this.menuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.menuButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuButton.ForeColor = System.Drawing.Color.White;
            this.menuButton.Location = new System.Drawing.Point(285, 321);
            this.menuButton.Name = "menuButton";
            this.menuButton.Size = new System.Drawing.Size(270, 95);
            this.menuButton.TabIndex = 12;
            this.menuButton.Text = "START";
            this.menuButton.UseVisualStyleBackColor = false;
            this.menuButton.Click += new System.EventHandler(this.menuButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Red;
            this.quitButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.quitButton.FlatAppearance.BorderSize = 5;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.quitButton.Location = new System.Drawing.Point(678, 12);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(150, 90);
            this.quitButton.TabIndex = 13;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // diffListBox
            // 
            this.diffListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(254)))), ((int)(((byte)(242)))), ((int)(((byte)(0)))));
            this.diffListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.diffListBox.CheckOnClick = true;
            this.diffListBox.Font = new System.Drawing.Font("Comic Sans MS", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.diffListBox.FormattingEnabled = true;
            this.diffListBox.Items.AddRange(new object[] {
            "Beginner",
            "Advanced",
            "Professional"});
            this.diffListBox.Location = new System.Drawing.Point(332, 451);
            this.diffListBox.Name = "diffListBox";
            this.diffListBox.Size = new System.Drawing.Size(187, 120);
            this.diffListBox.TabIndex = 14;
            this.diffListBox.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.diffListBox_ItemCheck);
            // 
            // goToMenuButton
            // 
            this.goToMenuButton.BackColor = System.Drawing.Color.Red;
            this.goToMenuButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.goToMenuButton.FlatAppearance.BorderSize = 5;
            this.goToMenuButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.goToMenuButton.Font = new System.Drawing.Font("Comic Sans MS", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.goToMenuButton.Location = new System.Drawing.Point(272, 501);
            this.goToMenuButton.Name = "goToMenuButton";
            this.goToMenuButton.Size = new System.Drawing.Size(307, 90);
            this.goToMenuButton.TabIndex = 15;
            this.goToMenuButton.Text = "Main Menu";
            this.goToMenuButton.UseVisualStyleBackColor = false;
            this.goToMenuButton.Click += new System.EventHandler(this.goToMenuButton_Click);
            // 
            // fpsLabel
            // 
            this.fpsLabel.AutoSize = true;
            this.fpsLabel.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.fpsLabel.Location = new System.Drawing.Point(0, 615);
            this.fpsLabel.Name = "fpsLabel";
            this.fpsLabel.Size = new System.Drawing.Size(0, 35);
            this.fpsLabel.TabIndex = 16;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.ClientSize = new System.Drawing.Size(840, 650);
            this.Controls.Add(this.fpsLabel);
            this.Controls.Add(this.goToMenuButton);
            this.Controls.Add(this.diffListBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.menuButton);
            this.Controls.Add(this.labelMenu);
            this.Controls.Add(this.BGmenu);
            this.Controls.Add(this.player);
            this.Controls.Add(this.restartButton);
            this.Controls.Add(this.labelCoins);
            this.Controls.Add(this.LabelLose);
            this.Controls.Add(this.labelInGameCoins);
            this.Controls.Add(this.coin);
            this.Controls.Add(this.enemy2);
            this.Controls.Add(this.enemy1);
            this.Controls.Add(this.BGpic2);
            this.Controls.Add(this.BGpic1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.MainForm_KeyPress);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.MainForm_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.BGpic1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGpic2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemy2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BGmenu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox BGpic1;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.PictureBox BGpic2;
        private System.Windows.Forms.PictureBox enemy1;
        private System.Windows.Forms.PictureBox enemy2;
        private System.Windows.Forms.Label LabelLose;
        private System.Windows.Forms.Button restartButton;
        private System.Windows.Forms.PictureBox coin;
        private System.Windows.Forms.Label labelCoins;
        private System.Windows.Forms.Label labelInGameCoins;
        private System.Windows.Forms.PictureBox BGmenu;
        private System.Windows.Forms.Label labelMenu;
        private System.Windows.Forms.Button menuButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.CheckedListBox diffListBox;
        private System.Windows.Forms.Button goToMenuButton;
        private System.Windows.Forms.Label fpsLabel;
    }
}