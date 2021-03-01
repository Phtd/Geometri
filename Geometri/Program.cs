using System;

namespace Geometri
{
    class Program
    {
        static void Main(string[] args)
        {
            Square squareOne = new Square(20, 10, 15); // Sets the values of a, b and c. the sides of the square

            Square squareTwo = new Square(20, 10, 15);

            squareTwo.A = 25; // changes the value for A, by setting the value
            squareTwo.B = 5;
            squareTwo.C = 12;

            Console.WriteLine("The circumference of Square 1 is = " + squareOne.Omkreds()); // Calls the method "omkreds" and uses it. Then it displays the result on the screen

            Console.WriteLine("Area of Square 1 is = " + squareOne.Areal()); // Calls the method called "Areal" and uses it. Then it displays the result on the screen


            Console.WriteLine("The circumference of Square 2 is = " + squareTwo.Omkreds());
            Console.WriteLine("Area of Square  2 is = " + squareTwo.Areal());



            Console.ReadKey(); // Prevents the program from shutting down once its done, unless a button is pressed
        }
    }
}
