
using System;
using System.Numerics;

namespace Game10003;

public class EnemyPaddle
{
    public Vector2 position;
    public Vector2 velocity;
    float radius;
    Color color;

    public EnemyPaddle()
    {
        radius = 90;
        color = Color.Cyan;
        position.X = 400;
        position.Y = 100;
        velocity.X = 200;
    }

    public void Render()
    {
        Draw.FillColor = color;
        Draw.Rectangle(position.X, position.Y, radius, radius);
    }

    public void UpdatePosition()
    {
        position += velocity * Time.DeltaTime;

        // flip paddle when it hits screen eddge
        if (position.X > Window.Width - radius)
        {
            velocity = -velocity;
        }
        else if (position.X < 0)
        {
            velocity = -velocity;
        }
    }
}


