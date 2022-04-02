using System;

namespace algorytmy2
{
    class Program
    {
        static void Main(string[] args)
        {
            float a = float.Parse(Console.ReadLine());
            float b = float.Parse(Console.ReadLine());
            float c = float.Parse(Console.ReadLine());
            float d = float.Parse(Console.ReadLine());
            
            

            double w = (-b / (3 * a));
            double w2 = w * w;
            double w3 = w * w * w;

            double p = ((3 * a * w2) + (2 * b * w) + c) / a;
            double q = ((a * w3) + (b * w3) + (c * w) + d) / a;
            double delta = ((q * q) / 4) + ((p * p * p) / 27);
            double u = (Math.Cbrt((-q / 2) + Math.Sqrt(delta)));
            double v = (Math.Cbrt((-q / 2) - Math.Sqrt(delta)));
             void writ(double a)
            {
                Console.WriteLine(System.Math.Round(a, 2));
                
            }
            if (delta > 0)
            {
                
                double x1 = u + v + w;
                double x2 = -((u + v) / 2) + w + ((Math.Sqrt(3) / 2) * (u - v));
                double x3 = -((u + v) / 2) + w -((Math.Sqrt(3) / 2) * (u - v));

                writ(x1);
                writ(x2);
                writ(x3);

            }
            else if (delta < 0)
            {
                double fi = Math.Acos((3 * q) / (2 * p * Math.Sqrt(-p / 3)));
                double x1 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos(fi / 3));
                double x2 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3)+(2/3)*Math.PI));
                double x3 = w + (2 * Math.Sqrt(-p / 3) * Math.Cos((fi / 3) + (4 / 3) * Math.PI));

                writ(x1);
                writ(x2);
                writ(x3);
            }
            else
            {
                double x1 = w - 2 * Math.Cbrt(q / 2);
                double x23 = w + 2 * Math.Cbrt(q / 2);

                writ(x1);
                writ(x23);
              
            }
            Console.ReadKey();
        }
    }
}
