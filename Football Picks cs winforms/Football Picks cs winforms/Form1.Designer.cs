namespace Football_Picks_cs_winforms
{
    partial class MainForm
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
            this.btn_printstats = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_readdata = new System.Windows.Forms.Button();
            this.lbl_gamesinmemory = new System.Windows.Forms.Label();
            this.btn_clearMemory = new System.Windows.Forms.Button();
            this.btn_clearOutput = new System.Windows.Forms.Button();
            this.btn_GameForm = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_printstats
            // 
            this.btn_printstats.Location = new System.Drawing.Point(12, 289);
            this.btn_printstats.Name = "btn_printstats";
            this.btn_printstats.Size = new System.Drawing.Size(123, 23);
            this.btn_printstats.TabIndex = 0;
            this.btn_printstats.Text = "Print Statistics";
            this.btn_printstats.UseVisualStyleBackColor = true;
            this.btn_printstats.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutput.Location = new System.Drawing.Point(394, 27);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOutput.Size = new System.Drawing.Size(729, 476);
            this.txtOutput.TabIndex = 1;
            this.txtOutput.TextChanged += new System.EventHandler(this.txtOutput_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Maroon;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1135, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.BackColor = System.Drawing.Color.Maroon;
            this.exitToolStripMenuItem.ForeColor = System.Drawing.Color.White;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(92, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_readdata
            // 
            this.btn_readdata.Location = new System.Drawing.Point(12, 260);
            this.btn_readdata.Name = "btn_readdata";
            this.btn_readdata.Size = new System.Drawing.Size(123, 23);
            this.btn_readdata.TabIndex = 3;
            this.btn_readdata.Text = "Read Data File";
            this.btn_readdata.UseVisualStyleBackColor = true;
            this.btn_readdata.Click += new System.EventHandler(this.btn_readdata_Click);
            // 
            // lbl_gamesinmemory
            // 
            this.lbl_gamesinmemory.Location = new System.Drawing.Point(220, 486);
            this.lbl_gamesinmemory.Name = "lbl_gamesinmemory";
            this.lbl_gamesinmemory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lbl_gamesinmemory.Size = new System.Drawing.Size(168, 17);
            this.lbl_gamesinmemory.TabIndex = 4;
            this.lbl_gamesinmemory.Text = "Games in Memory: 0";
            this.lbl_gamesinmemory.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lbl_gamesinmemory.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_clearMemory
            // 
            this.btn_clearMemory.Location = new System.Drawing.Point(12, 318);
            this.btn_clearMemory.Name = "btn_clearMemory";
            this.btn_clearMemory.Size = new System.Drawing.Size(123, 23);
            this.btn_clearMemory.TabIndex = 5;
            this.btn_clearMemory.Text = "Clear Memory";
            this.btn_clearMemory.UseVisualStyleBackColor = true;
            this.btn_clearMemory.Click += new System.EventHandler(this.btn_clearMemory_Click);
            // 
            // btn_clearOutput
            // 
            this.btn_clearOutput.Location = new System.Drawing.Point(313, 460);
            this.btn_clearOutput.Name = "btn_clearOutput";
            this.btn_clearOutput.Size = new System.Drawing.Size(75, 23);
            this.btn_clearOutput.TabIndex = 6;
            this.btn_clearOutput.Text = "Clear Output";
            this.btn_clearOutput.UseVisualStyleBackColor = true;
            this.btn_clearOutput.Click += new System.EventHandler(this.btn_clearOutput_Click);
            // 
            // btn_GameForm
            // 
            this.btn_GameForm.Location = new System.Drawing.Point(168, 76);
            this.btn_GameForm.Name = "btn_GameForm";
            this.btn_GameForm.Size = new System.Drawing.Size(75, 23);
            this.btn_GameForm.TabIndex = 7;
            this.btn_GameForm.Text = "Game Form";
            this.btn_GameForm.UseVisualStyleBackColor = true;
            this.btn_GameForm.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 515);
            this.Controls.Add(this.btn_GameForm);
            this.Controls.Add(this.btn_clearOutput);
            this.Controls.Add(this.btn_clearMemory);
            this.Controls.Add(this.lbl_gamesinmemory);
            this.Controls.Add(this.btn_readdata);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.btn_printstats);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.Text = "Jason & Jenn Football Picks";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_printstats;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_readdata;
        private System.Windows.Forms.Label lbl_gamesinmemory;
        private System.Windows.Forms.Button btn_clearMemory;
        private System.Windows.Forms.Button btn_clearOutput;
        private System.Windows.Forms.Button btn_GameForm;
    }
}

