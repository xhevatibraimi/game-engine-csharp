using System;
using System.Drawing;

namespace SimpleVideoGame.GamePresenter
{
    public static class BitmapExtensions
    {
        public static void TrySetPixel(this Bitmap bitmap, int x, int y, Color color)
        {
            try
            {
                bitmap.SetPixel(x, y, color);
            }
            catch (Exception) { }
        }
    }
}
