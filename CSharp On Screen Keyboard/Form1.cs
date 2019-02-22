using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;


namespace CSharp_On_Screen_Keyboard
{
    public partial class Form1 : Form
    {
        Boolean capslock = false;
        Boolean shift = false;

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams param = base.CreateParams;
                param.ExStyle |= 0x08000000;
                return param;
            }
        }

        //cobaroundform
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectgn
        (
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
        );

        public Form1()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.None;
            Region = System.Drawing.Region.FromHrgn(CreateRoundRectgn(0, 0,Width,Height,20,20));
        }

        //akhircobaroundform

        private void button10_Click(object sender, EventArgs e)
        {
            if (capslock == true)
            {
                SendKeys.Send("Q");
                shift = false;
            }
            else
            {
                SendKeys.Send("q");
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (capslock == true||shift==true)
            {
                SendKeys.Send("W");
                shift = false;
            }
            else
            {
                SendKeys.Send("w");
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("E");
                shift = false;
            }
            else
            {
                SendKeys.Send("e");
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("R");
                shift = false;
            }
            else
            {
                SendKeys.Send("r");
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("T");
                shift = false;
            }
            else
            {
                SendKeys.Send("t");
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("Y");
                shift = false;
            }
            else
            {
                SendKeys.Send("y");
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("U");
                shift = false;
            }
            else
            {
                SendKeys.Send("u");
            }
        }

        private void button72_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("I");
                shift = false;
            }
            else
            {
                SendKeys.Send("i");
            }
        }

        private void button71_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("O");
                shift = false;
            }
            else
            {
                SendKeys.Send("o");
            }
        }

        private void button70_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("P");
                shift = false;
            }
            else
            {
                SendKeys.Send("p");
            }
        }

        private void button23_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("A");
                shift = false;
            }
            else
            {
                SendKeys.Send("a");
            }
        }

        private void button22_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("S");
                shift = false;
            }
            else
            {
                SendKeys.Send("s");
            }
        }

        private void button21_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("D");
                shift = false;
            }
            else
            {
                SendKeys.Send("d");
            }
        }

        private void button20_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("F");
                shift = false;
            }
            else
            {
                SendKeys.Send("f");
            }
        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("G");
                shift = false;
            }
            else
            {
                SendKeys.Send("g");
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("H");
                shift = false;
            }
            else
            {
                SendKeys.Send("h");
            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("J");
                shift = false;
            }
            else
            {
                SendKeys.Send("j");
            }
        }

        private void button69_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("K");
                shift = false;
            }
            else
            {
                SendKeys.Send("k");
            }
        }

        private void button68_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("L");
                shift = false;
            }
            else
            {
                SendKeys.Send("l");
            }
        }

        private void button31_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("Z");
                shift = false;
            }
            else
            {
                SendKeys.Send("z");
            }
        }

        private void button30_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("X");
                shift = false;
            }
            else
            {
                SendKeys.Send("x");
            }
        }

        private void button29_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("C");
                shift = false;
            }
            else
            {
                SendKeys.Send("c");
            }
        }

        private void button28_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("V");
                shift = false;
            }
            else
            {
                SendKeys.Send("v");
            }
        }

        private void button27_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("B");
                shift = false;
            }
            else
            {
                SendKeys.Send("b");
            }
        }

        private void button26_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("N");
                shift = false;
            }
            else
            {
                SendKeys.Send("n");
            }
        }

        private void button25_Click(object sender, EventArgs e)
        {
            if (capslock == true || shift == true)
            {
                SendKeys.Send("M");
                shift = false;
            }
            else
            {
                SendKeys.Send("m");
            }
        }

        private void button24_Click(object sender, EventArgs e)
        {
            if (capslock == false)
            {
                capslock = true;
            }
            else
            {
                capslock = false;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{TAB}");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            if (shift == false)
            {
                shift = true;
            }
            else
            {
                shift = false;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("~");
                shift = false;
            }
            else
            {
                SendKeys.Send("`");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("!");
                shift = false;
            }
            else
            {
                SendKeys.Send("1");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("@");
                shift = false;
            }
            else
            {
                SendKeys.Send("2");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("#");
                shift = false;
            }
            else
            {
                SendKeys.Send("3");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("$");
                shift = false;
            }
            else
            {
                SendKeys.Send("4");
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("{%}");
                shift = false;
            }
            else
            {
                SendKeys.Send("5");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("{^}");
                shift = false;
            }
            else
            {
                SendKeys.Send("6");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("&");
                shift = false;
            }
            else
            {
                SendKeys.Send("7");
            }
        }

        private void button75_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("*");
                shift = false;
            }
            else
            {
                SendKeys.Send("8");
            }
        }

        private void button74_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("{(}");
                shift = false;
            }
            else
            {
                SendKeys.Send("9");
            }
        }

        private void button73_Click(object sender, EventArgs e)
        {
            
            if (shift == true)
            {
                SendKeys.Send("{)}");
                shift = false;
            }
            else
            {
                SendKeys.Send("0");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button76_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("_");
                shift = false;
            }
            else
            {
                SendKeys.Send("-");
            }
        }

        private void button61_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("{+}");
                shift = false;
            }
            else
            {
                SendKeys.Send("=");
            }
        }

        private void button52_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("{{}");
                shift = false;
            }
            else
            {
                SendKeys.Send("[");
            }
        }

        private void button44_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("{}}");
                shift = false;
            }
            else
            {
                SendKeys.Send("]");
            }
        }

        private void button67_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send(":");
                shift = false;
            }
            else
            {
                SendKeys.Send(";");
            }
        }

        private void button42_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("\"");
                shift = false;
            }
            else
            {
                SendKeys.Send("'");
            }
        }

        private void button37_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("|");
                shift = false;
            }
            else
            {
                SendKeys.Send("\\");
            }
        }

        private void button66_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("<");
                shift = false;
            }
            else
            {
                SendKeys.Send(",");
            }
        }

        private void button65_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send(">");
                shift = false;
            }
            else
            {
                SendKeys.Send(".");
            }
        }

        private void button64_Click(object sender, EventArgs e)
        {
            if (shift == true)
            {
                SendKeys.Send("?");
                shift = false;
            }
            else
            {
                SendKeys.Send("/");
            }
        }

        private void button48_Click(object sender, EventArgs e)
        {
            if (shift == false)
            {
                shift = true;
            }
            else
            {
                shift = false;
            }
        }

        private void button58_Click(object sender, EventArgs e)
        {
            SendKeys.Send("/");
        }

        private void button57_Click(object sender, EventArgs e)
        {
            SendKeys.Send("*");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            SendKeys.Send(" ");
        }

        private void button56_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{ENTER}");
        }

        private void button60_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{BACKSPACE}");
        }

        private void button54_Click(object sender, EventArgs e)
        {
            SendKeys.Send("8");
        }

        private void button51_Click(object sender, EventArgs e)
        {
            SendKeys.Send("4");
        }

        private void button55_Click(object sender, EventArgs e)
        {
            SendKeys.Send("7");
        }

        private void button53_Click(object sender, EventArgs e)
        {
            SendKeys.Send("9");
        }

        private void button50_Click(object sender, EventArgs e)
        {
            SendKeys.Send("5");
        }

        private void button49_Click(object sender, EventArgs e)
        {
            SendKeys.Send("6");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            SendKeys.Send("1");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            SendKeys.Send("2");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            SendKeys.Send("3");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            SendKeys.Send("0");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            SendKeys.Send(".");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{UP}");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{LEFT}");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{DOWN}");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            SendKeys.Send("{RIGHT}");
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            
        }

       
    }
}
