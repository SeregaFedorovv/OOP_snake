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
            //   создадим первую точку на экране:
            Point p1 = new Point();
            p1.x = 1;        //   координата точки №1 горизонтальная
            p1.y = 3;        //   координата точки №1 вертикальная
            p1.sym = '*';    //   символ который будет выводится в указанных координатах точки №1
            //  вызываем фун-ю, которая выведет на экран заанный символ в заданных координатах:
            Draw(p1.x, p1.y, p1.sym);

            //   создадим вторую точку на экране:
            Point p2 = new Point();
            p2.x = 4;
            p2.y = 5;
            p2.sym = '#';
            Draw(p2.x, p2.y, p2.sym);

            Console.ReadLine();
        }

        static void Draw(int x, int y, char sym)
        //  в качестве входных параметров функция принимает  значение переменных x y sym, содержащие координаты точки и символ для вывода на экран
        {
            Console.SetCursorPosition(x, y); //  переместить курсор в указанные  координаты
            Console.Write(sym); //   нарисовать заданный символ
        }
    }
}
