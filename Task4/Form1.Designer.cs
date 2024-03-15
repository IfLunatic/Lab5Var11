namespace Task4
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
            pictureBoxPhoto = new PictureBox();
            btnNext = new Button();
            btnPrevious = new Button();
            btnRotate = new Button();
            btnStartSlideshow = new Button();
            label1 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
            SuspendLayout();
            // 
            // pictureBoxPhoto
            // 
            pictureBoxPhoto.Location = new Point(245, 24);
            pictureBoxPhoto.Margin = new Padding(4, 3, 4, 3);
            pictureBoxPhoto.Name = "pictureBoxPhoto";
            pictureBoxPhoto.Size = new Size(361, 161);
            pictureBoxPhoto.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxPhoto.TabIndex = 0;
            pictureBoxPhoto.TabStop = false;
            // 
            // btnNext
            // 
            btnNext.Location = new Point(646, 89);
            btnNext.Margin = new Padding(4, 3, 4, 3);
            btnNext.Name = "btnNext";
            btnNext.Size = new Size(88, 27);
            btnNext.TabIndex = 1;
            btnNext.Text = "Next";
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // btnPrevious
            // 
            btnPrevious.Location = new Point(98, 89);
            btnPrevious.Margin = new Padding(4, 3, 4, 3);
            btnPrevious.Name = "btnPrevious";
            btnPrevious.Size = new Size(88, 27);
            btnPrevious.TabIndex = 2;
            btnPrevious.Text = "Previous";
            btnPrevious.UseVisualStyleBackColor = true;
            btnPrevious.Click += btnPrevious_Click;
            // 
            // btnRotate
            // 
            btnRotate.Location = new Point(384, 233);
            btnRotate.Margin = new Padding(4, 3, 4, 3);
            btnRotate.Name = "btnRotate";
            btnRotate.Size = new Size(88, 27);
            btnRotate.TabIndex = 3;
            btnRotate.Text = "Rotate";
            btnRotate.UseVisualStyleBackColor = true;
            btnRotate.Click += btnRotate_Click;
            // 
            // btnStartSlideshow
            // 
            btnStartSlideshow.Location = new Point(384, 191);
            btnStartSlideshow.Margin = new Padding(4, 3, 4, 3);
            btnStartSlideshow.Name = "btnStartSlideshow";
            btnStartSlideshow.Size = new Size(88, 27);
            btnStartSlideshow.TabIndex = 4;
            btnStartSlideshow.Text = "Stop";
            btnStartSlideshow.UseVisualStyleBackColor = true;
            btnStartSlideshow.Click += btnStartSlideshow_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(681, 119);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "->";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(133, 119);
            label2.Name = "label2";
            label2.Size = new Size(20, 15);
            label2.TabIndex = 6;
            label2.Text = "<-";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(933, 519);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnStartSlideshow);
            Controls.Add(btnRotate);
            Controls.Add(btnPrevious);
            Controls.Add(btnNext);
            Controls.Add(pictureBoxPhoto);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.PictureBox pictureBoxPhoto;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnRotate;
        private System.Windows.Forms.Button btnStartSlideshow;

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>

        #endregion

        private Label label1;
        private Label label2;
    }
}
