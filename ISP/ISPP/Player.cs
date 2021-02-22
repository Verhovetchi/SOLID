using System;

namespace ISPP
{
     public abstract class Player
     {
          public abstract void Show();
     }

     public class Goalkeeper : Player, IPlayWithHands, IPlayWithFeet
     {
          public void BallCatch() => Console.WriteLine("I can touch the ball with hands!!!");

          public void BallShoot() => Console.WriteLine("I can shoot the ball with my feet!!!");

          public override void Show()
          {
               Console.WriteLine("I am a goalkeeper!!!");
               BallCatch();
               BallShoot();
          }
     }

     public class Defender : Player, IPlayWithFeet
     {
          public void BallShoot() => Console.WriteLine("I can shoot the ball with my feet!!!");

          public override void Show()
          {
               Console.WriteLine("I am a defender");
               BallShoot();
          }
     }

     public class Midfield : Player, IPlayWithFeet
     {
          public void BallShoot() => Console.WriteLine("I can shoot the ball with my feet!!!");
          
          public override void Show() => BallShoot();
     }

     public class Forward : Player, IPlayWithFeet
     {
          public void BallShoot() => Console.WriteLine("I can shoot the ball with my feet!!!");

          public override void Show()
          {
               Console.WriteLine("I am a forward");
               BallShoot();
          }
     }
}
