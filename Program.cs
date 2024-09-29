using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2all4
{

    // Интерфейс IDrawable с методом Draw
    interface IDrawable
    {
        void Draw();
    }

    // Класс Circle, реализующий интерфейс IDrawable
    class Circle : IDrawable
    {
        public double Radius { get; set; }

        // Конструктор для инициализации радиуса круга
        public Circle(double radius)
        {
            Radius = radius;
        }

        // Реализация метода Draw для рисования круга
        public void Draw()
        {
            Console.WriteLine($"Рисуем круг с радиусом {Radius}");
        }
    }

    // Класс Rectangle, реализующий интерфейс IDrawable
    class Rectangle : IDrawable
    {
        public double Width { get; set; }
        public double Height { get; set; }

        // Конструктор для инициализации ширины и высоты прямоугольника
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        // Реализация метода Draw для рисования прямоугольника
        public void Draw()
        {
            Console.WriteLine($"Рисуем прямоугольник с шириной {Width} и высотой {Height}");
        }
    }

    // Класс Triangle, реализующий интерфейс IDrawable
    class Triangle : IDrawable
    {
        public double Base { get; set; }
        public double Height { get; set; }

        // Конструктор для инициализации основания и высоты треугольника
        public Triangle(double triangleBase, double height)
        {
            Base = triangleBase;
            Height = height;
        }

        // Реализация метода Draw для рисования треугольника
        public void Draw()
        {
            Console.WriteLine($"Рисуем треугольник с основанием {Base} и высотой {Height}");
        }
    }

    class Program
    {
        static void Main()
        {
            // Создаем массив объектов, реализующих интерфейс IDrawable
            IDrawable[] drawableObjects = new IDrawable[]
            {
            new Circle(10),         // Круг с радиусом 10
            new Rectangle(5, 11),   // Прямоугольник шириной 5 и высотой 11
            new Triangle(10, 5)     // Треугольник с основанием 10 и высотой 5
            };

            // Вызываем метод Draw() для каждого объекта в массиве
            foreach (IDrawable drawable in drawableObjects)
            {
                drawable.Draw();
            }
            Console.ReadLine();
        }
    }
}