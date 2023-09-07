namespace First_App
{
    partial class Test_Tools
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Test_Tools));
            ckb_reading = new CheckBox();
            ckb_football = new CheckBox();
            btn_start = new Button();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            listBox1 = new ListBox();
            progressBar1 = new ProgressBar();
            rbtn_female = new RadioButton();
            rbtn_male_p1 = new RadioButton();
            groupBox1 = new GroupBox();
            radioButton1 = new RadioButton();
            rbtn_male_p2 = new RadioButton();
            groupBox2 = new GroupBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // ckb_reading
            // 
            ckb_reading.AutoSize = true;
            ckb_reading.Location = new Point(59, 87);
            ckb_reading.Name = "ckb_reading";
            ckb_reading.Size = new Size(69, 19);
            ckb_reading.TabIndex = 0;
            ckb_reading.Text = "Reading";
            ckb_reading.UseVisualStyleBackColor = true;
            // 
            // ckb_football
            // 
            ckb_football.AutoSize = true;
            ckb_football.Location = new Point(59, 125);
            ckb_football.Name = "ckb_football";
            ckb_football.Size = new Size(69, 19);
            ckb_football.TabIndex = 1;
            ckb_football.Text = "Football";
            ckb_football.UseVisualStyleBackColor = true;
            // 
            // btn_start
            // 
            btn_start.Location = new Point(337, 402);
            btn_start.Name = "btn_start";
            btn_start.Size = new Size(75, 23);
            btn_start.TabIndex = 10;
            btn_start.Text = "start game";
            btn_start.UseVisualStyleBackColor = true;
            btn_start.Click += btn_start_Click;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(201, 51);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 12;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Cairo", "Giza", "Alex" });
            comboBox1.Location = new Point(451, 62);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 13;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "item 1", "item 2", "item 3" });
            listBox1.Location = new Point(609, 31);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 94);
            listBox1.TabIndex = 14;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(371, 356);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(283, 23);
            progressBar1.TabIndex = 16;
            progressBar1.Value = 90;
            // 
            // rbtn_female
            // 
            rbtn_female.AutoSize = true;
            rbtn_female.Location = new Point(62, 62);
            rbtn_female.Name = "rbtn_female";
            rbtn_female.Size = new Size(61, 19);
            rbtn_female.TabIndex = 3;
            rbtn_female.TabStop = true;
            rbtn_female.Text = "female";
            rbtn_female.UseVisualStyleBackColor = true;
            // 
            // rbtn_male_p1
            // 
            rbtn_male_p1.AutoSize = true;
            rbtn_male_p1.Location = new Point(62, 22);
            rbtn_male_p1.Name = "rbtn_male_p1";
            rbtn_male_p1.Size = new Size(51, 19);
            rbtn_male_p1.TabIndex = 2;
            rbtn_male_p1.TabStop = true;
            rbtn_male_p1.Text = "male";
            rbtn_male_p1.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(rbtn_male_p1);
            groupBox1.Controls.Add(rbtn_female);
            groupBox1.Location = new Point(168, 201);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(200, 100);
            groupBox1.TabIndex = 8;
            groupBox1.TabStop = false;
            groupBox1.Text = "player 1";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(64, 62);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(61, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "female";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // rbtn_male_p2
            // 
            rbtn_male_p2.AutoSize = true;
            rbtn_male_p2.Location = new Point(64, 22);
            rbtn_male_p2.Name = "rbtn_male_p2";
            rbtn_male_p2.Size = new Size(51, 19);
            rbtn_male_p2.TabIndex = 4;
            rbtn_male_p2.TabStop = true;
            rbtn_male_p2.Text = "male";
            rbtn_male_p2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(rbtn_male_p2);
            groupBox2.Controls.Add(radioButton1);
            groupBox2.Location = new Point(429, 201);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(200, 100);
            groupBox2.TabIndex = 9;
            groupBox2.TabStop = false;
            groupBox2.Text = "player 2";
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(28, 241);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(263, 164);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 15;
            pictureBox1.TabStop = false;
            // 
            // Test_Tools
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(progressBar1);
            Controls.Add(pictureBox1);
            Controls.Add(listBox1);
            Controls.Add(comboBox1);
            Controls.Add(numericUpDown1);
            Controls.Add(btn_start);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(ckb_football);
            Controls.Add(ckb_reading);
            Name = "Test_Tools";
            Text = "Test_Tools";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox ckb_reading;
        private CheckBox ckb_football;
        private Button btn_start;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private ListBox listBox1;
        private ProgressBar progressBar1;
        private RadioButton rbtn_female;
        private RadioButton rbtn_male_p1;
        private GroupBox groupBox1;
        private RadioButton radioButton1;
        private RadioButton rbtn_male_p2;
        private GroupBox groupBox2;
        private PictureBox pictureBox1;
    }
}