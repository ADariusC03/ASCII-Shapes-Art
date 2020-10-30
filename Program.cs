using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace training
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ASCII Shape Art");
            Console.WriteLine();

            // the numbers 50 and 20 represent the width and hieght of the
            // shape. w = 50 & h = 20.
            // Use int to make variables for the sizing


            int w = 50;
            int h = 20;

            Console.WriteLine("Solid Rectangle");
            for (int a = 0; a < h; a++)
            {
                for (int b = 0; b < w; b++)
                {
                    Console.Write("+");
                }
                Console.WriteLine();
            }

         
            Console.WriteLine();



            // int borderW is the width of the border. Making the top and
            // bottom show as the inside be another char.
            // wi = 40, hi = 12....width & height
            int borderW = 3;// depending of the number 1-6, the border is wide-dense.
            int wi = 40;
            int hi = 12;

            Console.WriteLine("Border Rectangle");

            for (int c = 0; c < hi; c++)
            {
                for (int d = 0; d < wi; d++)
                {
                    if (c < borderW || c > hi -1 - borderW || d < borderW || d > wi - 1 - borderW)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write(' ');// space left open is called white space.
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            // Use of the %(module), to have on and off effect with the height and width.
            // Even rows stay the same, Odd rows are given Even number, but will be thrown off or shifted.
            Console.WriteLine("Checkered Patteren");

            for (int c = 0; c < hi; c++)
            {
                for (int d = 0; d < wi; d++)
                {
                    if ((c + d)% 2 == 0)// even numbers or the next char is shown(diff char)/off(white space)
                    {
                     Console.Write('█');// use of special char full block

                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();




            Console.WriteLine("Pyramid");
            // PyramidWidth is 2 times the height - 1 unit, 
            // CenterColumn is heigth of the pyramid - 1 unit
            int pw = 2 * hi - 1;
            int cc = hi - 1;

            for (int c = 0; c < hi; c++)// goes up and down
            {
                for (int d = 0; d < pw; d++)// left to right
                {
                    if (d >= cc - c && d <= cc + c)
                    {
                        Console.Write('*');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();



            Console.WriteLine("Small Condense Circle");
            //Calculating the distance from the center with the c,d coordinates
            //f is the distance
            // r is radius
            double centerX = wi / 2.0;
            double centerY = hi / 2.0;
            double r = 0.0;

            if (hi < wi)
            {
                r = 0.5 * hi;
            }
            else
            {
                r = 0.5 * wi;
            }
            for (int c = 0; c < hi; c++)
            {
                for (int d = 0; d < wi; d++)
                {
                    double fx = d - centerX;// vertical from the center
                    double fy = c - centerY;// horizontal from the center
                    double f = Math.Sqrt(fx * fx + fy * fy);

                    if (f < r)
                    {
                        Console.Write('#');
                    }
                    else
                    {
                        Console.Write('.');
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();


            Console.ReadKey();

        }
    }
}
