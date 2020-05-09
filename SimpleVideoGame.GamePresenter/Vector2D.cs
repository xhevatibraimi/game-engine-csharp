namespace SimpleVideoGame.GamePresenter
{
    public class Vector2D
    {
        public float X { get; set; }
        public float Y { get; set; }

        public Vector2D() { }
        public Vector2D(float x, float y)
        {
            X = x;
            Y = y;
        }
    }
}