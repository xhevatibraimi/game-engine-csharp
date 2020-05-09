using System;
using System.Drawing;

namespace SimpleVideoGame.GamePresenter
{
    public class SceneObject
    {
        public Transform2D Transform { get; set; }
        public Bitmap Bitmap { get; set; }

        public SceneObject()
        {
            Transform = new Transform2D();
        }

        public void OnEveryFrame()
        {
            Transform.Position = new Vector2D(Transform.Position.X + 1f, Transform.Position.Y + 0.5f);
        }
    }
}
