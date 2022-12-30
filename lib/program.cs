using System;

namespace isimgeridenyazma
{
    class Program
    {
        static void Main(string[] args)
        {
         string isim="Ahmet";
string tersisim = "";
            foreach (char harf in isim)
            {
               tersisim = harf.ToString() + tersisim;
            }
            Console.WriteLine(tersisim);
        }
    }
}