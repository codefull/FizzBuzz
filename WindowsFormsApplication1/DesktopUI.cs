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

        void shortVariantFB()
        {
            for (int i = 1; i <= 100; i++)
            {
                if (fb.isFizz(i))
                    Console.Write("Fizz");

                if (fb.isBuzz(i))
                    Console.Write("Buzz");

                if (fb.isNotFB(i))
                    Console.Write(i.ToString());

            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
