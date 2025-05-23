using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrimeNumbers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }

        private void tbNumber2_TextChanged(object sender, EventArgs e){ }
        private void tbNumber1_TextChanged(object sender, EventArgs e){ }

        // Проверка на простое число
        private bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }

        // Получение списка чисел
        private List<int> GetPrimesInRange(int start, int end)
        {
            List<int> primes = new List<int>();

            // Проверка, что start меньше end
            if (start > end)
            {
                int temp = start;
                start = end;
                end = temp;
            }

            for (int i = start; i <= end; i++)
            {
                if (IsPrime(i))
                    primes.Add(i);
            }
            return primes;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                int num1 = int.Parse(tbNumber1.Text);
                int num2 = int.Parse(tbNumber2.Text);

                List<int> primes = new List<int>();
                int start = Math.Min(num1, num2);
                int end = Math.Max(num1, num2);

                for (int i = start; i <= end; i++)
                {
                    if (IsPrime(i)) primes.Add(i);
                }

                if (primes.Count == 0)
                {
                    lbResult.Text = "Простых чисел в диапазоне не найдено.";
                }
                else
                {
                    string result = $"Найдено {primes.Count} простых чисел:\n";
                    for (int i = 0; i < primes.Count; i++)
                    {
                        result += primes[i] + " ";
                        if ((i + 1) % 5 == 0) result += "\n";
                    }
                    lbResult.Text = result;
                }
            }
            catch (Exception ex)
            {
                lbResult.Text = $"Ошибка: {ex.Message}";
            }
        }
    }
}
