namespace Excel2Text
{
    partial class String2CSV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(String2CSV));
            this.textBoxHexValues = new System.Windows.Forms.RichTextBox();
            this.textBoxCSV = new System.Windows.Forms.RichTextBox();
            this.labelIndexValue = new System.Windows.Forms.Label();
            this.labelCSVFile = new System.Windows.Forms.Label();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.buttonSaveCSVFile = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBoxFloating = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBoxHexValues
            // 
            this.textBoxHexValues.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBoxHexValues.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxHexValues.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxHexValues.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxHexValues.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxHexValues.Location = new System.Drawing.Point(0, 0);
            this.textBoxHexValues.Name = "textBoxHexValues";
            this.textBoxHexValues.ReadOnly = true;
            this.textBoxHexValues.Size = new System.Drawing.Size(251, 462);
            this.textBoxHexValues.TabIndex = 0;
            this.textBoxHexValues.Text = "";
            // 
            // textBoxCSV
            // 
            this.textBoxCSV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.textBoxCSV.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxCSV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxCSV.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxCSV.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.textBoxCSV.Location = new System.Drawing.Point(0, 0);
            this.textBoxCSV.Name = "textBoxCSV";
            this.textBoxCSV.ReadOnly = true;
            this.textBoxCSV.Size = new System.Drawing.Size(541, 462);
            this.textBoxCSV.TabIndex = 1;
            this.textBoxCSV.Text = "";
            // 
            // labelIndexValue
            // 
            this.labelIndexValue.AutoSize = true;
            this.labelIndexValue.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelIndexValue.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.labelIndexValue.Location = new System.Drawing.Point(1, 9);
            this.labelIndexValue.Name = "labelIndexValue";
            this.labelIndexValue.Size = new System.Drawing.Size(93, 15);
            this.labelIndexValue.TabIndex = 2;
            this.labelIndexValue.Text = "Indexed Values";
            // 
            // labelCSVFile
            // 
            this.labelCSVFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelCSVFile.AutoSize = true;
            this.labelCSVFile.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCSVFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.labelCSVFile.Location = new System.Drawing.Point(743, 9);
            this.labelCSVFile.Name = "labelCSVFile";
            this.labelCSVFile.Size = new System.Drawing.Size(53, 15);
            this.labelCSVFile.TabIndex = 3;
            this.labelCSVFile.Text = "CSV File";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(1, 26);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.textBoxHexValues);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.textBoxCSV);
            this.splitContainer1.Size = new System.Drawing.Size(796, 462);
            this.splitContainer1.SplitterDistance = 251;
            this.splitContainer1.TabIndex = 4;
            // 
            // buttonSaveCSVFile
            // 
            this.buttonSaveCSVFile.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveCSVFile.Location = new System.Drawing.Point(704, 490);
            this.buttonSaveCSVFile.Name = "buttonSaveCSVFile";
            this.buttonSaveCSVFile.Size = new System.Drawing.Size(94, 25);
            this.buttonSaveCSVFile.TabIndex = 4;
            this.buttonSaveCSVFile.Text = "Save CSV file";
            this.buttonSaveCSVFile.UseVisualStyleBackColor = true;
            this.buttonSaveCSVFile.Click += new System.EventHandler(this.buttonSaveCSVFile_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.FileName = "csv.txt";
            this.saveFileDialog.Filter = "Text file (*.txt)|*.txt";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(202)))), ((int)(((byte)(82)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.checkBoxFloating);
            this.panel1.Location = new System.Drawing.Point(1, 488);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(809, 28);
            this.panel1.TabIndex = 5;
            // 
            // checkBoxFloating
            // 
            this.checkBoxFloating.AutoSize = true;
            this.checkBoxFloating.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxFloating.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.checkBoxFloating.Location = new System.Drawing.Point(1, 7);
            this.checkBoxFloating.Name = "checkBoxFloating";
            this.checkBoxFloating.Size = new System.Drawing.Size(166, 18);
            this.checkBoxFloating.TabIndex = 6;
            this.checkBoxFloating.Text = "Float to Short Conversion";
            this.checkBoxFloating.UseVisualStyleBackColor = true;
            this.checkBoxFloating.CheckedChanged += new System.EventHandler(this.checkBoxFloating_CheckedChanged);
            // 
            // String2CSV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ClientSize = new System.Drawing.Size(801, 516);
            this.Controls.Add(this.labelIndexValue);
            this.Controls.Add(this.labelCSVFile);
            this.Controls.Add(this.buttonSaveCSVFile);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(600, 535);
            this.Name = "String2CSV";
            this.Text = "String2CSV";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox textBoxHexValues;
        private System.Windows.Forms.RichTextBox textBoxCSV;
        private System.Windows.Forms.Label labelIndexValue;
        private System.Windows.Forms.Label labelCSVFile;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button buttonSaveCSVFile;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBoxFloating;
    }
}