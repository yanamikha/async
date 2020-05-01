using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asyncawait
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "no asymc-await";
        }

        int Factorial(int number)
        {
            int res = 1;
            for (int i = 2; i <= number; i++)
                res *= i;
            Thread.Sleep(100);
            return res;
        }

        async void SomeFunction()
        {
            textBox2.Text = Factorial(34).ToString();
            textBox3.Text = Factorial(4).ToString();
            textBox4.Text = Factorial(13).ToString();
            textBox5.Text = Factorial(10).ToString();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = "start:  " + DateTime.Now.TimeOfDay.ToString();
            SomeFunction();
            textBox1.Text += "\r\nend:   " + DateTime.Now.TimeOfDay.ToString();
           
        }

      
    }
}