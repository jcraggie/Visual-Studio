namespace CSfileCopierJCR
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
            this.source_lbl = new System.Windows.Forms.Label();
            this.target_lbl = new System.Windows.Forms.Label();
            this.status_lbl = new System.Windows.Forms.Label();
            this.clear_btn = new System.Windows.Forms.Button();
            this.copy_btn = new System.Windows.Forms.Button();
            this.delete_btn = new System.Windows.Forms.Button();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.overwrite_chk = new System.Windows.Forms.CheckBox();
            this.targetdir_txt = new System.Windows.Forms.TextBox();
            this.source_tvw = new System.Windows.Forms.TreeView();
            this.target_tvw = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // source_lbl
            // 
            this.source_lbl.AutoSize = true;
            this.source_lbl.Location = new System.Drawing.Point(13, 13);
            this.source_lbl.Name = "source_lbl";
            this.source_lbl.Size = new System.Drawing.Size(65, 13);
            this.source_lbl.TabIndex = 0;
            this.source_lbl.Text = "Source Files";
            // 
            // target_lbl
            // 
            this.target_lbl.AutoSize = true;
            this.target_lbl.Location = new System.Drawing.Point(290, 13);
            this.target_lbl.Name = "target_lbl";
            this.target_lbl.Size = new System.Drawing.Size(62, 13);
            this.target_lbl.TabIndex = 1;
            this.target_lbl.Text = "Target Files";
            // 
            // status_lbl
            // 
            this.status_lbl.AutoSize = true;
            this.status_lbl.Location = new System.Drawing.Point(13, 434);
            this.status_lbl.Name = "status_lbl";
            this.status_lbl.Size = new System.Drawing.Size(37, 13);
            this.status_lbl.TabIndex = 2;
            this.status_lbl.Text = "Status";
            // 
            // clear_btn
            // 
            this.clear_btn.Location = new System.Drawing.Point(16, 358);
            this.clear_btn.Name = "clear_btn";
            this.clear_btn.Size = new System.Drawing.Size(75, 23);
            this.clear_btn.TabIndex = 3;
            this.clear_btn.Text = "Clear";
            this.clear_btn.UseVisualStyleBackColor = true;
            // 
            // copy_btn
            // 
            this.copy_btn.Location = new System.Drawing.Point(507, 356);
            this.copy_btn.Name = "copy_btn";
            this.copy_btn.Size = new System.Drawing.Size(75, 23);
            this.copy_btn.TabIndex = 4;
            this.copy_btn.Text = "Copy";
            this.copy_btn.UseVisualStyleBackColor = true;
            // 
            // delete_btn
            // 
            this.delete_btn.Location = new System.Drawing.Point(507, 385);
            this.delete_btn.Name = "delete_btn";
            this.delete_btn.Size = new System.Drawing.Size(75, 23);
            this.delete_btn.TabIndex = 5;
            this.delete_btn.Text = "Delete";
            this.delete_btn.UseVisualStyleBackColor = true;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(507, 414);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 6;
            this.cancel_btn.Text = "Cancel";
            this.cancel_btn.UseVisualStyleBackColor = true;
            this.cancel_btn.Click += new System.EventHandler(this.cancel_btn_Click);
            // 
            // overwrite_chk
            // 
            this.overwrite_chk.AutoSize = true;
            this.overwrite_chk.Location = new System.Drawing.Point(293, 356);
            this.overwrite_chk.Name = "overwrite_chk";
            this.overwrite_chk.Size = new System.Drawing.Size(110, 17);
            this.overwrite_chk.TabIndex = 7;
            this.overwrite_chk.Text = "Overwrite If Exists";
            this.overwrite_chk.UseVisualStyleBackColor = true;
            // 
            // targetdir_txt
            // 
            this.targetdir_txt.Location = new System.Drawing.Point(293, 32);
            this.targetdir_txt.Multiline = true;
            this.targetdir_txt.Name = "targetdir_txt";
            this.targetdir_txt.Size = new System.Drawing.Size(289, 24);
            this.targetdir_txt.TabIndex = 8;
            this.targetdir_txt.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // source_tvw
            // 
            this.source_tvw.Location = new System.Drawing.Point(13, 32);
            this.source_tvw.Name = "source_tvw";
            this.source_tvw.Size = new System.Drawing.Size(274, 319);
            this.source_tvw.TabIndex = 9;
            // 
            // target_tvw
            // 
            this.target_tvw.Location = new System.Drawing.Point(293, 62);
            this.target_tvw.Name = "target_tvw";
            this.target_tvw.Size = new System.Drawing.Size(288, 288);
            this.target_tvw.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(594, 539);
            this.Controls.Add(this.target_tvw);
            this.Controls.Add(this.source_tvw);
            this.Controls.Add(this.targetdir_txt);
            this.Controls.Add(this.overwrite_chk);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.delete_btn);
            this.Controls.Add(this.copy_btn);
            this.Controls.Add(this.clear_btn);
            this.Controls.Add(this.status_lbl);
            this.Controls.Add(this.target_lbl);
            this.Controls.Add(this.source_lbl);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label source_lbl;
        private System.Windows.Forms.Label target_lbl;
        private System.Windows.Forms.Label status_lbl;
        private System.Windows.Forms.Button clear_btn;
        private System.Windows.Forms.Button copy_btn;
        private System.Windows.Forms.Button delete_btn;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.CheckBox overwrite_chk;
        private System.Windows.Forms.TextBox targetdir_txt;
        private System.Windows.Forms.TreeView source_tvw;
        private System.Windows.Forms.TreeView target_tvw;
    }
}

