using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prakt11_1_Shengals
{
    public partial class Student_work : Form
    {
        public Student_work()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Student student = new Student();
            student.name = textBox1.Text;
            student.size = (int)numericUpDown1.Value;
            student.weight = (int)numericUpDown2.Value;
            int eat = Convert.ToInt32(textBox2.Text);
            if (eat == 1)
            {
                student.SetEat(1);
                MessageBox.Show($"После еды 1 кг: вес = {student.GetEat()} кг, рост = {student.GetSize()} см");
            }
            else if (eat == 5)
            {
                student.SetEat(5);
                MessageBox.Show($"После еды 5 кг: вес = {student.GetEat()} кг, рост = {student.GetSize()} см");
            }
            else if (eat == 10)
            {
                student.SetEat(10);
                MessageBox.Show($"После еды 10 кг: вес = {student.GetEat()} кг, рост = {student.GetSize()} см");
            }
        }
    }
}
