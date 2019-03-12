namespace WindowsFormsApplication1
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
            this.editboxInputString = new System.Windows.Forms.TextBox();
            this.btnAllCaps = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.editboxOutputString = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button3 = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.button6 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.listBox3 = new System.Windows.Forms.ListBox();
            this.listBox4 = new System.Windows.Forms.ListBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Array2 = new System.Windows.Forms.RadioButton();
            this.Array1 = new System.Windows.Forms.RadioButton();
            this.listBox5 = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.points = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.distance = new System.Windows.Forms.TextBox();
            this.GetandSay = new System.Windows.Forms.Button();
            this.LinkedList = new System.Windows.Forms.ListBox();
            this.AddNode = new System.Windows.Forms.Button();
            this.DeleteNode = new System.Windows.Forms.Button();
            this.NodeValue = new System.Windows.Forms.TextBox();
            this.NodeNumber = new System.Windows.Forms.TextBox();
            this.NodeLabel = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button11 = new System.Windows.Forms.Button();
            this.label14 = new System.Windows.Forms.Label();
            this.threadback = new System.ComponentModel.BackgroundWorker();
            this.startThreadBack = new System.Windows.Forms.Button();
            this.cancelThreadBack = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnClearField = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.Freespace = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // editboxInputString
            // 
            this.editboxInputString.Location = new System.Drawing.Point(138, 20);
            this.editboxInputString.Multiline = true;
            this.editboxInputString.Name = "editboxInputString";
            this.editboxInputString.Size = new System.Drawing.Size(127, 52);
            this.editboxInputString.TabIndex = 0;
            this.editboxInputString.TextChanged += new System.EventHandler(this.editboxInputString_TextChanged);
            // 
            // btnAllCaps
            // 
            this.btnAllCaps.Location = new System.Drawing.Point(24, 20);
            this.btnAllCaps.Name = "btnAllCaps";
            this.btnAllCaps.Size = new System.Drawing.Size(99, 23);
            this.btnAllCaps.TabIndex = 1;
            this.btnAllCaps.Text = "Reverse a String";
            this.btnAllCaps.UseVisualStyleBackColor = true;
            this.btnAllCaps.Click += new System.EventHandler(this.btnReverseAString_Click);
            this.btnAllCaps.MouseHover += new System.EventHandler(this.btnReverseAString_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(162, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Input String";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // editboxOutputString
            // 
            this.editboxOutputString.Location = new System.Drawing.Point(291, 20);
            this.editboxOutputString.Multiline = true;
            this.editboxOutputString.Name = "editboxOutputString";
            this.editboxOutputString.ReadOnly = true;
            this.editboxOutputString.Size = new System.Drawing.Size(132, 51);
            this.editboxOutputString.TabIndex = 3;
            this.editboxOutputString.TextChanged += new System.EventHandler(this.editboxOutputString_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(325, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Output String";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(319, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Say Text";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(38, 84);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 6;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(554, 18);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Say All";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(656, 14);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(159, 95);
            this.listBox1.TabIndex = 8;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(554, 47);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "Clear List";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(656, 180);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(189, 147);
            this.listBox2.TabIndex = 11;
            this.listBox2.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 26);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 17);
            this.radioButton1.TabIndex = 12;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "English";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(15, 49);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(63, 17);
            this.radioButton2.TabIndex = 13;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Spanish";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(15, 72);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(62, 17);
            this.radioButton3.TabIndex = 14;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "German";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton3);
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(539, 212);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(90, 112);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(307, 156);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 23);
            this.button5.TabIndex = 16;
            this.button5.Text = "Factorial";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(291, 212);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(112, 20);
            this.textBox2.TabIndex = 18;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.BeepOnError = true;
            this.maskedTextBox1.Location = new System.Drawing.Point(291, 186);
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(112, 20);
            this.maskedTextBox1.TabIndex = 19;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(539, 180);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(99, 23);
            this.button6.TabIndex = 20;
            this.button6.Text = "Find Palendroms";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(664, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Total Word Count = ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(667, 161);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Palendrom Count = ";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(761, 161);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 13);
            this.label5.TabIndex = 23;
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(761, 148);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 24;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(670, 132);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Big Word Count =";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(758, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "label8";
            // 
            // listBox3
            // 
            this.listBox3.FormattingEnabled = true;
            this.listBox3.Location = new System.Drawing.Point(45, 268);
            this.listBox3.Name = "listBox3";
            this.listBox3.Size = new System.Drawing.Size(93, 134);
            this.listBox3.TabIndex = 27;
            this.listBox3.SelectedIndexChanged += new System.EventHandler(this.listBox3_SelectedIndexChanged);
            // 
            // listBox4
            // 
            this.listBox4.FormattingEnabled = true;
            this.listBox4.Location = new System.Drawing.Point(166, 268);
            this.listBox4.Name = "listBox4";
            this.listBox4.Size = new System.Drawing.Size(99, 134);
            this.listBox4.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(57, 254);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 29;
            this.label9.Text = "Array 1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(176, 254);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(37, 13);
            this.label10.TabIndex = 30;
            this.label10.Text = "Array2";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(291, 272);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(103, 26);
            this.button4.TabIndex = 31;
            this.button4.Text = "Sort Arrays";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click_1);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(291, 306);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(102, 21);
            this.button7.TabIndex = 32;
            this.button7.Text = "Merge Sort Arrays";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Array2);
            this.groupBox2.Controls.Add(this.Array1);
            this.groupBox2.Location = new System.Drawing.Point(292, 337);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(90, 66);
            this.groupBox2.TabIndex = 33;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Sort Array";
            // 
            // Array2
            // 
            this.Array2.AutoSize = true;
            this.Array2.Location = new System.Drawing.Point(15, 39);
            this.Array2.Name = "Array2";
            this.Array2.Size = new System.Drawing.Size(58, 17);
            this.Array2.TabIndex = 1;
            this.Array2.TabStop = true;
            this.Array2.Text = "Array 2";
            this.Array2.UseVisualStyleBackColor = true;
            // 
            // Array1
            // 
            this.Array1.AutoSize = true;
            this.Array1.Location = new System.Drawing.Point(15, 19);
            this.Array1.Name = "Array1";
            this.Array1.Size = new System.Drawing.Size(58, 17);
            this.Array1.TabIndex = 0;
            this.Array1.TabStop = true;
            this.Array1.Text = "Array 1";
            this.Array1.UseVisualStyleBackColor = true;
            // 
            // listBox5
            // 
            this.listBox5.FormattingEnabled = true;
            this.listBox5.Location = new System.Drawing.Point(414, 272);
            this.listBox5.Name = "listBox5";
            this.listBox5.Size = new System.Drawing.Size(87, 121);
            this.listBox5.TabIndex = 34;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(422, 254);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 35;
            this.label11.Text = "Merged Array";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(539, 350);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(90, 23);
            this.button8.TabIndex = 38;
            this.button8.Text = "Girls Rule";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(292, 239);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(101, 23);
            this.button9.TabIndex = 39;
            this.button9.Text = "Clear Merged";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(441, 77);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(135, 22);
            this.button10.TabIndex = 40;
            this.button10.Text = "Distance between Points";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click_1);
            // 
            // points
            // 
            this.points.Location = new System.Drawing.Point(441, 105);
            this.points.Name = "points";
            this.points.Size = new System.Drawing.Size(135, 20);
            this.points.TabIndex = 41;
            this.points.TextChanged += new System.EventHandler(this.points_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(452, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(103, 13);
            this.label12.TabIndex = 42;
            this.label12.Text = "x1, x2, y1, y2, z1, z2";
            // 
            // distance
            // 
            this.distance.Location = new System.Drawing.Point(441, 154);
            this.distance.Name = "distance";
            this.distance.Size = new System.Drawing.Size(135, 20);
            this.distance.TabIndex = 43;
            this.distance.TextChanged += new System.EventHandler(this.distance_TextChanged);
            // 
            // GetandSay
            // 
            this.GetandSay.Location = new System.Drawing.Point(293, 113);
            this.GetandSay.Name = "GetandSay";
            this.GetandSay.Size = new System.Drawing.Size(129, 32);
            this.GetandSay.TabIndex = 44;
            this.GetandSay.Text = "Get and Say Text";
            this.GetandSay.UseVisualStyleBackColor = true;
            this.GetandSay.Click += new System.EventHandler(this.GetandSay_Click);
            // 
            // LinkedList
            // 
            this.LinkedList.FormattingEnabled = true;
            this.LinkedList.Location = new System.Drawing.Point(899, 180);
            this.LinkedList.Name = "LinkedList";
            this.LinkedList.Size = new System.Drawing.Size(120, 212);
            this.LinkedList.TabIndex = 45;
            // 
            // AddNode
            // 
            this.AddNode.Location = new System.Drawing.Point(901, 70);
            this.AddNode.Name = "AddNode";
            this.AddNode.Size = new System.Drawing.Size(75, 24);
            this.AddNode.TabIndex = 46;
            this.AddNode.Text = "Add Node";
            this.AddNode.UseVisualStyleBackColor = true;
            this.AddNode.Click += new System.EventHandler(this.AddNode_Click);
            // 
            // DeleteNode
            // 
            this.DeleteNode.Location = new System.Drawing.Point(901, 100);
            this.DeleteNode.Name = "DeleteNode";
            this.DeleteNode.Size = new System.Drawing.Size(75, 23);
            this.DeleteNode.TabIndex = 47;
            this.DeleteNode.Text = "Delete Node";
            this.DeleteNode.UseVisualStyleBackColor = true;
            this.DeleteNode.Click += new System.EventHandler(this.DeleteNode_Click);
            // 
            // NodeValue
            // 
            this.NodeValue.Location = new System.Drawing.Point(899, 154);
            this.NodeValue.Name = "NodeValue";
            this.NodeValue.Size = new System.Drawing.Size(77, 20);
            this.NodeValue.TabIndex = 48;
            // 
            // NodeNumber
            // 
            this.NodeNumber.Location = new System.Drawing.Point(899, 129);
            this.NodeNumber.Name = "NodeNumber";
            this.NodeNumber.Size = new System.Drawing.Size(77, 20);
            this.NodeNumber.TabIndex = 49;
            // 
            // NodeLabel
            // 
            this.NodeLabel.AutoSize = true;
            this.NodeLabel.Location = new System.Drawing.Point(977, 131);
            this.NodeLabel.Name = "NodeLabel";
            this.NodeLabel.Size = new System.Drawing.Size(73, 13);
            this.NodeLabel.TabIndex = 50;
            this.NodeLabel.Text = "Node Number";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(977, 161);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(63, 13);
            this.label13.TabIndex = 51;
            this.label13.Text = "Node Value";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(821, 14);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(75, 23);
            this.button11.TabIndex = 52;
            this.button11.Text = "225/101010";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(827, 40);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(223, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "                                                                        ";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // threadback
            // 
            this.threadback.DoWork += new System.ComponentModel.DoWorkEventHandler(this.threadback_DoWork);
            // 
            // startThreadBack
            // 
            this.startThreadBack.Location = new System.Drawing.Point(902, 14);
            this.startThreadBack.Name = "startThreadBack";
            this.startThreadBack.Size = new System.Drawing.Size(75, 23);
            this.startThreadBack.TabIndex = 54;
            this.startThreadBack.Text = "Start";
            this.startThreadBack.UseVisualStyleBackColor = true;
            this.startThreadBack.Click += new System.EventHandler(this.startThreadBack_Click);
            // 
            // cancelThreadBack
            // 
            this.cancelThreadBack.Location = new System.Drawing.Point(983, 14);
            this.cancelThreadBack.Name = "cancelThreadBack";
            this.cancelThreadBack.Size = new System.Drawing.Size(75, 23);
            this.cancelThreadBack.TabIndex = 55;
            this.cancelThreadBack.Text = "Cancel";
            this.cancelThreadBack.UseVisualStyleBackColor = true;
            this.cancelThreadBack.Click += new System.EventHandler(this.cancelThreadBack_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(539, 395);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(90, 20);
            this.button12.TabIndex = 56;
            this.button12.Text = "Clear Reversal";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(656, 337);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(178, 43);
            this.richTextBox1.TabIndex = 57;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(656, 386);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(178, 44);
            this.richTextBox2.TabIndex = 58;
            this.richTextBox2.Text = "";
            // 
            // btnClearField
            // 
            this.btnClearField.Location = new System.Drawing.Point(24, 50);
            this.btnClearField.Name = "btnClearField";
            this.btnClearField.Size = new System.Drawing.Size(99, 23);
            this.btnClearField.TabIndex = 59;
            this.btnClearField.Text = "Clear field";
            this.btnClearField.UseVisualStyleBackColor = true;
            this.btnClearField.Click += new System.EventHandler(this.btnClearField_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(927, 407);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(75, 23);
            this.button13.TabIndex = 60;
            this.button13.Text = "Close";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(166, 414);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(119, 23);
            this.button14.TabIndex = 61;
            this.button14.Text = "Free space";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // Freespace
            // 
            this.Freespace.Location = new System.Drawing.Point(319, 416);
            this.Freespace.Name = "Freespace";
            this.Freespace.Size = new System.Drawing.Size(125, 20);
            this.Freespace.TabIndex = 62;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1101, 449);
            this.Controls.Add(this.Freespace);
            this.Controls.Add(this.button14);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.btnClearField);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.cancelThreadBack);
            this.Controls.Add(this.startThreadBack);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.NodeLabel);
            this.Controls.Add(this.NodeNumber);
            this.Controls.Add(this.NodeValue);
            this.Controls.Add(this.DeleteNode);
            this.Controls.Add(this.AddNode);
            this.Controls.Add(this.LinkedList);
            this.Controls.Add(this.GetandSay);
            this.Controls.Add(this.distance);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.points);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.listBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.listBox4);
            this.Controls.Add(this.listBox3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.editboxOutputString);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAllCaps);
            this.Controls.Add(this.editboxInputString);
            this.ForeColor = System.Drawing.Color.Red;
            this.Name = "Form1";
            this.Text = "Form1";
            this.TransparencyKey = System.Drawing.Color.Blue;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox editboxInputString;
        private System.Windows.Forms.Button btnAllCaps;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox editboxOutputString;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox listBox3;
        private System.Windows.Forms.ListBox listBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton Array2;
        private System.Windows.Forms.RadioButton Array1;
        private System.Windows.Forms.ListBox listBox5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox points;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox distance;
        private System.Windows.Forms.Button GetandSay;
        private System.Windows.Forms.ListBox LinkedList;
        private System.Windows.Forms.Button AddNode;
        private System.Windows.Forms.Button DeleteNode;
        private System.Windows.Forms.TextBox NodeValue;
        private System.Windows.Forms.TextBox NodeNumber;
        private System.Windows.Forms.Label NodeLabel;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label14;
        private System.ComponentModel.BackgroundWorker threadback;
        private System.Windows.Forms.Button startThreadBack;
        private System.Windows.Forms.Button cancelThreadBack;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button btnClearField;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.TextBox Freespace;
    }
}

