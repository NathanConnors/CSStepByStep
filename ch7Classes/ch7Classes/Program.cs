/*
 * Chapter 7 - Creating and managing classes and objects
 * Page 169
 */
using System;
using System.Collections.Generic;
using System.Text;


namespace ch7Classes
{
    class Program
    {
        static void doWork()
        {
            Point origin = new Point();
            Point bottomRight = new Point(1366, 768);
            double distance = origin.DistanceTo(bottomRight);
            Console.WriteLine("Distance is: {0}", distance);
        }

        static void Main(string[] args)
        {
            try
            {
                doWork();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
