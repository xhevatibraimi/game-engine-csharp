namespace SimpleVideoGame.GamePresenter
{
    public class LinearMovementObject : SceneObject
    {
        private readonly int maxiXPosition = 400;
        private readonly int maxiYPosition = 400;

        public override void OnEveryFrame()
        {
            Transform.Position = new Vector2D(Transform.Position.X + 1f, Transform.Position.Y + 0.5f);
            if (Transform.Position.X > maxiXPosition)
                Transform.Position.X = 0;
            if (Transform.Position.Y > maxiYPosition)
                Transform.Position.Y = 0;

        }
    }
}
