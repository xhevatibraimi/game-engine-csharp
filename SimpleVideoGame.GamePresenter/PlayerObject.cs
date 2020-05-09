namespace SimpleVideoGame.GamePresenter
{
    public class PlayerObject : SceneObject
    {
        public override void OnEveryFrame()
        {
            MoveIfNavigationKeysArePressed();
        }

        private void MoveIfNavigationKeysArePressed()
        {
            if (Input.IsKeyDown("a"))
                Transform.Position.X -= 1;
            else if (Input.IsKeyDown("s"))
                Transform.Position.Y += 1;
            else if (Input.IsKeyDown("w"))
                Transform.Position.Y -= 1;
            else if (Input.IsKeyDown("d"))
                Transform.Position.X += 1;
        }
    }
}
