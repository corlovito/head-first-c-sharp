namespace PartyPlanner_Ch6_Mods
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDinnerTab = new System.Windows.Forms.TabPage();
            this.label2 = new System.Windows.Forms.Label();
            this.labelDinnerCost = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxDinnerHealthy = new System.Windows.Forms.CheckBox();
            this.checkBoxDinnerFancy = new System.Windows.Forms.CheckBox();
            this.numericUpDownDinner = new System.Windows.Forms.NumericUpDown();
            this.tabBirthdayTab = new System.Windows.Forms.TabPage();
            this.textBoxCakeWriting = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelBirthdayCost = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.checkBoxBirthdayFancy = new System.Windows.Forms.CheckBox();
            this.numericUpDownBirthday = new System.Windows.Forms.NumericUpDown();
            this.tabControl1.SuspendLayout();
            this.tabDinnerTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDinner)).BeginInit();
            this.tabBirthdayTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDinnerTab);
            this.tabControl1.Controls.Add(this.tabBirthdayTab);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(284, 262);
            this.tabControl1.TabIndex = 0;
            // 
            // tabDinnerTab
            // 
            this.tabDinnerTab.Controls.Add(this.label2);
            this.tabDinnerTab.Controls.Add(this.labelDinnerCost);
            this.tabDinnerTab.Controls.Add(this.label1);
            this.tabDinnerTab.Controls.Add(this.checkBoxDinnerHealthy);
            this.tabDinnerTab.Controls.Add(this.checkBoxDinnerFancy);
            this.tabDinnerTab.Controls.Add(this.numericUpDownDinner);
            this.tabDinnerTab.Location = new System.Drawing.Point(4, 22);
            this.tabDinnerTab.Name = "tabDinnerTab";
            this.tabDinnerTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabDinnerTab.Size = new System.Drawing.Size(276, 236);
            this.tabDinnerTab.TabIndex = 0;
            this.tabDinnerTab.Text = "Dinner Party";
            this.tabDinnerTab.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(79, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Number of People";
            // 
            // labelDinnerCost
            // 
            this.labelDinnerCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelDinnerCost.Location = new System.Drawing.Point(120, 157);
            this.labelDinnerCost.Name = "labelDinnerCost";
            this.labelDinnerCost.Size = new System.Drawing.Size(70, 15);
            this.labelDinnerCost.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 158);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cost";
            // 
            // checkBoxDinnerHealthy
            // 
            this.checkBoxDinnerHealthy.AutoSize = true;
            this.checkBoxDinnerHealthy.Location = new System.Drawing.Point(82, 127);
            this.checkBoxDinnerHealthy.Name = "checkBoxDinnerHealthy";
            this.checkBoxDinnerHealthy.Size = new System.Drawing.Size(96, 17);
            this.checkBoxDinnerHealthy.TabIndex = 8;
            this.checkBoxDinnerHealthy.Text = "Healthy Option";
            this.checkBoxDinnerHealthy.UseVisualStyleBackColor = true;
            this.checkBoxDinnerHealthy.CheckedChanged += new System.EventHandler(this.checkBoxDinnerHealthy_CheckedChanged);
            // 
            // checkBoxDinnerFancy
            // 
            this.checkBoxDinnerFancy.AutoSize = true;
            this.checkBoxDinnerFancy.Location = new System.Drawing.Point(82, 104);
            this.checkBoxDinnerFancy.Name = "checkBoxDinnerFancy";
            this.checkBoxDinnerFancy.Size = new System.Drawing.Size(115, 17);
            this.checkBoxDinnerFancy.TabIndex = 7;
            this.checkBoxDinnerFancy.Text = "Fancy Decorations";
            this.checkBoxDinnerFancy.UseVisualStyleBackColor = true;
            this.checkBoxDinnerFancy.CheckedChanged += new System.EventHandler(this.checkBoxDinnerFancy_CheckedChanged);
            // 
            // numericUpDownDinner
            // 
            this.numericUpDownDinner.Location = new System.Drawing.Point(82, 78);
            this.numericUpDownDinner.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownDinner.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownDinner.Name = "numericUpDownDinner";
            this.numericUpDownDinner.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownDinner.TabIndex = 6;
            this.numericUpDownDinner.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownDinner.ValueChanged += new System.EventHandler(this.numericUpDownDinner_ValueChanged);
            // 
            // tabBirthdayTab
            // 
            this.tabBirthdayTab.Controls.Add(this.textBoxCakeWriting);
            this.tabBirthdayTab.Controls.Add(this.label4);
            this.tabBirthdayTab.Controls.Add(this.label3);
            this.tabBirthdayTab.Controls.Add(this.labelBirthdayCost);
            this.tabBirthdayTab.Controls.Add(this.label5);
            this.tabBirthdayTab.Controls.Add(this.checkBoxBirthdayFancy);
            this.tabBirthdayTab.Controls.Add(this.numericUpDownBirthday);
            this.tabBirthdayTab.Location = new System.Drawing.Point(4, 22);
            this.tabBirthdayTab.Name = "tabBirthdayTab";
            this.tabBirthdayTab.Padding = new System.Windows.Forms.Padding(3);
            this.tabBirthdayTab.Size = new System.Drawing.Size(276, 236);
            this.tabBirthdayTab.TabIndex = 1;
            this.tabBirthdayTab.Text = "Birthday Party";
            this.tabBirthdayTab.UseVisualStyleBackColor = true;
            // 
            // textBoxCakeWriting
            // 
            this.textBoxCakeWriting.Location = new System.Drawing.Point(82, 145);
            this.textBoxCakeWriting.Name = "textBoxCakeWriting";
            this.textBoxCakeWriting.Size = new System.Drawing.Size(106, 20);
            this.textBoxCakeWriting.TabIndex = 19;
            this.textBoxCakeWriting.TextChanged += new System.EventHandler(this.textBoxCakeWriting_TextChanged);
  //          this.textBoxCakeWriting.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBoxCakeWriting_KeyDown);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(79, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Cake Writing";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Number of People";
            // 
            // labelBirthdayCost
            // 
            this.labelBirthdayCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelBirthdayCost.Location = new System.Drawing.Point(120, 173);
            this.labelBirthdayCost.Name = "labelBirthdayCost";
            this.labelBirthdayCost.Size = new System.Drawing.Size(70, 15);
            this.labelBirthdayCost.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 174);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Cost";
            // 
            // checkBoxBirthdayFancy
            // 
            this.checkBoxBirthdayFancy.AutoSize = true;
            this.checkBoxBirthdayFancy.Location = new System.Drawing.Point(82, 104);
            this.checkBoxBirthdayFancy.Name = "checkBoxBirthdayFancy";
            this.checkBoxBirthdayFancy.Size = new System.Drawing.Size(115, 17);
            this.checkBoxBirthdayFancy.TabIndex = 13;
            this.checkBoxBirthdayFancy.Text = "Fancy Decorations";
            this.checkBoxBirthdayFancy.UseVisualStyleBackColor = true;
            this.checkBoxBirthdayFancy.CheckedChanged += new System.EventHandler(this.checkBoxBirthdayFancy_CheckedChanged);
            // 
            // numericUpDownBirthday
            // 
            this.numericUpDownBirthday.Location = new System.Drawing.Point(82, 78);
            this.numericUpDownBirthday.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDownBirthday.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownBirthday.Name = "numericUpDownBirthday";
            this.numericUpDownBirthday.Size = new System.Drawing.Size(96, 20);
            this.numericUpDownBirthday.TabIndex = 12;
            this.numericUpDownBirthday.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownBirthday.ValueChanged += new System.EventHandler(this.numericUpDownBirthday_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Party Planner 2.0";
            this.tabControl1.ResumeLayout(false);
            this.tabDinnerTab.ResumeLayout(false);
            this.tabDinnerTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDinner)).EndInit();
            this.tabBirthdayTab.ResumeLayout(false);
            this.tabBirthdayTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownBirthday)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabDinnerTab;
        private System.Windows.Forms.TabPage tabBirthdayTab;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelDinnerCost;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox checkBoxDinnerHealthy;
        private System.Windows.Forms.CheckBox checkBoxDinnerFancy;
        private System.Windows.Forms.NumericUpDown numericUpDownDinner;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label labelBirthdayCost;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox checkBoxBirthdayFancy;
        private System.Windows.Forms.NumericUpDown numericUpDownBirthday;
        private System.Windows.Forms.TextBox textBoxCakeWriting;
        private System.Windows.Forms.Label label4;
    }
}

