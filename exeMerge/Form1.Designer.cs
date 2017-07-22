namespace exeMerge
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
            this.btn_display_file = new System.Windows.Forms.Button();
            this.chk_framework = new System.Windows.Forms.CheckedListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_display_file = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_background_file = new System.Windows.Forms.TextBox();
            this.btn_background_file = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_outpot_file = new System.Windows.Forms.TextBox();
            this.btn_outpot_file = new System.Windows.Forms.Button();
            this.btn_merge_files = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lbl_error = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chk_display_export = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chk_background_export = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_display_file
            // 
            this.btn_display_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_display_file.Location = new System.Drawing.Point(281, 34);
            this.btn_display_file.Name = "btn_display_file";
            this.btn_display_file.Size = new System.Drawing.Size(62, 23);
            this.btn_display_file.TabIndex = 0;
            this.btn_display_file.Text = "Browse";
            this.btn_display_file.UseVisualStyleBackColor = true;
            this.btn_display_file.Click += new System.EventHandler(this.btn_display_file_Click);
            // 
            // chk_framework
            // 
            this.chk_framework.CheckOnClick = true;
            this.chk_framework.FormattingEnabled = true;
            this.chk_framework.Location = new System.Drawing.Point(11, 25);
            this.chk_framework.Name = "chk_framework";
            this.chk_framework.Size = new System.Drawing.Size(350, 139);
            this.chk_framework.TabIndex = 1;
            this.chk_framework.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chk_framework_ItemCheck);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Framework:";
            // 
            // txb_display_file
            // 
            this.txb_display_file.Enabled = false;
            this.txb_display_file.Location = new System.Drawing.Point(10, 36);
            this.txb_display_file.Name = "txb_display_file";
            this.txb_display_file.Size = new System.Drawing.Size(265, 20);
            this.txb_display_file.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Execute File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(6, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Execute File";
            // 
            // txb_background_file
            // 
            this.txb_background_file.Enabled = false;
            this.txb_background_file.Location = new System.Drawing.Point(9, 37);
            this.txb_background_file.Name = "txb_background_file";
            this.txb_background_file.Size = new System.Drawing.Size(264, 20);
            this.txb_background_file.TabIndex = 5;
            // 
            // btn_background_file
            // 
            this.btn_background_file.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.btn_background_file.Location = new System.Drawing.Point(279, 34);
            this.btn_background_file.Name = "btn_background_file";
            this.btn_background_file.Size = new System.Drawing.Size(62, 23);
            this.btn_background_file.TabIndex = 7;
            this.btn_background_file.Text = "Browse";
            this.btn_background_file.UseVisualStyleBackColor = true;
            this.btn_background_file.Click += new System.EventHandler(this.btn_background_file_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Output File";
            // 
            // txb_outpot_file
            // 
            this.txb_outpot_file.Enabled = false;
            this.txb_outpot_file.Location = new System.Drawing.Point(23, 431);
            this.txb_outpot_file.Name = "txb_outpot_file";
            this.txb_outpot_file.Size = new System.Drawing.Size(264, 20);
            this.txb_outpot_file.TabIndex = 8;
            // 
            // btn_outpot_file
            // 
            this.btn_outpot_file.Location = new System.Drawing.Point(293, 429);
            this.btn_outpot_file.Name = "btn_outpot_file";
            this.btn_outpot_file.Size = new System.Drawing.Size(62, 23);
            this.btn_outpot_file.TabIndex = 10;
            this.btn_outpot_file.Text = "Browse";
            this.btn_outpot_file.UseVisualStyleBackColor = true;
            this.btn_outpot_file.Click += new System.EventHandler(this.btn_outpot_file_Click);
            // 
            // btn_merge_files
            // 
            this.btn_merge_files.Location = new System.Drawing.Point(22, 457);
            this.btn_merge_files.Name = "btn_merge_files";
            this.btn_merge_files.Size = new System.Drawing.Size(75, 23);
            this.btn_merge_files.TabIndex = 11;
            this.btn_merge_files.Text = "Merge";
            this.btn_merge_files.UseVisualStyleBackColor = true;
            this.btn_merge_files.Click += new System.EventHandler(this.btn_merge_files_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Exe | *.exe";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Exe | *.exe";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lbl_error});
            this.statusStrip1.Location = new System.Drawing.Point(0, 488);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(369, 22);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lbl_error
            // 
            this.lbl_error.ForeColor = System.Drawing.Color.Red;
            this.lbl_error.Name = "lbl_error";
            this.lbl_error.Size = new System.Drawing.Size(118, 17);
            this.lbl_error.Text = "toolStripStatusLabel1";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chk_display_export);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txb_display_file);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btn_display_file);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox1.Location = new System.Drawing.Point(12, 170);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(349, 118);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Display";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label5.Location = new System.Drawing.Point(7, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Export Folder";
            // 
            // chk_display_export
            // 
            this.chk_display_export.FormattingEnabled = true;
            this.chk_display_export.Location = new System.Drawing.Point(10, 76);
            this.chk_display_export.Name = "chk_display_export";
            this.chk_display_export.Size = new System.Drawing.Size(265, 21);
            this.chk_display_export.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chk_background_export);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.txb_background_file);
            this.groupBox2.Controls.Add(this.btn_background_file);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.groupBox2.Location = new System.Drawing.Point(14, 294);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(347, 118);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Background";
            // 
            // chk_background_export
            // 
            this.chk_background_export.FormattingEnabled = true;
            this.chk_background_export.Location = new System.Drawing.Point(9, 76);
            this.chk_background_export.Name = "chk_background_export";
            this.chk_background_export.Size = new System.Drawing.Size(265, 21);
            this.chk_background_export.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label6.Location = new System.Drawing.Point(6, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Export Folder";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(369, 510);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btn_merge_files);
            this.Controls.Add(this.btn_outpot_file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_outpot_file);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chk_framework);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = " .Net Merge Exe";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_display_file;
        private System.Windows.Forms.CheckedListBox chk_framework;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_display_file;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_background_file;
        private System.Windows.Forms.Button btn_background_file;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_outpot_file;
        private System.Windows.Forms.Button btn_outpot_file;
        private System.Windows.Forms.Button btn_merge_files;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lbl_error;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox chk_display_export;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox chk_background_export;
        private System.Windows.Forms.Label label6;
    }
}

