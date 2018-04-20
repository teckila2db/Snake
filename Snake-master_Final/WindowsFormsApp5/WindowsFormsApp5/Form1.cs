﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {
        Random randFood = new Random();
        Graphics paper;
        Snake snake = new Snake();
        Food food;

    bool left = false;
        bool right = false;
        bool down = false;
        bool up = false;

        int score = 0;

        public Form1()
        {
            InitializeComponent();
            food = new Food(randFood);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            paper = e.Graphics;
            food.drawFood(paper);
            snake.drawSnake(paper);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData == Keys.Space)
            {
                timer1.Enabled = true;
                spaceBarLabel.Text = "";
                spaceBarLabel2.Text = "";
                down = false;
                up = false;
                right = true;
                left = false;
            }
            if(e.KeyData == Keys.H)
            {
                timer1.Enabled = false;
                timer1.Interval = 20;
                timer1.Enabled = true;
                spaceBarLabel.Text = "";
                spaceBarLabel2.Text = "";
            }
            if (e.KeyData == Keys.E)
            {
                timer1.Enabled = false;
                timer1.Interval = 65;
                timer1.Enabled = true;
                spaceBarLabel.Text = "";
                spaceBarLabel2.Text = "";
            }
            if (e.KeyData == Keys.N)
            {
                timer1.Enabled = false;
                timer1.Interval = 50;
                timer1.Enabled = true;
                spaceBarLabel.Text = "";
                spaceBarLabel2.Text = "";
            }
            if (e.KeyData == Keys.Down && up == false)
            {
                down = true;
                up = false;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Up && down == false)
            {
                down = false;
                up = true;
                right = false;
                left = false;
            }
            if (e.KeyData == Keys.Right && left == false)
            {
                down = false;
                up = false;
                right = true;
                left = false;
            }
            if (e.KeyData == Keys.Left && right == false)
            {
                down = false;
                up = false;
                right = false;
                left = true;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            snakeScoreLabel.Text = Convert.ToString(score);

            if(down) { snake.moveDown(); }
            if (up) { snake.moveUp(); }
            if (right) { snake.moveRight(); }
            if (left) { snake.moveLeft(); }

            for (int i = 0; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[i].IntersectsWith(food.foodRec))
                {
                    score += 10;
                    snake.growSnake();
                    food.foodLocation(randFood);
                }
            }

            collision();

            this.Invalidate();
        }

        public void collision()
        {
            for (int i = 1; i < snake.SnakeRec.Length; i++)
            {
                if (snake.SnakeRec[0].IntersectsWith(snake.SnakeRec[i]))
                {
                    restart();
                }
            }
            
            if(snake.SnakeRec[0].X < 0 || snake.SnakeRec[0].X > 350)
            {
                restart();
            }

            if (snake.SnakeRec[0].Y < 0 || snake.SnakeRec[0].Y > 350)
            {
                restart();
            }
        }

        public void restart()
        {
            timer1.Enabled = false;
            MessageBox.Show("Le Snake est mort");
            snakeScoreLabel.Text = "0";
            score = 0;
            spaceBarLabel.Text = "Appuis sur la barre espace pour commencer";
            spaceBarLabel2.Text = "Press sur H = Dur, E= Facile et N= normal";
            snake = new Snake();
        }

        private void spaceBarLabel_Click(object sender, EventArgs e)
        {

        }
        private void spaceBarLabel2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void toolStripStatusLabel2_Click(object sender, EventArgs e)
        {

        }
    }
}
