namespace First_App
{
    partial class SecondForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondForm));
            label2 = new Label();
            label1 = new Label();
            btn_Login = new Button();
            txt_password = new TextBox();
            txt_username = new TextBox();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(139, 193);
            label2.Margin = new Padding(6, 0, 6, 0);
            label2.Name = "label2";
            label2.Size = new Size(82, 21);
            label2.TabIndex = 9;
            label2.Text = "Password";
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 70);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(87, 21);
            label1.TabIndex = 8;
            label1.Text = "Username";
            // 
            // btn_Login
            // 
            btn_Login.BackColor = Color.Peru;
            btn_Login.Cursor = Cursors.Hand;
            btn_Login.Dock = DockStyle.Bottom;
            btn_Login.FlatStyle = FlatStyle.Popup;
            btn_Login.Location = new Point(0, 366);
            btn_Login.Margin = new Padding(6);
            btn_Login.Name = "btn_Login";
            btn_Login.Size = new Size(729, 95);
            btn_Login.TabIndex = 7;
            btn_Login.Text = "Login";
            btn_Login.UseVisualStyleBackColor = false;
            btn_Login.Click += Login_Click;
            // 
            // txt_password
            // 
            txt_password.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_password.Location = new Point(269, 185);
            txt_password.Margin = new Padding(6);
            txt_password.Name = "txt_password";
            txt_password.Size = new Size(414, 29);
            txt_password.TabIndex = 6;
            // 
            // txt_username
            // 
            txt_username.Anchor = AnchorStyles.Left | AnchorStyles.Right;
            txt_username.Location = new Point(269, 62);
            txt_username.Margin = new Padding(6);
            txt_username.Name = "txt_username";
            txt_username.Size = new Size(414, 29);
            txt_username.TabIndex = 5;
            txt_username.TextChanged += txt_username_TextChanged;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.Location = new Point(370, 259);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(140, 25);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Remember Me";
            checkBox1.UseVisualStyleBackColor = true;
            // 
            // SecondForm
            // 
            AutoScaleDimensions = new SizeF(10F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(729, 461);
            Controls.Add(checkBox1);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btn_Login);
            Controls.Add(txt_password);
            Controls.Add(txt_username);
            Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            ForeColor = SystemColors.ControlLightLight;
            Margin = new Padding(4);
            Name = "SecondForm";
            RightToLeft = RightToLeft.No;
            Text = "Login";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private Button btn_Login;
        private TextBox txt_password;
        private TextBox txt_username;
        private CheckBox checkBox1;
    }
}