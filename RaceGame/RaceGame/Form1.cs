using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RaceGame
{
    public partial class MainForm : Form
    {

        private Point pos;
        private Random rand = new Random();
        private bool dragging, lose = false, diffBeginner = false, diffAdvanced = false, diffProfessional = false;
        private int countCoins = 0;

        private bool moveLeft = false, moveRight = false;
        private int moveSpeed = 5;

        private Stopwatch stopwatch = new Stopwatch();
        private int frameCount = 0;
        private DateTime lastFpsUpdate = DateTime.Now;
        private double fps = 0;
        private double maxFPS = 0;
        private int totalFrames = 0;
        private DateTime startTime = DateTime.Now;

        private Queue<double> fpsHistory = new Queue<double>();
        private const int MaxHistorySize = 30;

        public MainForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;

            foreach (Control control in this.Controls)
            {
                control.MouseDown += MouseClickDown;
                control.MouseUp += MouseClickUp;
                control.MouseMove += MouseClickMove;
            }

            LabelLose.Visible = false;
            restartButton.Visible = false;
            labelCoins.Visible = false;
            goToMenuButton.Visible = false;

            labelInGameCoins.Visible = true;
            labelMenu.Visible = true;
            BGmenu.Visible = true;
            menuButton.Visible = true;
            quitButton.Visible = true;
            diffListBox.Visible = true;

            if (BGmenu.Visible == true)
            {
                fpsLabel.Visible = false;
            }
            else
            {
                fpsLabel.Visible = true;
            }

            timer.Enabled = false;

            KeyPreview = true;
        }

        //Захват окна мышкой
        private void MouseClickDown(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;

            dragging = true;
            pos.X = e.X;
            pos.Y = e.Y;
        }

        //Фиксация окна по положению мышки
        private void MouseClickUp(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;

            dragging = false;
        }

        //Перемещение окна
        private void MouseClickMove(object sender, MouseEventArgs e)
        {
            this.DoubleBuffered = true;

            if (dragging && !timer.Enabled)
            {
                Point currentPoint = PointToScreen(new Point(e.X, e.Y));
                this.Location = new Point(currentPoint.X - pos.X, currentPoint.Y - pos.Y);
            }
        }

        //Зажатие клавиш
        private void MainForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.DoubleBuffered = true;

            //Выход из игры
            if (e.KeyChar == (char)Keys.Escape)
            {
                this.Close();
            }
        }

        //Геймплей
        private void timer_Tick(object sender, EventArgs e)
        {
            stopwatch.Restart();
            totalFrames++;

            this.DoubleBuffered = true;

            int speed = 0;
            int carSpeed = 0;

            //Сложность
            if (diffBeginner || diffAdvanced || diffProfessional)
            {
                if (diffBeginner)
                {
                    speed = 5;
                    carSpeed = 7;
                }
                else if (diffAdvanced)
                {
                    speed = 8;
                    carSpeed = 10;
                }
                else if (diffProfessional)
                {
                    speed = 17;
                    carSpeed = 20;
                }
            }

            //Перемещение машинки
            if (moveLeft && player.Left > 150)
            {
                player.Left -= moveSpeed;
            }
            if (moveRight && player.Right < 700)
            {
                player.Left += moveSpeed;
            }

            BGpic1.Top += speed;
            BGpic2.Top += speed;

            enemy1.Top += carSpeed;
            enemy2.Top += carSpeed;

            coin.Top += speed;

            //Движение дороги
            if (BGpic1.Top >= 650)
            {
                BGpic1.Top = 0;
                BGpic2.Top = -650;
            }

            //Движение монеток
            if (coin.Top >= 650)
            {
                coin.Top = -50;

                coin.Left = rand.Next(150, 560);

                while (coin.Bounds.Left == enemy1.Bounds.Left || coin.Bounds.Left == enemy2.Bounds.Left)
                {
                    coin.Left = rand.Next(150, 560);
                }
            }

            //Движение противников
            if (enemy1.Top >= 650)
            {
                enemy1.Top = -130;
                enemy1.Left = rand.Next(150, 370);
            }

            if (enemy2.Top >= 650)
            {
                enemy2.Top = -400;
                enemy2.Left = rand.Next(420, 560);
            }

            //Поражение при столкновении
            if (player.Bounds.IntersectsWith(enemy1.Bounds) || player.Bounds.IntersectsWith(enemy2.Bounds))
            {
                timer.Enabled = false;

                LabelLose.Visible = true;
                restartButton.Visible = true;
                labelCoins.Visible = true;
                quitButton.Visible = true;
                goToMenuButton.Visible = true;

                labelInGameCoins.Visible = false;
                lose = true;
            }

            //Подбор монетки
            if (player.Bounds.IntersectsWith(coin.Bounds))
            {
                countCoins++;
                labelCoins.Text = "Picked Coins: " + countCoins.ToString();
                labelInGameCoins.Text = "Coins: " + countCoins.ToString();
                coin.Top = -50;
                coin.Left = rand.Next(150, 560);
            }

            stopwatch.Stop();

            //fps, ticktime, frames
            long elapsedMilliseconds = stopwatch.ElapsedMilliseconds;

            frameCount++;
            if ((DateTime.Now - lastFpsUpdate).TotalMilliseconds > 500)
            {
                fps = frameCount / ((DateTime.Now - lastFpsUpdate).TotalSeconds);
                lastFpsUpdate = DateTime.Now;
                frameCount = 0;

                fpsHistory.Enqueue(fps);
                if (fpsHistory.Count > MaxHistorySize)
                {
                    fpsHistory.Dequeue();
                }
            }

            double avgFps = fpsHistory.Average();

            if ((DateTime.Now - startTime).TotalSeconds >= 60)
            {
                startTime = DateTime.Now;
                totalFrames = 0;
            }

            if (avgFps > maxFPS)
            {
                maxFPS = avgFps;
            }

            fpsLabel.Text = $"FPS = {avgFps:F0} | maxFPS: {maxFPS:F0} | TickTime: {elapsedMilliseconds} ms | Frames: {totalFrames}";
        }

        //Движение машинки по нажатию кнопок
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            this.DoubleBuffered = true;

            if (lose)
            {
                return;
            }

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = true;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = true;
            }
        }

        //Прекращение движения машинки при отжатии кнопок
        private void MainForm_KeyUp(object sender, KeyEventArgs e)
        {
            this.DoubleBuffered = true;

            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                moveLeft = false;
            }
            else if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                moveRight = false;
            }
        }


        //Меню
        //Кнопка возврата в меню
        private void goToMenuButton_Click(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            timer.Enabled = false;

            labelMenu.Visible = true;
            BGmenu.Visible = true;
            menuButton.Visible = true;
            diffListBox.Visible = true;
            quitButton.Visible = true;

            LabelLose.Visible = false;
            restartButton.Visible = false;
            labelCoins.Visible = false;
            goToMenuButton.Visible = false;
        }

        //Кнопка старта
        private void menuButton_Click(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            if (diffListBox.CheckedItems.Count == 0)
            {
                MessageBox.Show("Pick the difficulty");
                return;
            }

            enemy1.Top = -130;
            enemy2.Top = -400;
            player.Left = 435;

            coin.Left = rand.Next(150, 560);

            LabelLose.Visible = false;
            restartButton.Visible = false;
            labelCoins.Visible = false;
            labelMenu.Visible = false;
            BGmenu.Visible = false;
            menuButton.Visible = false;
            diffListBox.Visible = false;
            quitButton.Visible = false;

            labelInGameCoins.Visible = true;
            timer.Enabled = true;

            lose = false;

            countCoins = 0;

            labelCoins.Text = "Picked Coins: " + countCoins.ToString();
            labelInGameCoins.Text = "Coins: " + countCoins.ToString();
            coin.Top = -50;
        }

        //Кнопка выхода из игры
        private void quitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Кнопки выбора сложности
        private void diffListBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            this.DoubleBuffered = true;

            var list = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
            {
                foreach (int index in list.CheckedIndices)
                {
                    if (index != e.Index)
                    {
                        list.SetItemChecked(index, false);
                    }
                }

                string selectedItem = list.Items[e.Index].ToString();

                if (selectedItem == "Beginner")
                {
                    diffBeginner = true;
                    diffAdvanced = false;
                    diffProfessional = false;
                }
                else if (selectedItem == "Advanced")
                {
                    diffAdvanced = true;
                    diffBeginner = false;
                    diffProfessional = false;
                }
                else if (selectedItem == "Professional")
                {
                    diffProfessional = true;
                    diffBeginner = false;
                    diffAdvanced = false;
                }
            }
        }

        //Кнопка перезапуска игры
        private void restartButton_Click(object sender, EventArgs e)
        {
            this.DoubleBuffered = true;

            enemy1.Top = -130;
            enemy2.Top = -400;
            player.Left = 435;

            LabelLose.Visible = false;
            restartButton.Visible = false;
            labelCoins.Visible = false;
            quitButton.Visible = false;
            goToMenuButton.Visible = false;

            labelInGameCoins.Visible = true;
            timer.Enabled = true;

            lose = false;

            countCoins = 0;

            labelCoins.Text = "Picked Coins: " + countCoins.ToString();
            labelInGameCoins.Text = "Coins: " + countCoins.ToString();
            coin.Top = -50;
        }
    }
}