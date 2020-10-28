namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.inx = new System.Windows.Forms.TextBox();
            this.mess = new System.Windows.Forms.TextBox();
            this.inf = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.inp = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_rah = new System.Windows.Forms.Button();
            this.btn_zah = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.ina = new System.Windows.Forms.TextBox();
            this.btn_open_file = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.button6 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btn_save = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // inx
            // 
            this.inx.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inx.Location = new System.Drawing.Point(129, 96);
            this.inx.Name = "inx";
            this.inx.Size = new System.Drawing.Size(100, 29);
            this.inx.TabIndex = 0;
            // 
            // mess
            // 
            this.mess.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.mess.Location = new System.Drawing.Point(32, 186);
            this.mess.Multiline = true;
            this.mess.Name = "mess";
            this.mess.Size = new System.Drawing.Size(303, 148);
            this.mess.TabIndex = 1;
            // 
            // inf
            // 
            this.inf.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inf.Location = new System.Drawing.Point(438, 186);
            this.inf.Multiline = true;
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(303, 148);
            this.inf.TabIndex = 3;
            this.inf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inf_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(28, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 5;
            this.label1.Text = "Введите х";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 161);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(328, 22);
            this.label2.TabIndex = 6;
            this.label2.Text = "Введите зашифрованное сообщение ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(487, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 22);
            this.label4.TabIndex = 9;
            this.label4.Text = "Введите p";
            // 
            // inp
            // 
            this.inp.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inp.Location = new System.Drawing.Point(608, 96);
            this.inp.Name = "inp";
            this.inp.Size = new System.Drawing.Size(100, 29);
            this.inp.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(473, 159);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 22);
            this.label5.TabIndex = 10;
            this.label5.Text = "Расшифрованный текст";
            // 
            // btn_rah
            // 
            this.btn_rah.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rah.Location = new System.Drawing.Point(91, 386);
            this.btn_rah.Name = "btn_rah";
            this.btn_rah.Size = new System.Drawing.Size(170, 32);
            this.btn_rah.TabIndex = 11;
            this.btn_rah.Text = "Расшифровать";
            this.btn_rah.UseVisualStyleBackColor = true;
            this.btn_rah.Click += new System.EventHandler(this.btn_rah_Click);
            // 
            // btn_zah
            // 
            this.btn_zah.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zah.Location = new System.Drawing.Point(91, 340);
            this.btn_zah.Name = "btn_zah";
            this.btn_zah.Size = new System.Drawing.Size(170, 32);
            this.btn_zah.TabIndex = 12;
            this.btn_zah.Text = "Зашифровать";
            this.btn_zah.UseVisualStyleBackColor = true;
            this.btn_zah.Click += new System.EventHandler(this.btn_zah_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_Clear.Location = new System.Drawing.Point(491, 340);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(170, 32);
            this.btn_Clear.TabIndex = 13;
            this.btn_Clear.Text = "Очистить все";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(256, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(96, 22);
            this.label3.TabIndex = 15;
            this.label3.Text = "Введите a";
            // 
            // ina
            // 
            this.ina.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ina.Location = new System.Drawing.Point(367, 96);
            this.ina.Name = "ina";
            this.ina.Size = new System.Drawing.Size(100, 29);
            this.ina.TabIndex = 14;
            // 
            // btn_open_file
            // 
            this.btn_open_file.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open_file.Location = new System.Drawing.Point(288, 340);
            this.btn_open_file.Name = "btn_open_file";
            this.btn_open_file.Size = new System.Drawing.Size(170, 32);
            this.btn_open_file.TabIndex = 16;
            this.btn_open_file.Text = "Открыть файл";
            this.btn_open_file.UseVisualStyleBackColor = true;
            this.btn_open_file.Click += new System.EventHandler(this.btn_open_file_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.button5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.button6);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 32);
            this.panel2.TabIndex = 17;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 3);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button5
            // 
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Dock = System.Windows.Forms.DockStyle.Right;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button5.Location = new System.Drawing.Point(733, 0);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(31, 32);
            this.button5.TabIndex = 15;
            this.button5.Text = "-";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(31, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Шифрование методом Эль Гамаля";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            // 
            // button6
            // 
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Dock = System.Windows.Forms.DockStyle.Right;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button6.Location = new System.Drawing.Point(764, 0);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(31, 32);
            this.button6.TabIndex = 14;
            this.button6.Text = "x";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 450);
            this.panel1.TabIndex = 18;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(795, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 408);
            this.panel4.TabIndex = 19;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 10);
            this.panel3.TabIndex = 20;
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(491, 386);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(170, 32);
            this.btn_save.TabIndex = 21;
            this.btn_save.Text = "Сохранить";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btn_open_file);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ina);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_zah);
            this.Controls.Add(this.btn_rah);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.inp);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.mess);
            this.Controls.Add(this.inx);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form2";
            this.Text = "Дешифрование";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form2_MouseDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inx;
        private System.Windows.Forms.TextBox mess;
        private System.Windows.Forms.TextBox inf;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox inp;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_rah;
        private System.Windows.Forms.Button btn_zah;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ina;
        private System.Windows.Forms.Button btn_open_file;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_save;
    }
}