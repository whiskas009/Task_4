using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите кол-во картинок");
            int pictures = int.Parse(Console.ReadLine());

            Console.WriteLine("Введите кол-во картинок в одном ряду");
            int picturesInRow = int.Parse(Console.ReadLine());

            int fullRows = pictures / picturesInRow;
            double picturesNotContained = pictures % fullRows;

            Console.WriteLine($"Количество полных рядов составляет: {fullRows}\nКоличество невместившихся картинок: {picturesNotContained}");
        }
    }
}
