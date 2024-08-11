int i = 1;
int sayi, sayilar;


Console.WriteLine("Sayı giriniz: ");
sayi = Convert.ToInt32(Console.ReadLine());

while (i < 3)
{
    if (sayi % 3 == 0 && sayi % 5 == 0 && sayi % 15 == 0)
    {
        sayilar = sayi;
        Console.WriteLine("Sayılar: " + sayilar + "şeklinde geliyor");
       

    }
    i++;
    Console.WriteLine("Tekrar sayı giriniz: ");
    sayi = Convert.ToInt32(Console.ReadLine());


}

