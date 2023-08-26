namespace MyProgrammBlackList
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnEnter = new Button();
            Password = new TextBox();
            Login = new TextBox();
            label3 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // btnEnter
            // 
            btnEnter.Location = new Point(110, 133);
            btnEnter.Name = "btnEnter";
            btnEnter.Size = new Size(117, 29);
            btnEnter.TabIndex = 16;
            btnEnter.Text = "Enter";
            btnEnter.UseVisualStyleBackColor = true;
            btnEnter.Click += btnEnter_Click;
            // 
            // Password
            // 
            Password.Location = new Point(96, 80);
            Password.Name = "Password";
            Password.PasswordChar = '*';
            Password.Size = new Size(162, 27);
            Password.TabIndex = 14;
            // 
            // Login
            // 
            Login.Location = new Point(96, 39);
            Login.Name = "Login";
            Login.Size = new Size(162, 27);
            Login.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 80);
            label3.Name = "label3";
            label3.Size = new Size(70, 20);
            label3.TabIndex = 12;
            label3.Text = "Password";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 41);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 11;
            label2.Text = "Login";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(339, 217);
            Controls.Add(btnEnter);
            Controls.Add(Password);
            Controls.Add(Login);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "Form1";
            Text = "My programms black list";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEnter;
        private TextBox Password;
        private TextBox Login;
        private Label label3;
        private Label label2;
    }
}