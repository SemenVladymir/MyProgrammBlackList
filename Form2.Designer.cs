namespace MyProgrammBlackList
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
            groupBox1 = new GroupBox();
            label8 = new Label();
            label7 = new Label();
            dateTimePicker2 = new DateTimePicker();
            dateTimePicker1 = new DateTimePicker();
            label5 = new Label();
            label6 = new Label();
            textBox4 = new TextBox();
            label4 = new Label();
            textBox3 = new TextBox();
            btnAdd = new Button();
            label3 = new Label();
            textBox2 = new TextBox();
            label2 = new Label();
            textBox1 = new TextBox();
            label1 = new Label();
            groupBox2 = new GroupBox();
            btnDelete = new Button();
            btnChange = new Button();
            listBox1 = new ListBox();
            button1 = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label7);
            groupBox1.Controls.Add(dateTimePicker2);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(textBox4);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(btnAdd);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label1);
            groupBox1.Location = new Point(12, 22);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(673, 227);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Adding app to black list";
            // 
            // label8
            // 
            label8.BorderStyle = BorderStyle.Fixed3D;
            label8.Location = new Point(10, 124);
            label8.Name = "label8";
            label8.Size = new Size(646, 2);
            label8.TabIndex = 15;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(497, 147);
            label7.Name = "label7";
            label7.Size = new Size(102, 20);
            label7.TabIndex = 14;
            label7.Text = "Input keycode";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Time;
            dateTimePicker2.Location = new Point(295, 184);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(107, 27);
            dateTimePicker2.TabIndex = 13;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Time;
            dateTimePicker1.Location = new Point(95, 184);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(107, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(221, 189);
            label5.Name = "label5";
            label5.Size = new Size(68, 20);
            label5.TabIndex = 11;
            label5.Text = "End time";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(10, 189);
            label6.Name = "label6";
            label6.Size = new Size(74, 20);
            label6.TabIndex = 9;
            label6.Text = "Start time";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(95, 140);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(278, 27);
            textBox4.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 142);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 7;
            label4.Text = "User name";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(471, 173);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(162, 27);
            textBox3.TabIndex = 6;
            textBox3.KeyDown += textBox3_KeyDown;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(501, 54);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(132, 39);
            btnAdd.TabIndex = 5;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 83);
            label3.Name = "label3";
            label3.Size = new Size(88, 20);
            label3.TabIndex = 4;
            label3.Text = "min per day";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(154, 80);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(99, 27);
            textBox2.TabIndex = 3;
            textBox2.KeyPress += textBox2_KeyPress;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 80);
            label2.Name = "label2";
            label2.Size = new Size(134, 20);
            label2.TabIndex = 2;
            label2.Text = "Allowed work time";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(97, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(309, 27);
            textBox1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 32);
            label1.Name = "label1";
            label1.Size = new Size(78, 20);
            label1.TabIndex = 0;
            label1.Text = "App name";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnDelete);
            groupBox2.Controls.Add(btnChange);
            groupBox2.Controls.Add(listBox1);
            groupBox2.Location = new Point(12, 255);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(673, 183);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "My app black list";
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(501, 114);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(132, 39);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnChange
            // 
            btnChange.Location = new Point(501, 42);
            btnChange.Name = "btnChange";
            btnChange.Size = new Size(132, 39);
            btnChange.TabIndex = 6;
            btnChange.Text = "Change";
            btnChange.UseVisualStyleBackColor = true;
            btnChange.Click += BtnChange_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.HorizontalScrollbar = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(14, 26);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(444, 144);
            listBox1.TabIndex = 0;
            listBox1.SelectedIndexChanged += ListBox1_SelectedIndexChanged;
            // 
            // button1
            // 
            button1.BackColor = Color.CadetBlue;
            button1.Location = new Point(282, 444);
            button1.Name = "button1";
            button1.Size = new Size(132, 31);
            button1.TabIndex = 8;
            button1.Text = "Hide";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightSteelBlue;
            ClientSize = new Size(701, 479);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form2";
            Text = "My black list";
            Load += Form2_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private GroupBox groupBox1;
        private TextBox textBox1;
        private Label label1;
        private Button btnAdd;
        private Label label3;
        private TextBox textBox2;
        private Label label2;
        private GroupBox groupBox2;
        private Button btnDelete;
        private Button btnChange;
        private ListBox listBox1;
        private Label label5;
        private Label label6;
        private TextBox textBox4;
        private Label label4;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker2;
        private DateTimePicker dateTimePicker1;
        private Label label7;
        private Label label8;
        private Button button1;
    }
}