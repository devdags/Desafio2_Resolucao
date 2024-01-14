using System;
using DesafioPOO.Models; 
class Program
{
    static void Main()
    {
        Console.WriteLine("Smartphone Nokia:");
        Nokia nokia = new Nokia("123456789", "Nokia Model X", "IMEI123", 64);
        nokia.InstalarAplicativo("Facebook");
        nokia.Ligar();
        nokia.ReceberLigacao();
        Console.WriteLine("\nSmartphone Iphone:");
        Iphone iphone = new Iphone("987654321", "iPhone 12", "IMEI456", 128);
        iphone.InstalarAplicativo("Teams");
        iphone.Ligar();
        iphone.ReceberLigacao();
    }
}
