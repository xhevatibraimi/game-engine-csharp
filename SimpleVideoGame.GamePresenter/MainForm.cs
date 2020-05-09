using System;
using System.Drawing;
using System.Windows.Forms;

namespace SimpleVideoGame.GamePresenter
{
    public partial class MainForm : Form
    {
        private DateTime LastFrameDateTime = DateTime.Now;
        private double minFps = int.MaxValue;
        private double maxFps = int.MinValue;

        private GameEngine GameEngine;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            GameEngine = new GameEngine(Size.Width, Size.Height);
            GameEngine.Init();
            GameEngine.OnDrawFrame += DrawFrame;
        }

        private void SetKeyDown(object sender, KeyEventArgs e)
        {
            Input.SetKeyDown(e.KeyCode.ToString(), true);
        }

        private void SetKeyUp(object sender, KeyEventArgs e)
        {
            Input.SetKeyDown(e.KeyCode.ToString(), false);
        }

        private void DrawFrame(object sender, DrawFrameEventArgs e)
        {
            DrawFrameInWindow(e.Bitmap);
        }
        private void StartGameEngineButton_Click(object sender, EventArgs e)
        {
            StartInputScanning();
            GameEngine.StartGameEngine();
        }

        private void StartInputScanning()
        {
            BringToFront();
            KeyPreview = true;
            KeyDown += SetKeyDown;
            KeyUp += SetKeyUp;
        }

        private void DrawFrameInWindow(Image image)
        {
            if (!GameEngine.IsRunning)
                return;

            if (InvokeRequired)
            {
                Invoke(new RefreshFrameDelegate(SetPictureBoxImage), image);
            }
            else
            {
                SetPictureBoxImage(image);
            }
        }
        private void SetPictureBoxImage(Image image)
        {
            if (!GameEngine.IsRunning)
                return;
            CanvasPictureBox.Image = image;
            UpdateFPSLabel();
        }

        private void UpdateFPSLabel()
        {
            var fps = Math.Round(1000 / (DateTime.Now - LastFrameDateTime).TotalMilliseconds, 4);
            LastFrameDateTime = DateTime.Now;

            if (fps > maxFps)
                maxFps = fps;
            if (fps < minFps)
                minFps = fps;

            FPSLabel.Text = $"fps: {fps}";
            MinFPSLabel.Text = $"Min fps: {minFps}";
            MaxFPSLabel.Text = $"Max fps: {maxFps}";
        }

        protected override void Dispose(bool disposing)
        {
            GameEngine.Dispose();
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
