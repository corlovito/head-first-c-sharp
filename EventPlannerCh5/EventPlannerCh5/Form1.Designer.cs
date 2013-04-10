namespace EventPlannerCh5
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
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxFancy = new System.Windows.Forms.CheckBox();
            this.checkBoxHealthy = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.labelCost = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number of People";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 41);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(89, 20);
            this.numericUpDown1.TabIndex = 1;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // checkBoxFancy
            // 
            this.checkBoxFancy.AutoSize = true;
            this.checkBoxFancy.Checked = true;
            this.checkBoxFancy.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBoxFancy.Location = new System.Drawing.Point(27, 67);
            this.checkBoxFancy.Name = "checkBoxFancy";
            this.checkBoxFancy.Size = new System.Drawing.Size(115, 17);
            this.checkBoxFancy.TabIndex = 2;
            this.checkBoxFancy.Text = "Fancy Decorations";
            this.checkBoxFancy.UseVisualStyleBackColor = true;
            this.checkBoxFancy.CheckedChanged += new System.EventHandler(this.checkBoxFancy_CheckedChanged);
            // 
            // checkBoxHealthy
            // 
            this.checkBoxHealthy.AutoSize = true;
            this.checkBoxHealthy.Location = new System.Drawing.Point(27, 91);
            this.checkBoxHealthy.Name = "checkBoxHealthy";
            this.checkBoxHealthy.Size = new System.Drawing.Size(96, 17);
            this.checkBoxHealthy.TabIndex = 3;
            this.checkBoxHealthy.Text = "Healthy Option";
            this.checkBoxHealthy.UseVisualStyleBackColor = true;
            this.checkBoxHealthy.CheckedChanged += new System.EventHandler(this.checkBoxHealthy_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Cost";
            // 
            // labelCost
            // 
            this.labelCost.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelCost.Location = new System.Drawing.Point(62, 123);
            this.labelCost.Name = "labelCost";
            this.labelCost.Size = new System.Drawing.Size(80, 20);
            this.labelCost.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(169, 176);
            this.Controls.Add(this.labelCost);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.checkBoxHealthy);
            this.Controls.Add(this.checkBoxFancy);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Party Planner";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.CheckBox checkBoxFancy;
        private System.Windows.Forms.CheckBox checkBoxHealthy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelCost;
    }
}

