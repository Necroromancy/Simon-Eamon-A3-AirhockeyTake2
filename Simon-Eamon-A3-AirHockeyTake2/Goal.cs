
using System;
using System.Numerics;

namespace Game10003
{
    public class Goal
    {
        public Vector2 position;
        float radius = 55;
        public Vector2 size;

        public void Render()
        {
            Draw.FillColor = Color.Clear;
            Draw.LineColor = Color.Red;
            Draw.Rectangle( position , radius );
        }

        
    }
}
