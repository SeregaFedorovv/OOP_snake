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
            //   создадим несколько точек на экране:
            int x1 = 1; //   координата точки №1 горизонтальная 
            int y1 = 3; //   координата точки №1 вертикальная
            char sym1 = '*'; //   символ который будет выводится в указанных координатах точки №1

            Draw(x1, y1, sym1); //  вызываем фун-ю, которая выведет на экран заанный символ в заданных координатах 

            int x2 = 4;
            int y2 = 5;
            char sym2 = '#';

            Draw(x2, y2, sym2);

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
