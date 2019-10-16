using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FizzBuzzLib;


namespace WindowsFormsApplication1
{
    public partial class DesktopUI : Form
    {
        FizzBuzzBL fb;
        public DesktopUI()
        {
            InitializeComponent();
            this.fb = new FizzBuzzBL();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        String[] shortVariantFB()
        {
            String[] lines = new String [100];
            for (int i = 1; i <= 100; i++)
            {

                if (fb.isFizz(i))
                    lines[i - 1] = "Fizz";

                if (fb.isBuzz(i))
                    lines[i - 1] += "Buzz";

                if (fb.isNotFB(i))
                    lines[i - 1] = i.ToString();
            }
            return lines;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Lines =  shortVariantFB();
        }
    }
}
