namespace First_App
{
    partial class Calculator
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
            label1 = new Label();
            menuStrip1 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            saveToolStripMenuItem = new ToolStripMenuItem();
            saveAsToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            openToolStripMenuItem = new ToolStripMenuItem();
            openRecentToolStripMenuItem = new ToolStripMenuItem();
            openLastToolStripMenuItem = new ToolStripMenuItem();
            openFirstToolStripMenuItem = new ToolStripMenuItem();
            editToolStripMenuItem = new ToolStripMenuItem();
            changeColorToolStripMenuItem = new ToolStripMenuItem();
            helpToolStripMenuItem = new ToolStripMenuItem();
            fbd_open = new FolderBrowserDialog();
            cd_color = new ColorDialog();
            btn_1 = new Button();
            btn_2 = new Button();
            btn_minus = new Button();
            btn_3 = new Button();
            btn_plus = new Button();
            btn_equal = new Button();
            btn_mul = new Button();
            rtb_results = new RichTextBox();
            btn_clear = new Button();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(188, 40);
            label1.Name = "label1";
            label1.Size = new Size(148, 37);
            label1.TabIndex = 0;
            label1.Text = "Calculator";
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, editToolStripMenuItem, helpToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(564, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newToolStripMenuItem, toolStripSeparator2, saveToolStripMenuItem, saveAsToolStripMenuItem, toolStripSeparator1, openToolStripMenuItem, openRecentToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(142, 22);
            newToolStripMenuItem.Text = "New";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(139, 6);
            // 
            // saveToolStripMenuItem
            // 
            saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            saveToolStripMenuItem.Size = new Size(142, 22);
            saveToolStripMenuItem.Text = "Save";
            saveToolStripMenuItem.Click += saveToolStripMenuItem_Click;
            // 
            // saveAsToolStripMenuItem
            // 
            saveAsToolStripMenuItem.Name = "saveAsToolStripMenuItem";
            saveAsToolStripMenuItem.Size = new Size(142, 22);
            saveAsToolStripMenuItem.Text = "Save As";
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(139, 6);
            // 
            // openToolStripMenuItem
            // 
            openToolStripMenuItem.Name = "openToolStripMenuItem";
            openToolStripMenuItem.Size = new Size(142, 22);
            openToolStripMenuItem.Text = "Open";
            openToolStripMenuItem.Click += openToolStripMenuItem_Click;
            // 
            // openRecentToolStripMenuItem
            // 
            openRecentToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openLastToolStripMenuItem, openFirstToolStripMenuItem });
            openRecentToolStripMenuItem.Name = "openRecentToolStripMenuItem";
            openRecentToolStripMenuItem.Size = new Size(142, 22);
            openRecentToolStripMenuItem.Text = "Open Recent";
            // 
            // openLastToolStripMenuItem
            // 
            openLastToolStripMenuItem.Name = "openLastToolStripMenuItem";
            openLastToolStripMenuItem.Size = new Size(128, 22);
            openLastToolStripMenuItem.Text = "Open last";
            openLastToolStripMenuItem.Click += openLastToolStripMenuItem_Click;
            // 
            // openFirstToolStripMenuItem
            // 
            openFirstToolStripMenuItem.Name = "openFirstToolStripMenuItem";
            openFirstToolStripMenuItem.Size = new Size(128, 22);
            openFirstToolStripMenuItem.Text = "Open First";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { changeColorToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // changeColorToolStripMenuItem
            // 
            changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            changeColorToolStripMenuItem.Size = new Size(147, 22);
            changeColorToolStripMenuItem.Text = "Change Color";
            changeColorToolStripMenuItem.Click += changeColorToolStripMenuItem_Click;
            // 
            // helpToolStripMenuItem
            // 
            helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            helpToolStripMenuItem.Size = new Size(44, 20);
            helpToolStripMenuItem.Text = "Help";
            // 
            // btn_1
            // 
            btn_1.Location = new Point(26, 173);
            btn_1.Name = "btn_1";
            btn_1.Size = new Size(67, 60);
            btn_1.TabIndex = 2;
            btn_1.Text = "1";
            btn_1.UseVisualStyleBackColor = true;
            btn_1.Click += btn_number_Click;
            // 
            // btn_2
            // 
            btn_2.Location = new Point(169, 173);
            btn_2.Name = "btn_2";
            btn_2.Size = new Size(67, 60);
            btn_2.TabIndex = 3;
            btn_2.Text = "2";
            btn_2.UseVisualStyleBackColor = true;
            btn_2.Click += btn_number_Click;
            // 
            // btn_minus
            // 
            btn_minus.Location = new Point(463, 239);
            btn_minus.Name = "btn_minus";
            btn_minus.Size = new Size(67, 60);
            btn_minus.TabIndex = 4;
            btn_minus.Text = "-";
            btn_minus.UseVisualStyleBackColor = true;
            btn_minus.Click += btn_operation_Click;
            // 
            // btn_3
            // 
            btn_3.Location = new Point(299, 173);
            btn_3.Name = "btn_3";
            btn_3.Size = new Size(67, 60);
            btn_3.TabIndex = 4;
            btn_3.Text = "3";
            btn_3.UseVisualStyleBackColor = true;
            btn_3.Click += btn_number_Click;
            // 
            // btn_plus
            // 
            btn_plus.Location = new Point(463, 173);
            btn_plus.Name = "btn_plus";
            btn_plus.Size = new Size(67, 60);
            btn_plus.TabIndex = 5;
            btn_plus.Text = "+";
            btn_plus.UseVisualStyleBackColor = true;
            btn_plus.Click += btn_operation_Click;
            // 
            // btn_equal
            // 
            btn_equal.Location = new Point(169, 305);
            btn_equal.Name = "btn_equal";
            btn_equal.Size = new Size(67, 60);
            btn_equal.TabIndex = 6;
            btn_equal.Text = "=";
            btn_equal.UseVisualStyleBackColor = true;
            btn_equal.Click += btn_equal_Click;
            // 
            // btn_mul
            // 
            btn_mul.Location = new Point(463, 305);
            btn_mul.Name = "btn_mul";
            btn_mul.Size = new Size(67, 60);
            btn_mul.TabIndex = 7;
            btn_mul.Text = "*";
            btn_mul.UseVisualStyleBackColor = true;
            btn_mul.Click += btn_operation_Click;
            // 
            // rtb_results
            // 
            rtb_results.Location = new Point(28, 80);
            rtb_results.Name = "rtb_results";
            rtb_results.ReadOnly = true;
            rtb_results.Size = new Size(504, 87);
            rtb_results.TabIndex = 8;
            rtb_results.Text = "";
            // 
            // btn_clear
            // 
            btn_clear.Location = new Point(299, 305);
            btn_clear.Name = "btn_clear";
            btn_clear.Size = new Size(67, 60);
            btn_clear.TabIndex = 9;
            btn_clear.Text = "CE";
            btn_clear.UseVisualStyleBackColor = true;
            btn_clear.Click += btn_clear_Click;
            // 
            // Calculator
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            ClientSize = new Size(564, 380);
            Controls.Add(btn_clear);
            Controls.Add(rtb_results);
            Controls.Add(btn_mul);
            Controls.Add(btn_equal);
            Controls.Add(btn_plus);
            Controls.Add(btn_3);
            Controls.Add(btn_minus);
            Controls.Add(btn_2);
            Controls.Add(btn_1);
            Controls.Add(label1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Calculator";
            Text = "Calculator";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem saveToolStripMenuItem;
        private ToolStripMenuItem saveAsToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem openToolStripMenuItem;
        private ToolStripMenuItem openRecentToolStripMenuItem;
        private ToolStripMenuItem openLastToolStripMenuItem;
        private ToolStripMenuItem openFirstToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private ToolStripMenuItem helpToolStripMenuItem;
        private FolderBrowserDialog fbd_open;
        private ToolStripMenuItem changeColorToolStripMenuItem;
        private ColorDialog cd_color;
        private Button btn_1;
        private Button btn_2;
        private Button btn_minus;
        private Button btn_3;
        private Button btn_plus;
        private Button btn_equal;
        private Button btn_mul;
        private RichTextBox rtb_results;
        private Button btn_clear;
    }
}