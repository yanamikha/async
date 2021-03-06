﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asyncawait
{
    public partial class Form2_async_ : Form
    {
        public Form2_async_()
        {
            InitializeComponent();
            this.Text = "async-await";
        }

        int Factorial(int number)
        {
            int res = 1;
            for (int i = 2; i <= number; i++)
                res *= i; ;
            Thread.Sleep(100);
            return res;
        }

        async void  SomeFunction()
        {
            textBox2.Text = await Task.Run(() => Factorial(34).ToString());
            textBox3.Text = await Task.Run(() => Factorial(4).ToString());
            textBox4.Text = await Task.Run(() => Factorial(13).ToString());
            textBox5.Text = await Task.Run(() => Factorial(10).ToString());
        }
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "start:  " + DateTime.Now.TimeOfDay.ToString();
            SomeFunction();
            textBox1.Text += "\r\nend:    " + DateTime.Now.TimeOfDay.ToString();

        }

    }
}
