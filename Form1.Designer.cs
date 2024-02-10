namespace ToysApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            buttonShow = new Button();
            SuspendLayout();
            // 
            // buttonShow
            // 
            buttonShow.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            buttonShow.Location = new Point(12, 15);
            buttonShow.Name = "buttonShow";
            buttonShow.Size = new Size(151, 56);
            buttonShow.TabIndex = 0;
            buttonShow.Text = "Show";
            buttonShow.UseVisualStyleBackColor = true;
            buttonShow.Click += buttonShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(175, 88);
            Controls.Add(buttonShow);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button buttonShow;
    }
}
