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
            //6
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i <= n; i++)
            //{
            //    Console.WriteLine($"Квадрат числа {i} равен {i*i}");
            //}
            //7
            //string s = Console.ReadLine();
            //int n = int.Parse(Console.ReadLine());
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine(s);
            //}
            //8
            //     bool a = true;
            //        for (int i = 0; i < 10; i++)
            //        {
            //            int number = int.Parse(Console.ReadLine());

            //            if (number % 2 != 0)
            //            {
            //                a = false;
            //            }
            //        }
            //    Console.WriteLine(a ? "YES" : "NO");
            //9
            //int shot = 0;

            //for (int i = 1; i <= 3; i++)
            //{
            //    Console.WriteLine("Выстрел совершен");
            //    shot++;
            //    Console.WriteLine($"Израсходовано боезапасов: {shot}");
            //    if (i < 3)
            //    {
            //        Console.Write("Нажмите Enter для выстрела: ");
            //        string input = Console.ReadLine();

            //        if (input?.ToLower() == "стоп")
            //        {
            //            Console.WriteLine("Огонь прекращен!");
            //            break;
            //        }
            //    }
            //}

            //ДЗ 4
            //1
            //string[] m = { "sword", "shield", "potion", "sword", "potion", "potion" };
            //foreach (string i in m)
            //{
            //     Console.WriteLine(i);
            //}
            //2
            //int[] m = { 10, 20, 15, 30, 25 };
            //int c = 0;
            //for (int i = 0; i < m.Length; i++) {
            //    c += m[i];
            //}
            //Console.WriteLine($"Общее количество очков: {c}");
            //3
            //int[] m = { 1, 3, 7, 2, 5 };
            //int max = m[0];
            //for (int i = 1; i < m.Length; i++)
            //{
            //  if (m[i] > max)
            //  {
            // max = m[i];
            //  }
            //}
            //Console.WriteLine(max);
            //4
            //int[] m= { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int x = 0;
            //int y=0;
            //for (int i = 0; i < m.Length; i++) {

            //    if (m[i] % 2 == 0) {
            //        x++;
            //    }
            //    else
            //    {
            //        y++;
            //    }
            //}
            //Console.WriteLine($"{x} четных и {y} нечетных");
        }
    }
       
}
    

