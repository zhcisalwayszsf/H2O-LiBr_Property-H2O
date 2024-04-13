namespace LiBr_H2O_Calculator
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tableLayoutPanel1 = new TableLayoutPanel();
            panel1 = new Panel();
            label10 = new Label();
            label1 = new Label();
            comboBox1 = new ComboBox();
            panel2 = new Panel();
            button1 = new Button();
            panel5 = new Panel();
            textBox3 = new TextBox();
            label5 = new Label();
            textBox2 = new TextBox();
            label4 = new Label();
            textBox1 = new TextBox();
            label3 = new Label();
            panel7 = new Panel();
            label12 = new Label();
            textBox7 = new TextBox();
            label11 = new Label();
            tabPage2 = new TabPage();
            tableLayoutPanel2 = new TableLayoutPanel();
            panel8 = new Panel();
            label13 = new Label();
            textBox8 = new TextBox();
            label14 = new Label();
            panel3 = new Panel();
            label9 = new Label();
            label2 = new Label();
            comboBox4 = new ComboBox();
            panel4 = new Panel();
            button2 = new Button();
            panel6 = new Panel();
            textBox4 = new TextBox();
            label6 = new Label();
            textBox5 = new TextBox();
            label7 = new Label();
            textBox6 = new TextBox();
            label8 = new Label();
            tabPage3 = new TabPage();
            tableLayoutPanel3 = new TableLayoutPanel();
            panel9 = new Panel();
            label15 = new Label();
            textBox9 = new TextBox();
            label16 = new Label();
            panel10 = new Panel();
            textBox13 = new TextBox();
            label17 = new Label();
            label18 = new Label();
            panel11 = new Panel();
            button3 = new Button();
            panel12 = new Panel();
            textBox10 = new TextBox();
            label19 = new Label();
            textBox11 = new TextBox();
            label20 = new Label();
            textBox12 = new TextBox();
            label21 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel5.SuspendLayout();
            panel7.SuspendLayout();
            tabPage2.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            panel8.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            panel6.SuspendLayout();
            tabPage3.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            panel9.SuspendLayout();
            panel10.SuspendLayout();
            panel11.SuspendLayout();
            panel12.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 0);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(800, 450);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(tableLayoutPanel1);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(792, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "饱和水";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.Anchor = AnchorStyles.None;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.19084F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.80916F));
            tableLayoutPanel1.Controls.Add(panel1, 1, 0);
            tableLayoutPanel1.Controls.Add(panel2, 1, 1);
            tableLayoutPanel1.Controls.Add(panel5, 0, 0);
            tableLayoutPanel1.Controls.Add(panel7, 0, 1);
            tableLayoutPanel1.Location = new Point(3, 3);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel1.Size = new Size(786, 411);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Controls.Add(label10);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(comboBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(594, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(189, 293);
            panel1.TabIndex = 2;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label10.ForeColor = SystemColors.MenuHighlight;
            label10.Location = new Point(30, 170);
            label10.Name = "label10";
            label10.Size = new Size(123, 70);
            label10.TabIndex = 4;
            label10.Text = "正在计算\r\n水";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(30, 25);
            label1.Name = "label1";
            label1.Size = new Size(132, 27);
            label1.TabIndex = 2;
            label1.Text = "选择计算模式";
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "计算焓值（根据压力）", "计算焓值（根据温度）", "计算压力（根据温度）" });
            comboBox1.Location = new Point(0, 83);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(187, 28);
            comboBox1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(button1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(594, 302);
            panel2.Name = "panel2";
            panel2.Size = new Size(189, 106);
            panel2.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(44, 29);
            button1.MinimumSize = new Size(98, 54);
            button1.Name = "button1";
            button1.Size = new Size(104, 54);
            button1.TabIndex = 5;
            button1.Text = "计算";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // panel5
            // 
            panel5.Controls.Add(textBox3);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(textBox2);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(textBox1);
            panel5.Controls.Add(label3);
            panel5.Dock = DockStyle.Fill;
            panel5.Location = new Point(3, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(585, 293);
            panel5.TabIndex = 1;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(300, 170);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(114, 27);
            textBox3.TabIndex = 3;
            textBox3.KeyPress += textBoxNumOnly;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(60, 170);
            label5.Name = "label5";
            label5.Size = new Size(144, 27);
            label5.TabIndex = 4;
            label5.Text = "比焓（kJ/kg）";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(300, 100);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(114, 27);
            textBox2.TabIndex = 2;
            textBox2.KeyPress += textBoxNumOnly;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(60, 100);
            label4.Name = "label4";
            label4.Size = new Size(126, 27);
            label4.TabIndex = 2;
            label4.Text = "压力（kPa）";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(300, 30);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(114, 27);
            textBox1.TabIndex = 1;
            textBox1.KeyPress += textBoxNumOnly;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(60, 30);
            label3.Name = "label3";
            label3.Size = new Size(152, 27);
            label3.TabIndex = 0;
            label3.Text = "温度（摄氏度）";
            // 
            // panel7
            // 
            panel7.Controls.Add(label12);
            panel7.Controls.Add(textBox7);
            panel7.Controls.Add(label11);
            panel7.Dock = DockStyle.Fill;
            panel7.Location = new Point(3, 302);
            panel7.Name = "panel7";
            panel7.Size = new Size(585, 106);
            panel7.TabIndex = 4;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label12.Location = new Point(400, 35);
            label12.Name = "label12";
            label12.Size = new Size(0, 35);
            label12.TabIndex = 2;
            // 
            // textBox7
            // 
            textBox7.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox7.Location = new Point(180, 35);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.ScrollBars = ScrollBars.Vertical;
            textBox7.Size = new Size(200, 39);
            textBox7.TabIndex = 6;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label11.Location = new Point(26, 35);
            label11.Name = "label11";
            label11.Size = new Size(150, 35);
            label11.TabIndex = 0;
            label11.Text = "计算结果：";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(tableLayoutPanel2);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(792, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "饱和水蒸气";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.None;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.19084F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.80916F));
            tableLayoutPanel2.Controls.Add(panel8, 0, 1);
            tableLayoutPanel2.Controls.Add(panel3, 1, 0);
            tableLayoutPanel2.Controls.Add(panel4, 1, 1);
            tableLayoutPanel2.Controls.Add(panel6, 0, 0);
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel2.Size = new Size(786, 411);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // panel8
            // 
            panel8.Controls.Add(label13);
            panel8.Controls.Add(textBox8);
            panel8.Controls.Add(label14);
            panel8.Dock = DockStyle.Fill;
            panel8.Location = new Point(3, 302);
            panel8.Name = "panel8";
            panel8.Size = new Size(585, 106);
            panel8.TabIndex = 4;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label13.Location = new Point(400, 35);
            label13.Name = "label13";
            label13.Size = new Size(0, 35);
            label13.TabIndex = 2;
            // 
            // textBox8
            // 
            textBox8.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox8.Location = new Point(180, 35);
            textBox8.Name = "textBox8";
            textBox8.ReadOnly = true;
            textBox8.ScrollBars = ScrollBars.Horizontal;
            textBox8.Size = new Size(200, 39);
            textBox8.TabIndex = 6;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label14.Location = new Point(26, 35);
            label14.Name = "label14";
            label14.Size = new Size(150, 35);
            label14.TabIndex = 0;
            label14.Text = "计算结果：";
            // 
            // panel3
            // 
            panel3.Controls.Add(label9);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(comboBox4);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(594, 3);
            panel3.Name = "panel3";
            panel3.Size = new Size(189, 293);
            panel3.TabIndex = 2;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label9.ForeColor = SystemColors.MenuHighlight;
            label9.Location = new Point(30, 170);
            label9.Name = "label9";
            label9.Size = new Size(123, 70);
            label9.TabIndex = 3;
            label9.Text = "正在计算\r\n水蒸气";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(30, 25);
            label2.Name = "label2";
            label2.Size = new Size(132, 27);
            label2.TabIndex = 2;
            label2.Text = "选择计算模式";
            // 
            // comboBox4
            // 
            comboBox4.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox4.FormattingEnabled = true;
            comboBox4.Items.AddRange(new object[] { "焓值（根据温度，压力）", "温度（根据压力）", "饱和水蒸气的密度（根据温度）" });
            comboBox4.Location = new Point(0, 83);
            comboBox4.Name = "comboBox4";
            comboBox4.Size = new Size(187, 28);
            comboBox4.TabIndex = 4;
            // 
            // panel4
            // 
            panel4.Controls.Add(button2);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(594, 302);
            panel4.Name = "panel4";
            panel4.Size = new Size(189, 106);
            panel4.TabIndex = 3;
            // 
            // button2
            // 
            button2.Location = new Point(44, 29);
            button2.MinimumSize = new Size(98, 54);
            button2.Name = "button2";
            button2.Size = new Size(104, 54);
            button2.TabIndex = 5;
            button2.Text = "计算";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // panel6
            // 
            panel6.Controls.Add(textBox4);
            panel6.Controls.Add(label6);
            panel6.Controls.Add(textBox5);
            panel6.Controls.Add(label7);
            panel6.Controls.Add(textBox6);
            panel6.Controls.Add(label8);
            panel6.Dock = DockStyle.Fill;
            panel6.Location = new Point(3, 3);
            panel6.Name = "panel6";
            panel6.Size = new Size(585, 293);
            panel6.TabIndex = 1;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(300, 170);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(114, 27);
            textBox4.TabIndex = 3;
            textBox4.KeyPress += textBoxNumOnly;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(60, 170);
            label6.Name = "label6";
            label6.Size = new Size(144, 27);
            label6.TabIndex = 10;
            label6.Text = "比焓（kJ/kg）";
            // 
            // textBox5
            // 
            textBox5.Location = new Point(300, 100);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(114, 27);
            textBox5.TabIndex = 2;
            textBox5.KeyPress += textBoxNumOnly;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label7.Location = new Point(60, 100);
            label7.Name = "label7";
            label7.Size = new Size(126, 27);
            label7.TabIndex = 8;
            label7.Text = "压力（kPa）";
            // 
            // textBox6
            // 
            textBox6.Location = new Point(300, 30);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(114, 27);
            textBox6.TabIndex = 1;
            textBox6.KeyPress += textBoxNumOnly;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(60, 30);
            label8.Name = "label8";
            label8.Size = new Size(152, 27);
            label8.TabIndex = 6;
            label8.Text = "温度（摄氏度）";
            // 
            // tabPage3
            // 
            tabPage3.Controls.Add(tableLayoutPanel3);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(792, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "过热蒸汽";
            tabPage3.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.None;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75.19084F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 24.80916F));
            tableLayoutPanel3.Controls.Add(panel9, 0, 1);
            tableLayoutPanel3.Controls.Add(panel10, 1, 0);
            tableLayoutPanel3.Controls.Add(panel11, 1, 1);
            tableLayoutPanel3.Controls.Add(panel12, 0, 0);
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 112F));
            tableLayoutPanel3.Size = new Size(786, 411);
            tableLayoutPanel3.TabIndex = 2;
            // 
            // panel9
            // 
            panel9.Controls.Add(label15);
            panel9.Controls.Add(textBox9);
            panel9.Controls.Add(label16);
            panel9.Dock = DockStyle.Fill;
            panel9.Location = new Point(3, 302);
            panel9.Name = "panel9";
            panel9.Size = new Size(585, 106);
            panel9.TabIndex = 4;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label15.Location = new Point(400, 35);
            label15.Name = "label15";
            label15.Size = new Size(0, 35);
            label15.TabIndex = 2;
            // 
            // textBox9
            // 
            textBox9.Font = new Font("Microsoft YaHei UI", 15F, FontStyle.Regular, GraphicsUnit.Point);
            textBox9.Location = new Point(180, 35);
            textBox9.Name = "textBox9";
            textBox9.ReadOnly = true;
            textBox9.ScrollBars = ScrollBars.Horizontal;
            textBox9.Size = new Size(200, 39);
            textBox9.TabIndex = 6;
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label16.Location = new Point(26, 35);
            label16.Name = "label16";
            label16.Size = new Size(150, 35);
            label16.TabIndex = 0;
            label16.Text = "计算结果：";
            label16.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // panel10
            // 
            panel10.Controls.Add(textBox13);
            panel10.Controls.Add(label17);
            panel10.Controls.Add(label18);
            panel10.Dock = DockStyle.Fill;
            panel10.Location = new Point(594, 3);
            panel10.Name = "panel10";
            panel10.Size = new Size(189, 293);
            panel10.TabIndex = 2;
            // 
            // textBox13
            // 
            textBox13.BackColor = SystemColors.Control;
            textBox13.BorderStyle = BorderStyle.None;
            textBox13.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBox13.Location = new Point(3, 83);
            textBox13.Name = "textBox13";
            textBox13.ReadOnly = true;
            textBox13.Size = new Size(183, 26);
            textBox13.TabIndex = 4;
            textBox13.Text = "过热蒸汽焓";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Font = new Font("Microsoft YaHei UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            label17.ForeColor = SystemColors.MenuHighlight;
            label17.Location = new Point(30, 170);
            label17.Name = "label17";
            label17.Size = new Size(150, 70);
            label17.TabIndex = 3;
            label17.Text = "正在计算\r\n过热水蒸气";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label18.Location = new Point(30, 25);
            label18.Name = "label18";
            label18.Size = new Size(132, 27);
            label18.TabIndex = 2;
            label18.Text = "选择计算模式";
            // 
            // panel11
            // 
            panel11.Controls.Add(button3);
            panel11.Dock = DockStyle.Fill;
            panel11.Location = new Point(594, 302);
            panel11.Name = "panel11";
            panel11.Size = new Size(189, 106);
            panel11.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(44, 29);
            button3.MinimumSize = new Size(98, 54);
            button3.Name = "button3";
            button3.Size = new Size(104, 54);
            button3.TabIndex = 5;
            button3.Text = "计算";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // panel12
            // 
            panel12.Controls.Add(textBox10);
            panel12.Controls.Add(label19);
            panel12.Controls.Add(textBox11);
            panel12.Controls.Add(label20);
            panel12.Controls.Add(textBox12);
            panel12.Controls.Add(label21);
            panel12.Dock = DockStyle.Fill;
            panel12.Location = new Point(3, 3);
            panel12.Name = "panel12";
            panel12.Size = new Size(585, 293);
            panel12.TabIndex = 1;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(300, 170);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(114, 27);
            textBox10.TabIndex = 3;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label19.Location = new Point(60, 170);
            label19.Name = "label19";
            label19.Size = new Size(144, 27);
            label19.TabIndex = 10;
            label19.Text = "比焓（kJ/kg）";
            // 
            // textBox11
            // 
            textBox11.Location = new Point(300, 100);
            textBox11.Name = "textBox11";
            textBox11.Size = new Size(114, 27);
            textBox11.TabIndex = 2;
            textBox11.KeyPress += textBoxNumOnly;
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label20.Location = new Point(60, 100);
            label20.Name = "label20";
            label20.Size = new Size(126, 27);
            label20.TabIndex = 8;
            label20.Text = "压力（kPa）";
            // 
            // textBox12
            // 
            textBox12.Location = new Point(300, 30);
            textBox12.Name = "textBox12";
            textBox12.Size = new Size(114, 27);
            textBox12.TabIndex = 1;
            textBox12.KeyPress += textBoxNumOnly;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Font = new Font("Microsoft YaHei UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label21.Location = new Point(60, 30);
            label21.Name = "label21";
            label21.Size = new Size(152, 27);
            label21.TabIndex = 6;
            label21.Text = "温度（摄氏度）";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            MaximizeBox = false;
            Name = "Form1";
            RightToLeft = RightToLeft.No;
            Text = "H2O物性参数计算程序";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel7.ResumeLayout(false);
            panel7.PerformLayout();
            tabPage2.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            panel8.ResumeLayout(false);
            panel8.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel6.ResumeLayout(false);
            panel6.PerformLayout();
            tabPage3.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            panel9.ResumeLayout(false);
            panel9.PerformLayout();
            panel10.ResumeLayout(false);
            panel10.PerformLayout();
            panel11.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel12.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private ComboBox comboBox1;
        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel5;
        private TabPage tabPage2;
        private TableLayoutPanel tableLayoutPanel2;
        private Panel panel3;
        private Label label2;
        private ComboBox comboBox4;
        private Panel panel4;
        private Button button2;
        private Label label3;
        private TextBox textBox3;
        private Label label5;
        private TextBox textBox2;
        private Label label4;
        private TextBox textBox1;
        private Label label9;
        private Panel panel6;
        private TextBox textBox4;
        private Label label6;
        private TextBox textBox5;
        private Label label7;
        private TextBox textBox6;
        private Label label8;
        private Label label10;
        private Panel panel7;
        private Label label12;
        private TextBox textBox7;
        private Label label11;
        private Panel panel8;
        private Label label13;
        private TextBox textBox8;
        private Label label14;
        private TabPage tabPage3;
        private TableLayoutPanel tableLayoutPanel3;
        private Panel panel9;
        private Label label15;
        private TextBox textBox9;
        private Label label16;
        private Panel panel10;
        private Label label17;
        private Label label18;
        private Panel panel11;
        private Button button3;
        private Panel panel12;
        private TextBox textBox10;
        private Label label19;
        private TextBox textBox11;
        private Label label20;
        private TextBox textBox12;
        private Label label21;
        private TextBox textBox13;

    }
}
