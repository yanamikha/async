using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace asyncawait
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            Form1 form1 = new Form1();
            Form2_async_ form2 = new Form2_async_();
            form1.ShowDialog();
            form2.ShowDialog();
            
        }
    }
}
