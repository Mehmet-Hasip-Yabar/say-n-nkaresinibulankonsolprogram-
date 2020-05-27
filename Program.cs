using System;

public class MyProgram
{
    public static void Main(string[] args)
    {
        int sayi;
        Console.WriteLine("Sayı girin:");
        string girilen = Console.ReadLine();
        sayi = Convert.ToInt32(girilen);
        int kare = sayi * sayi;
        Console.WriteLine("Sayının karesi:" + kare);
        Console.ReadKey();
    }
}