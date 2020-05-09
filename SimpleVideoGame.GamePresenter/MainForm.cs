using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVideoGame.GamePresenter
{
    public partial class MainForm : Form
    {
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

        private void DrawFrame(object sender, DrawFrameEventArgs e)
        {
            DrawFrameInWindow(e.Bitmap);
        }
        private void StartGameEngineButton_Click(object sender, EventArgs e)
        {
            GameEngine.StartGameEngine();
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
