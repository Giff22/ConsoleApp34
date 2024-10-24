using System;
using System.Text;

namespace lab1
{
    internal class Program
    {


        public class Angle
        {
            private int grad;
            private int min; // Закриті поля класу
            public Angle(int grad, int min) // Конструктор з параметрами
            {
                this.grad = grad;
                this.min = min;
            }

            public bool Correct() // Метод для перевірки правильності кута
            {
                return grad > 0 && grad < 360 && min >= 0 && min < 60;
            }

            public double Rad() // Метод для переведення кута в радіани
            {
                double totalDegrees = grad + (min / 60.0);
                return totalDegrees * Math.PI / 180.0;
            }

            public double Psin() // Метод для обчислення синуса кута
            {
                return Math.Sin(Rad());
            }

            public void Print() // Метод для виведення значень полів на екран
            {
                Console.WriteLine($"Градуси: {grad}, Хвилини: {min}");
            }
        }

        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                int grad, min;

                try
                {
                    Console.OutputEncoding = Encoding.UTF8;

                    Console.Write("Введіть градуси (0-359): ");   // Введення градусів і хвилин з клавіатури
                    grad = Convert.ToInt32(Console.ReadLine());

                    Console.Write("Введіть хвилини (0-59): ");   // Введення градусів і хвилин з клавіатури
                    min = Convert.ToInt32(Console.ReadLine());

                    Angle angle = new Angle(grad, min);  // Створення об'єкта Angle

                    angle.Print(); // Виведення полів кута

                    if (angle.Correct())// Перевірка правильності кута
                    {
                        // Виведення результатів розрахунків

                        double radians = angle.Rad();
                        double sine = angle.Psin();
                        Console.WriteLine($"Кут у радіанах: {radians:F3}");
                        Console.WriteLine($"Синус кута: {sine:F3}");
                    }
                    else
                    {
                        Console.WriteLine("Кут не може існувати.");
                    }
                }
                catch
                {
                    Console.WriteLine("Сталася помилка при введенні даних. Спробуйте ще раз.");
                }

                Console.ReadKey();
            }
        }
    }
}

