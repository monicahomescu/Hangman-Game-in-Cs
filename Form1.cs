using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace leg
{
    public partial class leg : Form
    {
        public leg()
        {
            InitializeComponent();
            txt1.PasswordChar = '*';
        }
        string s;
        int k = 6, x = 0;
        char[] cuvant;
        private void leg_Load(object sender, EventArgs e)
        {

        }

        private void pnl_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = pnl.CreateGraphics();
            Pen r = new Pen(Color.Red,3);
            Pen p = new Pen(Color.Black,6);
            Brush b = new SolidBrush(Color.Black);
            g.DrawLine(r, 50, 350, 180,350);
            g.DrawLine(r, 115, 350, 115, 90);
            g.DrawLine(r, 115, 90, 180, 90);
            g.DrawLine(r, 180, 90, 180, 110);
        }

        private void desen()
        {
            Graphics g = pnl.CreateGraphics();
            Pen p = new Pen(Color.Black, 6);
            Brush b = new SolidBrush(Color.Black);
            if (k == 5)
            {
                g.DrawEllipse(p, 160, 110, 40, 40);
                g.FillEllipse(b, 160, 110, 40, 40);
            }
            if (k == 4)
                g.DrawLine(p, 180, 150, 180, 261);
            if (k == 3)
                g.DrawLine(p, 180, 170, 160, 190);
            if(k == 2)
                g.DrawLine(p, 180, 170, 200, 190);
            if (k == 1)
                g.DrawLine(p, 180, 260, 160, 280);
            if(k == 0)
                g.DrawLine(p, 180, 260, 200, 280);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            btn.Visible = false;
            txt2.Visible = true;
            btn3.Visible = true;
            txt3.Visible = true;
            btn4.Visible = true;
            lbl3.Visible = true;
            lbl4.Visible = true;
            s = txt1.Text;
            cuvant = new char[txt1.Text.Length];
            for (int i = 0; i < txt1.Text.Length; i++)
                cuvant[i] = '?';
            lbl1.Text = new string(cuvant);
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            string v = txt3.Text;
            if (v == s)
                MessageBox.Show("Ai ghicit");
            else
            {
                MessageBox.Show("Gresit");
                lbl5.Visible = true;
                txt4.Visible = true;
                txt4.Text = s;
            }
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            lbl3.Visible = false;
            txt2.Visible = false;
            btn3.Visible = false;
            lbl6.Text = "";
            txt3.Text = "";
            lbl4.Visible = false;
            txt3.Visible = false;
            btn4.Visible = false;
            lbl5.Visible = false;
            txt4.Visible = false;
            btn.Visible = true;
            lbl1.Text = "";
            pnl.Refresh();
            string s;
            x = 0;
            char[] cuvant;
            k = 6;
            s = txt1.Text;
            cuvant = new char[txt1.Text.Length];
            for (int i = 0; i < txt1.Text.Length; i++)
                cuvant[i] = '?';
            lbl1.Text = new string(cuvant);
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            char c = txt2.Text[0];
            int var = 0;
            for(int i=0;i<txt1.Text.Length;i++)
            {
                if (c == s[i])
                {
                    cuvant[i] = c;
                    x++;
                    var++;
                }
            }
            if (var == 0)
                lbl6.Text += txt2.Text + " ";
            txt2.Text = "";
            if (var == 0)
            {
                k--;
                desen();
            }
           else
            {
                lbl1.Text = "";
                for (int i = 0; i < txt1.Text.Length; i++)
                    lbl1.Text += cuvant[i];
            }
            if (k == 0)
            { 
                desen();
                MessageBox.Show("Nu mai ai vieti");
                lbl5.Visible = true;
                txt4.Visible = true;
                txt4.Text = s;
            }
            if (x == txt1.Text.Length)
                MessageBox.Show("Ai ghicit");
        }
    }
}
