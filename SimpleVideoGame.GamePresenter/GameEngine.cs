﻿using System;
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
            Bitmap DrawArea = new Bitmap(ScreenWidth, ScreenHeight);
            using (var g = Graphics.FromImage(DrawArea))
            {
                g.Clear(Color.Black);
                foreach (var sceneObject in SceneObjects)
                {
                    g.DrawImage(sceneObject.Bitmap, sceneObject.Location.X, sceneObject.Location.Y);
                }
                DrawFrame(DrawArea);
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
            SceneObjects.Add(new SceneObject { Location = new Point(100, 100), Bitmap = GetSquare(100, Color.Red) });
            SceneObjects.Add(new SceneObject { Location = new Point(200, 200), Bitmap = GetSquare(100, Color.Green) });
            SceneObjects.Add(new SceneObject { Location = new Point(300, 300), Bitmap = GetSquare(100, Color.Blue) });
        }

        public void Dispose()
        {
            IsRunning = false;
        }
    }
}