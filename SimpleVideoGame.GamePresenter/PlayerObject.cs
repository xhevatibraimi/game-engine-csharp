using System.Windows.Input;

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
            //if (Keyboard.IsKeyDown(Key.A))
            //    Transform.Position.X -= 1;
            //else if (Keyboard.IsKeyDown(Key.S))
            //    Transform.Position.Y -= 1;
            //else if (Keyboard.IsKeyDown(Key.W))
            //    Transform.Position.Y += 1;
            //else if (Keyboard.IsKeyDown(Key.D))
            //    Transform.Position.X += 1;
        }
    }
}
