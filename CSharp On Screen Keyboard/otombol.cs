using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace CSharp_On_Screen_Keyboard
{
    public partial class otombol : Form
    {
        static Form1 bk = new Form1();
        
        Boolean saklar = false;
        public otombol()
        {
            InitializeComponent();
        }

        private void otombol_Click(object sender, EventArgs e)
        {
            
            if (saklar == false)
            {
                saklar = true;
                bk = new Form1();
                bk.Show();
                
            }
            else
            {
                saklar = false;
                bk.Close();
                
            }
        }

        private void otombol_Load(object sender, EventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            path.AddEllipse(0, 0, this.Width, this.Height);
            Region region = new Region(path);
            this.Region = region;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (saklar == false)
            {
                saklar = true;
                bk = new Form1();
                bk.Show();

            }
            else
            {
                saklar = false;
                bk.Close();

            }
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
