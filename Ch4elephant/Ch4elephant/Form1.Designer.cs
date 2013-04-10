namespace Ch4elephant
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
            this.buttonLloyd = new System.Windows.Forms.Button();
            this.buttonLucinda = new System.Windows.Forms.Button();
            this.buttonSwap = new System.Windows.Forms.Button();
            this.buttonAnother = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonLloyd
            // 
            this.buttonLloyd.Location = new System.Drawing.Point(51, 32);
            this.buttonLloyd.Name = "buttonLloyd";
            this.buttonLloyd.Size = new System.Drawing.Size(75, 23);
            this.buttonLloyd.TabIndex = 0;
            this.buttonLloyd.Text = "Lloyd";
            this.buttonLloyd.UseVisualStyleBackColor = true;
            this.buttonLloyd.Click += new System.EventHandler(this.buttonLloyd_Click);
            // 
            // buttonLucinda
            // 
            this.buttonLucinda.Location = new System.Drawing.Point(51, 61);
            this.buttonLucinda.Name = "buttonLucinda";
            this.buttonLucinda.Size = new System.Drawing.Size(75, 23);
            this.buttonLucinda.TabIndex = 1;
            this.buttonLucinda.Text = "Lucinda";
            this.buttonLucinda.UseVisualStyleBackColor = true;
            this.buttonLucinda.Click += new System.EventHandler(this.buttonLucinda_Click);
            // 
            // buttonSwap
            // 
            this.buttonSwap.Location = new System.Drawing.Point(51, 90);
            this.buttonSwap.Name = "buttonSwap";
            this.buttonSwap.Size = new System.Drawing.Size(75, 23);
            this.buttonSwap.TabIndex = 2;
            this.buttonSwap.Text = "Swap!";
            this.buttonSwap.UseVisualStyleBackColor = true;
            this.buttonSwap.Click += new System.EventHandler(this.buttonSwap_Click);
            // 
            // buttonAnother
            // 
            this.buttonAnother.Location = new System.Drawing.Point(51, 119);
            this.buttonAnother.Name = "buttonAnother";
            this.buttonAnother.Size = new System.Drawing.Size(75, 23);
            this.buttonAnother.TabIndex = 3;
            this.buttonAnother.Text = "Another";
            this.buttonAnother.UseVisualStyleBackColor = true;
            this.buttonAnother.Click += new System.EventHandler(this.buttonAnother_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 149);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Biggest Ears";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(180, 201);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonAnother);
            this.Controls.Add(this.buttonSwap);
            this.Controls.Add(this.buttonLucinda);
            this.Controls.Add(this.buttonLloyd);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonLloyd;
        private System.Windows.Forms.Button buttonLucinda;
        private System.Windows.Forms.Button buttonSwap;
        private System.Windows.Forms.Button buttonAnother;
        private System.Windows.Forms.Button button1;
    }
}

