using System;

namespace SimpleVideoGame.GamePresenter
{
    public class CircleMovementObject : SceneObject
    {
        private int counter = 0;

        public override void OnEveryFrame()
        {
            Transform.Position.Y = 100 * (float)Math.Sin(DegreeToRadian(counter));
            Transform.Position.X = 100 * (float)Math.Cos(DegreeToRadian(counter));
            counter++;
            if (counter == 360)
                counter = 0;
        }

        private double DegreeToRadian(double angle)
        {
            return Math.PI * angle / 180.0;
        }
    }
}
