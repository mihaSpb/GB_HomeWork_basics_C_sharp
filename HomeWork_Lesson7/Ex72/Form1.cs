using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Ex72
{
    public partial class Form1 : Form
    {
        RandNumber rnum;
        int max;
        Form2 f2;
        public Form1()
        {
            max = 250;
            rnum = new RandNumber(max);
            InitializeComponent();
            btnCheck.Text = "Проверить";
            this.Text = "Угадай число";
            lblStepCount.Text = "0";
            lblEnterTheNumber.Text = $"Введите число от 0 до {max}:";
            lblStepText.Text = "Счёт ходов:";
            MessageBox.Show("Вводите в поле число пока не угадаете. Нажимайте кнопку \"Проверить\" " +
                "чтобы узнать результат попытки. ", "Правила");
            tboxUserAnswer.Visible = false;
            f2 = new Form2();
            f2.Show();
        }


        // Обработчик нажатия кнопки
        private void btnCheck_Click_1(object sender, EventArgs e)
        {
            bool check;
            Debug.WriteLine("Кнопка нажата");
            MessageBox.Show(rnum.CheckValue(out check, f2.userAnswer));

            if (check)
            {
                rnum.Reset(max);
                MessageBox.Show($"Игра началась заново.\nВведите число от 0 до {max}:");
            }
            Update();
        }
        //private void btnCheck_Click(object sender, EventArgs e)
        //{
        //    bool check;
        //    Debug.WriteLine("Кнопка нажата");
        //    MessageBox.Show(rnum.CheckValue(out check, f2.userAnswer));

        //    if (check)
        //    {
        //        rnum.Reset(max);
        //        MessageBox.Show($"Игра началась заново.\nВведите число от 0 до {max}:");
        //    }
        //    Update();
        //}

        void Update()
        {
            lblStepCount.Text = rnum.Steps.ToString();
            this.Refresh();
        }

    }
 }
