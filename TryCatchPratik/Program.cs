try
{
    Console.Write("Lütfen bir sayı giriniz: ");
    int sayi = int.Parse(Console.ReadLine());  // Kullanıcıdan sayı alma
    int kare = sayi * sayi;
    Console.WriteLine($"Girdiğiniz sayının karesi: {kare}");
}
catch (FormatException)
{
    // Geçersiz giriş durumunda hata mesajı
    Console.WriteLine("Geçersiz giriş! Lütfen bir sayı giriniz.");
}