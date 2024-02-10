namespace ToysApp
{
    partial class ShowForm
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
            button1 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            comboBox1 = new ComboBox();
            label9 = new Label();
            button3 = new Button();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button1.Location = new Point(12, 400);
            button1.Name = "button1";
            button1.Size = new Size(150, 50);
            button1.TabIndex = 1;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            button2.Location = new Point(170, 400);
            button2.Name = "button2";
            button2.Size = new Size(150, 50);
            button2.TabIndex = 2;
            button2.Text = "Cancel";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 42);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(308, 259);
            listBox1.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(350, 15);
            label1.Name = "label1";
            label1.Size = new Size(30, 25);
            label1.TabIndex = 4;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label2.Location = new Point(350, 70);
            label2.Name = "label2";
            label2.Size = new Size(64, 25);
            label2.TabIndex = 5;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label3.Location = new Point(350, 125);
            label3.Name = "label3";
            label3.Size = new Size(150, 25);
            label3.TabIndex = 6;
            label3.Text = "DateOfСreation";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label4.Location = new Point(350, 180);
            label4.Name = "label4";
            label4.Size = new Size(102, 25);
            label4.TabIndex = 7;
            label4.Text = "Producter";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label5.Location = new Point(350, 235);
            label5.Name = "label5";
            label5.Size = new Size(56, 25);
            label5.TabIndex = 8;
            label5.Text = "Price";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label6.Location = new Point(350, 290);
            label6.Name = "label6";
            label6.Size = new Size(75, 25);
            label6.TabIndex = 9;
            label6.Text = "Weight";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label7.Location = new Point(350, 345);
            label7.Name = "label7";
            label7.Size = new Size(91, 25);
            label7.TabIndex = 10;
            label7.Text = "AgeLimit";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold);
            label8.Location = new Point(350, 400);
            label8.Name = "label8";
            label8.Size = new Size(145, 25);
            label8.TabIndex = 11;
            label8.Text = "DateOfLastSale";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(12, 12);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 23);
            comboBox1.TabIndex = 12;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(12, 304);
            label9.Name = "label9";
            label9.Size = new Size(245, 15);
            label9.TabIndex = 13;
            label9.Text = "Чтобы удалить, нажите дважды на элемент";
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button3.Location = new Point(12, 345);
            button3.Name = "button3";
            button3.Size = new Size(308, 49);
            button3.TabIndex = 14;
            button3.Text = "Refresh";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // ShowForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(743, 461);
            Controls.Add(button3);
            Controls.Add(label9);
            Controls.Add(comboBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "ShowForm";
            Text = "ShowForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button button1;
        private Button button2;
        private ListBox listBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private ComboBox comboBox1;
        private Label label9;
        private Button button3;
    }
}