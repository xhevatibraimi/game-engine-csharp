namespace SimpleVideoGame.GamePresenter
{
    public class PoliceOfficerObject : SceneObject
    {
        public override void OnEveryFrame()
        {
            Transform.Position.X -= 0.5f;
        }
    }
}
