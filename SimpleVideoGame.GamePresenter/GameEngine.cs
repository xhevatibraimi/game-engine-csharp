using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleVideoGame.GamePresenter
{
    public class GameEngine : IDisposable
    {
        public EventHandler<DrawFrameEventArgs> OnDrawFrame = new EventHandler<DrawFrameEventArgs>((o, e) => { });
        private List<SceneObject> SceneObjects = new List<SceneObject>();
        private Task _sceneDrawingTask;
        public bool IsRunning { get; private set; } = false;
        private readonly int ScreenWidth = 0;
        private readonly int ScreenHeight = 0;

        public GameEngine(int screenWidth, int screenHeight)
        {
            ScreenWidth = screenWidth;
            ScreenHeight = screenHeight;
        }

        private void RunEventLoopCycle()
        {
            RunPhysicsCycle();

            Bitmap DrawArea = new Bitmap(ScreenWidth, ScreenHeight);
            using (var g = Graphics.FromImage(DrawArea))
            {
                g.Clear(Color.Black);
                foreach (var sceneObject in SceneObjects)
                {
                    g.DrawImage(sceneObject.Bitmap, sceneObject.Transform.Position.X, sceneObject.Transform.Position.Y);
                }
                DrawFrame(DrawArea);
            }
        }

        private void RunPhysicsCycle()
        {
            foreach (var sceneObject in SceneObjects)
            {
                sceneObject.OnEveryFrame();
            }
        }

        private void DrawFrame(Bitmap DrawArea)
        {
            OnDrawFrame.Invoke(this, new DrawFrameEventArgs(DrawArea));
        }

        public void StartGameEngine()
        {
            IsRunning = true;
            _sceneDrawingTask = Task.Factory.StartNew(() =>
            {
                while (IsRunning)
                {
                    RunEventLoopCycle();
                }
            });
        }

        public void StopGameEngine()
        {
            IsRunning = false;
            _sceneDrawingTask.Dispose();
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

        public void Init()
        {
            var redSquare = new LinearMovementObject();
            redSquare.Transform.Position = new Vector2D(100, 100);
            redSquare.Bitmap = GetSquare(100, Color.Red);

            var greenSquare = new LinearMovementObject();
            greenSquare.Transform.Position = new Vector2D(150, 150);
            greenSquare.Bitmap = GetSquare(100, Color.Green);

            var blueSquare = new LinearMovementObject();
            blueSquare.Transform.Position = new Vector2D(200, 200);
            blueSquare.Bitmap = GetSquare(100, Color.Blue);

            var circleTrajectorySquare = new CircleMovementObject();
            circleTrajectorySquare.Transform.Position = new Vector2D(200, 200);
            circleTrajectorySquare.Bitmap = GetSquare(100, Color.Yellow);

            SceneObjects.Add(redSquare);
            SceneObjects.Add(greenSquare);
            SceneObjects.Add(blueSquare);
            SceneObjects.Add(circleTrajectorySquare);
        }

        public void Dispose()
        {
            IsRunning = false;
        }
    }
}
