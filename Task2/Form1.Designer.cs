namespace Task2
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
            openFileDialog1 = new OpenFileDialog();
            browseButton = new Button();
            fileInfoLabel = new Label();
            folderPathTextBox = new TextBox();
            folderInfoLabel = new Label();
            folderRadioButton = new RadioButton();
            fileRadioButton = new RadioButton();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // browseButton
            // 
            browseButton.Location = new Point(535, 25);
            browseButton.Margin = new Padding(4, 3, 4, 3);
            browseButton.Name = "browseButton";
            browseButton.Size = new Size(88, 27);
            browseButton.TabIndex = 0;
            browseButton.Text = "Open";
            browseButton.UseVisualStyleBackColor = true;
            browseButton.Click += browseButton_Click;
            // 
            // fileInfoLabel
            // 
            fileInfoLabel.AutoSize = true;
            fileInfoLabel.Location = new Point(52, 113);
            fileInfoLabel.Margin = new Padding(4, 0, 4, 0);
            fileInfoLabel.Name = "fileInfoLabel";
            fileInfoLabel.Size = new Size(0, 15);
            fileInfoLabel.TabIndex = 2;
            // 
            // folderPathTextBox
            // 
            folderPathTextBox.Location = new Point(12, 29);
            folderPathTextBox.Name = "folderPathTextBox";
            folderPathTextBox.Size = new Size(516, 23);
            folderPathTextBox.TabIndex = 3;
            // 
            // folderInfoLabel
            // 
            folderInfoLabel.AutoSize = true;
            folderInfoLabel.Location = new Point(249, 145);
            folderInfoLabel.Name = "folderInfoLabel";
            folderInfoLabel.Size = new Size(0, 15);
            folderInfoLabel.TabIndex = 4;
            // 
            // folderRadioButton
            // 
            folderRadioButton.AutoSize = true;
            folderRadioButton.Location = new Point(12, 62);
            folderRadioButton.Name = "folderRadioButton";
            folderRadioButton.Size = new Size(63, 19);
            folderRadioButton.TabIndex = 5;
            folderRadioButton.TabStop = true;
            folderRadioButton.Text = "Folders";
            folderRadioButton.UseVisualStyleBackColor = true;
            // 
            // fileRadioButton
            // 
            fileRadioButton.AutoSize = true;
            fileRadioButton.Location = new Point(90, 62);
            fileRadioButton.Name = "fileRadioButton";
            fileRadioButton.Size = new Size(48, 19);
            fileRadioButton.TabIndex = 6;
            fileRadioButton.TabStop = true;
            fileRadioButton.Text = "Files";
            fileRadioButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(982, 396);
            Controls.Add(fileRadioButton);
            Controls.Add(folderRadioButton);
            Controls.Add(folderInfoLabel);
            Controls.Add(folderPathTextBox);
            Controls.Add(fileInfoLabel);
            Controls.Add(browseButton);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label fileInfoLabel;
        private TextBox folderPathTextBox;
        private Label folderInfoLabel;
        private RadioButton folderRadioButton;
        private RadioButton fileRadioButton;
    }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

   #endregion
}
