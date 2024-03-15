namespace Task3
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

        private void InitializeComponent()
        {
            listBox = new ListBox();
            pictureBox = new PictureBox();
            OpenButton = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox).BeginInit();
            SuspendLayout();
            // 
            // listBox
            // 
            listBox.FormattingEnabled = true;
            listBox.ItemHeight = 15;
            listBox.Location = new Point(14, 14);
            listBox.Margin = new Padding(4, 3, 4, 3);
            listBox.Name = "listBox";
            listBox.Size = new Size(198, 229);
            listBox.TabIndex = 0;
            listBox.SelectedIndexChanged += ListBox_SelectedIndexChanged;
            // 
            // pictureBox
            // 
            pictureBox.Location = new Point(422, 14);
            pictureBox.Margin = new Padding(4, 3, 4, 3);
            pictureBox.Name = "pictureBox";
            pictureBox.Size = new Size(331, 230);
            pictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox.TabIndex = 1;
            pictureBox.TabStop = false;
            // 
            // OpenButton
            // 
            OpenButton.Location = new Point(241, 126);
            OpenButton.Margin = new Padding(4, 3, 4, 3);
            OpenButton.Name = "OpenButton";
            OpenButton.Size = new Size(140, 35);
            OpenButton.TabIndex = 2;
            OpenButton.Text = "Open";
            OpenButton.UseVisualStyleBackColor = true;
            OpenButton.Click += openButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(OpenButton);
            Controls.Add(pictureBox);
            Controls.Add(listBox);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox).EndInit();
            ResumeLayout(false);
        }

        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button OpenButton;
        #region Windows Form Designer generated code



        #endregion
    }
}
