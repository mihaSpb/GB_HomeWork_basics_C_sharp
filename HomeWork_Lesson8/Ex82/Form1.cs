using System;
using System.Windows.Forms;


// Морозов Михаил
// Создайте простую форму на котором свяжите свойство Text элемента TextBox со свойством Value элемента NumericUpDown


namespace Ex82
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "Текст = Значение";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            textBox1.Text = numericUpDown1.Value.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                numericUpDown1.Value = decimal.Parse(textBox1.Text);
            }

            catch (ArgumentOutOfRangeException ex)
            {
                MessageBox.Show($"Некорректный ввод: {ex.Message}");
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Некорректный ввод: {ex.Message}");
            }
        }
    }
}
