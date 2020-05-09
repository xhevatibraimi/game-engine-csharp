using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVideoGame.GamePresenter
{
    public partial class MainForm : Form
    {
        Task SceneDrawingTask;

        public MainForm()
        {
            InitializeComponent();
        }

        private void StartGameEngine()
        {
            SceneDrawingTask = new Task(RumGameEngine);
            SceneDrawingTask.Start();
        }

        private void RumGameEngine()
        {
            //var square = GetSquare(100);
            while (true)
            {
                Bitmap DrawArea = new Bitmap(CanvasPictureBox.Size.Width, CanvasPictureBox.Size.Height);
                using (var g = Graphics.FromImage(DrawArea))
                {
                    g.Clear(Color.Black);
                    //g.DrawImage(square, 100, 100);
                    if (InvokeRequired)
                    {
                        Invoke(new RefreshFrameDelegate(SetPictureBoxImage), DrawArea);
                    }
                    else
                    {
                        SetPictureBoxImage(DrawArea);
                    }
                }
            }
        }

        private void SetPictureBoxImage(Bitmap bitmap)
        {
            CanvasPictureBox.Image = bitmap;
        }

        private Bitmap GetSquare(int size)
        {
            Bitmap bitmap = new Bitmap(100, 100);
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    bitmap.TrySetPixel(x, y, Color.Red);
                }
            }
            return bitmap;
        }

        private void StartGameEngineButton_Click(object sender, EventArgs e)
        {
            StartGameEngine();
        }
    }
}
