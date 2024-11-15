
using System;
using System.Numerics;

namespace Game10003
{
    public class Goal
    {
        public Vector2 position;
         float radius;
        Color color;
       
        public Goal()
        {
            position = new Vector2(330, 780);
            radius = 55;
        }

        public void Render()
        {
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Red;
            Draw.Rectangle( position.X, position.Y , radius, radius );
        }
    }
}
