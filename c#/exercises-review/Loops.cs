using System;

namespace CSharp1Exercises.ControlFlow
{
  public class Loops
  {
    public void Ex1()
      {
        int count = 0;

        for (var i = 1; i <= 100; i++)
        {
          if (i%3 == 0) count++;
        }

        Console.WriteLine(count);
      }
    public void Ex2()
      {
        Console.Write("Enter a number or OK to exit: ");
        var input = Console.Read();

        // if input is an intager add to sum
        // if OK exit
        // else
        Console.WriteLine("Input is invalid");
      }
    public void Ex3()
      {

      }
    public void Ex4()
      {

      }
    public void Ex5()
      {

      }

  }
}
