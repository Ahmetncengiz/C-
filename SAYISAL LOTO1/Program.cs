int[] sayilar=new int[6];
int[] kasaSayilar=new int[6];
int tahmin = 0;

Console.WriteLine("lütfen 6 sayı giriniz");
Random rnd=new Random();

for (int i = 0; i < 6; i++)
{
    kasaSayilar[i]=rnd.Next(1,60);
    Console.WriteLine("{0}.  sayıyı giriniz :", (i+1) );
    sayilar[i]=int.Parse(Console.ReadLine()!);
}
foreach(var sayı in  sayilar)
{
    foreach(var kasaSayi in  kasaSayilar)
    {
       tahmin = sayı==kasaSayi? tahmin++ : tahmin;
    }
}
Console.WriteLine("{0} adet doğru tahminde bulundunuz",tahmin);
Console.WriteLine("random sayilar: {0}",kasaSayilar.ToString());
        for (int i = 0; i < kasaSayilar.Length; i++)
{
    
}
{
    Console.WriteLine("{0}", kasaSayilar[i]);
}