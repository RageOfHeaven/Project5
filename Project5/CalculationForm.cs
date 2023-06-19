using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Project5
{
    public partial class CalculationForm : Form
    {
        public CalculationForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string selectedOperation = comboBox1.SelectedItem.ToString();

            switch (selectedOperation)
            {
                case "Сума чисел":
                    int sum = 0;
                    foreach (char digitChar in textBox1.Text)
                    {
                        if (char.IsDigit(digitChar))
                        {
                            int digit = int.Parse(digitChar.ToString());
                            sum += digit;
                        }
                    }
                    label3.Text = sum.ToString();
                    break;
                case "Середнє арифметичне":
                    double average = 0;
                    int total = 0;
                    foreach (char character in textBox1.Text)
                    {
                        if (char.IsDigit(character))
                        {
                            average += char.GetNumericValue(character);
                            total++;
                        }
                    }
                    if (total > 0)
                    {
                        average /= total;
                    }
                    label3.Text = average.ToString();
                    break;
                case "Кількість чисел":
                    int count = 0;
                    foreach (char character in textBox1.Text)
                    {
                        if (char.IsDigit(character))
                        {
                            count++;
                        }
                    }
                    label3.Text = count.ToString();
                    break;
                case "Віддзеркалити значення":
                    string mirroredValue = string.Empty;
                    for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                    {
                        mirroredValue += textBox1.Text[i];
                    }
                    label3.Text = mirroredValue.ToString();
                    break;
                case "Змішування":
                    string mixedValue = string.Empty;
                    List<string> numbers = new List<string>();

                    for (int i = 0; i < textBox1.Text.Length; i++)
                    {
                        numbers.Add(textBox1.Text[i].ToString());
                    }
                    Random random = new Random();
                    while (numbers.Count > 0)
                    {
                        int index = random.Next(numbers.Count);
                        mixedValue += numbers[index];
                        numbers.RemoveAt(index);
                    }
                    label3.Text = mixedValue;
                    break;
                default:
                    label3.Text = "Оберіть операцію";
                    break;
            }
    }
    private string PerformOperation(string operation, string value)
        {
            return "Результат операції";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(textBox1.Text);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Сума чисел");
            comboBox1.Items.Add("Середнє арифметичне");
            comboBox1.Items.Add("Кількість чисел");
            comboBox1.Items.Add("Віддзеркалити значення");
            comboBox1.Items.Add("Змішування");
            comboBox1.SelectedIndex = 0;
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            {
                string selectedOperation = comboBox1.SelectedItem.ToString();

                switch (selectedOperation)
                {
                    case "Сума чисел":
                        int sum = 0;
                        foreach (char digitChar in textBox1.Text)
                        {
                            if (char.IsDigit(digitChar))
                            {
                                int digit = int.Parse(digitChar.ToString());
                                sum += digit;
                            }
                        }
                        label3.Text = sum.ToString();
                        break;
                    case "Середнє арифметичне":
                        double average = 0;
                        int total = 0;
                        foreach (char character in textBox1.Text)
                        {
                            if (char.IsDigit(character))
                            {
                                average += char.GetNumericValue(character);
                                total++;
                            }
                        }
                        if (total > 0)
                        {
                            average /= total;
                        }
                        label3.Text = average.ToString();
                        break;
                    case "Кількість чисел":
                        int count = 0;
                        foreach (char character in textBox1.Text)
                        {
                            if (char.IsDigit(character))
                            {
                                count++;
                            }
                        }
                        label3.Text = count.ToString();
                        break;
                    case "Віддзеркалити значення":
                        string mirroredValue = string.Empty;
                        for (int i = textBox1.Text.Length - 1; i >= 0; i--)
                        {
                            mirroredValue += textBox1.Text[i];
                        }
                        label3.Text = mirroredValue.ToString();
                        break;
                    case "Змішування":
                        string mixedValue = string.Empty;
                        List<string> numbers = new List<string>();

                        for (int i = 0; i < textBox1.Text.Length; i++)
                        {
                            numbers.Add(textBox1.Text[i].ToString());
                        }
                        Random random = new Random();
                        while (numbers.Count > 0)
                        {
                            int index = random.Next(numbers.Count);
                            mixedValue += numbers[index];
                            numbers.RemoveAt(index);
                        }
                        label3.Text = mixedValue;
                        break;
                    default:
                        label3.Text = "Помилка операції";
                        break;
                }
            }
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Сума чисел");
            comboBox1.Items.Add("Середнє арифметичне");
            comboBox1.Items.Add("Кількість чисел");
            comboBox1.Items.Add("Віддзеркалити значення");
            comboBox1.Items.Add("Змішування");
            comboBox1.SelectedIndex = 0;
        }
    }
}
