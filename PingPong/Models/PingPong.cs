using System;
using System.Collections.Generic;

public class PingPong
{
  public static void LoopyBoi()
  {
    Console.WriteLine("Input a number");
    int countNumber = int.Parse(Console.ReadLine());

    for (int i = 1; i <= countNumber; i++)
    {
      PingPong.ConvertToPingPong(i);
    }
  }
  public static void ConvertToPingPong(int index)
  {
    if (index % 15 == 0)
    {
      Console.WriteLine("Ping-Pong");
    }
    else if (index % 3 == 0)
    {
      Console.WriteLine("Ping");
    }
    else if (index % 5 == 0)
    {
      Console.WriteLine("Pong");
    }
    else
    {
      Console.WriteLine(index.ToString());
    }
  }
}

public class Program
{
  public static void Main()
  {
    PingPong.LoopyBoi();
  }
}
