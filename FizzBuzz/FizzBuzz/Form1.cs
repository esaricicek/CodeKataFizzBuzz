using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FizzBuzz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int ot;
            if (int.TryParse(textBox1.Text,out ot)) label1.Text = FindFizzBuzz(ot);
        }

        private string FindFizzBuzz(int vl )
        {
         var rtrn = "";
         if (vl % 3 == 0 && vl % 5 == 0) return "FizzBuzz";
         else if(vl % 3 == 0) return "Fizz";
         else if(vl % 5 == 0) return "Buzz";
         return rtrn;
        }
    }
}
