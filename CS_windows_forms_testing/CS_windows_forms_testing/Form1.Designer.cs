namespace CS_windows_forms_testing
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
            System.Windows.Forms.ListViewGroup listViewGroup5 = new System.Windows.Forms.ListViewGroup("ListViewGroup1", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewGroup listViewGroup6 = new System.Windows.Forms.ListViewGroup("ListViewGroup2", System.Windows.Forms.HorizontalAlignment.Left);
            System.Windows.Forms.ListViewItem listViewItem7 = new System.Windows.Forms.ListViewItem(new string[] {
            "group1-awayteam",
            "game1",
            "game2"}, -1);
            System.Windows.Forms.ListViewItem listViewItem8 = new System.Windows.Forms.ListViewItem("group1-hometeam");
            System.Windows.Forms.ListViewItem listViewItem9 = new System.Windows.Forms.ListViewItem(new string[] {
            "group2-text",
            "2-team1",
            "2-team2"}, -1);
            this.listJMCwin01 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.game_winner1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.spread_winner1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.lineShape1 = new Microsoft.VisualBasic.PowerPacks.LineShape();
            this.listJCRwin01 = new System.Windows.Forms.ListBox();
            this.listJMCspread01 = new System.Windows.Forms.ListBox();
            this.listJCRspread01 = new System.Windows.Forms.ListBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.listJMCwin02 = new System.Windows.Forms.ListBox();
            this.listJCRwin02 = new System.Windows.Forms.ListBox();
            this.listJMCspread02 = new System.Windows.Forms.ListBox();
            this.listJCRspread02 = new System.Windows.Forms.ListBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.listJMCspread03 = new System.Windows.Forms.ListBox();
            this.listJCRwin03 = new System.Windows.Forms.ListBox();
            this.listJMCwin03 = new System.Windows.Forms.ListBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.listJCRspread03 = new System.Windows.Forms.ListBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.listJMCwin04 = new System.Windows.Forms.ListBox();
            this.listJCRwin04 = new System.Windows.Forms.ListBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.listJMCspread04 = new System.Windows.Forms.ListBox();
            this.listJCRspread04 = new System.Windows.Forms.ListBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.listJCRwin05 = new System.Windows.Forms.ListBox();
            this.listJMCspread05 = new System.Windows.Forms.ListBox();
            this.listJMCwin05 = new System.Windows.Forms.ListBox();
            this.listJCRspread05 = new System.Windows.Forms.ListBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.listJMCspread06 = new System.Windows.Forms.ListBox();
            this.listJCRwin06 = new System.Windows.Forms.ListBox();
            this.listJMCwin06 = new System.Windows.Forms.ListBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.listJCRspread06 = new System.Windows.Forms.ListBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_Year = new System.Windows.Forms.ComboBox();
            this.numUD_Sheet = new System.Windows.Forms.NumericUpDown();
            this.btn_GetSheetData = new System.Windows.Forms.Button();
            this.txt_NumGames = new System.Windows.Forms.TextBox();
            this.txt_GamesInMemory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Sheet)).BeginInit();
            this.SuspendLayout();
            // 
            // listJMCwin01
            // 
            this.listJMCwin01.FormattingEnabled = true;
            this.listJMCwin01.Location = new System.Drawing.Point(270, 95);
            this.listJMCwin01.Name = "listJMCwin01";
            this.listJMCwin01.Size = new System.Drawing.Size(123, 30);
            this.listJMCwin01.TabIndex = 0;
            this.listJMCwin01.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "checkedListBox1-item1",
            "checkedListBox1-item2"});
            this.checkedListBox1.Location = new System.Drawing.Point(12, 148);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(148, 34);
            this.checkedListBox1.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.game_winner1,
            this.spread_winner1});
            listViewGroup5.Header = "ListViewGroup1";
            listViewGroup5.Name = "listViewGroup1";
            listViewGroup6.Header = "ListViewGroup2";
            listViewGroup6.Name = "listViewGroup2";
            this.listView1.Groups.AddRange(new System.Windows.Forms.ListViewGroup[] {
            listViewGroup5,
            listViewGroup6});
            listViewItem7.Group = listViewGroup5;
            listViewItem7.IndentCount = 4;
            listViewItem8.Group = listViewGroup5;
            listViewItem9.Group = listViewGroup6;
            this.listView1.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem7,
            listViewItem8,
            listViewItem9});
            this.listView1.Location = new System.Drawing.Point(270, 331);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(619, 338);
            this.listView1.TabIndex = 4;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // game_winner1
            // 
            this.game_winner1.Text = "GAME WINNER";
            this.game_winner1.Width = 110;
            // 
            // spread_winner1
            // 
            this.spread_winner1.Text = "SPREAD WINNER";
            this.spread_winner1.Width = 124;
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(27, 198);
            this.txt_Output.Multiline = true;
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Output.Size = new System.Drawing.Size(159, 202);
            this.txt_Output.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 786);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "EXIT";
            this.btn_Exit.UseVisualStyleBackColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(350, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "GAME WINNER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(675, 37);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "SPREAD WINNER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(304, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "JENNIFER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(432, 73);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "JASON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(632, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "JENNIFER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(796, 75);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "JASON";
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.lineShape1});
            this.shapeContainer1.Size = new System.Drawing.Size(1037, 827);
            this.shapeContainer1.TabIndex = 8;
            this.shapeContainer1.TabStop = false;
            // 
            // lineShape1
            // 
            this.lineShape1.BorderWidth = 5;
            this.lineShape1.Name = "lineShape1";
            this.lineShape1.X1 = 970;
            this.lineShape1.X2 = 972;
            this.lineShape1.Y1 = 382;
            this.lineShape1.Y2 = 746;
            // 
            // listJCRwin01
            // 
            this.listJCRwin01.FormattingEnabled = true;
            this.listJCRwin01.Location = new System.Drawing.Point(399, 95);
            this.listJCRwin01.Name = "listJCRwin01";
            this.listJCRwin01.Size = new System.Drawing.Size(120, 30);
            this.listJCRwin01.TabIndex = 9;
            this.listJCRwin01.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listJMCspread01
            // 
            this.listJMCspread01.FormattingEnabled = true;
            this.listJMCspread01.Location = new System.Drawing.Point(595, 95);
            this.listJMCspread01.Name = "listJMCspread01";
            this.listJMCspread01.Size = new System.Drawing.Size(123, 30);
            this.listJMCspread01.TabIndex = 0;
            this.listJMCspread01.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRspread01
            // 
            this.listJCRspread01.FormattingEnabled = true;
            this.listJCRspread01.Location = new System.Drawing.Point(760, 95);
            this.listJCRspread01.Name = "listJCRspread01";
            this.listJCRspread01.Size = new System.Drawing.Size(123, 30);
            this.listJCRspread01.TabIndex = 0;
            this.listJCRspread01.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(538, 95);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(38, 30);
            this.textBox2.TabIndex = 10;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(724, 95);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(30, 30);
            this.textBox3.TabIndex = 11;
            this.textBox3.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listJMCwin02
            // 
            this.listJMCwin02.FormattingEnabled = true;
            this.listJMCwin02.Location = new System.Drawing.Point(270, 131);
            this.listJMCwin02.Name = "listJMCwin02";
            this.listJMCwin02.Size = new System.Drawing.Size(123, 30);
            this.listJMCwin02.TabIndex = 0;
            this.listJMCwin02.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRwin02
            // 
            this.listJCRwin02.FormattingEnabled = true;
            this.listJCRwin02.Location = new System.Drawing.Point(399, 131);
            this.listJCRwin02.Name = "listJCRwin02";
            this.listJCRwin02.Size = new System.Drawing.Size(120, 30);
            this.listJCRwin02.TabIndex = 9;
            this.listJCRwin02.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listJMCspread02
            // 
            this.listJMCspread02.FormattingEnabled = true;
            this.listJMCspread02.Location = new System.Drawing.Point(595, 131);
            this.listJMCspread02.Name = "listJMCspread02";
            this.listJMCspread02.Size = new System.Drawing.Size(123, 30);
            this.listJMCspread02.TabIndex = 0;
            this.listJMCspread02.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRspread02
            // 
            this.listJCRspread02.FormattingEnabled = true;
            this.listJCRspread02.Location = new System.Drawing.Point(760, 131);
            this.listJCRspread02.Name = "listJCRspread02";
            this.listJCRspread02.Size = new System.Drawing.Size(123, 30);
            this.listJCRspread02.TabIndex = 0;
            this.listJCRspread02.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(538, 131);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(38, 30);
            this.textBox4.TabIndex = 10;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(724, 131);
            this.textBox5.Multiline = true;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(30, 30);
            this.textBox5.TabIndex = 11;
            this.textBox5.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listJMCspread03
            // 
            this.listJMCspread03.FormattingEnabled = true;
            this.listJMCspread03.Location = new System.Drawing.Point(595, 167);
            this.listJMCspread03.Name = "listJMCspread03";
            this.listJMCspread03.Size = new System.Drawing.Size(123, 30);
            this.listJMCspread03.TabIndex = 0;
            this.listJMCspread03.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRwin03
            // 
            this.listJCRwin03.FormattingEnabled = true;
            this.listJCRwin03.Location = new System.Drawing.Point(399, 167);
            this.listJCRwin03.Name = "listJCRwin03";
            this.listJCRwin03.Size = new System.Drawing.Size(120, 30);
            this.listJCRwin03.TabIndex = 9;
            this.listJCRwin03.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listJMCwin03
            // 
            this.listJMCwin03.FormattingEnabled = true;
            this.listJMCwin03.Location = new System.Drawing.Point(270, 167);
            this.listJMCwin03.Name = "listJMCwin03";
            this.listJMCwin03.Size = new System.Drawing.Size(123, 30);
            this.listJMCwin03.TabIndex = 0;
            this.listJMCwin03.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(538, 167);
            this.textBox6.Multiline = true;
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(38, 30);
            this.textBox6.TabIndex = 10;
            // 
            // listJCRspread03
            // 
            this.listJCRspread03.FormattingEnabled = true;
            this.listJCRspread03.Location = new System.Drawing.Point(760, 167);
            this.listJCRspread03.Name = "listJCRspread03";
            this.listJCRspread03.Size = new System.Drawing.Size(123, 30);
            this.listJCRspread03.TabIndex = 0;
            this.listJCRspread03.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(724, 167);
            this.textBox7.Multiline = true;
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(30, 30);
            this.textBox7.TabIndex = 11;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listJMCwin04
            // 
            this.listJMCwin04.FormattingEnabled = true;
            this.listJMCwin04.Location = new System.Drawing.Point(270, 203);
            this.listJMCwin04.Name = "listJMCwin04";
            this.listJMCwin04.Size = new System.Drawing.Size(123, 30);
            this.listJMCwin04.TabIndex = 0;
            this.listJMCwin04.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRwin04
            // 
            this.listJCRwin04.FormattingEnabled = true;
            this.listJCRwin04.Location = new System.Drawing.Point(399, 203);
            this.listJCRwin04.Name = "listJCRwin04";
            this.listJCRwin04.Size = new System.Drawing.Size(120, 30);
            this.listJCRwin04.TabIndex = 9;
            this.listJCRwin04.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(538, 203);
            this.textBox8.Multiline = true;
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(38, 30);
            this.textBox8.TabIndex = 10;
            // 
            // listJMCspread04
            // 
            this.listJMCspread04.FormattingEnabled = true;
            this.listJMCspread04.Location = new System.Drawing.Point(595, 203);
            this.listJMCspread04.Name = "listJMCspread04";
            this.listJMCspread04.Size = new System.Drawing.Size(123, 30);
            this.listJMCspread04.TabIndex = 0;
            this.listJMCspread04.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRspread04
            // 
            this.listJCRspread04.FormattingEnabled = true;
            this.listJCRspread04.Location = new System.Drawing.Point(760, 203);
            this.listJCRspread04.Name = "listJCRspread04";
            this.listJCRspread04.Size = new System.Drawing.Size(123, 30);
            this.listJCRspread04.TabIndex = 0;
            this.listJCRspread04.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(724, 203);
            this.textBox9.Multiline = true;
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(30, 30);
            this.textBox9.TabIndex = 11;
            this.textBox9.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(538, 239);
            this.textBox10.Multiline = true;
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(38, 30);
            this.textBox10.TabIndex = 10;
            // 
            // listJCRwin05
            // 
            this.listJCRwin05.FormattingEnabled = true;
            this.listJCRwin05.Location = new System.Drawing.Point(399, 239);
            this.listJCRwin05.Name = "listJCRwin05";
            this.listJCRwin05.Size = new System.Drawing.Size(120, 30);
            this.listJCRwin05.TabIndex = 9;
            this.listJCRwin05.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listJMCspread05
            // 
            this.listJMCspread05.FormattingEnabled = true;
            this.listJMCspread05.Location = new System.Drawing.Point(595, 239);
            this.listJMCspread05.Name = "listJMCspread05";
            this.listJMCspread05.Size = new System.Drawing.Size(123, 30);
            this.listJMCspread05.TabIndex = 0;
            this.listJMCspread05.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJMCwin05
            // 
            this.listJMCwin05.FormattingEnabled = true;
            this.listJMCwin05.Location = new System.Drawing.Point(270, 239);
            this.listJMCwin05.Name = "listJMCwin05";
            this.listJMCwin05.Size = new System.Drawing.Size(123, 30);
            this.listJMCwin05.TabIndex = 0;
            this.listJMCwin05.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRspread05
            // 
            this.listJCRspread05.FormattingEnabled = true;
            this.listJCRspread05.Location = new System.Drawing.Point(760, 239);
            this.listJCRspread05.Name = "listJCRspread05";
            this.listJCRspread05.Size = new System.Drawing.Size(123, 30);
            this.listJCRspread05.TabIndex = 0;
            this.listJCRspread05.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(724, 239);
            this.textBox11.Multiline = true;
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(30, 30);
            this.textBox11.TabIndex = 11;
            this.textBox11.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // listJMCspread06
            // 
            this.listJMCspread06.FormattingEnabled = true;
            this.listJMCspread06.Location = new System.Drawing.Point(595, 275);
            this.listJMCspread06.Name = "listJMCspread06";
            this.listJMCspread06.Size = new System.Drawing.Size(123, 30);
            this.listJMCspread06.TabIndex = 0;
            this.listJMCspread06.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRwin06
            // 
            this.listJCRwin06.FormattingEnabled = true;
            this.listJCRwin06.Location = new System.Drawing.Point(399, 275);
            this.listJCRwin06.Name = "listJCRwin06";
            this.listJCRwin06.Size = new System.Drawing.Size(120, 30);
            this.listJCRwin06.TabIndex = 9;
            this.listJCRwin06.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listJMCwin06
            // 
            this.listJMCwin06.FormattingEnabled = true;
            this.listJMCwin06.Location = new System.Drawing.Point(270, 275);
            this.listJMCwin06.Name = "listJMCwin06";
            this.listJMCwin06.Size = new System.Drawing.Size(123, 30);
            this.listJMCwin06.TabIndex = 0;
            this.listJMCwin06.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(538, 275);
            this.textBox12.Multiline = true;
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(38, 30);
            this.textBox12.TabIndex = 10;
            // 
            // listJCRspread06
            // 
            this.listJCRspread06.FormattingEnabled = true;
            this.listJCRspread06.Location = new System.Drawing.Point(760, 275);
            this.listJCRspread06.Name = "listJCRspread06";
            this.listJCRspread06.Size = new System.Drawing.Size(123, 30);
            this.listJCRspread06.TabIndex = 0;
            this.listJCRspread06.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(724, 275);
            this.textBox13.Multiline = true;
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(30, 30);
            this.textBox13.TabIndex = 11;
            this.textBox13.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(877, 9);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(148, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Load Data From File";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // combo_Year
            // 
            this.combo_Year.FormattingEnabled = true;
            this.combo_Year.Items.AddRange(new object[] {
            "2015",
            "2016",
            "2017"});
            this.combo_Year.Location = new System.Drawing.Point(91, 38);
            this.combo_Year.Name = "combo_Year";
            this.combo_Year.Size = new System.Drawing.Size(121, 21);
            this.combo_Year.TabIndex = 13;
            this.combo_Year.Text = "2016";
            // 
            // numUD_Sheet
            // 
            this.numUD_Sheet.Location = new System.Drawing.Point(91, 66);
            this.numUD_Sheet.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numUD_Sheet.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numUD_Sheet.Name = "numUD_Sheet";
            this.numUD_Sheet.Size = new System.Drawing.Size(120, 20);
            this.numUD_Sheet.TabIndex = 14;
            this.numUD_Sheet.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btn_GetSheetData
            // 
            this.btn_GetSheetData.Location = new System.Drawing.Point(12, 92);
            this.btn_GetSheetData.Name = "btn_GetSheetData";
            this.btn_GetSheetData.Size = new System.Drawing.Size(139, 23);
            this.btn_GetSheetData.TabIndex = 15;
            this.btn_GetSheetData.Text = "Get Sheet Data";
            this.btn_GetSheetData.UseVisualStyleBackColor = true;
            this.btn_GetSheetData.Click += new System.EventHandler(this.btn_GetSheetData_Click);
            // 
            // txt_NumGames
            // 
            this.txt_NumGames.Location = new System.Drawing.Point(12, 122);
            this.txt_NumGames.Name = "txt_NumGames";
            this.txt_NumGames.Size = new System.Drawing.Size(139, 20);
            this.txt_NumGames.TabIndex = 16;
            // 
            // txt_GamesInMemory
            // 
            this.txt_GamesInMemory.Location = new System.Drawing.Point(877, 39);
            this.txt_GamesInMemory.Name = "txt_GamesInMemory";
            this.txt_GamesInMemory.Size = new System.Drawing.Size(148, 20);
            this.txt_GamesInMemory.TabIndex = 17;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1037, 827);
            this.Controls.Add(this.txt_GamesInMemory);
            this.Controls.Add(this.txt_NumGames);
            this.Controls.Add(this.btn_GetSheetData);
            this.Controls.Add(this.numUD_Sheet);
            this.Controls.Add(this.combo_Year);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.listJCRspread06);
            this.Controls.Add(this.listJMCspread06);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.listJCRwin06);
            this.Controls.Add(this.listJMCwin06);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.listJCRspread05);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.listJMCwin05);
            this.Controls.Add(this.listJCRwin05);
            this.Controls.Add(this.listJMCspread05);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.listJCRspread04);
            this.Controls.Add(this.listJMCwin04);
            this.Controls.Add(this.listJMCspread04);
            this.Controls.Add(this.listJCRwin04);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.listJCRspread03);
            this.Controls.Add(this.listJMCspread03);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.listJCRwin03);
            this.Controls.Add(this.listJMCwin03);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.listJCRspread02);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.listJMCwin02);
            this.Controls.Add(this.listJCRwin02);
            this.Controls.Add(this.listJMCspread02);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.listJCRspread01);
            this.Controls.Add(this.listJMCspread01);
            this.Controls.Add(this.listJCRwin01);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listJMCwin01);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.shapeContainer1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Sheet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listJMCwin01;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader game_winner1;
        private System.Windows.Forms.ColumnHeader spread_winner1;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.LineShape lineShape1;
        private System.Windows.Forms.ListBox listJCRwin01;
        private System.Windows.Forms.ListBox listJMCspread01;
        private System.Windows.Forms.ListBox listJCRspread01;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.ListBox listJMCwin02;
        private System.Windows.Forms.ListBox listJCRwin02;
        private System.Windows.Forms.ListBox listJMCspread02;
        private System.Windows.Forms.ListBox listJCRspread02;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.ListBox listJMCspread03;
        private System.Windows.Forms.ListBox listJCRwin03;
        private System.Windows.Forms.ListBox listJMCwin03;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.ListBox listJCRspread03;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.ListBox listJMCwin04;
        private System.Windows.Forms.ListBox listJCRwin04;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.ListBox listJMCspread04;
        private System.Windows.Forms.ListBox listJCRspread04;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.ListBox listJCRwin05;
        private System.Windows.Forms.ListBox listJMCspread05;
        private System.Windows.Forms.ListBox listJMCwin05;
        private System.Windows.Forms.ListBox listJCRspread05;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.ListBox listJMCspread06;
        private System.Windows.Forms.ListBox listJCRwin06;
        private System.Windows.Forms.ListBox listJMCwin06;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.ListBox listJCRspread06;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_Year;
        private System.Windows.Forms.NumericUpDown numUD_Sheet;
        private System.Windows.Forms.Button btn_GetSheetData;
        private System.Windows.Forms.TextBox txt_NumGames;
        private System.Windows.Forms.TextBox txt_GamesInMemory;
    }
}

