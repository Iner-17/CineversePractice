namespace CineversePractice
{
    partial class main
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
            this.txt_movieName = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txt_moviePrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.setDate = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 35);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add Movie";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(73, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Movie Name";
            // 
            // txt_movieName
            // 
            this.txt_movieName.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_movieName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_movieName.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_movieName.Location = new System.Drawing.Point(5, 9);
            this.txt_movieName.Margin = new System.Windows.Forms.Padding(5);
            this.txt_movieName.Name = "txt_movieName";
            this.txt_movieName.Size = new System.Drawing.Size(230, 25);
            this.txt_movieName.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt_movieName);
            this.panel1.Location = new System.Drawing.Point(77, 161);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(246, 41);
            this.panel1.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.txt_moviePrice);
            this.panel2.Location = new System.Drawing.Point(392, 161);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(151, 41);
            this.panel2.TabIndex = 5;
            // 
            // txt_moviePrice
            // 
            this.txt_moviePrice.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txt_moviePrice.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_moviePrice.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_moviePrice.Location = new System.Drawing.Point(5, 9);
            this.txt_moviePrice.Margin = new System.Windows.Forms.Padding(5);
            this.txt_moviePrice.Name = "txt_moviePrice";
            this.txt_moviePrice.Size = new System.Drawing.Size(230, 25);
            this.txt_moviePrice.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(358, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "Movie Price";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Montserrat", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(357, 167);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 29);
            this.label4.TabIndex = 6;
            this.label4.Text = "₱";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Montserrat", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(73, 225);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(196, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "Set Date Screening";
            // 
            // setDate
            // 
            this.setDate.CustomFormat = "MMMM dd, yyy";
            this.setDate.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.setDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.setDate.Location = new System.Drawing.Point(77, 260);
            this.setDate.Name = "setDate";
            this.setDate.Size = new System.Drawing.Size(192, 26);
            this.setDate.TabIndex = 7;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(113)))), ((int)(((byte)(214)))), ((int)(((byte)(227)))));
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Consolas", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(77, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(466, 58);
            this.button1.TabIndex = 9;
            this.button1.Text = "ADD";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(642, 553);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.setDate);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "main";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_movieName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txt_moviePrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker setDate;
        private System.Windows.Forms.Button button1;
    }
}

