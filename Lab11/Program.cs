using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                Console.WriteLine("Программа для решения линейного уравнения типа kx+b=0");
                Console.Write("Введите значение k= ");
                double k1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Введите значение b= ");
                double b1 = Convert.ToDouble(Console.ReadLine());
                Lin lin1 = new Lin { k = k1, b = b1 };
                lin1.Root();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Неверный ввод");
            }
                 Console.ReadKey();
        }
    }
    struct Lin
    {
        public double k;   
        public double b;
        public void Root()
        {
            double answer = -b / k;
            Console.WriteLine("Ответ={0,8:f3}",answer);
        }
    }
}
