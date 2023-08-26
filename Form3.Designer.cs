namespace MyProgrammBlackList
{
    partial class Form3
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
            groupBox1 = new GroupBox();
            label3 = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
            checkedListBox1 = new CheckedListBox();
            groupBox2 = new GroupBox();
            btnChange = new Button();
            btnDelete = new Button();
            listBox1 = new ListBox();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(checkedListBox1);
            groupBox1.Location = new Point(12, 24);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(366, 535);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "System processes";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(262, 87);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 6;
            label3.Text = "min per day";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(123, 80);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(133, 27);
            textBox1.TabIndex = 5;
            textBox1.KeyPress += textBox1_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(19, 87);
            label2.Name = "label2";
            label2.Size = new Size(98, 20);
            label2.TabIndex = 4;
            label2.Text = "Allowed time";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 33);
            label1.Name = "label1";
            label1.Size = new Size(38, 20);
            label1.TabIndex = 3;
            label1.Text = "User";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(57, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(283, 28);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(102, 475);
            button1.Name = "button1";
            button1.Size = new Size(134, 46);
            button1.TabIndex = 1;
            button1.Text = "Add to list - >";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // checkedListBox1
            // 
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(13, 142);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(327, 312);
            checkedListBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnChange);
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(384, 33);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(530, 526);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Black list";
            // 
            // btnChange
            // 
            btnChange.Location = new Point(53, 470);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(142, 38);
            btnChange.TabIndex = 2;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(301, 470);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(142, 38);
            btnDelete.TabIndex = 1;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(21, 29);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(487, 424);
            listBox1.TabIndex = 0;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSeaGreen;
            ClientSize = new Size(929, 569);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form3";
            Text = "Administrator panel";
            Load += Form3_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Button button1;
        private CheckedListBox checkedListBox1;
        private TextBox textBox1;
        private Label label2;
        private Label label1;
        private ComboBox comboBox1;
        private Label label3;
        private GroupBox groupBox2;
        private Button btnChange;
        private Button btnDelete;
        private ListBox listBox1;
    }
}