using System;
using System.CodeDom;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Security.Cryptography;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;


namespace ImageProcessing
{
    public partial class Form1 : Form
    {
        private Bitmap originalImage;
        private Bitmap processedImage;



        private FilterInfoCollection videoDevices; // Collection of video devices
        private VideoCaptureDevice videoSource; // Video capture device

        bool cameraOn = false;
        bool histogrambtn_on = false;
        bool invertcolorsbtn_on = false;
        bool sepiabtn_on = false;
        bool subtract_on = false;
        private readonly object imageLock = new object();




        public Form1()
        {
            InitializeComponent();
            InitializeWebcam();
        }






        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (cameraOn)
                {
                    StopWebcam();


                }
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    originalImage = new Bitmap(ofd.FileName);
                    pictureBoxOriginal.Image = originalImage;
                    processedImage = new Bitmap(originalImage);
                    pictureBoxProcessed.Image = processedImage;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (originalImage == null) return;
            processedImage = new Bitmap(originalImage);
            pictureBoxProcessed.Image = processedImage;
        }

        private void invertcolorsbtn_Click(object sender, EventArgs e)
        {
            if (cameraOn)
            {
                processedImage = originalImage;
            }
            else if (processedImage == null) return;

            for (int y = 0; y < processedImage.Height; y++)
            {
                for (int x = 0; x < processedImage.Width; x++)
                {
                    Color pixelColor = processedImage.GetPixel(x, y);
                    Color invertedColor = Color.FromArgb(255 - pixelColor.R, 255 - pixelColor.G, 255 - pixelColor.B);
                    processedImage.SetPixel(x, y, invertedColor);
                }
            }
            pictureBoxProcessed.Image = processedImage;
        }




        private void histogrambtn_Click(object sender, EventArgs e)
        {
            lock (imageLock)
            {
                if (cameraOn)
                {

                    processedImage = new Bitmap(originalImage);
                    pictureBoxProcessed.Image = processedImage;


                }


                else if (processedImage == null) return;
                hisfunct();
            }
        }


        private void hisfunct()
        {

            int[] histogram = new int[256];

            for (int y = 0; y < processedImage.Height; y++)
            {
                for (int x = 0; x < processedImage.Width; x++)
                {
                    Color pixelColor = processedImage.GetPixel(x, y);
                    int grayValue = (int)((pixelColor.R + pixelColor.G + pixelColor.B) / 3);
                    histogram[grayValue]++;
                }
            }

            int max = histogram.Max();

            Bitmap histogramBitmap = new Bitmap(256, 100);
            using (Graphics g = Graphics.FromImage(histogramBitmap))
            {
                g.Clear(Color.White);

                for (int i = 0; i < histogram.Length; i++)
                {
                    int barHeight = (int)((histogram[i] / (float)max) * histogramBitmap.Height);
                    g.DrawLine(Pens.Black, i, histogramBitmap.Height, i, histogramBitmap.Height - barHeight);
                }
            }



            pictureBoxResult.Image = histogramBitmap;
        }

        private void sepiabtn_Click(object sender, EventArgs e)
        {
            if (processedImage == null) return;

            for (int y = 0; y < processedImage.Height; y++)
            {
                for (int x = 0; x < processedImage.Width; x++)
                {
                    Color pixelColor = processedImage.GetPixel(x, y);
                    int tr = (int)(0.393 * pixelColor.R + 0.769 * pixelColor.G + 0.189 * pixelColor.B);
                    int tg = (int)(0.349 * pixelColor.R + 0.686 * pixelColor.G + 0.168 * pixelColor.B);
                    int tb = (int)(0.272 * pixelColor.R + 0.534 * pixelColor.G + 0.131 * pixelColor.B);

                    Color sepiaColor = Color.FromArgb(
                        Math.Min(tr, 255),
                        Math.Min(tg, 255),
                        Math.Min(tb, 255)
                    );

                    processedImage.SetPixel(x, y, sepiaColor);
                }
            }
            pictureBoxProcessed.Image = processedImage;
        }

        private void saveimagebtn_Click(object sender, EventArgs e)
        {
            if (processedImage == null) return;

            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "PNG|*.png|JPEG|*.jpg|BMP|*.bmp";
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    processedImage.Save(sfd.FileName, ImageFormat.Png);
                }
            }
        }


        private void subtractimagesbtn_Click(object sender, EventArgs e)
        {

            Bitmap imageA;
            if (!cameraOn)
            {
                imageA = LoadImage();
                pictureBoxOriginal.Image = imageA;
            }
            else
            {
                imageA = originalImage;
            }



            Bitmap imageB = LoadImage();
            pictureBoxProcessed.Image = imageB;




            pictureBoxResult.Image = ConvertToSubtraction(imageB, imageA);
        }


        private Bitmap LoadImage()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    return new Bitmap(ofd.FileName);
                }
            }
            return null;
        }

        private void grayscalebtn_Click_1(object sender, EventArgs e)
        {
            if (originalImage == null) return;


            processedImage = new Bitmap(originalImage.Width, originalImage.Height);

            for (int y = 0; y < originalImage.Height; y++)
            {
                for (int x = 0; x < originalImage.Width; x++)
                {
                    Color pixelColor = originalImage.GetPixel(x, y);


                    int gray = (int)(0.3 * pixelColor.R + 0.59 * pixelColor.G + 0.11 * pixelColor.B);
                    Color newColor = Color.FromArgb(gray, gray, gray);

                    processedImage.SetPixel(x, y, newColor);
                }
            }

            pictureBoxProcessed.Image = processedImage;
        }
        public static Bitmap ConvertToSubtraction(Bitmap imageA, Bitmap imageB)
        {
            Color targetGreen = Color.FromArgb(0, 255, 0);
            Bitmap processed = new Bitmap(imageB.Width, imageB.Height);
            int threshold = 60;

            for (int x = 0; x < Math.Min(imageA.Width, imageB.Width); x++)
            {
                for (int y = 0; y < Math.Min(imageA.Height, imageB.Height); y++)
                {
                    Color pixel = imageB.GetPixel(x, y);
                    Color backPixel = imageA.GetPixel(x, y);

                    if (pixel.G > pixel.R + threshold && pixel.G > pixel.B + threshold)
                    {
                        processed.SetPixel(x, y, backPixel);
                    }
                    else
                    {
                        processed.SetPixel(x, y, pixel);
                    }
                }
            }
            return processed;
        }

        private void cameratoggle_Click(object sender, EventArgs e)
        {
            if (!cameraOn)
            {
                videoSource = new VideoCaptureDevice(videoDevices[0].MonikerString);
                videoSource.NewFrame += new NewFrameEventHandler(videoSource_NewFrame);

                // Start capturing
                videoSource.Start();
                cameraOn = true;
                cameratoggle.Text = "turn off camera";
            }
            else
            {
                StopWebcam();

            }


        }


        // Initialize the webcam
        private void InitializeWebcam()
        {
            // Get available video devices
            videoDevices = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (videoDevices.Count == 0)
            {
                MessageBox.Show("No video sources found.");
                return;
            }
        }

        // Start the webcam when the button is clicked

        // Handle new frames from the webcam
        private void videoSource_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            // Clone the current frame (in a thread-safe manner)
            Bitmap bitmap = (Bitmap)eventArgs.Frame.Clone();

            // Ensure UI updates are done on the UI thread
            if (pictureBoxOriginal.InvokeRequired)
            {
                pictureBoxOriginal.Invoke(new Action(() => UpdatePictureBox(bitmap)));
            }
            else
            {
                UpdatePictureBox(bitmap);
            }
        }

        // Method to update PictureBox and clone original image
        private void UpdatePictureBox(Bitmap bitmap)
        {
            lock (imageLock)
            {
                // Dispose of the previous image if it exists
                if (pictureBoxOriginal.Image != null)
                {
                    pictureBoxOriginal.Image.Dispose();
                }

                // Assign the new bitmap to pictureBoxOriginal
                pictureBoxOriginal.Image = bitmap;

                // Clone the bitmap to originalImage
                originalImage = (Bitmap)bitmap.Clone();
            }
        }

        // Stop the webcam when the form is closing
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            StopWebcam();
        }

        // Stop the webcam when the stop button is clicked
        private void btnStopWebcam_Click(object sender, EventArgs e)
        {
            StopWebcam();
        }

        // Method to stop the webcam
        private void StopWebcam()
        {
            if (videoSource != null && videoSource.IsRunning)
            {
                videoSource.SignalToStop();
                videoSource.WaitForStop();
            }
            cameraOn = false;
            cameratoggle.Text = "turn on camera";
            pictureBoxProcessed.Image = null;
        }
    }

}