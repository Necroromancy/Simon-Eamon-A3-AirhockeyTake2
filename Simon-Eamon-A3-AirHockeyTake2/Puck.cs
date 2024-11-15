
using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;
namespace Game10003;

public class Puck
{
    public Vector2 position;
    public Vector2 velocity;
    float point;
    float radius;
    Color color;

    public Puck()
    {
        position = new Vector2(300, 400);
        velocity = Random.Direction() * 360;
        color = Color.Black;
        radius = 15;
    }

    public void Render()
    {
        Draw.FillColor = color;
        Draw.Circle(position, radius);
    }

    public void UpdatePosition()
    {
        UpdateVelocity();
        ConstrainToWindowBounds();
        position += velocity * Time.DeltaTime;
    }



    public void UpdateVelocity()
    {
        radius = 15;

        
        //position = Random.Vector2(radius, Window.Width - radius, radius, Window.Height - radius);
    }

    public bool ConstrainToWindowBounds()
    {
        // Keep  Puck inside screen
        bool isTouchingTop = position.Y <= 0 + radius;
        bool isTouchingBottom = position.Y >= Window.Height - radius;
        bool isTouchingLeft = position.X <= 0 + radius;
        bool isTouchingRight = position.X >= Window.Width - radius;

        if (isTouchingTop || isTouchingBottom)
        {
            velocity.Y = -velocity.Y;
        }

        if (isTouchingRight || isTouchingLeft)
        {
            velocity.X = -velocity.X;
        }

        if (isTouchingLeft || isTouchingRight || isTouchingBottom || isTouchingTop)
        {
            return true;
        }

        return false;
    }
}
