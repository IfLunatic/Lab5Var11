namespace Task4
{
    public partial class Form1 : Form
    {
        private List<string> imagePaths = new List<string>();
        private int currentIndex = 0;
        private System.Windows.Forms.Timer slideshowTimer = new System.Windows.Forms.Timer();

        public Form1()
        {
            InitializeComponent();
            LoadImagePaths();
            InitializeSlideshow();
        }

        private void LoadImagePaths()
        {
            string imageDirectory = @"D:\Pizza";

            try
            {
                List<string> imageFiles = new List<string>();

                imageFiles.AddRange(Directory.GetFiles(imageDirectory, "*.jpg"));
                imageFiles.AddRange(Directory.GetFiles(imageDirectory, "*.png"));
                imageFiles.AddRange(Directory.GetFiles(imageDirectory, "*.bmp"));

                imagePaths.AddRange(imageFiles);
            }
            catch (DirectoryNotFoundException)
            {
                MessageBox.Show("Not found in the image box.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InitializeSlideshow()
        {
            slideshowTimer.Interval = 1000;
            slideshowTimer.Tick += slideshowTimer_Tick;
            slideshowTimer.Start();
            DisplayCurrentImage();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void slideshowTimer_Tick(object sender, EventArgs e)
        {
            MoveToNextImage();
        }
        private void DisplayCurrentImage()
        {
            if (imagePaths.Count > 0 && currentIndex >= 0 && currentIndex < imagePaths.Count)
            {
                string currentImagePath = imagePaths[currentIndex];
                pictureBoxPhoto.Image = Image.FromFile(currentImagePath);
            }
        }
        private void MoveToNextImage()
        {
            currentIndex = (currentIndex + 1) % imagePaths.Count;
            DisplayCurrentImage();
        }
        private void MoveToPreviousImage()
        {
            currentIndex = (currentIndex - 1 + imagePaths.Count) % imagePaths.Count;
            DisplayCurrentImage();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            MoveToNextImage();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            MoveToPreviousImage();
        }

        private void btnRotate_Click(object sender, EventArgs e)
        {
            if (pictureBoxPhoto.Image != null)
            {
                pictureBoxPhoto.Image.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBoxPhoto.Invalidate();
            }
        }

        private void btnStartSlideshow_Click(object sender, EventArgs e)
        {
            if (slideshowTimer.Enabled)
            {
                slideshowTimer.Stop();
                btnStartSlideshow.Text = "Start";
            }
            else
            {
                slideshowTimer.Start();
                btnStartSlideshow.Text = "Stop";
            }
        }
    }
}
