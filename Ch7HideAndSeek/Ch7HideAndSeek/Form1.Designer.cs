﻿namespace Ch7HideAndSeek
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
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.buttonGoHere = new System.Windows.Forms.Button();
            this.buttonGoThroughDoor = new System.Windows.Forms.Button();
            this.comboBoxExits = new System.Windows.Forms.ComboBox();
            this.buttonCheck = new System.Windows.Forms.Button();
            this.buttonHide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(12, 12);
            this.textBoxDescription.Multiline = true;
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(312, 145);
            this.textBoxDescription.TabIndex = 0;
            // 
            // buttonGoHere
            // 
            this.buttonGoHere.Location = new System.Drawing.Point(12, 163);
            this.buttonGoHere.Name = "buttonGoHere";
            this.buttonGoHere.Size = new System.Drawing.Size(75, 23);
            this.buttonGoHere.TabIndex = 1;
            this.buttonGoHere.Text = "Go here:";
            this.buttonGoHere.UseVisualStyleBackColor = true;
            this.buttonGoHere.Visible = false;
            this.buttonGoHere.Click += new System.EventHandler(this.buttonGoHere_Click);
            // 
            // buttonGoThroughDoor
            // 
            this.buttonGoThroughDoor.Location = new System.Drawing.Point(12, 192);
            this.buttonGoThroughDoor.Name = "buttonGoThroughDoor";
            this.buttonGoThroughDoor.Size = new System.Drawing.Size(312, 23);
            this.buttonGoThroughDoor.TabIndex = 2;
            this.buttonGoThroughDoor.Text = "Go through the door";
            this.buttonGoThroughDoor.UseVisualStyleBackColor = true;
            this.buttonGoThroughDoor.Visible = false;
            this.buttonGoThroughDoor.Click += new System.EventHandler(this.buttonGoThroughDoor_Click);
            // 
            // comboBoxExits
            // 
            this.comboBoxExits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxExits.FormattingEnabled = true;
            this.comboBoxExits.Location = new System.Drawing.Point(102, 165);
            this.comboBoxExits.Name = "comboBoxExits";
            this.comboBoxExits.Size = new System.Drawing.Size(222, 21);
            this.comboBoxExits.TabIndex = 3;
            this.comboBoxExits.Visible = false;
            // 
            // buttonCheck
            // 
            this.buttonCheck.Location = new System.Drawing.Point(12, 221);
            this.buttonCheck.Name = "buttonCheck";
            this.buttonCheck.Size = new System.Drawing.Size(312, 23);
            this.buttonCheck.TabIndex = 4;
            this.buttonCheck.Text = "Check";
            this.buttonCheck.UseVisualStyleBackColor = true;
            this.buttonCheck.Visible = false;
            this.buttonCheck.Click += new System.EventHandler(this.buttonCheck_Click);
            // 
            // buttonHide
            // 
            this.buttonHide.Location = new System.Drawing.Point(12, 250);
            this.buttonHide.Name = "buttonHide";
            this.buttonHide.Size = new System.Drawing.Size(312, 23);
            this.buttonHide.TabIndex = 5;
            this.buttonHide.Text = "Hide!";
            this.buttonHide.UseVisualStyleBackColor = true;
            this.buttonHide.Click += new System.EventHandler(this.buttonHide_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 283);
            this.Controls.Add(this.buttonHide);
            this.Controls.Add(this.buttonCheck);
            this.Controls.Add(this.comboBoxExits);
            this.Controls.Add(this.buttonGoThroughDoor);
            this.Controls.Add(this.buttonGoHere);
            this.Controls.Add(this.textBoxDescription);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.Text = "Explore the House";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.Button buttonGoHere;
        private System.Windows.Forms.Button buttonGoThroughDoor;
        private System.Windows.Forms.ComboBox comboBoxExits;
        private System.Windows.Forms.Button buttonCheck;
        private System.Windows.Forms.Button buttonHide;
    }
}

