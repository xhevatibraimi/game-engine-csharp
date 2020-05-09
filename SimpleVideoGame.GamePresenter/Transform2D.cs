namespace SimpleVideoGame.GamePresenter
{
    public class Transform2D
    {
        public Vector2D Position { get; set; }
        public Vector2D Rotation { get; set; }
        public Vector2D Scale { get; set; }

        public Transform2D()
        {
            Position = new Vector2D();
            Rotation = new Vector2D();
            Scale = new Vector2D();
        }

        public Transform2D(Vector2D position, Vector2D rotation, Vector2D scale)
        {
            Position = position;
            Rotation = rotation;
            Scale = scale;
        }
    }
}
