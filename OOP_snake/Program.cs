using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_snake
{
    class Program
    {
        static void Main(string[] args)
        {
         
            Point p1 = new Point(); //   создадим первую точку на экране
            p1.x = 1;               //   координата точки №1 горизонтальная
            p1.y = 3;               //   координата точки №1 вертикальная
            p1.sym = '*';           //   символ который будет выводится в указанных координатах точки №1
            p1.Draw(); //  вызываем фун-ю, которая выведет на экран заанный символ в заданных координатах


            Point p2 = new Point();//   создадим вторую точку на экране:
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            p2.Draw();

            Console.ReadLine();
        }
    }
}
