using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
       void crypt(int p, int x)
        {

            Common.p = Common.Rand(Common.op);
            Common.x = x;
            string str = inm.Text;
            int n = str.Length;
            int[] res = new int[n];

            for (Common.i = 0; Common.i < n; Common.i++)
            {
                res[Common.i] = (int)str[Common.i];
            }

           

            Common.g = Common.GetPRoot(Common.p);

            Common.k = Common.rns.Next((Common.p - 2) + 1); 


            Common.x = Common.rns.Next(1, Common.p - 1);// 1 < k < (Common.p-1)
            Common.y = Common.Power(Common.g, Common.x, Common.p);// p g y открытые ключи

            Common.b = new int[n];

       
                Common.a = Common.Power(Common.g, Common.k, Common.p);
                for (Common.i = 0; Common.i < n; Common.i++)
                {
                    Common.b[Common.i] = Common.Mul(Common.Power(Common.y, Common.k, Common.p), res[Common.i], Common.p);
                }

                inf.Text = "Закрытый ключ:" + "\r\n" + "х= " + "\r\n" + Common.x;
                inf.Text += Environment.NewLine + "Открытые ключи: " + "\r\n" + "p= " + "\r\n" + Common.p + "\r\n" + "a= " + "\r\n" + Common.a;
                inf.Text += Environment.NewLine + "Шифр-текст: " + "\r\n";

                Common.res2 = new char[n];
                for (int i = 0; i < n; i++)
                {
                    Common.res2[i] = (char)Common.b[i];
                    inf.Text += Common.res2[i];
              
                }
      

        }

        public Form1()
        {
            InitializeComponent();
            //StartPosition = FormStartPosition.CenterScreen;
            //inf.ScrollBars = ScrollBars.Both;
            //inm.ScrollBars = ScrollBars.Both;
            //Opacity = 0;
            //Timer timer = new Timer();
            //timer.Tick += new EventHandler((sender, e) =>
            // {
            //     if ((Opacity += 0.3d) == 1) timer.Stop();
            // });
            //timer.Interval = 100;
            //timer.Start();
        }

        
    

       

        private void button6_Click(object sender, EventArgs e)
        {
            if (inm.Text == "" && inf.Text == "")
            {

                Application.Exit();
            }
            else
            {
                DialogResult result = MessageBox.Show("Сохранить ключи?", "Сохранение", MessageBoxButtons.YesNo,
                      MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);


                if (result == DialogResult.Yes)
                {

                    SaveFileDialog save = new SaveFileDialog();
                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        StreamWriter date = new StreamWriter(save.FileName, true, Encoding.Unicode);
                        date.WriteLine(inf.Text, true);
                        date.Close();

                    }
                    else
                    {
                        Application.Exit();
                    }

                }
                Application.Exit();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (base.WindowState == FormWindowState.Normal)
            {
                base.WindowState = FormWindowState.Minimized;
            }
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            base.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            panel2.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void label6_MouseDown(object sender, MouseEventArgs e)
        {
            label6.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

      

        private void inf_TextChanged(object sender, EventArgs e)
        {

        }

        private void inm_TextChanged(object sender, EventArgs e)
        {

        }

        private void inf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void panel2_MouseDown_1(object sender, MouseEventArgs e)
        {
            panel2.Capture = false;
            Message m = Message.Create(base.Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            this.WndProc(ref m);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

     

        private void btn_zah_Click(object sender, EventArgs e)
        {
            inf.Clear();
            if (inm.Text == "")
            {
                MessageBox.Show("Пустые поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);


                return;
            }

            crypt(Common.p, Common.x);

        }

        private void btn_rah_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 fr = new Form2();

            fr.ShowDialog(this);
        }

        private void btn_open_Click(object sender, EventArgs e)
        {

            Encoding utf8 = Encoding.GetEncoding("UTF-8");
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                inm.Text = File.ReadAllText(open.FileName);


            }
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            inm.Clear();
            inf.Clear();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить ключи?", "Сохранение", MessageBoxButtons.YesNo,
               MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.Yes)
            {
                SaveFileDialog save = new SaveFileDialog();
                if (save.ShowDialog() == DialogResult.OK)
                {
                    StreamWriter date = new StreamWriter(save.FileName, true, Encoding.Unicode);
                    date.WriteLine(inf.Text, true);
                    date.Close();

                }
                else
                {
                    this.Hide();
                }

            }
        }
    }
}