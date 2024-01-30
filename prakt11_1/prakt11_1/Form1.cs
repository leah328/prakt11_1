using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt11_1
{
    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        public class Student
        {
            public string name;
            public double rost;
            private double ves = 40;
            public double GetEat(double ves1)
            {
                ves = ves1;
                return ves;
            }
            public double SetEat(int eda, double ves)
            {
                if (eda >= 5 && eda < 10)
                {
                    ves = ves + ((eda - 2800 / 1000) * 0.7);
                }
                else
                    if (eda >= 10)
                {
                    ves = ves + ((eda - 2800 / 1000) * 0.5);
                }
                else
                    ves = ves + eda - 2800 / 1000;
                return ves;

            }

            public double SetRost(int eda, double rost)
            {
                if (eda >= 5 && eda <= 10)
                {
                    rost -= 1;
                    return rost;
                }
                else
                    if (eda >= 10)
                {
                    rost -= 2;
                    return rost;
                }
                else
                    return rost;
            }

        }
            
            
            private void button1_Click(object sender, EventArgs e)
            {
            Student student1 = new Student();
            student1.name = textBox1.Text;
            student1.rost = (double)(numericUpDown1.Value);
            MessageBox.Show(string.Format("Студент: {0}\nПервоначальный рост: {1}\nПервоначальный вес: {2}\nСъел еды: {3}кг\nРост после еды {4}\nВес после еды {5}", 
            student1.name, student1.rost, student1.GetEat(Convert.ToInt32(numericUpDown2.Value)), student1.GetEat(Convert.ToInt32(numericUpDown3.Value)),
            student1.SetRost(Convert.ToInt32(numericUpDown3.Value), student1.rost), student1.SetEat(Convert.ToInt32(numericUpDown3.Value), 
            (Convert.ToDouble(numericUpDown2.Value)))));
            }

    }
}
