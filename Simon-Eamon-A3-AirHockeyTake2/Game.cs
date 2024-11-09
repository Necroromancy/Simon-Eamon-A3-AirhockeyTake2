using System;
using System.Numerics;

namespace Game10003
{
  
    public class Game
    {
        // Place your variables here:


        /// <summary>
        ///     Setup runs once before the game loop begins.
        /// </summary>
        public void Setup()
        {
            Window.SetTitle("AirHockey");
            Window.SetSize(600, 800);

     
        }

        /// <summary>
        ///     Update runs every frame.
        /// </summary>
        public void Update()
        {
            Playerpaddle.UpdatePosition();
            {

            }
            EnemyPaddle.UpdatePosition();
        }
    }
}
