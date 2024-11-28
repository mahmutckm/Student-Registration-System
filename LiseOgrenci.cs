using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    internal class LiseOgrenci:Ogrenci
    {
        public double Point {  get; set; }
        public double Point1 {  get; set; }
        public LiseOgrenci(string nameusername, string schoolnumber, string schoolname, Educationlevel educationlevel, double point, double point1) : base(nameusername, schoolnumber, schoolname, educationlevel)
        {
            this.Point = point;
            this.Point1 = point1;
        }
        public void NotHesapla()
        {
            double average = (Point + Point1) / 2;
            if (average >=85 && average <=100)
            {
                Console.WriteLine($"Ortalamanız: {average} Pek iyi");
            }
            else if (average >= 70 && average <= 84.99)
            {
                Console.WriteLine($"Ortalamanız: {average} İyi");
            }
            else if (average >= 60 && average <= 69.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Orta");
            }
            else if (average >= 50 && average <= 59.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Geçer");
            }
            else if (average >= 0 && average <= 49.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Tekrar");
            }
            else
            {
                Console.WriteLine("Hatalı not!");
            }
        }
    }
}
