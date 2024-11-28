namespace Ödev
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ogrenci ogrenci = new Ogrenci("Mahmut Çekem", "10", "Açıktan Eğitim", Educationlevel.İlkOgretim);
            foreach (Ogrenci student in ogrenci.Student)
            {
                Console.WriteLine($"AdSoyad: {student.NameUsername}, Okul No: {student.SchoolNumber}, Okul Adı: {student.SchoolName}, Okul Düzeyi: {student.Educationlevel}");
            }
            ogrenci.NotHesapla();
            //OgrenciNotHesapla(ogrenci);
            LiseOgrenci liseOgrenci = new LiseOgrenci("Mahmut Çekem", "10", "Yıldız Teknik Üniversitesi", Educationlevel.Lise, 50, 50);
            foreach (Ogrenci student in liseOgrenci.Student)
            {
                Console.WriteLine($"AdSoyad: {student.NameUsername}, Okul No: {student.SchoolNumber}, Okul Adı: {student.SchoolName}, Okul Düzeyi: {student.Educationlevel}");
            }
            liseOgrenci.NotHesapla();
            //OgrenciNotHesapla(liseOgrenci);
            LisansOgrenci lisansOgrenci = new LisansOgrenci("Mahmut Çekem", "5", "Atatürk Üniversitesi", Educationlevel.Lisans, "Fakülte", 60, 70);
            foreach (Ogrenci student in lisansOgrenci.Student)
            {
                Console.WriteLine($"AdSoyad: {student.NameUsername}, Okul No: {student.SchoolNumber}, Okul Adı: {student.SchoolName}, Okul Düzeyi: {student.Educationlevel}");
            }
            lisansOgrenci.NotHesapla();
            //OgrenciNotHesapla(lisansOgrenci);
        }
        //public static void OgrenciNotHesapla(Ogrenci ogrenci)
        //{ 
        //    ogrenci.NotHesapla();
        //}
    }
}
