
namespace Lab5Var11
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

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Quantity = new NumericUpDown();
            label1 = new Label();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            pictureBox1 = new PictureBox();
            radioButton1 = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)Quantity).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // Quantity
            // 
            Quantity.Location = new Point(232, 12);
            Quantity.Name = "Quantity";
            Quantity.Size = new Size(120, 23);
            Quantity.TabIndex = 0;
            Quantity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(173, 16);
            label1.Name = "label1";
            label1.Size = new Size(53, 15);
            label1.TabIndex = 1;
            label1.Text = "Quantity";
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(21, 37);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(101, 19);
            radioButton2.TabIndex = 3;
            radioButton2.Text = "Gavay 110 uah";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(21, 62);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(120, 19);
            radioButton3.TabIndex = 4;
            radioButton3.Text = "Margarita 130 uah";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(21, 87);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(103, 19);
            radioButton4.TabIndex = 5;
            radioButton4.Text = "Diablo 125 uah";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ScrollBar;
            button1.Location = new Point(173, 60);
            button1.Name = "button1";
            button1.Size = new Size(110, 23);
            button1.TabIndex = 6;
            button1.Text = "Розрахувати";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(411, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(302, 224);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(21, 12);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(116, 19);
            radioButton1.TabIndex = 2;
            radioButton1.Text = "Paperoni 115 uah";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(radioButton4);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(radioButton1);
            Controls.Add(label1);
            Controls.Add(Quantity);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)Quantity).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private NumericUpDown Quantity;
        private Label label1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private Button button1;

        #region Windows Form Designer generated code

        #endregion

        private PictureBox pictureBox1;
        private RadioButton radioButton1;
    }
}
