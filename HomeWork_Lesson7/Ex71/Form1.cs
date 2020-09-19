using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Морозов Михаил
// а) Добавить в программу «Удвоитель» подсчёт количества отданных команд удвоителю.
// б) Добавить меню и команду «Играть». При нажатии появляется сообщение, какое число должен получить игрок.
// Игрок должен получить это число за минимальное количество ходов.
// в) * Добавить кнопку «Отменить», которая отменяет последние ходы.Используйте обобщенный класс Stack.
// Вся логика игры должна быть реализована в классе с удвоителем.


namespace Ex71
{
    public partial class Form1 : Form
    {

        GameDoubling gameDoubling;

        public Form1()
        {
            gameDoubling = new GameDoubling();
            InitializeComponent();
            btnCommand1.Text = "+1";
            btnCommand2.Text = "x2";
            lblNumber.Text = "1";
            btnReset.Text = "Сброс";
            this.Text = "Удвоитель";
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
            lblStepsCount.Text = "0";
        }


        public void Update ()
        {
            lblNumber.Text = gameDoubling.ResultValue.ToString();
            lblStepsCount.Text = gameDoubling.StepCount.ToString();
            this.Refresh();

            if (lblGoal.Visible)
                if (gameDoubling.CheckGoal())
                {
                    MessageBox.Show($"Вы достигли цель за {gameDoubling.StepCount} ходов");
                    lblGoal.Visible = false;
                    lblGoalText.Visible = false;
                    gameDoubling.Reset();
                }
        }


        //private void btnCommand2_Click(object sender, EventArgs e)
        //{
        //    //lblNumber.Text = (int.Parse(lblNumber.Text) * 2).ToString();
        //    gameDoubling.MultiplicTwo();
        //    Update();
        //}

        // Кнопка сброса
        private void btnReset_Click(object sender, EventArgs e)
        {
            //lblNumber.Text = "1";
            gameDoubling.Reset();
            Update();
        }

        // Выход из игры
        private void exitToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        // Начать игру
        private void startGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            gameDoubling.SetGoal();
            MessageBox.Show($"Ваша цель: {gameDoubling.Goal}, получите это число!");
            gameDoubling.Reset();
            lblGoal.Visible = true;
            lblGoalText.Visible = true;
            lblGoal.Text = gameDoubling.Goal.ToString();
            Update();
        }

        // Остановить игру
        private void stopGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameDoubling.Reset();
            lblGoal.Visible = false;
            lblGoalText.Visible = false;
        }

        // Отменить ход
        private void undoStepToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gameDoubling.CheckStack();
            Update();
        }

        // Добавить единицу
        private void btnCommand1_Click_1(object sender, EventArgs e)
        {
            gameDoubling.PlusOne();
            Update();
        }

        // Умножение на 2
        private void btnCommand2_Click(object sender, EventArgs e)
        {
            gameDoubling.MultiplicTwo();
            Update();
        }
    }
}
