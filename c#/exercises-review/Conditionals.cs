using System;

namespace exercises_review
{
    public class Conditionals
    {
        public void Ex1()
        {
            Console.Write("Enter a number between 1 and 10: ");
            var input = Console.ReadLine();
            int number = Convert.ToInt32(input);

            if (number >= 1 && number <= 10)
                Console.WriteLine("Valid");
            else
                Console.WriteLine("Invalid");
        }

        public void Ex2()
        {
            Console.Write("Enter a number: ");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter another number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());

            var max = (number1 > number2 ? number1 : number2);

            Console.WriteLine(max);

        }

        public void Ex3()
        {
            Console.Write("Enter image width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter image height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            var orientation = width > height ? "landscape" : "portrait";
            Console.WriteLine(orientation);
        }

        public void Ex4()
        {
            Console.Write("Enter speed limit: ");
            int limit = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter current speed: ");
            int speed = Convert.ToInt32(Console.ReadLine());

            if (speed < limit)
            {
                Console.WriteLine("OK");
                break;
            }

            int overage = (speed - limit);
            int demerits = 0;
            for (var i = 0; i <= overage; i+5)
            {
                demerits++;
            }

            if (demerits > 12)
            {
                Console.WriteLine("License Suspended");
            }
        }



    }
}
