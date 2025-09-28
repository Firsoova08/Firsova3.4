using Microsoft.VisualBasic;

namespace Firsova3._4
{
    enum TrafficLight { Red, Yellow, Green }
    enum OrderStatus { New, Processing, Shipped, Delivered }
    internal class Program
    {
        static void Main(string[] args)
        {
            //ДЗ Lab3
            //1
            //TrafficLight current = TrafficLight.Green;
            //TrafficLight next;
            //if (current == TrafficLight.Green)
            //    next = TrafficLight.Red;
            //else if (current == TrafficLight.Red)
            //    next = TrafficLight.Yellow;
            //else
            //    next = TrafficLight.Green;
            //Console.WriteLine($"После {current} будет {next}");

            //2
            //bool canOR(OrderStatus status) => status == OrderStatus.New || status == OrderStatus.Processing;
            //Console.Write($"New:{canOR(OrderStatus.New)} ");
            //Console.Write($"Processing:{canOR(OrderStatus.Processing)} ");
            //Console.Write($"Shipped:{canOR(OrderStatus.Shipped)} ");
            //Console.Write($"Delivered:{canOR(OrderStatus.Delivered)}");

            //3
            //for(int i = 10; i >= 1; i--)
            //   {
            //       Console.WriteLine(i);
            //   }

            //4
            // for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine($"5*{i}={5*i}");
            // }
            //5
            //int i = 0;
            //while (i < 10)
            //{
            //       Console.WriteLine("Запомни: всего одна ошибка и ты ошибся.");
            //    i++;
            //}
        }
    }
}
