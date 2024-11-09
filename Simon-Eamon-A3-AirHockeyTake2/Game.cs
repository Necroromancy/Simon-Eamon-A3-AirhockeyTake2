using System;
using System.Numerics;

namespace Game10003
{
  
    public class Game
    {
        //variables 
        Puck puck;
        PlayerPaddle player;
        EnemyPaddle enemy;

        public void Setup()
        {
            Window.SetTitle("AirHockey");
            Window.SetSize(600, 800);
            PlayerPaddle playerPaddle = new PlayerPaddle();
            EnemyPaddle enemyPaddle = new EnemyPaddle();

     
        }

    
        //
        public void Update()
        {
          Window.ClearBackground(color: Color.White);
            puck.UpdatePosition();
            enemy.UpdatePosition();
            player.UpdatePosition();

            puck.Render();
            player.Render();
            enemy.Render();

            Goal.Render();

        }

    }
}
