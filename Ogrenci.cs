using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ödev
{
    internal class Ogrenci
    {
        public ArrayList Student = new ArrayList();
        public string NameUsername { get; set; }
        public string SchoolNumber { get; set; }
        public string SchoolName = "Açıktan Eğitim";
        public Educationlevel Educationlevel;

        public Ogrenci(string nameusername, string schoolnumber, string schoolname, Educationlevel educationlevel)
        {
            this.NameUsername = nameusername;
            this.SchoolNumber = schoolnumber;
            this.SchoolName = schoolname;
            this.Educationlevel = educationlevel;
            Student.Add(this);
        }
        public void NotHesapla()
        {
            Console.WriteLine("Not bilgisi eksik!");
        }
    }
    enum Educationlevel: int
    {
        İlkOgretim, 
        OrtaOgretim, 
        Lise, 
        Lisans
    }
}
