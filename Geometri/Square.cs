using System;
using System.Collections.Generic;
using System.Text;

namespace Geometri
{
    public class Square
    {
        private float a; // My variable floats for the square sides
        private float b;
        private float c;
        private float d;
        public float A  // gets and sets the value of the float a
        {
            get { return a; }
            set { a = value; }
        }
        public float B  // gets and sets the value of the float a
        {
            get { return b; }
            set { b = value; }
        }
        public float C  // gets and sets the value of the float a
        {
            get { return c; }
            set { c = value; }
        }

        public Square(float a, float b, float c) // the constructor and object called Square
        {
            A = a;
            B = b;
            C = c;
        }


        // A method called "Omkreds". It returns the circumference of a square, With the help of the variable float a.

        public float Omkreds()
        {
            return A * 4; // Using this calculation, it returns the value of "Omkreds" 
        }

        //  A method called "Areal". 

        public float Areal()
        {
            return B * C; // Using this calculation, it returns the value of the "Area" method
        }

        public Square(float a)
        {
            A = a;
        }

    }
}
