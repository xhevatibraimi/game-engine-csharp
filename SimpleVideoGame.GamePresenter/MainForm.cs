using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimpleVideoGame.GamePresenter
{
    public partial class MainForm : Form
    {
        private List<SceneObject> SceneObjects = new List<SceneObject>();
        private Task SceneDrawingTask;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            InitScene();
        }

        private void StartGameEngine()
        {
            SceneDrawingTask = new Task(RunGameEngine);
            SceneDrawingTask.Start();
        }

        private void RunGameEngine()
        {
            while (true)
            {
                RunEventLoopCycle();
            }
        }

        private void RunEventLoopCycle()
        {
            Bitmap DrawArea = new Bitmap(CanvasPictureBox.Size.Width, CanvasPictureBox.Size.Height);
            using (var g = Graphics.FromImage(DrawArea))
            {
                g.Clear(Color.Black);
                foreach (var sceneObject in SceneObjects)
                {
                    g.DrawImage(sceneObject.Bitmap, sceneObject.Location.X, sceneObject.Location.Y);
                }
                DrawFrameInWindow(DrawArea);
            }
        }

        private void DrawFrameInWindow(Image image)
        {
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
            CanvasPictureBox.Image = image;
        }

        private Bitmap GetSquare(int size, Color color)
        {
            Bitmap bitmap = new Bitmap(100, 100);
            for (int x = 0; x < size; x++)
            {
                for (int y = 0; y < size; y++)
                {
                    bitmap.TrySetPixel(x, y, color);
                }
            }
            return bitmap;
        }

        private void StartGameEngineButton_Click(object sender, EventArgs e)
        {
            StartGameEngine();
        }

        private void InitScene()
        {
            SceneObjects.Add(new SceneObject { Location = new Point(100, 100), Bitmap = GetSquare(100, Color.Red) });
            SceneObjects.Add(new SceneObject { Location = new Point(200, 200), Bitmap = GetSquare(100, Color.Green) });
            SceneObjects.Add(new SceneObject { Location = new Point(300, 300), Bitmap = GetSquare(100, Color.Blue) });
        }
    }
}
