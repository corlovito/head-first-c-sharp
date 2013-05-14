namespace BeehiveSimulatorCh6_Part2
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
            this.buttonNextShift = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAssignJob = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.numericUpDownShifts = new System.Windows.Forms.NumericUpDown();
            this.comboBoxWorkerBeeJob = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBoxReport = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonNextShift
            // 
            this.buttonNextShift.Location = new System.Drawing.Point(259, 34);
            this.buttonNextShift.Name = "buttonNextShift";
            this.buttonNextShift.Size = new System.Drawing.Size(80, 70);
            this.buttonNextShift.TabIndex = 0;
            this.buttonNextShift.Text = "Work Next Shift";
            this.buttonNextShift.UseVisualStyleBackColor = true;
            this.buttonNextShift.Click += new System.EventHandler(this.buttonNextShift_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAssignJob);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.numericUpDownShifts);
            this.groupBox1.Controls.Add(this.comboBoxWorkerBeeJob);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(231, 105);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Worker Bee Assignments";
            // 
            // buttonAssignJob
            // 
            this.buttonAssignJob.Location = new System.Drawing.Point(6, 69);
            this.buttonAssignJob.Name = "buttonAssignJob";
            this.buttonAssignJob.Size = new System.Drawing.Size(121, 23);
            this.buttonAssignJob.TabIndex = 4;
            this.buttonAssignJob.Text = "Assign Job";
            this.buttonAssignJob.UseVisualStyleBackColor = true;
            this.buttonAssignJob.Click += new System.EventHandler(this.buttonAssignJob_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Shifts";
            // 
            // numericUpDownShifts
            // 
            this.numericUpDownShifts.Location = new System.Drawing.Point(157, 42);
            this.numericUpDownShifts.Name = "numericUpDownShifts";
            this.numericUpDownShifts.Size = new System.Drawing.Size(66, 20);
            this.numericUpDownShifts.TabIndex = 2;
            // 
            // comboBoxWorkerBeeJob
            // 
            this.comboBoxWorkerBeeJob.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxWorkerBeeJob.FormattingEnabled = true;
            this.comboBoxWorkerBeeJob.Items.AddRange(new object[] {
            "Nectar collector",
            "Honey manufacturing",
            "Egg care",
            "Baby bee tutoring",
            "Hive maintenance",
            "Sting patrol"});
            this.comboBoxWorkerBeeJob.Location = new System.Drawing.Point(6, 41);
            this.comboBoxWorkerBeeJob.Name = "comboBoxWorkerBeeJob";
            this.comboBoxWorkerBeeJob.Size = new System.Drawing.Size(121, 21);
            this.comboBoxWorkerBeeJob.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Job";
            // 
            // textBoxReport
            // 
            this.textBoxReport.Location = new System.Drawing.Point(12, 123);
            this.textBoxReport.Multiline = true;
            this.textBoxReport.Name = "textBoxReport";
            this.textBoxReport.Size = new System.Drawing.Size(469, 209);
            this.textBoxReport.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(493, 344);
            this.Controls.Add(this.textBoxReport);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonNextShift);
            this.Name = "Form1";
            this.Text = "Beehive Management System";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownShifts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonNextShift;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAssignJob;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown numericUpDownShifts;
        private System.Windows.Forms.ComboBox comboBoxWorkerBeeJob;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxReport;
    }
}

