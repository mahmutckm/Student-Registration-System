using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    internal class LisansOgrenci:Ogrenci
    {
        public string Faculty {  get; set; }
        public double Midtermexam {  get; set; }
        public double Finalgrad {  get; set; }
        public LisansOgrenci(string nameusername, string schoolnumber, string schoolname, Educationlevel educationlevel, string faculty, double midterexam, double finalgrad) : base(nameusername, schoolnumber, schoolname, educationlevel)
        {
            this.Faculty = faculty;
            this.Midtermexam = midterexam;
            this.Finalgrad = finalgrad;           
        }
        public void NotHesapla()
        {
            Console.WriteLine($"Fakülte: {Faculty}");
            double average = ((Midtermexam * 0.40) + (Finalgrad * 0.60));
            if (average >= 85 && average <= 100)
            {
                Console.WriteLine($"Ortalamanız: {average} Harf notu: A");
            }
            else if (average >= 70 && average <= 84.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Harf notu: B");
            }
            else if (average >= 60 && average <= 69.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Harf notu: C");
            }
            else if (average >= 50 && average <= 59.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Harf notu: D");
            }
            else if (average >= 45 && average <= 49.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Harf notu: E");
            }
            else if (average >= 0 && average <= 44.99)
            {
                Console.WriteLine($"Ortalamanız: {average} Harf notu: F");
            }
            else
            {
                Console.WriteLine("Hatalı not!!");
            }
        }
    }
}
