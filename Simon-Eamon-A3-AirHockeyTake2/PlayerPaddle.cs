
using System;
using System.Numerics;

namespace Game10003;

public class PlayerPaddle
{
    public Vector2 position;
    int radius = 20;

    
    // draw player
    public void Render()
    {
        Draw.FillColor = Color.Green;
        Draw.Circle(position, radius);
    }

    public void UpdatePosition()
    {
        position.X = Input.GetMouseX();
        position.Y = Input.GetMouseY();
    }

   
}



