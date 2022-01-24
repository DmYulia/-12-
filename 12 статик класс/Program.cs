using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace _12_статик_класс
{
    class Program
    {
        static int Main(string[] args)
        {
            string q = "";
            double r, x, y, cx, cy;
        Zero:
            WriteLine("             Введите код необходимого пункта меню:");
            WriteLine("1 - Расчитать длину окружности через радиус.");
            WriteLine("2 - Расчитать площадь круга через радиус.");
            WriteLine("3 - Определить принадлежность точки к кругу с заданными параметрами.");
            WriteLine("q - Выход из программы.");
        Begin:
            try
            {
                q = ReadLine();
            }
            catch(Exception e)
            {
                WriteLine(e.Message);
                goto Begin;
            }
            switch (q)
            {
                case "1":
                C1:
                    Write("Введите радиус окружности: ");//радиус обрабатывается по модулю во всех методах класса
                    try
                    {
                        r = ToDouble(ReadLine());
                    }
                    catch(Exception e)
                    {
                        WriteLine(e.Message);
                        goto C1;
                    }
                    WriteLine($"Длина окружности равна {Circle.Length(r)} .");
                    ReadKey();
                    goto Zero;
                case "2":
                C2:
                    Write("Введите радиус окружности: ");//радиус обрабатывается по модулю во всех методах класса
                    try
                    {
                        r = ToDouble(ReadLine());
                    }
                    catch (Exception e)
                    {
                        WriteLine(e.Message);
                        goto C2;
                    }
                    WriteLine($"Площадь круга равна {Circle.Square(r)} .");
                    ReadKey();
                    goto Zero;
                case "3":
                    WriteLine("Введите координаты точки, радиус круга и координаты центра круга: ");//радиус обрабатывается по модулю во всех методах класса
                C3_x:
                    Write("x точки = ");
                    try
                    {
                        x = ToDouble(ReadLine());
                    }
                    catch (Exception e)
                    {
                        WriteLine(e.Message);
                        goto C3_x;
                    }
                C3_y:
                    Write("y точки = ");
                    try
                    {
                        y = ToDouble(ReadLine());
                    }
                    catch (Exception e)
                    {
                        WriteLine(e.Message);
                        goto C3_y;
                    }
                C3_r:
                    Write("Радиус круга = ");
                    try
                    {
                        r = ToDouble(ReadLine());
                    }
                    catch (Exception e)
                    {
                        WriteLine(e.Message);
                        goto C3_r;
                    }
                C3_cx:
                    Write("x центра круга = ");
                    try
                    {
                        cx = ToDouble(ReadLine());
                    }
                    catch (Exception e)
                    {
                        WriteLine(e.Message);
                        goto C3_cx;
                    }
                C3_cy:
                    Write("y центра круга = ");
                    try
                    {
                        cy = ToDouble(ReadLine());
                    }
                    catch (Exception e)
                    {
                        WriteLine(e.Message);
                        goto C3_cy;
                    }
                    if (Circle.Point(x,y,r,cx,cy) == true)
                    {
                        WriteLine("Точка принадлежит кругу.");
                    }
                    else
                    {
                        WriteLine("Точка не принадлежит кругу.");
                    }
                    ReadKey();
                    goto Zero;
                case "q":
                    goto End;
                default:
                    WriteLine("Введен несуществующий код пункта меню!");
                    goto Begin;
            }
        End:
            return 0;
        }
    }
}
