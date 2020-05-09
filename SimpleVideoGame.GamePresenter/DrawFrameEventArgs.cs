using System.Drawing;

namespace SimpleVideoGame.GamePresenter
{
    public class DrawFrameEventArgs
    {
        public Bitmap Bitmap { get; private set; }

        public DrawFrameEventArgs(Bitmap drawArea)
        {
            Bitmap = drawArea;
        }
    }
}
