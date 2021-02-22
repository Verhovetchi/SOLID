using System;

namespace ViolationISP
{
     public abstract class Player
     {
          public abstract void Show();
     }

     public class Goalkeeper : Player, IPlay
     {
          public void PlayWithFeet() => Console.WriteLine("I can shoot the ball with my feet!!!");

          public void PlayWithHands() => Console.WriteLine("I can touch the ball with hands!!!"); 

          public override void Show()
          {
               Console.WriteLine("I am a goalkeeper!!!");
               PlayWithFeet();
               PlayWithHands();
          }
     }

     public class Defender : Player, IPlay
     {
          public void PlayWithFeet() => Console.WriteLine("I can shoot the ball with my feet!!!");

          public void PlayWithHands() => throw new Exception("I can't touch the ball with my hands");

          public override void Show()
          {
               Console.WriteLine("I am a defender");
               PlayWithFeet();
               PlayWithHands();
          }
     }

     public class Midfield : Player, IPlay
     {
          public void PlayWithFeet() => Console.WriteLine("I can shoot the ball with my feet!!!");

          public void PlayWithHands() => throw new Exception("I can't touch the ball with my hands");

          public override void Show()
          {
               Console.WriteLine("I am a midfield");
               PlayWithFeet();
               PlayWithHands();
          }
     }

     public class Forward : Player, IPlay
     {
          public void PlayWithFeet() => Console.WriteLine("I can shoot the ball with my feet!!!");

          public void PlayWithHands() => throw new Exception("I can't touch the ball with my hands");

          public override void Show()
          {
               Console.WriteLine("I am a forward");
               PlayWithFeet();
               PlayWithHands();
          }
     }
}