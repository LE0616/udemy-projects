using System;

namespace exercises_review
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

        var sum = 0;

        while (true)
        {
          Console.Write("Enter a number or OK to exit: ");
          var input = Console.ReadLine();

          if (input == "OK" || input == "ok") //input.ToLower() == "ok"
          {
            break;
          }

          sum += Convert.ToInt32(input);
        }

        Console.WriteLine("Sum of all number is: " + sum);
      }
    public void Ex3()
      {
        Console.Write("Enter a number: ");
        var input = Convert.ToInt32(Console.ReadLine());

        var factorial = 1;
        for (var i = input; i <= 1; i--)
        {
          factorial *= i;
        }

        Console.WriteLine("{0}! = {1}", input, factorial);
      }
    // public void Ex4()
    //   {

    //   }
    // public void Ex5()
    //   {

    //   }

  }
}
