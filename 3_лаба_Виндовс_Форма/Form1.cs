using System;
using System.Windows.Forms;

namespace _3_лаба_Виндовс_Форма
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            buttonCalculate.Click += buttonCalculate_Click;
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            // Получаем значения x, y и z
            if (double.TryParse(textBoxX.Text, out double x) &&
                double.TryParse(textBoxY.Text, out double y) &&
                double.TryParse(textBoxZ.Text, out double z))
            {
                // Вычисляем результат функции a
                double result = CalculateA(x, y, z);

                // Выводим результат в TextBox
                textBoxResult.Text = result.ToString();
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных. Проверьте введенные значения.");
            }
        }

        private double CalculateA(double x, double y, double z)
        {
            // Вычисляем результат функции a
            double a = Math.Log(Math.Pow(y, -Math.Sqrt(Math.Abs(x))) * (x - (y / 2) + Math.Pow(Math.Sin(z), 2)) * Math.Atan(z));
            return a;
        }
    }
}
