using System;
using System.Numerics;


namespace Game10003;


public class Game
{
  //variables 
    Puck puck;
    PlayerPaddle player;
    EnemyPaddle enemy;
    int score = 0;
    
    public void Setup()
    {
        Window.SetTitle("Air Hockey");
        Window.SetSize(600, 800);
    
        player = new PlayerPaddle();
        enemy = new EnemyPaddle();
        puck = new Puck();
     

    }


    //
    public void Update()
    {
        Draw.FillColor = Color.Green;
        Draw.LineColor = Color.Black;


        Window.ClearBackground(Color.White);


        
       
        enemy.UpdatePosition();
        player.UpdatePosition();
        puck.UpdatePosition();

        player.Render();
        enemy.Render();
        puck.Render();

        Text.Draw($"Score: {score}", 50, 700);
        
    }

}
