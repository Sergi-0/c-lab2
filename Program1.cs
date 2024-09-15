using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2_2
{
    class vehicle
    {
        protected double x;
        protected double y;
        protected int cost;
        protected int speed;
        protected int year;

        public vehicle(double x, double y, int cost, int speed, int year)
        {
            this.x = x; 
            this.y = y;
            this.cost = cost;
            this.speed = speed;
            this.year = year;
        }

        public virtual void Info() { }
    }

    class Plane: vehicle
    {
        private int h;
        private int numper_p;
        public Plane(int h, int numper_p, double x, double y, int cost, int speed, int year): base(x, y, cost, speed, year)
        {
            this.h = h;
            this.numper_p = numper_p;
        }

        public override void Info()
        {
            Console.WriteLine($"Самолет: Высота: {h}, Количество пассажиров: {numper_p}, координата x: {x}, координата y: {y}, цена: {cost}, скорость : {speed}, год выпуска: {year}");
        }
    }

    class Car: vehicle
    {
        private int numper_p;

        public Car(int numper_p, double x, double y, int cost, int speed, int year) : base(x, y, cost, speed, year)
        {
            this.numper_p = numper_p;
        }

        public override void Info()
        {
            Console.WriteLine($"Машина: Количество пассажиров: {numper_p}, координата x: {x}, координата y: {y}, цена: {cost}, скорость : {speed}, год выпуска: {year}");
        }
    }

    class Ship: vehicle
    {
        private int numper_p;
        private string port;

        public Ship(int numper_p, string port, double x, double y, int cost, int speed, int year) : base(x, y, cost, speed, year)
        {
            this.numper_p = numper_p;
            this.port = port;
        }

        public override void Info()
        {
            Console.WriteLine($"Корабль: Конечный порт: {port}, Количество пассажиров: {numper_p}, координата x: {x}, координата y: {y}, цена: {cost}, скорость : {speed}, год выпуска: {year}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car(4,31,40, 3000000, 330, 2021);
            Plane plane = new Plane(10000, 125, 40, 50, 10000000, 900, 2011);
            Ship ship = new Ship(100, "Альбукерке", 31, 29, 35000000, 30, 1999);
            car.Info();
            plane.Info();
            ship.Info();
            Console.ReadLine();
        }
    }
}
