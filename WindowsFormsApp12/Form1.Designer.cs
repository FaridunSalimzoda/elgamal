namespace WindowsFormsApp1
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_sv = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.inf = new System.Windows.Forms.TextBox();
            this.inm = new System.Windows.Forms.TextBox();
            this.btn_zah = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_rah = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_open = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.btn_sv);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.btn_exit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(5, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(795, 32);
            this.panel2.TabIndex = 19;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown_1);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(23, 4);
            this.pictureBox1.MinimumSize = new System.Drawing.Size(15, 15);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(22, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btn_sv
            // 
            this.btn_sv.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_sv.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_sv.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_sv.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_sv.Location = new System.Drawing.Point(733, 0);
            this.btn_sv.Name = "btn_sv";
            this.btn_sv.Size = new System.Drawing.Size(31, 32);
            this.btn_sv.TabIndex = 15;
            this.btn_sv.Text = "-";
            this.btn_sv.UseVisualStyleBackColor = true;
            this.btn_sv.Click += new System.EventHandler(this.button5_Click);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(61, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(193, 23);
            this.label6.TabIndex = 13;
            this.label6.Text = "Шифрование методом Эль Гамаля";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label6.MouseDown += new System.Windows.Forms.MouseEventHandler(this.label6_MouseDown);
            // 
            // btn_exit
            // 
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_exit.Location = new System.Drawing.Point(764, 0);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(31, 32);
            this.btn_exit.TabIndex = 14;
            this.btn_exit.Text = "x";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.button6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 450);
            this.panel1.TabIndex = 20;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel4.Location = new System.Drawing.Point(795, 32);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(5, 408);
            this.panel4.TabIndex = 21;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Highlight;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(5, 440);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(795, 10);
            this.panel3.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(520, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 24);
            this.label3.TabIndex = 26;
            this.label3.Text = "Информация";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(24, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(360, 24);
            this.label2.TabIndex = 25;
            this.label2.Text = "Введите сообщение для зашифровки";
            // 
            // inf
            // 
            this.inf.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inf.Location = new System.Drawing.Point(439, 107);
            this.inf.Multiline = true;
            this.inf.Name = "inf";
            this.inf.Size = new System.Drawing.Size(309, 176);
            this.inf.TabIndex = 24;
            this.inf.TextChanged += new System.EventHandler(this.inf_TextChanged);
            this.inf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.inf_KeyPress);
            // 
            // inm
            // 
            this.inm.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.inm.Location = new System.Drawing.Point(41, 107);
            this.inm.Multiline = true;
            this.inm.Name = "inm";
            this.inm.Size = new System.Drawing.Size(309, 176);
            this.inm.TabIndex = 23;
            this.inm.TextChanged += new System.EventHandler(this.inm_TextChanged);
            // 
            // btn_zah
            // 
            this.btn_zah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_zah.Location = new System.Drawing.Point(69, 325);
            this.btn_zah.Name = "btn_zah";
            this.btn_zah.Size = new System.Drawing.Size(177, 30);
            this.btn_zah.TabIndex = 27;
            this.btn_zah.Text = "Зашифровать";
            this.btn_zah.UseVisualStyleBackColor = true;
            this.btn_zah.Click += new System.EventHandler(this.btn_zah_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_clear.Location = new System.Drawing.Point(505, 325);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(177, 30);
            this.btn_clear.TabIndex = 28;
            this.btn_clear.Text = "Отчистить все";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_rah
            // 
            this.btn_rah.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_rah.Location = new System.Drawing.Point(69, 370);
            this.btn_rah.Name = "btn_rah";
            this.btn_rah.Size = new System.Drawing.Size(177, 30);
            this.btn_rah.TabIndex = 29;
            this.btn_rah.Text = "Рашифровать";
            this.btn_rah.UseVisualStyleBackColor = true;
            this.btn_rah.Click += new System.EventHandler(this.btn_rah_Click);
            // 
            // btn_save
            // 
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_save.Location = new System.Drawing.Point(505, 370);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(177, 30);
            this.btn_save.TabIndex = 30;
            this.btn_save.Text = "Сохранить ключи";
            this.btn_save.UseVisualStyleBackColor = true;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_open
            // 
            this.btn_open.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btn_open.Location = new System.Drawing.Point(294, 325);
            this.btn_open.Name = "btn_open";
            this.btn_open.Size = new System.Drawing.Size(177, 75);
            this.btn_open.TabIndex = 31;
            this.btn_open.Text = "Открыть сообщение для шифрования";
            this.btn_open.UseVisualStyleBackColor = true;
            this.btn_open.Click += new System.EventHandler(this.btn_open_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_open);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_rah);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn_zah);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.inf);
            this.Controls.Add(this.inm);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_sv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox inf;
        private System.Windows.Forms.TextBox inm;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_zah;
        public System.Windows.Forms.Button btn_clear;
        public System.Windows.Forms.Button btn_rah;
        public System.Windows.Forms.Button btn_save;
        public System.Windows.Forms.Button btn_open;
    }
}