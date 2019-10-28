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
            this.components = new System.ComponentModel.Container();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txt_Output = new System.Windows.Forms.TextBox();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.combo_Year = new System.Windows.Forms.ComboBox();
            this.numUD_Sheet = new System.Windows.Forms.NumericUpDown();
            this.btn_GetSheetData = new System.Windows.Forms.Button();
            this.txt_NumGames = new System.Windows.Forms.TextBox();
            this.txt_GamesInMemory = new System.Windows.Forms.TextBox();
            this.btn_ClearSelections = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.listJMCwin01 = new System.Windows.Forms.ListBox();
            this.listJMCwin02 = new System.Windows.Forms.ListBox();
            this.txtTeams06 = new System.Windows.Forms.TextBox();
            this.listJCRwin01 = new System.Windows.Forms.ListBox();
            this.txtTeams05 = new System.Windows.Forms.TextBox();
            this.txtRanks06 = new System.Windows.Forms.TextBox();
            this.txtTeams04 = new System.Windows.Forms.TextBox();
            this.listScore01 = new System.Windows.Forms.ListBox();
            this.txtTeams03 = new System.Windows.Forms.TextBox();
            this.listJMCspread01 = new System.Windows.Forms.ListBox();
            this.txtRanks05 = new System.Windows.Forms.TextBox();
            this.listLine01 = new System.Windows.Forms.ListBox();
            this.listJCRspread01 = new System.Windows.Forms.ListBox();
            this.txtRanks04 = new System.Windows.Forms.TextBox();
            this.listJCRwin02 = new System.Windows.Forms.ListBox();
            this.listScore02 = new System.Windows.Forms.ListBox();
            this.txtRanks03 = new System.Windows.Forms.TextBox();
            this.txtTime06 = new System.Windows.Forms.TextBox();
            this.listJMCspread02 = new System.Windows.Forms.ListBox();
            this.listLine02 = new System.Windows.Forms.ListBox();
            this.txtTime05 = new System.Windows.Forms.TextBox();
            this.listJCRspread02 = new System.Windows.Forms.ListBox();
            this.txtTime04 = new System.Windows.Forms.TextBox();
            this.txtTeams01 = new System.Windows.Forms.TextBox();
            this.txtTime03 = new System.Windows.Forms.TextBox();
            this.txtTeams02 = new System.Windows.Forms.TextBox();
            this.txtRanks01 = new System.Windows.Forms.TextBox();
            this.txtRanks02 = new System.Windows.Forms.TextBox();
            this.txtTime01 = new System.Windows.Forms.TextBox();
            this.txtTime02 = new System.Windows.Forms.TextBox();
            this.listJMCwin03 = new System.Windows.Forms.ListBox();
            this.listJCRwin03 = new System.Windows.Forms.ListBox();
            this.listLine06 = new System.Windows.Forms.ListBox();
            this.listScore03 = new System.Windows.Forms.ListBox();
            this.listJMCspread03 = new System.Windows.Forms.ListBox();
            this.listLine03 = new System.Windows.Forms.ListBox();
            this.listJCRspread03 = new System.Windows.Forms.ListBox();
            this.listJMCwin04 = new System.Windows.Forms.ListBox();
            this.listJMCwin05 = new System.Windows.Forms.ListBox();
            this.listJMCwin06 = new System.Windows.Forms.ListBox();
            this.listJCRwin04 = new System.Windows.Forms.ListBox();
            this.listJMCspread04 = new System.Windows.Forms.ListBox();
            this.listScore04 = new System.Windows.Forms.ListBox();
            this.listLine04 = new System.Windows.Forms.ListBox();
            this.listJCRspread04 = new System.Windows.Forms.ListBox();
            this.listJCRspread05 = new System.Windows.Forms.ListBox();
            this.listJCRspread06 = new System.Windows.Forms.ListBox();
            this.listLine05 = new System.Windows.Forms.ListBox();
            this.listJMCspread05 = new System.Windows.Forms.ListBox();
            this.listJMCspread06 = new System.Windows.Forms.ListBox();
            this.listScore05 = new System.Windows.Forms.ListBox();
            this.listScore06 = new System.Windows.Forms.ListBox();
            this.listJCRwin05 = new System.Windows.Forms.ListBox();
            this.listJCRwin06 = new System.Windows.Forms.ListBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.gameBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.football_picksDataSet = new CS_windows_forms_testing.football_picksDataSet();
            this.gameTableAdapter = new CS_windows_forms_testing.football_picksDataSetTableAdapters.gameTableAdapter();
            this.tableAdapterManager = new CS_windows_forms_testing.football_picksDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Sheet)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_picksDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txt_Output
            // 
            this.txt_Output.Location = new System.Drawing.Point(12, 279);
            this.txt_Output.Multiline = true;
            this.txt_Output.Name = "txt_Output";
            this.txt_Output.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_Output.Size = new System.Drawing.Size(159, 202);
            this.txt_Output.TabIndex = 5;
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(12, 528);
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
            this.label5.Location = new System.Drawing.Point(290, 14);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "GAME WINNER";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(615, 14);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "SPREAD WINNER";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(244, 50);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "JENNIFER";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(372, 50);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(42, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "JASON";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(572, 50);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "JENNIFER";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(742, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(42, 13);
            this.label10.TabIndex = 7;
            this.label10.Text = "JASON";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 38);
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
            this.combo_Year.Location = new System.Drawing.Point(91, 112);
            this.combo_Year.Name = "combo_Year";
            this.combo_Year.Size = new System.Drawing.Size(60, 21);
            this.combo_Year.TabIndex = 13;
            this.combo_Year.Text = "2016";
            // 
            // numUD_Sheet
            // 
            this.numUD_Sheet.Location = new System.Drawing.Point(91, 139);
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
            this.numUD_Sheet.Size = new System.Drawing.Size(60, 20);
            this.numUD_Sheet.TabIndex = 14;
            this.numUD_Sheet.Value = new decimal(new int[] {
            4,
            0,
            0,
            0});
            // 
            // btn_GetSheetData
            // 
            this.btn_GetSheetData.Location = new System.Drawing.Point(12, 166);
            this.btn_GetSheetData.Name = "btn_GetSheetData";
            this.btn_GetSheetData.Size = new System.Drawing.Size(139, 23);
            this.btn_GetSheetData.TabIndex = 15;
            this.btn_GetSheetData.Text = "Get Sheet Data";
            this.btn_GetSheetData.UseVisualStyleBackColor = true;
            this.btn_GetSheetData.Click += new System.EventHandler(this.btn_GetSheetData_Click);
            // 
            // txt_NumGames
            // 
            this.txt_NumGames.Location = new System.Drawing.Point(12, 196);
            this.txt_NumGames.Name = "txt_NumGames";
            this.txt_NumGames.Size = new System.Drawing.Size(139, 20);
            this.txt_NumGames.TabIndex = 16;
            // 
            // txt_GamesInMemory
            // 
            this.txt_GamesInMemory.Location = new System.Drawing.Point(12, 67);
            this.txt_GamesInMemory.Name = "txt_GamesInMemory";
            this.txt_GamesInMemory.Size = new System.Drawing.Size(148, 20);
            this.txt_GamesInMemory.TabIndex = 17;
            // 
            // btn_ClearSelections
            // 
            this.btn_ClearSelections.Location = new System.Drawing.Point(12, 250);
            this.btn_ClearSelections.Name = "btn_ClearSelections";
            this.btn_ClearSelections.Size = new System.Drawing.Size(139, 23);
            this.btn_ClearSelections.TabIndex = 18;
            this.btn_ClearSelections.Text = "Clear All Selections";
            this.btn_ClearSelections.UseVisualStyleBackColor = true;
            this.btn_ClearSelections.Click += new System.EventHandler(this.button2_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(218, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1010, 1700);
            this.tabControl1.TabIndex = 22;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.tableLayoutPanel1);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1002, 1674);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 11;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 46F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 132F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 119F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 39F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 114F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 43F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 123F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 34F));
            this.tableLayoutPanel1.Controls.Add(this.listJMCwin01, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.listJMCwin02, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTeams06, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.listJCRwin01, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTeams05, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtRanks06, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTeams04, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.listScore01, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTeams03, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.listJMCspread01, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRanks05, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.listLine01, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.listJCRspread01, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRanks04, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.listJCRwin02, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.listScore02, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRanks03, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTime06, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.listJMCspread02, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.listLine02, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTime05, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.listJCRspread02, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTime04, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtTeams01, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTime03, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtTeams02, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtRanks01, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtRanks02, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtTime01, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtTime02, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.listJMCwin03, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.listJCRwin03, 4, 2);
            this.tableLayoutPanel1.Controls.Add(this.listLine06, 7, 5);
            this.tableLayoutPanel1.Controls.Add(this.listScore03, 5, 2);
            this.tableLayoutPanel1.Controls.Add(this.listJMCspread03, 6, 2);
            this.tableLayoutPanel1.Controls.Add(this.listLine03, 7, 2);
            this.tableLayoutPanel1.Controls.Add(this.listJCRspread03, 8, 2);
            this.tableLayoutPanel1.Controls.Add(this.listJMCwin04, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.listJMCwin05, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.listJMCwin06, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.listJCRwin04, 4, 3);
            this.tableLayoutPanel1.Controls.Add(this.listJMCspread04, 6, 3);
            this.tableLayoutPanel1.Controls.Add(this.listScore04, 5, 3);
            this.tableLayoutPanel1.Controls.Add(this.listLine04, 7, 3);
            this.tableLayoutPanel1.Controls.Add(this.listJCRspread04, 8, 3);
            this.tableLayoutPanel1.Controls.Add(this.listJCRspread05, 8, 4);
            this.tableLayoutPanel1.Controls.Add(this.listJCRspread06, 8, 5);
            this.tableLayoutPanel1.Controls.Add(this.listLine05, 7, 4);
            this.tableLayoutPanel1.Controls.Add(this.listJMCspread05, 6, 4);
            this.tableLayoutPanel1.Controls.Add(this.listJMCspread06, 6, 5);
            this.tableLayoutPanel1.Controls.Add(this.listScore05, 5, 4);
            this.tableLayoutPanel1.Controls.Add(this.listScore06, 5, 5);
            this.tableLayoutPanel1.Controls.Add(this.listJCRwin05, 4, 4);
            this.tableLayoutPanel1.Controls.Add(this.listJCRwin06, 4, 5);
            this.tableLayoutPanel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLayoutPanel1.Location = new System.Drawing.Point(57, 78);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 40F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(939, 392);
            this.tableLayoutPanel1.TabIndex = 23;
            this.tableLayoutPanel1.Paint += new System.Windows.Forms.PaintEventHandler(this.tableLayoutPanel1_Paint);
            // 
            // listJMCwin01
            // 
            this.listJMCwin01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCwin01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCwin01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCwin01.FormattingEnabled = true;
            this.listJMCwin01.ItemHeight = 16;
            this.listJMCwin01.Location = new System.Drawing.Point(228, 4);
            this.listJMCwin01.Name = "listJMCwin01";
            this.listJMCwin01.Size = new System.Drawing.Size(126, 34);
            this.listJMCwin01.TabIndex = 0;
            this.listJMCwin01.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJMCwin02
            // 
            this.listJMCwin02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCwin02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCwin02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCwin02.FormattingEnabled = true;
            this.listJMCwin02.ItemHeight = 16;
            this.listJMCwin02.Location = new System.Drawing.Point(228, 45);
            this.listJMCwin02.Name = "listJMCwin02";
            this.listJMCwin02.Size = new System.Drawing.Size(126, 34);
            this.listJMCwin02.TabIndex = 0;
            this.listJMCwin02.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtTeams06
            // 
            this.txtTeams06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeams06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeams06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeams06.Location = new System.Drawing.Point(125, 209);
            this.txtTeams06.Multiline = true;
            this.txtTeams06.Name = "txtTeams06";
            this.txtTeams06.Size = new System.Drawing.Size(96, 34);
            this.txtTeams06.TabIndex = 21;
            this.txtTeams06.Text = "teams06";
            // 
            // listJCRwin01
            // 
            this.listJCRwin01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRwin01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRwin01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRwin01.FormattingEnabled = true;
            this.listJCRwin01.ItemHeight = 16;
            this.listJCRwin01.Location = new System.Drawing.Point(361, 4);
            this.listJCRwin01.Name = "listJCRwin01";
            this.listJCRwin01.Size = new System.Drawing.Size(113, 34);
            this.listJCRwin01.TabIndex = 9;
            this.listJCRwin01.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // txtTeams05
            // 
            this.txtTeams05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeams05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeams05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeams05.Location = new System.Drawing.Point(125, 168);
            this.txtTeams05.Multiline = true;
            this.txtTeams05.Name = "txtTeams05";
            this.txtTeams05.Size = new System.Drawing.Size(96, 34);
            this.txtTeams05.TabIndex = 21;
            this.txtTeams05.Text = "teams05";
            // 
            // txtRanks06
            // 
            this.txtRanks06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRanks06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRanks06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanks06.Location = new System.Drawing.Point(78, 209);
            this.txtRanks06.Multiline = true;
            this.txtRanks06.Name = "txtRanks06";
            this.txtRanks06.Size = new System.Drawing.Size(40, 34);
            this.txtRanks06.TabIndex = 21;
            this.txtRanks06.Text = "ranks06";
            this.txtRanks06.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTeams04
            // 
            this.txtTeams04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeams04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeams04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeams04.Location = new System.Drawing.Point(125, 127);
            this.txtTeams04.Multiline = true;
            this.txtTeams04.Name = "txtTeams04";
            this.txtTeams04.Size = new System.Drawing.Size(96, 34);
            this.txtTeams04.TabIndex = 21;
            this.txtTeams04.Text = "teams04";
            // 
            // listScore01
            // 
            this.listScore01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScore01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScore01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listScore01.FormattingEnabled = true;
            this.listScore01.ItemHeight = 16;
            this.listScore01.Location = new System.Drawing.Point(481, 4);
            this.listScore01.Name = "listScore01";
            this.listScore01.Size = new System.Drawing.Size(33, 34);
            this.listScore01.TabIndex = 19;
            // 
            // txtTeams03
            // 
            this.txtTeams03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeams03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeams03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeams03.Location = new System.Drawing.Point(125, 86);
            this.txtTeams03.Multiline = true;
            this.txtTeams03.Name = "txtTeams03";
            this.txtTeams03.Size = new System.Drawing.Size(96, 34);
            this.txtTeams03.TabIndex = 21;
            this.txtTeams03.Text = "teams03";
            // 
            // listJMCspread01
            // 
            this.listJMCspread01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCspread01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCspread01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCspread01.FormattingEnabled = true;
            this.listJMCspread01.ItemHeight = 16;
            this.listJMCspread01.Location = new System.Drawing.Point(521, 4);
            this.listJMCspread01.Name = "listJMCspread01";
            this.listJMCspread01.Size = new System.Drawing.Size(108, 34);
            this.listJMCspread01.TabIndex = 0;
            this.listJMCspread01.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtRanks05
            // 
            this.txtRanks05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRanks05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRanks05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanks05.Location = new System.Drawing.Point(78, 168);
            this.txtRanks05.Multiline = true;
            this.txtRanks05.Name = "txtRanks05";
            this.txtRanks05.Size = new System.Drawing.Size(40, 34);
            this.txtRanks05.TabIndex = 21;
            this.txtRanks05.Text = "ranks05";
            this.txtRanks05.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listLine01
            // 
            this.listLine01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLine01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLine01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLine01.FormattingEnabled = true;
            this.listLine01.ItemHeight = 16;
            this.listLine01.Location = new System.Drawing.Point(636, 4);
            this.listLine01.Name = "listLine01";
            this.listLine01.Size = new System.Drawing.Size(37, 34);
            this.listLine01.TabIndex = 20;
            // 
            // listJCRspread01
            // 
            this.listJCRspread01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRspread01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRspread01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRspread01.FormattingEnabled = true;
            this.listJCRspread01.ItemHeight = 16;
            this.listJCRspread01.Location = new System.Drawing.Point(680, 4);
            this.listJCRspread01.Name = "listJCRspread01";
            this.listJCRspread01.Size = new System.Drawing.Size(117, 34);
            this.listJCRspread01.TabIndex = 0;
            this.listJCRspread01.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtRanks04
            // 
            this.txtRanks04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRanks04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRanks04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanks04.Location = new System.Drawing.Point(78, 127);
            this.txtRanks04.Multiline = true;
            this.txtRanks04.Name = "txtRanks04";
            this.txtRanks04.Size = new System.Drawing.Size(40, 34);
            this.txtRanks04.TabIndex = 21;
            this.txtRanks04.Text = "ranks04";
            this.txtRanks04.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // listJCRwin02
            // 
            this.listJCRwin02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRwin02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRwin02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRwin02.FormattingEnabled = true;
            this.listJCRwin02.ItemHeight = 16;
            this.listJCRwin02.Location = new System.Drawing.Point(361, 45);
            this.listJCRwin02.Name = "listJCRwin02";
            this.listJCRwin02.Size = new System.Drawing.Size(113, 34);
            this.listJCRwin02.TabIndex = 9;
            this.listJCRwin02.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listScore02
            // 
            this.listScore02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScore02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScore02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listScore02.FormattingEnabled = true;
            this.listScore02.ItemHeight = 16;
            this.listScore02.Location = new System.Drawing.Point(481, 45);
            this.listScore02.Name = "listScore02";
            this.listScore02.Size = new System.Drawing.Size(33, 34);
            this.listScore02.TabIndex = 19;
            // 
            // txtRanks03
            // 
            this.txtRanks03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRanks03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRanks03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanks03.Location = new System.Drawing.Point(78, 86);
            this.txtRanks03.Multiline = true;
            this.txtRanks03.Name = "txtRanks03";
            this.txtRanks03.Size = new System.Drawing.Size(40, 34);
            this.txtRanks03.TabIndex = 21;
            this.txtRanks03.Text = "ranks03";
            this.txtRanks03.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTime06
            // 
            this.txtTime06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTime06.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime06.Location = new System.Drawing.Point(4, 209);
            this.txtTime06.Name = "txtTime06";
            this.txtTime06.Size = new System.Drawing.Size(67, 13);
            this.txtTime06.TabIndex = 21;
            this.txtTime06.Text = "timeBox06";
            this.txtTime06.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listJMCspread02
            // 
            this.listJMCspread02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCspread02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCspread02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCspread02.FormattingEnabled = true;
            this.listJMCspread02.ItemHeight = 16;
            this.listJMCspread02.Location = new System.Drawing.Point(521, 45);
            this.listJMCspread02.Name = "listJMCspread02";
            this.listJMCspread02.Size = new System.Drawing.Size(108, 34);
            this.listJMCspread02.TabIndex = 0;
            this.listJMCspread02.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listLine02
            // 
            this.listLine02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLine02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLine02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLine02.FormattingEnabled = true;
            this.listLine02.ItemHeight = 16;
            this.listLine02.Location = new System.Drawing.Point(636, 45);
            this.listLine02.Name = "listLine02";
            this.listLine02.Size = new System.Drawing.Size(37, 34);
            this.listLine02.TabIndex = 20;
            // 
            // txtTime05
            // 
            this.txtTime05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTime05.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime05.Location = new System.Drawing.Point(4, 168);
            this.txtTime05.Name = "txtTime05";
            this.txtTime05.Size = new System.Drawing.Size(67, 13);
            this.txtTime05.TabIndex = 21;
            this.txtTime05.Text = "timeBox05";
            this.txtTime05.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listJCRspread02
            // 
            this.listJCRspread02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRspread02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRspread02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRspread02.FormattingEnabled = true;
            this.listJCRspread02.ItemHeight = 16;
            this.listJCRspread02.Location = new System.Drawing.Point(680, 45);
            this.listJCRspread02.Name = "listJCRspread02";
            this.listJCRspread02.Size = new System.Drawing.Size(117, 34);
            this.listJCRspread02.TabIndex = 0;
            this.listJCRspread02.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // txtTime04
            // 
            this.txtTime04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTime04.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime04.Location = new System.Drawing.Point(4, 127);
            this.txtTime04.Name = "txtTime04";
            this.txtTime04.Size = new System.Drawing.Size(67, 13);
            this.txtTime04.TabIndex = 21;
            this.txtTime04.Text = "timeBox04";
            this.txtTime04.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeams01
            // 
            this.txtTeams01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeams01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeams01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeams01.Location = new System.Drawing.Point(125, 4);
            this.txtTeams01.Multiline = true;
            this.txtTeams01.Name = "txtTeams01";
            this.txtTeams01.Size = new System.Drawing.Size(96, 34);
            this.txtTeams01.TabIndex = 21;
            this.txtTeams01.Text = "teams01";
            // 
            // txtTime03
            // 
            this.txtTime03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTime03.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime03.Location = new System.Drawing.Point(4, 86);
            this.txtTime03.Name = "txtTime03";
            this.txtTime03.Size = new System.Drawing.Size(67, 13);
            this.txtTime03.TabIndex = 21;
            this.txtTime03.Text = "timeBox03";
            this.txtTime03.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTeams02
            // 
            this.txtTeams02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeams02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTeams02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeams02.Location = new System.Drawing.Point(125, 45);
            this.txtTeams02.Multiline = true;
            this.txtTeams02.Name = "txtTeams02";
            this.txtTeams02.Size = new System.Drawing.Size(96, 34);
            this.txtTeams02.TabIndex = 21;
            this.txtTeams02.Text = "teams02";
            // 
            // txtRanks01
            // 
            this.txtRanks01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRanks01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRanks01.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanks01.Location = new System.Drawing.Point(78, 4);
            this.txtRanks01.Multiline = true;
            this.txtRanks01.Name = "txtRanks01";
            this.txtRanks01.Size = new System.Drawing.Size(40, 34);
            this.txtRanks01.TabIndex = 21;
            this.txtRanks01.Text = "ranks01";
            this.txtRanks01.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtRanks02
            // 
            this.txtRanks02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRanks02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtRanks02.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRanks02.Location = new System.Drawing.Point(78, 45);
            this.txtRanks02.Multiline = true;
            this.txtRanks02.Name = "txtRanks02";
            this.txtRanks02.Size = new System.Drawing.Size(40, 34);
            this.txtRanks02.TabIndex = 21;
            this.txtRanks02.Text = "ranks02";
            this.txtRanks02.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // txtTime01
            // 
            this.txtTime01.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime01.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTime01.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime01.Location = new System.Drawing.Point(4, 4);
            this.txtTime01.Name = "txtTime01";
            this.txtTime01.Size = new System.Drawing.Size(67, 13);
            this.txtTime01.TabIndex = 21;
            this.txtTime01.Text = "timeBox01";
            this.txtTime01.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTime02
            // 
            this.txtTime02.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTime02.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTime02.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTime02.Location = new System.Drawing.Point(4, 45);
            this.txtTime02.Name = "txtTime02";
            this.txtTime02.Size = new System.Drawing.Size(67, 13);
            this.txtTime02.TabIndex = 21;
            this.txtTime02.Text = "timeBox02";
            this.txtTime02.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // listJMCwin03
            // 
            this.listJMCwin03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCwin03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCwin03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCwin03.FormattingEnabled = true;
            this.listJMCwin03.ItemHeight = 16;
            this.listJMCwin03.Location = new System.Drawing.Point(228, 86);
            this.listJMCwin03.Name = "listJMCwin03";
            this.listJMCwin03.Size = new System.Drawing.Size(126, 34);
            this.listJMCwin03.TabIndex = 0;
            this.listJMCwin03.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRwin03
            // 
            this.listJCRwin03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRwin03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRwin03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRwin03.FormattingEnabled = true;
            this.listJCRwin03.ItemHeight = 16;
            this.listJCRwin03.Location = new System.Drawing.Point(361, 86);
            this.listJCRwin03.Name = "listJCRwin03";
            this.listJCRwin03.Size = new System.Drawing.Size(113, 34);
            this.listJCRwin03.TabIndex = 9;
            this.listJCRwin03.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listLine06
            // 
            this.listLine06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLine06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLine06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLine06.FormattingEnabled = true;
            this.listLine06.ItemHeight = 16;
            this.listLine06.Location = new System.Drawing.Point(636, 209);
            this.listLine06.Name = "listLine06";
            this.listLine06.Size = new System.Drawing.Size(37, 34);
            this.listLine06.TabIndex = 20;
            // 
            // listScore03
            // 
            this.listScore03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScore03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScore03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listScore03.FormattingEnabled = true;
            this.listScore03.ItemHeight = 16;
            this.listScore03.Location = new System.Drawing.Point(481, 86);
            this.listScore03.Name = "listScore03";
            this.listScore03.Size = new System.Drawing.Size(33, 34);
            this.listScore03.TabIndex = 19;
            // 
            // listJMCspread03
            // 
            this.listJMCspread03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCspread03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCspread03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCspread03.FormattingEnabled = true;
            this.listJMCspread03.ItemHeight = 16;
            this.listJMCspread03.Location = new System.Drawing.Point(521, 86);
            this.listJMCspread03.Name = "listJMCspread03";
            this.listJMCspread03.Size = new System.Drawing.Size(108, 34);
            this.listJMCspread03.TabIndex = 0;
            this.listJMCspread03.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listLine03
            // 
            this.listLine03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLine03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLine03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLine03.FormattingEnabled = true;
            this.listLine03.ItemHeight = 16;
            this.listLine03.Location = new System.Drawing.Point(636, 86);
            this.listLine03.Name = "listLine03";
            this.listLine03.Size = new System.Drawing.Size(37, 34);
            this.listLine03.TabIndex = 20;
            // 
            // listJCRspread03
            // 
            this.listJCRspread03.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRspread03.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRspread03.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRspread03.FormattingEnabled = true;
            this.listJCRspread03.ItemHeight = 16;
            this.listJCRspread03.Location = new System.Drawing.Point(680, 86);
            this.listJCRspread03.Name = "listJCRspread03";
            this.listJCRspread03.Size = new System.Drawing.Size(117, 34);
            this.listJCRspread03.TabIndex = 0;
            this.listJCRspread03.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJMCwin04
            // 
            this.listJMCwin04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCwin04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCwin04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCwin04.FormattingEnabled = true;
            this.listJMCwin04.ItemHeight = 16;
            this.listJMCwin04.Location = new System.Drawing.Point(228, 127);
            this.listJMCwin04.Name = "listJMCwin04";
            this.listJMCwin04.Size = new System.Drawing.Size(126, 34);
            this.listJMCwin04.TabIndex = 0;
            this.listJMCwin04.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJMCwin05
            // 
            this.listJMCwin05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCwin05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCwin05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCwin05.FormattingEnabled = true;
            this.listJMCwin05.ItemHeight = 16;
            this.listJMCwin05.Location = new System.Drawing.Point(228, 168);
            this.listJMCwin05.Name = "listJMCwin05";
            this.listJMCwin05.Size = new System.Drawing.Size(126, 34);
            this.listJMCwin05.TabIndex = 0;
            this.listJMCwin05.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJMCwin06
            // 
            this.listJMCwin06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCwin06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCwin06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCwin06.FormattingEnabled = true;
            this.listJMCwin06.ItemHeight = 16;
            this.listJMCwin06.Location = new System.Drawing.Point(228, 209);
            this.listJMCwin06.Name = "listJMCwin06";
            this.listJMCwin06.Size = new System.Drawing.Size(126, 34);
            this.listJMCwin06.TabIndex = 0;
            this.listJMCwin06.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRwin04
            // 
            this.listJCRwin04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRwin04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRwin04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRwin04.FormattingEnabled = true;
            this.listJCRwin04.ItemHeight = 16;
            this.listJCRwin04.Location = new System.Drawing.Point(361, 127);
            this.listJCRwin04.Name = "listJCRwin04";
            this.listJCRwin04.Size = new System.Drawing.Size(113, 34);
            this.listJCRwin04.TabIndex = 9;
            this.listJCRwin04.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listJMCspread04
            // 
            this.listJMCspread04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCspread04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCspread04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCspread04.FormattingEnabled = true;
            this.listJMCspread04.ItemHeight = 16;
            this.listJMCspread04.Location = new System.Drawing.Point(521, 127);
            this.listJMCspread04.Name = "listJMCspread04";
            this.listJMCspread04.Size = new System.Drawing.Size(108, 34);
            this.listJMCspread04.TabIndex = 0;
            this.listJMCspread04.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listScore04
            // 
            this.listScore04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScore04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScore04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listScore04.FormattingEnabled = true;
            this.listScore04.ItemHeight = 16;
            this.listScore04.Location = new System.Drawing.Point(481, 127);
            this.listScore04.Name = "listScore04";
            this.listScore04.Size = new System.Drawing.Size(33, 34);
            this.listScore04.TabIndex = 19;
            // 
            // listLine04
            // 
            this.listLine04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLine04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLine04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLine04.FormattingEnabled = true;
            this.listLine04.ItemHeight = 16;
            this.listLine04.Location = new System.Drawing.Point(636, 127);
            this.listLine04.Name = "listLine04";
            this.listLine04.Size = new System.Drawing.Size(37, 34);
            this.listLine04.TabIndex = 20;
            // 
            // listJCRspread04
            // 
            this.listJCRspread04.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRspread04.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRspread04.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRspread04.FormattingEnabled = true;
            this.listJCRspread04.ItemHeight = 16;
            this.listJCRspread04.Location = new System.Drawing.Point(680, 127);
            this.listJCRspread04.Name = "listJCRspread04";
            this.listJCRspread04.Size = new System.Drawing.Size(117, 34);
            this.listJCRspread04.TabIndex = 0;
            this.listJCRspread04.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRspread05
            // 
            this.listJCRspread05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRspread05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRspread05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRspread05.FormattingEnabled = true;
            this.listJCRspread05.ItemHeight = 16;
            this.listJCRspread05.Location = new System.Drawing.Point(680, 168);
            this.listJCRspread05.Name = "listJCRspread05";
            this.listJCRspread05.Size = new System.Drawing.Size(117, 34);
            this.listJCRspread05.TabIndex = 0;
            this.listJCRspread05.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJCRspread06
            // 
            this.listJCRspread06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRspread06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRspread06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRspread06.FormattingEnabled = true;
            this.listJCRspread06.ItemHeight = 16;
            this.listJCRspread06.Location = new System.Drawing.Point(680, 209);
            this.listJCRspread06.Name = "listJCRspread06";
            this.listJCRspread06.Size = new System.Drawing.Size(117, 34);
            this.listJCRspread06.TabIndex = 0;
            this.listJCRspread06.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listLine05
            // 
            this.listLine05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listLine05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listLine05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listLine05.FormattingEnabled = true;
            this.listLine05.ItemHeight = 16;
            this.listLine05.Location = new System.Drawing.Point(636, 168);
            this.listLine05.Name = "listLine05";
            this.listLine05.Size = new System.Drawing.Size(37, 34);
            this.listLine05.TabIndex = 20;
            // 
            // listJMCspread05
            // 
            this.listJMCspread05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCspread05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCspread05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCspread05.FormattingEnabled = true;
            this.listJMCspread05.ItemHeight = 16;
            this.listJMCspread05.Location = new System.Drawing.Point(521, 168);
            this.listJMCspread05.Name = "listJMCspread05";
            this.listJMCspread05.Size = new System.Drawing.Size(108, 34);
            this.listJMCspread05.TabIndex = 0;
            this.listJMCspread05.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listJMCspread06
            // 
            this.listJMCspread06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJMCspread06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJMCspread06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJMCspread06.FormattingEnabled = true;
            this.listJMCspread06.ItemHeight = 16;
            this.listJMCspread06.Location = new System.Drawing.Point(521, 209);
            this.listJMCspread06.Name = "listJMCspread06";
            this.listJMCspread06.Size = new System.Drawing.Size(108, 34);
            this.listJMCspread06.TabIndex = 0;
            this.listJMCspread06.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // listScore05
            // 
            this.listScore05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScore05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScore05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listScore05.FormattingEnabled = true;
            this.listScore05.ItemHeight = 16;
            this.listScore05.Location = new System.Drawing.Point(481, 168);
            this.listScore05.Name = "listScore05";
            this.listScore05.Size = new System.Drawing.Size(33, 34);
            this.listScore05.TabIndex = 19;
            // 
            // listScore06
            // 
            this.listScore06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listScore06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listScore06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listScore06.FormattingEnabled = true;
            this.listScore06.ItemHeight = 16;
            this.listScore06.Location = new System.Drawing.Point(481, 209);
            this.listScore06.Name = "listScore06";
            this.listScore06.Size = new System.Drawing.Size(33, 34);
            this.listScore06.TabIndex = 19;
            // 
            // listJCRwin05
            // 
            this.listJCRwin05.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRwin05.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRwin05.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRwin05.FormattingEnabled = true;
            this.listJCRwin05.ItemHeight = 16;
            this.listJCRwin05.Location = new System.Drawing.Point(361, 168);
            this.listJCRwin05.Name = "listJCRwin05";
            this.listJCRwin05.Size = new System.Drawing.Size(113, 34);
            this.listJCRwin05.TabIndex = 9;
            this.listJCRwin05.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // listJCRwin06
            // 
            this.listJCRwin06.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listJCRwin06.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listJCRwin06.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listJCRwin06.FormattingEnabled = true;
            this.listJCRwin06.ItemHeight = 16;
            this.listJCRwin06.Location = new System.Drawing.Point(361, 209);
            this.listJCRwin06.Name = "listJCRwin06";
            this.listJCRwin06.Size = new System.Drawing.Size(113, 34);
            this.listJCRwin06.TabIndex = 9;
            this.listJCRwin06.SelectedIndexChanged += new System.EventHandler(this.listBox2_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1002, 1674);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1002, 1674);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // gameBindingSource
            // 
            this.gameBindingSource.DataMember = "game";
            this.gameBindingSource.DataSource = this.football_picksDataSet;
            // 
            // football_picksDataSet
            // 
            this.football_picksDataSet.DataSetName = "football_picksDataSet";
            this.football_picksDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gameTableAdapter
            // 
            this.gameTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.gameTableAdapter = this.gameTableAdapter;
            this.tableAdapterManager.UpdateOrder = CS_windows_forms_testing.football_picksDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1284, 873);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.btn_ClearSelections);
            this.Controls.Add(this.txt_GamesInMemory);
            this.Controls.Add(this.txt_NumGames);
            this.Controls.Add(this.btn_GetSheetData);
            this.Controls.Add(this.numUD_Sheet);
            this.Controls.Add(this.combo_Year);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.txt_Output);
            this.Controls.Add(this.dateTimePicker1);
            this.MaximumSize = new System.Drawing.Size(1300, 1800);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numUD_Sheet)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gameBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.football_picksDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox txt_Output;
        private System.Windows.Forms.Button btn_Exit;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox combo_Year;
        private System.Windows.Forms.NumericUpDown numUD_Sheet;
        private System.Windows.Forms.Button btn_GetSheetData;
        private System.Windows.Forms.TextBox txt_NumGames;
        private System.Windows.Forms.TextBox txt_GamesInMemory;
        private System.Windows.Forms.Button btn_ClearSelections;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private football_picksDataSet football_picksDataSet;
        private System.Windows.Forms.BindingSource gameBindingSource;
        private football_picksDataSetTableAdapters.gameTableAdapter gameTableAdapter;
        private football_picksDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ListBox listJMCwin01;
        private System.Windows.Forms.ListBox listJMCwin02;
        private System.Windows.Forms.TextBox txtTeams06;
        private System.Windows.Forms.ListBox listJCRwin01;
        private System.Windows.Forms.TextBox txtTeams05;
        private System.Windows.Forms.TextBox txtRanks06;
        private System.Windows.Forms.TextBox txtTeams04;
        private System.Windows.Forms.ListBox listScore01;
        private System.Windows.Forms.TextBox txtTeams03;
        private System.Windows.Forms.ListBox listJMCspread01;
        private System.Windows.Forms.TextBox txtRanks05;
        private System.Windows.Forms.ListBox listLine01;
        private System.Windows.Forms.ListBox listJCRspread01;
        private System.Windows.Forms.TextBox txtRanks04;
        private System.Windows.Forms.ListBox listJCRwin02;
        private System.Windows.Forms.ListBox listScore02;
        private System.Windows.Forms.TextBox txtRanks03;
        private System.Windows.Forms.TextBox txtTime06;
        private System.Windows.Forms.ListBox listJMCspread02;
        private System.Windows.Forms.ListBox listLine02;
        private System.Windows.Forms.TextBox txtTime05;
        private System.Windows.Forms.ListBox listJCRspread02;
        private System.Windows.Forms.TextBox txtTime04;
        private System.Windows.Forms.TextBox txtTeams01;
        private System.Windows.Forms.TextBox txtTime03;
        private System.Windows.Forms.TextBox txtTeams02;
        private System.Windows.Forms.TextBox txtRanks01;
        private System.Windows.Forms.TextBox txtRanks02;
        private System.Windows.Forms.TextBox txtTime01;
        private System.Windows.Forms.TextBox txtTime02;
        private System.Windows.Forms.ListBox listJMCwin03;
        private System.Windows.Forms.ListBox listJCRwin03;
        private System.Windows.Forms.ListBox listLine06;
        private System.Windows.Forms.ListBox listScore03;
        private System.Windows.Forms.ListBox listJMCspread03;
        private System.Windows.Forms.ListBox listLine03;
        private System.Windows.Forms.ListBox listJCRspread03;
        private System.Windows.Forms.ListBox listJMCwin04;
        private System.Windows.Forms.ListBox listJMCwin05;
        private System.Windows.Forms.ListBox listJMCwin06;
        private System.Windows.Forms.ListBox listJCRwin04;
        private System.Windows.Forms.ListBox listJMCspread04;
        private System.Windows.Forms.ListBox listScore04;
        private System.Windows.Forms.ListBox listLine04;
        private System.Windows.Forms.ListBox listJCRspread04;
        private System.Windows.Forms.ListBox listJCRspread05;
        private System.Windows.Forms.ListBox listJCRspread06;
        private System.Windows.Forms.ListBox listLine05;
        private System.Windows.Forms.ListBox listJMCspread05;
        private System.Windows.Forms.ListBox listJMCspread06;
        private System.Windows.Forms.ListBox listScore05;
        private System.Windows.Forms.ListBox listScore06;
        private System.Windows.Forms.ListBox listJCRwin05;
        private System.Windows.Forms.ListBox listJCRwin06;
    }
}

