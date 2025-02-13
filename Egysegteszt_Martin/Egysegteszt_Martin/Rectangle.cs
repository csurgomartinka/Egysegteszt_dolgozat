using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Egysegteszt_Martin
{
    public class Rectangle
    {
        public double CalCulateArea(double width, double height)
        {
            if (width < 0 || height < 0)
            {
                throw new ArgumentException("Nem lehet negatív!");
            }
            return width * height;
        }
        static void Main(string[] args)
        {
            Console.Write("A téglalap egyik oldala: ");
            double szelesseg = Convert.ToDouble(Console.ReadLine());
            Console.Write("A téglalap másik oldala: ");
            double magassag = Convert.ToDouble(Console.ReadLine());
            var teglalap = new Rectangle();
            Console.WriteLine($"A téglalap területe: {teglalap.CalCulateArea(szelesseg,magassag)}");

            Console.ReadKey();
        }
    }
}
