using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {

        void decrypt(int p, int x)//string inFileName, string outFileName)
        {
            p = Common.p;
            x = Common.x;
            Common.a = Convert.ToInt32(ina.Text);
            //Common.s  = Convert.ToChar(mess.Text);
            Common.s = mess.Text.ToCharArray();
            Common.p = Convert.ToInt32(inp.Text);
            Common.x = Convert.ToInt32(inx.Text);
            string str = mess.Text;
            int n = str.Length;
            int[] res = new int[n];
            for (int i = 0; i < n; i++)
            {
                inf.Text += (char)Common.Mul((int)mess.Text[i], Common.Power(Common.a, Common.p - 1 - Common.x, Common.p), Common.p);
            }


        }

        public Form2()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
            mess.ScrollBars = ScrollBars.Both;
            inf.ScrollBars = ScrollBars.Both;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }


       


     

        
        private void button6_Click(object sender, EventArgs e)
        {
            if (inx.Text == "" && ina.Text == "" && inp.Text == "" && mess.Text == "" && inf.Text == "")
            {
                Application.Exit();
            }
            else
            {
                DialogResult result = MessageBox.Show("Сохранить расшифрованный текст?", "Сохранение", MessageBoxButtons.YesNo,
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

        private void Form2_MouseDown(object sender, MouseEventArgs e)
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

        private void inf_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Сохранить расшифрованный текст?", "Сохранение", MessageBoxButtons.YesNo,
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

        private void btn_Clear_Click(object sender, EventArgs e)
        {

            inx.Clear();
            mess.Clear();
            ina.Clear();
            inp.Clear();
            inf.Clear();
        }

        private void btn_open_file_Click(object sender, EventArgs e)
        {
            inx.Clear();
            mess.Clear();
            ina.Clear();
            inp.Clear();
            inf.Clear();
            OpenFileDialog open = new OpenFileDialog();
            if (open.ShowDialog() == DialogResult.OK)
            {
                string[] lines = File.ReadAllLines(open.FileName);
                inx.Text = lines[2];
                inp.Text = lines[5];
                ina.Text = lines[7];
                mess.Text = lines[9];
            }

        }

        private void btn_rah_Click(object sender, EventArgs e)
        {
            inf.Clear();
            if (inx.Text == "" || ina.Text == "" || inp.Text == "" || mess.Text == "")
            {
                MessageBox.Show("Пустые поля", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            decrypt(Common.p, Common.x);
        }

        private void btn_zah_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 fr = new Form1();
            fr.Show();
        }
    }
}
