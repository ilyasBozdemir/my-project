using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            Point2D point = new Point2D()
            {
                X = rnd.Next(0, 20),
                Y = rnd.Next(0, 20)
            };
            Point2D point2 = new Point2D()
            {
                X = rnd.Next(0, 10),
                Y = rnd.Next(0, 10)
            };
            Console.WriteLine($"\"point\" : {point}");
            Console.WriteLine($"\"point2\" : {point2}");
            Console.WriteLine();
            Console.WriteLine($"\"point + point2\" : {point + point2}");
            Console.WriteLine($"\"point - point2\" : {point - point2}");
            Console.WriteLine($"\"point * point2\" : {point * point2}");
            Console.WriteLine($"\"point / point2\" : {point / point2}");
            Console.WriteLine($"\"point == point2\" : {point == point2}");
            Console.WriteLine($"\"point != point\" : {point != point2}");
            Console.ReadLine();
        }
    }

    public struct Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Point2D(int X, int Y) { this.X = X; this.Y = Y; }
        public override string ToString()
        {
            return $"X : {this.X} Y: {this.Y}";
        }
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        public static Point2D operator +(Point2D a, Point2D b)
        {
            Point2D point2 = new Point2D();
            point2.X = a.X + b.X;
            point2.Y = a.Y + b.Y;
            return point2;
        }
        public static Point2D operator -(Point2D a, Point2D b)
        {
            Point2D point2 = new Point2D();
            point2.X = a.X - b.X;
            point2.Y = a.Y - b.Y;
            return point2;
        }
        public static Point2D operator *(Point2D a, Point2D b)
        {
            Point2D point2 = new Point2D();
            point2.X = a.X * b.X;
            point2.Y = a.Y * b.Y;
            return point2;
        }
        public static Point2D operator /(Point2D a, Point2D b)
        {
            Point2D point2 = new Point2D();
            point2.X = a.X / b.X;
            point2.Y = a.Y / b.Y;
            return point2;
        }
        public static bool operator !=(Point2D a, Point2D b)
        {
            bool durum = false;
            if (a.X != b.X)
            {
                if (a.Y != b.Y)
                {
                    durum = true;
                }
            }
            return durum;
        }
        public static bool operator ==(Point2D a, Point2D b)
        {
            bool durum = false;
            if (a.X == b.X)
            {
                if (a.Y == b.Y)
                {
                    durum = true;
                }
            }
            return durum;
        }

    }
}
