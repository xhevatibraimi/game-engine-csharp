using System.Drawing;

namespace SimpleVideoGame.GamePresenter
{
    public abstract class SceneObject
    {
        public Transform2D Transform { get; set; }
        public Bitmap Bitmap { get; set; }

        public SceneObject()
        {
            Transform = new Transform2D();
        }

        public virtual void OnEveryFrame() { }
    }
}
