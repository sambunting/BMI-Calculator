namespace BMI_Calculator
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textName = new System.Windows.Forms.TextBox();
            this.textHeight = new System.Windows.Forms.TextBox();
            this.textWeightSt = new System.Windows.Forms.TextBox();
            this.button_show = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textWeightLb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Height";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Weight";
            // 
            // textName
            // 
            this.textName.Location = new System.Drawing.Point(98, 10);
            this.textName.Name = "textName";
            this.textName.Size = new System.Drawing.Size(283, 20);
            this.textName.TabIndex = 3;
            // 
            // textHeight
            // 
            this.textHeight.Location = new System.Drawing.Point(98, 50);
            this.textHeight.Name = "textHeight";
            this.textHeight.Size = new System.Drawing.Size(249, 20);
            this.textHeight.TabIndex = 4;
            // 
            // textWeightSt
            // 
            this.textWeightSt.Location = new System.Drawing.Point(98, 89);
            this.textWeightSt.Name = "textWeightSt";
            this.textWeightSt.Size = new System.Drawing.Size(110, 20);
            this.textWeightSt.TabIndex = 5;
            // 
            // button_show
            // 
            this.button_show.Location = new System.Drawing.Point(306, 123);
            this.button_show.Name = "button_show";
            this.button_show.Size = new System.Drawing.Size(75, 23);
            this.button_show.TabIndex = 0;
            this.button_show.Text = "Submit";
            this.button_show.UseVisualStyleBackColor = true;
            this.button_show.Click += new System.EventHandler(this.button_show_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "St";
            // 
            // textWeightLb
            // 
            this.textWeightLb.Location = new System.Drawing.Point(246, 89);
            this.textWeightLb.Name = "textWeightLb";
            this.textWeightLb.Size = new System.Drawing.Size(110, 20);
            this.textWeightLb.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(362, 92);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(19, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Lb";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(353, 53);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(28, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Inch";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 158);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textWeightLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_show);
            this.Controls.Add(this.textWeightSt);
            this.Controls.Add(this.textHeight);
            this.Controls.Add(this.textName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textName;
        private System.Windows.Forms.TextBox textHeight;
        private System.Windows.Forms.TextBox textWeightSt;
        private System.Windows.Forms.Button button_show;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textWeightLb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

