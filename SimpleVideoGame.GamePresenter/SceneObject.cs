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
    }
}
