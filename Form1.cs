using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RandomBirthDate
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void GetRandom_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            string BirthDate;
            int age;
            int currentYear = DateTime.Now.Year;
            int dayBirth;
            int monthBirth;

            if (int.TryParse(AgeText.Text, out age) == false)
             {
                MessageBox.Show("Неправильно введен возраст", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
             }

            if (age == 0) //рандомная дата при 0
            {
                currentYear -= rand.Next(18, 60);
                dayBirth = rand.Next(1, 30);
                monthBirth = rand.Next(1, 12);
                BirthDate = $"{ResNumber(dayBirth)}.{ResNumber(monthBirth)}.{currentYear}";
                DateText.Text = BirthDate;
            }
            else if (age > 0)
            {
                dayBirth = rand.Next(1, 30);
                monthBirth = rand.Next(1, 12);
                BirthDate = $"{ResNumber(dayBirth)}.{ResNumber(monthBirth)}.{currentYear - age}";
                DateText.Text = BirthDate;
            }
            else MessageBox.Show("Нужно больше 0", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        static string ResNumber(int number) //дописывание 0 в выводе
        {
            string resNumber;

            if (number >= 1 && number <= 9) resNumber = "0" + number;
            else resNumber = number.ToString();
            return resNumber;
        }
    }
}
